using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;

namespace System_Library { 
    public class Book : Methodes
    {
        DBWORK DB = new DBWORK();
        private int iD;
        private string address;
        private int num_Nashnality;
        private DateTime date_Input_Library;
        private bool borrowable;
        private int num_Copy;
        private string location;
        private int numbering_at_Library;
        private int? num_chapter;
        private DateTime date_print;
        private string type_Print;
        private double? price;
        private bool? purchasable;
        private string iD_data_Home_Share;
        private int iD_specilized;
        private int quantity;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public int Num_Nashnality
        {
            get
            {
                return num_Nashnality;
            }

            set
            {
                num_Nashnality = value;
            }
        }

        public DateTime Date_Input_Library
        {
            get
            {
                return date_Input_Library;
            }

            set
            {
                date_Input_Library = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public bool Borrowable
        {
            get
            {
                return borrowable;
            }

            set
            {
                borrowable = value;
            }
        }

        public int Num_Copy
        {
            get
            {
                return num_Copy;
            }

            set
            {
                num_Copy = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public int Numbering_at_Library
        {
            get
            {
                return numbering_at_Library;
            }

            set
            {
                numbering_at_Library = value;
            }
        }

        public int? Num_chapter
        {
            get
            {
                return num_chapter;
            }

            set
            {
                num_chapter = value;
            }
        }

        public DateTime Date_print
        {
            get
            {
                return date_print;
            }

            set
            {
                date_print = value;
            }
        }

        public bool? Purchasable
        {
            get
            {
                return purchasable;
            }

            set
            {
                purchasable = value;
            }
        }

        public string ID_Data_Home_Share
        {
            get
            {
                return iD_data_Home_Share;
            }

            set
            {
                iD_data_Home_Share = value;
            }
        }

        public int ID_specilized
        {
            get
            {
                return iD_specilized;
            }

            set
            {
                iD_specilized = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string Type_Print
        {
            get
            {
                return type_Print;
            }

            set
            {
                type_Print = value;
            }
        }

        public double? Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Employee Employee
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Book_Authores Book_Authores
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Bill Bill
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string ADD()
        {
            string cmd = @"Insert Into Book Values("+ID+",'"+Address+"',"+Num_Nashnality+",'"+Date_Input_Library+"','"+Borrowable+"',"+Num_Copy+",'"+Location+"',"+Numbering_at_Library+","+Num_chapter+",'"+Type_Print+"','"+Date_print+"',"+Price+",'"+Purchasable+"','"+ID_Data_Home_Share+"',"+ID_specilized+","+Quantity+") ;";
            return DB.RUNInsDelUpd(cmd);
        }

        public string Update()
        {
            string cmd = $"Update Book Set B_Address= '{Address}' , [B_Nationality Number] ={Num_Nashnality} ,B_DateOfEnteringTheLibrary ='{Date_Input_Library}' , B_Borrowable = '{Borrowable}' , B_CopyNumber={Num_Copy} ,B_LocationInLibrary='{Location}' ,B_NumberingAtLibrary={Numbering_at_Library},B_ChapterNumber={Num_chapter},B_PrinterType='{Type_Print}', B_PrinterDate='{Date_print}',B_Price={Price},B_Pruchasable='{Purchasable}',ID_PublishingHouse='{ID_Data_Home_Share}',ID_Specilized={ID_specilized} , Quantity ={Quantity} Where B_ID ={ID}";
            return DB.RUNInsDelUpd(cmd);
        }

        public string Delate()
        {
            string cmd = $@"Delete dbo.Book Where B_ID = {ID}";
            return DB.RUNInsDelUpd(cmd);
        }

        public DataTable Select()
        {
            string msg;
            msg = $"Select * From dbo.Book Where B_ID={ID};";
            return  DB.RUNSelect(msg);

        }
    }
}
