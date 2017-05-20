using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BSK.projekt
{
    class DatabaseConnector
    {
        public SqlConnection connection;
        public SqlCommand commandSQL;
        public DatabaseConnector(string user, string instance, string DatabaseName )
        {
            connection = new SqlConnection(); //(@"Data Source=tcp:10.0.1.8\TOMASZPALUCE56A,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=test"));//(@"Data Source=10.0.1.8\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=test");
            //(@"Data Source=(IP Address)\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=sa;Password=password");
            connection.ConnectionString = "user id=" + user + ";" + ";Data Source=" + instance + ";" + "Trusted_Connection=yes;" + "database=" + DatabaseName + "; " + "connection timeout=3";
            connection.Open();
        }


        public DataTable getData(string q)
        {
            DataTable dataTable = new DataTable();
            SqlDataReader dataReader;
            

            commandSQL = new SqlCommand(q); // utworzenie instancji SQLCommand ktora ma wykonac zapytanie podane jako parametr
                                            // w zmiennej q

            commandSQL.Connection = this.connection; //wskazanie połączenia do bazy danych
            dataReader = commandSQL.ExecuteReader(); //utworzenie wskaźnika dataReader
            dataTable.Load(dataReader);
            return dataTable;
        }
    }
}
