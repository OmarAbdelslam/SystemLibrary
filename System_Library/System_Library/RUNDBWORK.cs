using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace System_Library
{
    public abstract class RUNDBWORK
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        public string RUNInsDelUpd(string SqlMethod)
        {
            conn = new SqlConnection(@"C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA");
            cmd = new SqlCommand();

            throw new NotImplementedException();
        }

        public DataTable RUNSelect(string SqlSelect)
        {
            throw new System.NotImplementedException();
        }
    }
}