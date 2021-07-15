using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace MaterialManagement
{
    class DataBaseClass
    {

        SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
        //SQLiteConnection conn = new SQLiteConnection();
        SQLiteConnection conn = new SQLiteConnection();

        public static SQLiteConnection OpenConnection(string database)
        {
            var conntion = new SQLiteConnection()
            {
                ConnectionString = $"Data Source={database};Version=3;New=False;Compress=True;"
            };
            if (conntion.State == ConnectionState.Open) conntion.Close();
            conntion.Open();
            return conntion;
        }

        public DataTable DBGirdView(string sqlString)
        {

            var connection = OpenConnection("e_material_db.db");

            var myTable = new DataTable();

            try
            {
                var dataAdapter = new SQLiteDataAdapter(sqlString, connection);               
                var myDataSet = new DataSet();
                myDataSet.Clear();

                dataAdapter.Fill(myDataSet);
                myTable = myDataSet.Tables[0];

                return myTable; 
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "Connection failed.");
            }
            return myTable;
        }

        public String DBReturnID(string productName) {
            string productID = "";

            var connection = OpenConnection("e_material_db.db");
            string sqlString = "select * from electrical where 名稱 like '" + productName +"';";
 
            DataTable table = new DataTable();
            try {
                //conn.Open();

                //conn.ConnectionString = builder.ConnectionString;
                //SQLiteCommand command = conn.CreateCommand();

                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlString, connection);

                da.Fill(table);
                //conn.Close();

                productID = table.Rows[0][0].ToString();

                return productID;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message, "Connection failed.");
                connection.Close();
            }
            return productID;

        }

        public void DBGridInsert(ItemList item,int index)
        {
            var connection = OpenConnection("e_material_db.db");

            DataTable table = new DataTable();

            try
            {
                SQLiteCommand command = connection.CreateCommand();

                string sqlString = "INSERT INTO electrical (ID,名稱,數量,類別,建檔日期,儲存盒號) VALUES('" + index
                                   +"','"+item.itemName + "','" + item.amount + "','"+ item.type + "','" + item.dt + "','"+
                                   item.storage +"');";
                
                command.CommandText = sqlString;

                SQLiteDataReader mySqliteReader;
                mySqliteReader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Connection failed.");
                connection.Close();
            }
        }

        public void DBGridDelete(int serialNum)
        {
            var connection = OpenConnection("e_material_db.db");

            DataTable table = new DataTable();

            try
            {
                SQLiteCommand command = connection.CreateCommand();

                string sqlString = "Delete from electrical where ID =" + serialNum.ToString() +";";
                
                command.CommandText = sqlString;
                SQLiteDataReader MySqliteReader;
                MySqliteReader = command.ExecuteReader();

                MessageBox.Show("Delete Data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Connection failed.");
                connection.Close();
            }
        }

        public void DBLogInset(string logtxt)
        {
            var connection = OpenConnection("e_material_db.db");
            DataTable table = new DataTable();

            try
            {
                SQLiteCommand command = connection.CreateCommand();

                string sqlString = "INSERT INTO electrical_log (OPTime,OPLog) Values ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").ToString() + "','" + logtxt + "') ";
                command.CommandText = sqlString;

                SQLiteDataReader MySqliteReader;
                MySqliteReader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Connection failed.");
                connection.Close();
            }
        }

        public void DBGidUpdate(string serial,ItemList item)
        {
            var connection = OpenConnection("e_material_db.db");
            DataTable table = new DataTable();

            try
            {
                SQLiteCommand command = connection.CreateCommand();

                string sqlString = "UPDATE electrical SET " + "名稱='" + item.itemName + "',數量="
                                  + item.amount.ToString() + ",類別='" + item.type + "',建檔日期='" + item.dt
                                  + "',儲存盒號='" +item.storage + "' where ID = "+ serial + ";"; 

                command.CommandText = sqlString;

                SQLiteDataReader MySqliteReader;
                MySqliteReader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Connection failed.");
                connection.Close();

            }
        }


    }
}
