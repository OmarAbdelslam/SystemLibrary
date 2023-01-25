using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Library
{
    public class Data_Authores : Methodes
    {
        private int ID;
        private string Name;
        private string Country;
        private string Address;
        private int Phone;
        private string Web_Site;
        private int E_Mail;

        public int ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public string Country1
        {
            get
            {
                return Country;
            }

            set
            {
                Country = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public int Phone1
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public string Web_Site1
        {
            get
            {
                return Web_Site;
            }

            set
            {
                Web_Site = value;
            }
        }

        public int E_Mail1
        {
            get
            {
                return E_Mail;
            }

            set
            {
                E_Mail = value;
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
