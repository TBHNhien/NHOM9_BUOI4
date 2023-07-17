using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace themdata_dtgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dtgvMain.Columns.Add("MASV", "MSSV");
            //dtgvMain.Columns.Add("HOTEN", "HỌ VÀ TÊN");
            //dtgvMain.Columns.Add("NGAYSINH", "NGÀY SINH");
            //dtgvMain.Columns.Add("LOP", "LỚP");

            //Đặt kích thước mỗi cột 
            foreach(DataGridViewColumn column in dtgvMain.Columns)
            {
                column.Width = 100;
            }

            dtgvMain.Rows.Add("SV0001", "Trần Văn Nam", "20/08/1985", "CNTT");
            dtgvMain.Rows.Add("SV0002", "Nguyễn Thị Hằng", "15/03/1990", "Kinh tế");
            dtgvMain.Rows.Add("SV0003", "Lê Minh Đức", "05/11/1992", "CNTT");
        }
    }
}
