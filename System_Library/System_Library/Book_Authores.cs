using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System_Library
{
    public class Book_Authores : Methodes
    {
        private int B_id;
        private int A_id;
        private int concatinet;

        public int B_ID
        {
            get
            {
                return B_id;
            }

            set
            {
                B_id = value;
            }
        }

        public int A_ID
        {
            get
            {
                return A_id;
            }

            set
            {
                A_id = value;
            }
        }

        public int Concatinet
        {
            get
            {
                return concatinet;
            }

            set
            {
                concatinet = value;
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