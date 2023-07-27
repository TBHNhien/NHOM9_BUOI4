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
                dtgvQLSV.Rows[index].Cells[2].Value = s.AVERAGESCORE;
                dtgvQLSV.Rows[index].Cells[3].Value = s.FACULTY.FACULTYNAME;
                
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


            }
        }
    }

}
