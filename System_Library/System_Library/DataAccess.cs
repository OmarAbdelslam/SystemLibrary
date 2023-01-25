using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace System_Library
{
    public class DataAccess
    {
        public List<Book> GetPe()
        {
            using (IDbConnection connection = new SqlConnection(Helper.cnnval("LibraryDB")))
            {
              return  connection.Query<Book>("Select * from dbo.Book").ToList();
            }
        }
    }
}
