using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace KC_20_Gimalova_lab7_var9
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString);

        //открывает связь с БД
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //закрывает связь с БД
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //возвращает строку подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
