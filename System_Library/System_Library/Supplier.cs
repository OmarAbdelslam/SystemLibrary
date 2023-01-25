namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Data;

    public  class Supplier : Methodes
    {
        private int iD;
        private string name;
        private int? phone;
        private string gender;
        private string country;
        private string adg;
        private string addrees;

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

        public int? Phone
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

        public string Adg
        {
            get
            {
                return adg;
            }

            set
            {
                adg = value;
            }
        }

        public string Addrees
        {
            get
            {
                return addrees;
            }

            set
            {
                addrees = value;
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
