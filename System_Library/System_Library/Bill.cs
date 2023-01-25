using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class Bill : Methodes
    {
        private int order_ID;
        private int book_ID;
        private DateTime date;
        private int quantity;
        private double price;

        public int Order_ID
        {
            get
            {
                return order_ID;
            }

            set
            {
                order_ID = value;
            }
        }

        public int Book_ID
        {
            get
            {
                return book_ID;
            }

            set
            {
                book_ID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
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