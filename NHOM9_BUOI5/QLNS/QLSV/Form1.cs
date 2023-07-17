
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class FQLSV : Form
    {
        public FQLSV()
        {
            InitializeComponent();
            cmbPhongBan.SelectedIndex = 0;
            Load_dtgv();
        }

        #region method

        //Load datagridview 
        public void Load_dtgv()
        {

            //tạo column
            dtgvNV.Columns.Add("MANV", "MANV");
            dtgvNV.Columns.Add("TENNV", "TENNV");
            dtgvNV.Columns.Add("NGAYSINH", "NGAYSINH");
            dtgvNV.Columns.Add("PHONGBAN", "PHONGBAN");

            dtgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        //Hàm Binding list có tên hiển thị là tên khoa , giá trị là Mã Khoa
        private void FillPBCombobox(List<PHONGBAN> PHONGBANs)
        {
            this.cmbPhongBan.DataSource = PHONGBANs;
            this.cmbPhongBan.DisplayMember = "TENPB";
            this.cmbPhongBan.ValueMember = "MAPB";
        }

        //HÀM binding gridview từ list sinh viên
        private void BindGrid(List<NHANVIEN> NHANVIENs)
        {
            dtgvNV.Rows.Clear();
            foreach(var item in NHANVIENs)
            {
                int index = dtgvNV.Rows.Add();
                dtgvNV.Rows[index].Cells[0].Value = item.MANV;
                dtgvNV.Rows[index].Cells[1].Value = item.TENNV;
                dtgvNV.Rows[index].Cells[2].Value = item.NGAYSINH;
                dtgvNV.Rows[index].Cells[3].Value = item.PHONGBAN.MAPB;
            }
        }


        #endregion

        #region Event
        private void FQLSV_Load(object sender, EventArgs e)
        {
            try
            {
                QLNSdb context = new QLNSdb();
                List<PHONGBAN> listPB = context.PHONGBANs.ToList();//lấy các khoa
                List<NHANVIEN> listNV = context.NHANVIENs.ToList();//lấy sinh viên
                FillPBCombobox(listPB);
                BindGrid(listNV);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //sự kiện thêm
        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {


        }

        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy chỉ số dòng được chọn
            int rowIndex = e.RowIndex;

            //kiểm tra nếu chỉ số dòng hợp lệ
            if (rowIndex >= 0 && rowIndex < dtgvNV.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgvNV.Rows[rowIndex];
                txb_MSNV.Text =selectedRow.Cells[0].Value.ToString();
                txb_Name.Text = selectedRow.Cells[1].Value.ToString();
                dtpkNgaySinh.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                cmbPhongBan.Text = selectedRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("LOI");
            }
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            QLNSdb context = new QLNSdb();
            NHANVIEN s = new NHANVIEN()
            {
                MANV = txb_MSNV.Text.ToString(),
                TENNV = txb_Name.Text.ToString(),
                NGAYSINH = dtpkNgaySinh.Value,
                MAPB = cmbPhongBan.SelectedValue.ToString(),
            };
            context.NHANVIENs.Add(s);
            context.SaveChanges();
            List<NHANVIEN> ListNHANVIENs = context.NHANVIENs.ToList();
            BindGrid(ListNHANVIENs);
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
           // Lưu vùng chọn hiện tại
            int rowIndex = dtgvNV.CurrentRow.Index;
            int columnIndex = dtgvNV.CurrentCell.ColumnIndex;

            QLNSdb context = new QLNSdb();
            NHANVIEN dbUpdate = context.NHANVIENs.FirstOrDefault(p => p.MANV.ToString() == txb_MSNV.Text.ToString());
            if (dbUpdate != null)
            {
                dbUpdate.TENNV = txb_Name.Text.ToString();
                dbUpdate.MAPB = cmbPhongBan.SelectedValue.ToString();
                dbUpdate.NGAYSINH = dtpkNgaySinh.Value;

                context.SaveChanges();
                List<NHANVIEN> ListNHANVIENs = context.NHANVIENs.ToList();

                BindGrid(ListNHANVIENs);
            }

            dtgvNV.CurrentCell = dtgvNV.Rows[rowIndex].Cells[columnIndex];
            dtgvNV.Rows[rowIndex].Selected = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon XOA HEM  ? ", "THÔNG BÁO ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                QLNSdb context = new QLNSdb();
                NHANVIEN dbDelete = context.NHANVIENs.FirstOrDefault(p => p.MANV.ToString() == txb_MSNV.Text.ToString());
                if (dbDelete != null)
                {
                    context.NHANVIENs.Remove(dbDelete);
                    context.SaveChanges();
                    List<NHANVIEN> ListNHANVIENs = context.NHANVIENs.ToList();
                    BindGrid(ListNHANVIENs);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong ? ", "THÔNG BÁO ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
