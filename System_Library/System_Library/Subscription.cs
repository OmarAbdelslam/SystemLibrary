using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;

namespace System_Library { 
public class Subscription : Methodes
    {
        private int iD;
        private string name;
      private int? age;
       private string type;
       private string address;
      private  DateTime? start_Date;
      private  DateTime? end_Date;
      private  string sub_Period;
      private  decimal? price;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int? Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
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

        public DateTime? Start_Date
        {
            get
            {
                return start_Date;
            }

            set
            {
                start_Date = value;
            }
        }

        public DateTime? End_Date
        {
            get
            {
                return end_Date;
            }

            set
            {
                end_Date = value;
            }
        }

        public string Sub_Period
        {
            get
            {
                return sub_Period;
            }

            set
            {
                sub_Period = value;
            }
        }

        public decimal? Price
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
