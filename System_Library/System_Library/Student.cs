
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
using System_Library;

namespace System_Library
{
    public class Student : Methodes
    {
        private int s_ID;
        private string s_Name;
        private string s_Section;
        private string s_Team;

        public int S_ID
        {
            get
            {
                return s_ID;
            }

            set
            {
                s_ID = value;
            }
        }

        public string S_Name
        {
            get
            {
                return s_Name;
            }

            set
            {
                s_Name = value;
            }
        }

        public string S_Section
        {
            get
            {
                return s_Section;
            }

            set
            {
                s_Section = value;
            }
        }

        public string S_Team
        {
            get
            {
                return s_Team;
            }

            set
            {
                s_Team = value;
            }
        }
        DBWORK DB = new DBWORK();
        public string ADD()
        {
            string msg = $"Insert into Student Values({S_ID},'{S_Name}','{S_Section}','{S_Team}');";
           return DB.RUNInsDelUpd(msg);
        }

        public string Delate()
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }

}