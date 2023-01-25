using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class Imports : Methodes
    {
        private int id;
        private int quantity;
        private double price;
        private int copy_Num;
        private int chapter;
        private int id_Supplier;
        private int id_Publishing_house_data;

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

        public double Price
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

        public int Copy_Num
        {
            get
            {
                return copy_Num;
            }

            set
            {
                copy_Num = value;
            }
        }

        public int Chapter
        {
            get
            {
                return chapter;
            }

            set
            {
                chapter = value;
            }
        }

        public int Id_Supplier
        {
            get
            {
                return id_Supplier;
            }

            set
            {
                id_Supplier = value;
            }
        }

        public int Id_Publishing_house_data
        {
            get
            {
                return id_Publishing_house_data;
            }

            set
            {
                id_Publishing_house_data = value;
            }
        }

        public Publishing_house_data Publishing_house_data
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