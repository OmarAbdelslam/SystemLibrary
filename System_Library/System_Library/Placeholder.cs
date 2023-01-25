using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace System_Library
{
   partial class Form1 
    {

        public string txtbox(int s)
        {
            string[] arr = { "Enter Number Book ....", "Name Book...", "Nationality Number...", "Copy Number...", "Location in library...", "Numbering at Library...", "Chapter Number...", "Print Type...", "Print Data...", "Price...", "Pruchasable...", "ID Publishing house", "ID Specilizec", "Date of entering the library..." };
           
            return arr[s];
        }
        private void RemoveText1(object sender, EventArgs e)
        {
            if (txtID1.Focus())
            {
                txtID1.ForeColor = Color.Black;
                txtID1.Text = "";
            }
        }
        private void AddText1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtID1.Text))
            {
                txtID1.Text = "Enter Number Book....";
                txtID1.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText2(object sender, EventArgs e)
        {
            if (txtName2.Focus())
            {
                txtName2.ForeColor = Color.Black;
                txtName2.Text = "";
            }
        }
        private void AddText2(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName2.Text))
            {
                txtName2.Text = txtbox(1);
                txtName2.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText3(object sender, EventArgs e)
        {
            if (txtNationality3.Focus())
            {
                txtNationality3.ForeColor = Color.Black;
                txtNationality3.Text = "";
            }
        }
        private void AddText3(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNationality3.Text))
            {
                txtNationality3.Text = txtbox(2);
                txtNationality3.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText4(object sender, EventArgs e)
        {
            if (txtCopyNumber4.Focus())
            {
                txtCopyNumber4.ForeColor = Color.Black;
                txtCopyNumber4.Text = "";
            }
        }
        private void AddText4(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCopyNumber4.Text))
            {
                txtCopyNumber4.Text = txtbox(3);
                txtCopyNumber4.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText5(object sender, EventArgs e)
        {
            if (txtLocation5.Focus())
            {
                txtLocation5.ForeColor = Color.Black;
                txtLocation5.Text = "";
            }
        }
        private void AddText5(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLocation5.Text))
            {
                txtLocation5.Text = txtbox(4);
                txtLocation5.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText6(object sender, EventArgs e)
        {
            if (txtNumbringatLibrary6.Focus())
            {
                txtNumbringatLibrary6.ForeColor = Color.Black;
                txtNumbringatLibrary6.Text = "";
            }
        }
        private void AddText6(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumbringatLibrary6.Text))
            {
                txtNumbringatLibrary6.Text = txtbox(5);
                txtNumbringatLibrary6.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText7(object sender, EventArgs e)
        {
            if (txtChapter7.Focus())
            {
                txtChapter7.ForeColor = Color.Black;
                txtChapter7.Text = "";
            }
        }
        private void AddText7(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtChapter7.Text))
            {
                txtChapter7.Text = txtbox(6);
                txtChapter7.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText8(object sender, EventArgs e)
        {
            if (txtPrintT8.Focus())
            {
                txtPrintT8.ForeColor = Color.Black;
                txtPrintT8.Text = "";
            }
        }
        private void AddText8(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPrintT8.Text))
            {
                txtPrintT8.Text = txtbox(7);
                txtPrintT8.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText9(object sender, EventArgs e)
        {
            if (txtPrintD9.Focus())
            {
                txtPrintD9.ForeColor = Color.Black;
                txtPrintD9.Text = "";
            }
        }
        private void AddText9(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPrintD9.Text))
            {
                txtPrintD9.Text = txtbox(8);
                txtPrintD9.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText10(object sender, EventArgs e)
        {
            if (txtPrice10.Focus())
            {
                txtPrice10.ForeColor = Color.Black;
                txtPrice10.Text = "";
            }
        }
        private void AddText10(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPrice10.Text))
            {
                txtPrice10.Text = txtbox(9);
                txtPrice10.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText11(object sender, EventArgs e)
        {
            if (txtPruchasable1.Focus())
            {
                txtPruchasable1.ForeColor = Color.Black;
                txtPruchasable1.Text = "";
            }
        }
        private void AddText11(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPruchasable1.Text))
            {
                txtPruchasable1.Text = txtbox(10);
                txtPruchasable1.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText12(object sender, EventArgs e)
        {
            if (txtIDPublish12.Focus())
            {
                txtIDPublish12.ForeColor = Color.Black;
                txtIDPublish12.Text = "";
            }
        }
        private void AddText12(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIDPublish12.Text))
            {
                txtIDPublish12.Text = txtbox(11);
                txtIDPublish12.ForeColor = Color.OliveDrab;
            }
        }
        private void RemoveText13(object sender, EventArgs e)
        {
            if (txtIDSpecilized13.Focus())
            {
                txtIDSpecilized13.ForeColor = Color.Black;
                txtIDSpecilized13.Text = "";
            }
        }
        private void AddText13(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIDSpecilized13.Text))
            {
                txtIDSpecilized13.Text = txtbox(12);
                txtIDSpecilized13.ForeColor = Color.OliveDrab;
            }
        }
        //private void RemoveText14(object sender, EventArgs e)
        //{
        //    if (textBox14.Focus())
        //    {
        //        textBox14.ForeColor = Color.Black;
        //        textBox14.Text = "";
        //    }
        //}
        //private void AddText14(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrWhiteSpace(textBox1.Text))
        //    {
        //        textBox1.Text = "Enter Number Book....";
        //        textBox1.ForeColor = Color.OliveDrab;
        //    }
        //}


    }
    
}
