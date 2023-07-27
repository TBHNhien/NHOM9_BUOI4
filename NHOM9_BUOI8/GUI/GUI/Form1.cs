using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setGridViewStyle(DataGridView dgview)
        {

            dtgvQLSV.BorderStyle = BorderStyle.None;



            dtgvQLSV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;

            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; dgview.BackgroundColor = Color.White;

            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void fillF(List<FACULTY> listf)
        {
            listf.Insert(0, new FACULTY());
            this.cmbKhoa.DataSource = listf;
            this.cmbKhoa.DisplayMember = "FACULTYName";
            this.cmbKhoa.ValueMember = "FACULTYID";
        }


        private void Bind(List<STUDENT> LS)
        {
            dtgvQLSV.Rows.Clear();

            foreach (var s in LS)
            {
                int index = dtgvQLSV.Rows.Add();
                dtgvQLSV.Rows[index].Cells[0].Value = s.STUDENTID;
                dtgvQLSV.Rows[index].Cells[1].Value = s.FULLNAME;
                dtgvQLSV.Rows[index].Cells[2].Value = s.FACULTY.FACULTYNAME;
                dtgvQLSV.Rows[index].Cells[3].Value = s.AVERAGESCORE;

                //dtgvQLSV.Rows[index].Cells[4].Value = s.MAJOR.MAJORID;

                if (s.MAJOR != null)
                {
                    dtgvQLSV.Rows[index].Cells[4].Value = s.MAJOR.MAJORID;
                }
                else
                {
                    dtgvQLSV.Rows[index].Cells[4].Value = "";
                }
                
            }

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dtgvQLSV);


                var listF = FacultyService.Instance.GetAll();
                var listS = StudentService.Instance.GetAll();


                fillF(listF);

                Bind(listS);

            }
            catch (Exception ex)
            {
            }
        }
        private readonly StudentService STUDENTService = new StudentService();

        private readonly FacultyService FACULTYService = new FacultyService();

        private void dtgvQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy chỉ số dòng được chọn
            int rowIndex = e.RowIndex;

            //kiểm tra nếu chỉ số dòng hợp lệ
            if (rowIndex >= 0 && rowIndex < dtgvQLSV.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgvQLSV.Rows[rowIndex];
                txbMaSV.Text = selectedRow.Cells[0].Value.ToString();
                txbHoTen.Text = selectedRow.Cells[1].Value.ToString();
                txbDTB.Text = selectedRow.Cells[2].Value.ToString();
                cmbKhoa.Text = selectedRow.Cells[3].Value.ToString();

                string imagePath = string.Format("{0}.jpg", txbMaSV.Text);
                string fullImagePath = Path.Combine(Application.StartupPath, "ImageSource", imagePath);
                pic.Image = new Bitmap(fullImagePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pic.Image = new Bitmap(Application.StartupPath + "\\ImageSource\\1234567890.jpg");

            string imagePath = (Application.StartupPath + "\\ImageSource\\1234567890.jpg");

            if (File.Exists(imagePath))
            {
                pic.Image = new Bitmap(imagePath);
                MessageBox.Show("Tập tin ảnh này tồn tại.");

            }
            else
            {
                // Xử lý tập tin không tồn tại
                MessageBox.Show("Tập tin ảnh không tồn tại.");
            }
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var lS = new List<STUDENT>();
            if (this.chkUnregisterMajor.Checked)
                lS = StudentService.Instance.GetAllHasNoMajor();
            else
                lS = StudentService.Instance.GetAll();
            Bind(lS);
        }

        private void dtgvQLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
