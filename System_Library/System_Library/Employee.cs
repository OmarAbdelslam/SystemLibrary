using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class Employee : Methodes
    {
        private int id;
        private string name;
        private string carrer_type;
        private string section;
        private string address;
        private int phone;
        private int phone_lind;
        private DateTime birth_day;
        private string gender;
        private string password;

        public int Id
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

        public string Carrer_type
        {
            get
            {
                return carrer_type;
            }

            set
            {
                carrer_type = value;
            }
        }

        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
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

        public int Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public int Phone_lind
        {
            get
            {
                return phone_lind;
            }

            set
            {
                phone_lind = value;
            }
        }

        public DateTime Birth_day
        {
            get
            {
                return birth_day;
            }

            set
            {
                birth_day = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public Metaphor Metaphor
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