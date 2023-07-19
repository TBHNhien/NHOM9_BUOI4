using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection cnn = null;
        //string strcnn = "Server = DESKTOP-4SNQUT1\\SQLEXPRESS; Database =QUANLYSINHVIEN ;User id = ;pwd =123";
        string strcnn = "Data Source =.\\SQLEXPRESS;Initial Catalog = QUANLYSINHVIEN; Integrated Security = True";
        BindingSource bs = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(strcnn);
            }

            SqlDataAdapter adt = new SqlDataAdapter("Select * from Student ", cnn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adt);

            DataSet ds = new DataSet();
            adt.Fill(ds, "student");//cach1
                                    //adt.Fill(ds);//cach 2

            bs = new BindingSource(ds, "student");
            txbMa.DataBindings.Add("text", bs, "StudentID");
            txbTenSV.DataBindings.Add("text", bs, "FULLNAME");
            txbDiem.DataBindings.Add("text", bs, "AVERAGESCORE");
            txbKhoa.DataBindings.Add("text", bs, "FacultyId");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (bs.Position < bs.Count - 1)
            {
                bs.Position++;
            }



            string vitri = bs.Position.ToString();
            
            string tong = bs.Count.ToString();
            int temp = bs.Position;
            temp++;
            vitri = temp.ToString();
            

            label1.Text = ( vitri+"/"+ tong).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
            {
                bs.Position--;
            }



            string vitri = bs.Position.ToString();

            string tong = bs.Count.ToString();
            int temp = bs.Position;
            temp++;
            vitri = temp.ToString();
            label1.Text = (vitri + "/" + tong).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bs.Position >0)
            {
                bs.Position = 0;
            }


            string vitri = bs.Position.ToString();

            string tong = bs.Count.ToString();
            int temp = bs.Position;
            temp++;
            vitri = temp.ToString();
            label1.Text = (vitri + "/" + tong).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
            {
                bs.Position = bs.Count ;
            }



            string vitri = bs.Position.ToString();

            string tong = bs.Count.ToString();
            int temp = bs.Position;
            temp++;
            vitri = temp.ToString();
            label1.Text = (vitri + "/" + tong).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
