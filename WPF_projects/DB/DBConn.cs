using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_projects.DB
{
    public class DBConn
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prince\Desktop\C#\WPF_projects\WPF_projects\RevAppDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn = null;
        public DBConn()
        {
            conn = new SqlConnection(ConnectionString);
        }
        public SqlDataReader Execute(string Query)
        {
            try
            {
                //3 Open Conn
                conn.Open();
                //4 Prepare SQL Query
                SqlCommand cmd = new SqlCommand(Query, conn);
                //5 Execute query
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return null;
        }
        public void Close()
        {
            // Close the connection
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
