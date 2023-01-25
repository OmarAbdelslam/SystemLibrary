using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class sPECILIZED :DBWORK , Methodes 
    {
       
        private int id;
        private string type;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string TYPE
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string ADD()
        {
            string msg = "Insert into dbo.Specilized_Book values (" +ID +",'"+TYPE+ "');";
            string Return = RUNInsDelUpd(msg);
            if (Return == "OK")
                return "Add SPECILIZED Done";
            else
                return "Does Not Add SPECILIZED Becouse \n" + Return;
        }

        public string Delate()
        {
            string msg = "Delete from dbo.Specilized_Book Where S_ID ="+ID;
            string Return = RUNInsDelUpd(msg);
            if (Return == "OK")
                return "Delete SPECILIZED Done";
            else
                return "Does Not Delete SPECILIZED Becouse \n" + Return;
        }

        public DataTable Select()
        {
            string msg = "Select * From dbo.Specilized_Book";
           return RUNSelect(msg);
        }

        public string Update()
        {
            string msg = "Update Specilized_Book Set S_Type ='"+TYPE+"' where S_ID="+ID+";";
            string value = RUNInsDelUpd(msg);
            if (value == "OK")
                return "Update Done";
            else
                return "Does Not Update ON this Column Becouse \n" + value;
        }
    }
}