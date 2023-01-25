using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class DBWORK
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private DataTable DB;

        public string RUNInsDelUpd(string SqlMethod)
        {

            conn = new SqlConnection();
            cmd = new SqlCommand();
            //conn.ConnectionString = "Data Source=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\Libarary.mdf";
            //conn.ConnectionString = @"Data Source=(LibararyDB)\MSSQLLibararyDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\Libarary.mdf;Integrated Security=True";
            //conn.ConnectionString = "server=|DataDirectory|\\Libarary.mdf;" + "Database=Libarary.sdf;" + "Trusted_Connection=true;";
            //conn.ConnectionString = "LibararyDB";
            //conn.ConnectionString = @"Server=DESKTOP-RTMN4HO\SQL2019\myInstanceName;Database=Libarary;User Id=sa;Password=01126920859;";
            conn = new SqlConnection(Helper.cnnval("LibraryDB"));
            cmd.Connection = conn;
            cmd.CommandText = SqlMethod;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                
                conn.Close();
                return "OK";
        }
            catch (SqlException ex)
            {
                return "Error :" + ex;
            }

}

        public DataTable RUNSelect(string SqlSelect)
        {
            conn = new SqlConnection(Helper.cnnval("LibraryDB"));
            cmd = new SqlCommand(SqlSelect, conn);
            
            DB = new DataTable();
            try
            {
                conn.Open();
                DB.Load(cmd.ExecuteReader());
                
                conn.Close();
                return DB;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
    }
}