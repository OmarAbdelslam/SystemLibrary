using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
namespace System_Library{
   public class Metaphor : Methodes
    {
        private int iD;
        private string type;
        private  int? person_ID;
        private string borrowingPeriod;
        private DateTime? date_Time_Start;
        private DateTime? date_Time_Out;
        private int fK_ID_bOOK;

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

        public string Type
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

        public int? Person_ID
        {
            get
            {
                return person_ID;
            }

            set
            {
                person_ID = value;
            }
        }

        public string BorrowingPeriod
        {
            get
            {
                return borrowingPeriod;
            }

            set
            {
                borrowingPeriod = value;
            }
        }

        public DateTime? Date_Time_Start
        {
            get
            {
                return date_Time_Start;
            }

            set
            {
                date_Time_Start = value;
            }
        }

        public DateTime? Date_Time_Out
        {
            get
            {
                return date_Time_Out;
            }

            set
            {
                date_Time_Out = value;
            }
        }

        public int FK_ID_bOOK
        {
            get
            {
                return fK_ID_bOOK;
            }

            set
            {
                fK_ID_bOOK = value;
            }
        }

        public string ADD()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }

        public string Delate()
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {
            throw new NotImplementedException();
        }
    }
}
