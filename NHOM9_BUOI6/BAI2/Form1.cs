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

        #region method

        private void RefreshForm()
        {
            // Ẩn form hiện tại thay vì đóng nó
            this.Hide();

            // Tạo mới instance của form
            Form1 newForm = new Form1();

            // Hiển thị form mới
            newForm.Show();
        }

        // Ví dụ hàm LoadDataFromDatabase để load dữ liệu mới từ CSDL
        private void LoadDataFromDatabase()
        {
            // Code để lấy dữ liệu mới từ CSDL và hiển thị lên form
            // Ví dụ:
            // SqlDataAdapter adt = new SqlDataAdapter("SELECT * FROM YourTable", cnn);
            // DataSet ds = new DataSet();
            // adt.Fill(ds, "YourTable");
            // dataGridView.DataSource = ds.Tables["YourTable"];
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
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();




            string vitri = bs.Position.ToString();

            string tong = bs.Count.ToString();
            int temp = bs.Position;
            temp++;
            vitri = temp.ToString();
            label1.Text = (vitri + "/" + tong).ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn == null)
                {
                    cnn = new SqlConnection(strcnn);
                }

                SqlCommand sqlc = new SqlCommand("USP_THEMSV", cnn);
                sqlc.CommandType = CommandType.StoredProcedure;

                //thêm các tham số và giá trị tương ứng vào sqlCommnad
                sqlc.Parameters.AddWithValue("@ID", txbMa.Text);
                sqlc.Parameters.AddWithValue("@TEN", txbTenSV.Text);
                sqlc.Parameters.AddWithValue("@DIEM", txbDiem.Text);
                sqlc.Parameters.AddWithValue("@MAKHOA", txbKhoa.Text);

                //KHỞI TẠO SQLDATAADAPTER VỚI SQLCOMMAND ĐÃ TẠO TRÊN
                SqlDataAdapter adt = new SqlDataAdapter(sqlc);

                //khởi tạo dataset và điền dữ liệu từ sqladapter vào dataset

                DataSet ds = new DataSet();
                adt.Fill(ds, "student");

                // Bổ sung dữ liệu mới vào DataSet hiện có thay vì thay thế
                ds.Merge(ds);

                RefreshForm();

                MessageBox.Show("ĐÃ THÊM THÀNH CÔNG !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            txbMa.Text = "";
            txbTenSV.Text = "";
            txbDiem.Text = "";
            txbKhoa.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn == null)
                {
                    cnn = new SqlConnection(strcnn);
                }

                SqlCommand sqlc = new SqlCommand("USP_SUASV", cnn);
                sqlc.CommandType = CommandType.StoredProcedure;

                

                //thêm các tham số và giá trị tương ứng vào sqlCommnad
                sqlc.Parameters.AddWithValue("@ID", txbMa.Text);
                sqlc.Parameters.AddWithValue("@TEN", txbTenSV.Text);
                sqlc.Parameters.AddWithValue("@DIEM", txbDiem.Text);
                sqlc.Parameters.AddWithValue("@MAKHOA", txbKhoa.Text);

                //KHỞI TẠO SQLDATAADAPTER VỚI SQLCOMMAND ĐÃ TẠO TRÊN
                SqlDataAdapter adt = new SqlDataAdapter(sqlc);

                //khởi tạo dataset và điền dữ liệu từ sqladapter vào dataset

                DataSet ds = new DataSet();
                adt.Fill(ds, "student");

                // Bổ sung dữ liệu mới vào DataSet hiện có thay vì thay thế
                ds.Merge(ds);

                RefreshForm();

                MessageBox.Show("ĐÃ SỬA THÀNH CÔNG !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn == null)
                {
                    cnn = new SqlConnection(strcnn);
                }

                SqlCommand sqlc = new SqlCommand("USP_XOASV", cnn);
                sqlc.CommandType = CommandType.StoredProcedure;



                //thêm các tham số và giá trị tương ứng vào sqlCommnad
                sqlc.Parameters.AddWithValue("@ID", txbMa.Text);

                //KHỞI TẠO SQLDATAADAPTER VỚI SQLCOMMAND ĐÃ TẠO TRÊN
                SqlDataAdapter adt = new SqlDataAdapter(sqlc);

                //khởi tạo dataset và điền dữ liệu từ sqladapter vào dataset

                DataSet ds = new DataSet();
                adt.Fill(ds, "student");

                // Bổ sung dữ liệu mới vào DataSet hiện có thay vì thay thế
                ds.Merge(ds);

                RefreshForm();

                MessageBox.Show("ĐÃ XÓA THÀNH CÔNG !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
