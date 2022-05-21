using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_lab7_var9
{
    public partial class ChangeNoteForm : Form
    {
        DataBase dataBase = new DataBase();
        Form1 form1;
        public ChangeNoteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void JournalImg_Click(object sender, EventArgs e)
        {
            NameBank.imgLoc = "";
            try
            {
                dataBase.openConnection();

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.BMP; *.PNG; *JPG; *GIF)|*.BMP; *.PNG; *JPG; *GIF|All files(*.*)|*.*";
                ofd.Title = "Выберите обложку";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //храним путь файла
                    NameBank.imgLoc = ofd.FileName.ToString();
                    //отражение картинки
                    JournalImg.ImageLocation = NameBank.imgLoc;

                    //pucturebox
                    NameBank.byteImg = null;

                    FileStream fileStream = new FileStream(NameBank.imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    NameBank.byteImg = binaryReader.ReadBytes((int)fileStream.Length);

                    SqlCommand cmd = new SqlCommand($"UPDATE Library SET Picture=@picture WHERE id=@id", dataBase.getConnection());

                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.Add(new SqlParameter("@picture", NameBank.byteImg));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Картинка изменена!", "Успех", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                form1 = new Form1();

                NameBank.nameJournal = txtNameJournal.Text;
                NameBank.nameArticle = txtNameArticle.Text;
                NameBank.nameAuthor = txtAuthor.Text;

                NameBank.ID = Int32.Parse(txtID.Text);
                NameBank.numVolume = Int32.Parse(txtTom.Text);
                NameBank.numJournal = Int32.Parse(txtNumJournal.Text);
                NameBank.varFirstPage = Int32.Parse(numFirstPage.Text);
                NameBank.varEndPage = Int32.Parse(numEndPage.Text);
                NameBank.varYear = Int32.Parse(lblYear.Text);



                if (NameBank.varFirstPage > NameBank.varEndPage)
                {
                    MessageBox.Show("Порядок страниц совсем иной, вы все напутали!", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (NameBank.numVolume <= 0)
                {
                    MessageBox.Show("Номер тома должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (NameBank.numJournal <= 0)
                {
                    MessageBox.Show("Номер журнала должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (NameBank.varYear <= 0)
                {
                    MessageBox.Show("Год должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Change();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ChangeNoteForm_Load(object sender, EventArgs e)
        {
            
        }

        public void Change()
        {


            //проверка на пустую строку 
            if (NameBank.row.Cells[0].Value.ToString() != string.Empty)
            {

                NameBank.row.SetValues(NameBank.ID, NameBank.nameJournal, NameBank.nameArticle, NameBank.nameAuthor,
                        NameBank.varYear, NameBank.numVolume, NameBank.numJournal, NameBank.varFirstPage, NameBank.varEndPage);
                NameBank.row.Cells[9].Value = RowState.Modified;


               
            }


        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtNameJournal.Clear();
            txtNameArticle.Clear();
            txtAuthor.Clear();
            txtTom.Clear();
            txtNumJournal.Clear();
            numFirstPage.Value = 0;
            numEndPage.Value = 0;
            lblYear.Text = "";
            JournalImg.Image = null;
        }

        private void trackBarYear_Scroll(object sender, EventArgs e)
        {
            lblYear.Text = trackBarYear.Value.ToString();
        }
    }
}
