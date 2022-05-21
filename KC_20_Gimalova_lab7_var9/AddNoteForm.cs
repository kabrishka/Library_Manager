using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace KC_20_Gimalova_lab7_var9
{
    public partial class AddNoteForm : Form
    {
        Form1 form1 = new Form1();
        DataBase dataBase = new DataBase();
        NameBank bank = new NameBank();
        public AddNoteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            

            dataBase.openConnection();

            var nameJournal = txtNameJournal.Text;
            var nameArticle = txtNameArticle.Text;
            var nameAuthor = txtAuthor.Text;

            try
            {
                int numVolume = Int32.Parse(txtTom.Text);
                int numJournal = Int32.Parse(txtNumJournal.Text);
                int varFirstPage = Int32.Parse(numFirstPage.Text);
                int varEndPage = Int32.Parse(numEndPage.Text);
                int varYear = Int32.Parse(lblYear.Text);

                if (varFirstPage > varEndPage)
                {
                    MessageBox.Show("Порядок страниц совсем иной, вы все напутали!", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (numVolume <= 0)
                {
                    MessageBox.Show("Номер тома должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (numJournal <= 0)
                {
                    MessageBox.Show("Номер журнала должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (varYear <= 0)
                {
                    MessageBox.Show("Год должен быть больше 0", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NameBank.byteImg = null;

                    FileStream fileStream = new FileStream(NameBank.imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    NameBank.byteImg = binaryReader.ReadBytes((int)fileStream.Length);

                    var addQuery = $"INSERT INTO Library (Journal,Article,Authors,Year,Volume,Number,FirstPage,EndPage,Picture)" +
                    $" VALUES (N'{nameJournal}',N'{nameArticle}',N'{nameAuthor}','{varYear}','{numVolume}','{numJournal}','{varFirstPage}','{varEndPage}',@images)";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.Parameters.Add(new SqlParameter("@images", NameBank.byteImg));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Должен быть введен числовой формат", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();

            
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

        
        private void JournalImg_Click(object sender, EventArgs e)
        {
            NameBank.imgLoc = "";
            NameBank.byteImg = null; 

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.BMP; *.PNG; *JPG; *GIF)|*.BMP; *.PNG; *JPG; *GIF|All files(*.*)|*.*";
                ofd.Title = "Выберите обложку";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //храним путь файла
                    NameBank.imgLoc = ofd.FileName.ToString();
                    //отражение картинки
                    JournalImg.ImageLocation = NameBank.imgLoc;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void trackBarYear_Scroll(object sender, EventArgs e)
        {
            lblYear.Text = trackBarYear.Value.ToString();
        }
    }
}
