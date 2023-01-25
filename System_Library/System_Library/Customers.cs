using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System_Library 
{
    public class Customers : Methodes
    {
        private int phone;
        private string name;
        private string gender;
        private int age;
        private string country;
        private string Email;

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

        public int Age
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

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
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