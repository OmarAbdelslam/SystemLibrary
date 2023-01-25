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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button10.Click += new EventHandler(button10_Click);
            txtDateofEnteringtheLibrary14.GotFocus += new EventHandler(EnterDate);

            //dateTimePicker1.Visible = false;
            //menuStrip1.Renderer = new MyRenderer();
        }
        //private class MyRenderer : ToolStripProfessionalRenderer
        //{
        //    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        //    {
        //        Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
        //        Color c = e.Item.Selected ? Color.OrangeRed : Color.AliceBlue;
        //        //using (SolidBrush brush = new SolidBrush(c))
        //        //    e.Graphics.FillRectangle(brush, rc);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            pAN_Specialization.Visible = false;
        }

        // this method do Design Tool DataGridView
        private void DesignDGV(/*DataTable Datasorces*/)
        {
            //dataGridView1.Visible = true;
            //dataGridView1.DataSource = Datasorces;
            dataGridView1.Size = new Size(50, 300);
            dataGridView1.Dock = DockStyle.Bottom;

        }
        private void EnterDate(object sender, EventArgs e)
        {
            txtDateofEnteringtheLibrary14.Text = System.DateTime.Now.ToShortDateString().ToString();

            combBorrowable1.Focus();
        }
        //PlaceHolder



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (book_Tool.Selected == true)
                book_Tool.BackColor = Color.OrangeRed;
            else
                book_Tool.BackColor = menuStrip1.BackColor;
            if (student_Tool.Selected == true)
                student_Tool.BackColor = Color.OrangeRed;
            else
                student_Tool.BackColor = menuStrip1.BackColor;
            if (specilized_Tool.Selected == true)
                specilized_Tool.BackColor = Color.OrangeRed;
            else
                specilized_Tool.BackColor = menuStrip1.BackColor;
            if (authores_Data_tool.Selected == true)
                authores_Data_tool.BackColor = Color.OrangeRed;
        }

        private void book_Tool_Click(object sender, EventArgs e)
        {

            //Panel[] Pa = { Pan_Student };
            ////foreach (Panel P in Pa)
            ////{
            ////    P.Visible = false;
            ////}
            //for (int a = 0; a < Pa.Length; a++)
            //{
            //    Pa[a].Visible = false;
            //    //panel1.Visible = false;
            //    //Pan_Student.Visible = false;
            //}
            //dataGridView1 = new DataGridView();
            //this.Controls.Remove(dataGridView1);
            panel1.Visible = true;
            //panel1.Controls.Add(dataGridView1);
            //dataGridView1.Visible = true;
            //DesignDGV();

            //this.Controls.Remove(pAN_Specialization);
            //this.Controls.Remove(Pan_Student);
            //this.Controls.Add(panel1);
            //panel1.Visible = true;
            ////panel1.Visible = false;
            //panel1.Controls.Add(dataGridView1);
            //dataGridView1.Visible = true;
            //DesignDGV();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void student_Tool_Click(object sender, EventArgs e)
        {
            //    Panel[] Pa = { panel1, pAN_Specialization};
            //    for (int a = 0; a < Pa.Length; a++)
            //    {
            //        Pa[a].Visible = false;
            //        //panel1.Visible = false;
            //        //Pan_Student.Visible = false;
            //    }
            //    //this.Controls.Remove(panel1);
            //    this.Controls.Add(Pan_Student);
            //    Pan_Student.Visible = true;
            //    //panel1.Visible = false;
            //    Pan_Student.Controls.Add(dataGridView1);
            //    dataGridView1.Visible = true;
            //    DesignDGV();
        }

        private void specilized_Tool_Click(object sender, EventArgs e)
        {
            //Panel[] Pa = { panel1/*, Pan_Student*/ };
            ////foreach (Panel P in Pa)
            ////{
            ////    P.Visible = false;
            ////}
            //for(int a=0;a<Pa.Length;a++)
            //{
            //    Pa[a].Visible = false;
            //    //panel1.Visible = false;
            //    //Pan_Student.Visible = false;
            //}

            //panel1.Visible = false;
            pAN_Specialization.Visible = true;
            pAN_Specialization.Controls.Add(dataGridView1);
            dataGridView1.Visible = true;
            DesignDGV();
            //this.Controls.Remove(panel1);
            //this.Controls.Remove(Pan_Student);
            //this.Controls.Add(pAN_Specialization);
            //pAN_Specialization.Visible = true;
            ////panel1.Visible = false;
            //pAN_Specialization.Controls.Add(dataGridView1);
            //dataGridView1.Visible = true;
        }

        private void authores_Data_tool_Click(object sender, EventArgs e)
        {
            //Pan_Authors_Data.Visible = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                dataGridView1.Visible = true;
                dataGridView1.Dock = DockStyle.Bottom;
            }
            else
                dataGridView1.Visible = false;
        }
        List<Book> b = new List<Book>();
        private void button1_Click(object sender, EventArgs e)
        {
            //    DataAccess BA = new DataAccess();
            //    b = BA.GetPe();
            //    dataGridView1.DataSource = b;

            //try
            //{
            Book book = new Book()
            {
                ID = Convert.ToInt16(txtID1.Text),
                Address = txtName2.Text,
                Num_Nashnality = int.Parse(txtNationality3.Text),
                Date_Input_Library = Convert.ToDateTime(txtDateofEnteringtheLibrary14.Text),
                Borrowable = bool.Parse(combBorrowable1.Text),
                Num_Copy = int.Parse(txtCopyNumber4.Text),
                Location = txtLocation5.Text,
                Numbering_at_Library = int.Parse(txtNumbringatLibrary6.Text),
                Num_chapter = int.Parse(txtChapter7.Text),
                Type_Print = txtPrintT8.Text,
                Date_print = Convert.ToDateTime(txtPrintD9.Text),
                Price = double.Parse(txtPrice10.Text),
                Purchasable = bool.Parse(txtPruchasable1.Text),
                ID_Data_Home_Share = txtIDPublish12.Text,
                ID_specilized = int.Parse(txtIDSpecilized13.Text),
                Quantity = Convert.ToInt16(numQuantity1.Value)

            };
            string msg = book.ADD();
            MessageBox.Show(msg);

            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sPECILIZED S = new sPECILIZED()
            {
                ID = int.Parse(txtSID.Text),
                TYPE = txtSN.Text
            };
            MessageBox.Show(S.ADD());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DataAccess BA = new DataAccess();
            //b = BA.GetPe();
            //dataGridView1.DataSource = b;

            Book book = new Book();
            //txtID1.Text = "";
            //txtName2.Text = "";
            //if (txtID1.Text !=)
            //{
            book.ID = Convert.ToInt16(txtID1.Text);
            dataGridView1.DataSource = book.Select();

            // }
            //else if (txtName2.Text != txtName2.Text)
            // {
            //     book.Address = txtID1.Text;
            //     dataGridView1.DataSource = book.Select();
            // }
            // else
            //     MessageBox.Show("Empty Select \nEnter ID or Address Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtID1_TextChanged(object sender, EventArgs e)
        {
            Book book = new Book();

            if (txtID1.Text != "" && txtID1.Text != "Enter Number Book....")
            {// في صندوق الرسالة ...تلغي الفوكس علي صندوق النص ويتم الغاء القيمة التي ادخلها المستخدم للبحث عنها , وايضا عند ظهور صندوق الرسائل تلغي الفوكس علي صندوق النص okتم الغاء هذه الرسالة لانها عند الضغط علي 
                //MessageBox.Show(txtID1.Text);
                book.ID = Convert.ToInt16(txtID1.Text);
                dataGridView1.DataSource = book.Select();

            }
        }

        private void txtDateofEnteringtheLibrary14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            sPECILIZED S = new sPECILIZED();

            dataGridView1.DataSource = S.Select();

            //dataGridView1.DataSource = null;
            //pAN_Specialization.Controls.Add(dataGridView1);
            //DesignDGV(S.Select());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sPECILIZED S = new sPECILIZED();
            S.ID = Convert.ToInt16(txtSID.Text);
            MessageBox.Show(S.Delate());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sPECILIZED S = new sPECILIZED();
            S.ID = Convert.ToInt16(txtSID.Text);
            S.TYPE = txtSN.Text;
            MessageBox.Show(S.Update());


        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result=  MessageBox.Show("Make sure that the data fields are filled in so that the data is not updated incorrectly", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(txtID1.Text) && txtID1.Text != "Enter Number Book....")
                {
                    Book book = new Book()
                    {
                        ID = Convert.ToInt16(txtID1.Text),
                        Address = txtName2.Text,
                        Num_Nashnality = int.Parse(txtNationality3.Text),
                        Date_Input_Library = Convert.ToDateTime(txtDateofEnteringtheLibrary14.Text),
                        Borrowable = bool.Parse(combBorrowable1.Text),
                        Num_Copy = int.Parse(txtCopyNumber4.Text),
                        Location = txtLocation5.Text,
                        Numbering_at_Library = int.Parse(txtNumbringatLibrary6.Text),
                        Num_chapter = int.Parse(txtChapter7.Text),
                        Type_Print = txtPrintT8.Text,
                        Date_print = Convert.ToDateTime(txtPrintD9.Text),
                        Price = double.Parse(txtPrice10.Text),
                        Purchasable = bool.Parse(txtPruchasable1.Text),
                        ID_Data_Home_Share = txtIDPublish12.Text,
                        ID_specilized = int.Parse(txtIDSpecilized13.Text),
                        Quantity = Convert.ToInt16(numQuantity1.Value)

                    };
                    string msg = book.Update();
                    MessageBox.Show(msg);
                }
            }
            else if(Result == DialogResult.No)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void ST_ADD_Click(object sender, EventArgs e)
        {
            //Student S = new Student()
            //{
            //    S_ID= Convert.ToInt32(txt_ST_Id.Text),
            //    S_Name=txt_ST_Name.Text,
            //    S_Section=txt_ST_Section.Text,
            //    S_Team=txt_ST_Team.Text
            //};
            //MessageBox.Show(S.ADD());
        }

        private void ST_Update_Click(object sender, EventArgs e)
        {

        }

        private void ST_Delete_Click(object sender, EventArgs e)
        {

        }

        private void ST_Select_Click(object sender, EventArgs e)
        {

        }
    }
}
