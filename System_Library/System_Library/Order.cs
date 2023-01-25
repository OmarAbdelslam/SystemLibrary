using System;
using System.Data;
using System.Linq;
namespace System_Library
{
    public class Order : Methodes
    {
        private  int iD;
        private DateTime? date;
        private decimal? price;
        private decimal? descount;
        private int? quantity;

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

        public DateTime? Date
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

        public decimal? Descount
        {
            get
            {
                return descount;
            }

            set
            {
                descount = value;
            }
        }

        public int? Quantity
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
