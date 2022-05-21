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
using System.Runtime.Serialization.Formatters.Binary;

namespace KC_20_Gimalova_lab7_var9
{
    //состояние данных в таблице
    enum RowState{
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        SqlDataReader sqlDataReader;

        AddNoteForm addNoteForm;
        ChangeNoteForm changeNoteForm;

        public int selectedRow;
        public Form1()
        {
            InitializeComponent();

        }

        //название стобцов в DataGridView
        private void createColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Journal", "Журнал");
            dataGridView1.Columns.Add("Article", "Статья");
            dataGridView1.Columns.Add("Authors", "Авторы");
            dataGridView1.Columns.Add("Year", "Год");
            dataGridView1.Columns.Add("Volume", "Том");
            dataGridView1.Columns.Add("Number", "Номер");
            dataGridView1.Columns.Add("FirstPage", "Первая страница");
            dataGridView1.Columns.Add("EndPage", "Последняя страница");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        //IDataRecord - предоставляет доступ к значениям столбцов для каждой строки
        private void readSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), 
                record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7), record.GetInt32(8),  RowState.ModifiedNew);
        }

        //вывод данных в таблицу
        private void refreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"SELECT id,Journal,Article,Authors,Year,Volume,Number,FirstPage,EndPage FROM Library";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }

            sqlDataReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createColumns();
            refreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataBase.openConnection();

            selectedRow = e.RowIndex;

            //e.RowIndex >= 0, тк если мы нажмем, например, на строку с названиями столбцов, то 
            //выйдет ошибка, что мы за границами индекса
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                //работа с pictureBox в форме ChangeNoteForms

                string request = "SELECT Picture FROM Library WHERE Id='" + row.Cells[0].Value.ToString() + "'";
                SqlCommand sqlCommand = new SqlCommand(request, dataBase.getConnection());

                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                //считывание картинки
                if (sqlDataReader.HasRows)
                {
                    byte[] images = (byte[])(sqlDataReader[0]);
                    if (images == null)
                        mainPicture.Image = null;

                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(images);
                        mainPicture.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно считать картинку");
                }
                sqlDataReader.Close();


            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для изменения", "Выберите строку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
            refreshDataGrid(dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNoteForm = new AddNoteForm();
            addNoteForm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        //поиск в БД
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"SELECT * FROM Library WHERE  CONCAT (id,Journal,Article,Authors,Year,Volume,Number,FirstPage,EndPage) LIKE N'%" + txtSearch.Text + "%'";

            SqlCommand cmd = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readSingleRow(dgw, sqlDataReader);
            }
            sqlDataReader.Close();
        }


        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            deleteRow();
        }
        private void btmSave_Click(object sender, EventArgs e)
        {
            
        }



        //удаление
        public void deleteRow()
        {
            //передаем индекс той строки, в которой находимся
            int index = dataGridView1.CurrentCell.RowIndex;

            //скрываем 
            dataGridView1.Rows[index].Visible = false;

            //проверяем, если пустая строка
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[9].Value = RowState.Deleted;

        }
        //чтобы сохранялись все изменения
        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[9].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    //занесем индекс той строки, в которой находимся
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"DELETE FROM Library WHERE id = {id}";

                    var commad = new SqlCommand(deleteQuery, dataBase.getConnection());
                    commad.ExecuteNonQuery();
                }

                
                if (rowState == RowState.Modified)
                {

                    
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var journal = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var article = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var author = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var year = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var volume = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var numJournal = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var firstPage = dataGridView1.Rows[index].Cells[7].Value.ToString();
                    var lastPage = dataGridView1.Rows[index].Cells[8].Value.ToString();

                    var changeQuery = $"UPDATE Library SET Journal = N'{journal}'," +
                        $"Article = N'{article}'," +
                        $"Authors = N'{author}'," +
                        $"Year = '{year}'," +
                        $"Volume = '{volume}'," +
                        $"Number = '{numJournal}'," +
                        $"FirstPage = '{firstPage}'," +
                        $"EndPage = '{lastPage}' WHERE id = '{id}'";

                    var commad = new SqlCommand(changeQuery, dataBase.getConnection());
                    commad.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
  

        private void btnChange_Click(object sender, EventArgs e)
        {

            dataBase.openConnection();

            changeNoteForm = new ChangeNoteForm();

            NameBank.selectedRowIndexForChange = dataGridView1.CurrentCell.RowIndex;

            //e.RowIndex >= 0, тк если мы нажмем, например, на строку с названиями столбцов, то 
            //выйдет ошибка, что мы за границами индекса
            if (NameBank.selectedRowIndexForChange >= 0)
            {
                NameBank.row = dataGridView1.Rows[NameBank.selectedRowIndexForChange];

                changeNoteForm.Show();

                changeNoteForm.txtID.Text = NameBank.row.Cells[0].Value.ToString();
                changeNoteForm.txtNameJournal.Text = NameBank.row.Cells[1].Value.ToString();
                changeNoteForm.txtNameArticle.Text = NameBank.row.Cells[2].Value.ToString();
                changeNoteForm.txtAuthor.Text = NameBank.row.Cells[3].Value.ToString();
                changeNoteForm.txtTom.Text = NameBank.row.Cells[5].Value.ToString();
                changeNoteForm.txtNumJournal.Text = NameBank.row.Cells[6].Value.ToString();
                changeNoteForm.numFirstPage.Text = NameBank.row.Cells[7].Value.ToString();
                changeNoteForm.numEndPage.Text = NameBank.row.Cells[8].Value.ToString();
                changeNoteForm.lblYear.Text = NameBank.row.Cells[4].Value.ToString();
                changeNoteForm.trackBarYear.Value = Int32.Parse(changeNoteForm.lblYear.Text);


                //работа с pictureBox в форме ChangeNoteForms

                string request = "SELECT Picture FROM Library WHERE Id='" + changeNoteForm.txtID.Text + "'";
                SqlCommand sqlCommand = new SqlCommand(request, dataBase.getConnection());


                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                //считывание картинки
                if (sqlDataReader.HasRows)
                {
                    byte[] images = (byte[])(sqlDataReader[0]);
                    if (images == null)
                        changeNoteForm.JournalImg.Image = null;

                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(images);
                        changeNoteForm.JournalImg.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно считать картинку");
                }
                sqlDataReader.Close();


            }
            else
            {
                MessageBox.Show("Вы не выбрали строку для изменения", "Выберите строку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //список параметров
        List<classInfo> list = new List<classInfo>();

        //чтение из БД
        private void btnFile_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Library", dataBase.getConnection());
            sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {

                    list.Add(new classInfo(sqlDataReader[1].ToString(), sqlDataReader[2].ToString(),
                        sqlDataReader[3].ToString(), Convert.ToInt32(sqlDataReader[4]),
                        Convert.ToInt32(sqlDataReader[5]), Convert.ToInt32(sqlDataReader[6]),
                        Convert.ToInt32(sqlDataReader[7]), Convert.ToInt32(sqlDataReader[8]),
                        ObjectToByteArray(sqlDataReader[9]))); 
                    
                }
            }
            sqlDataReader.Close();

            MessageBox.Show("Данные считаны из БД и занесены в структуру");

            FileStream fileStream = new FileStream(@"data.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.GetEncoding(1251));

            for(int i = 0; i < list.Count; i++)
            {
                streamWriter.WriteLine(list[i].Journal + " " + list[i].Article + " " + 
                    list[i].Authors + " " + list[i].Year + " " + list[i].Volume + " " + list[i].Number + " " + 
                    list[i].FirstPage + " " + list[i].EndPage + " " + list[i].Picture);
                
            }
            streamWriter.Close();
        }

        //конвертация object в byte[]
        private byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
    }

    
}
