using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string flag;
        DataTable dtSV;
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoacontrol();
            dtSV = creatable();

            // Thêm dữ liệu vào DataGridView
            datagridsinhvien.Rows.Add("SV0001", "Trần Văn Nam","20/8/1985 12:00:00SA",  "7", "CNTT1", "20/08/1985");
            datagridsinhvien.Rows.Add("SV0002","Nguyễn Thị Hằng", "25/8/1986 12:00:00SA",  "8", "Kinh tế2", "15/03/1990");
            datagridsinhvien.Rows.Add("SV0003", "Lê Minh Đức", "21/3/1984 12:00:00SA",  "9", "CNTT3", "05/11/1992");



        }
        public void khoacontrol()
        {
            btnadd.Enabled = true;
            btnupdate.Enabled = true;
            btndel.Enabled = true;
            btncancel.Enabled = false;
            btnsave.Enabled = false;

            txttensv.ReadOnly = true;
            txtid.ReadOnly = true;
            txtdiem.ReadOnly = true;
            txtlop.ReadOnly = true;

            btnadd.Focus();
        }
        public void unlockcontrol()
        {
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btndel.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;

            txttensv.ReadOnly = false;
            txtid.ReadOnly = false;
            txtdiem.ReadOnly = false;
            txtlop.ReadOnly = false;

            btnadd.Focus();


        }

        public List<SINHVIEN> TaoDuLieu()
        {
            //Console.InputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;
            List<SINHVIEN> ds = new List<SINHVIEN>();
            ds.Add(new SINHVIEN() { MASV = "SV0001", HOTEN = "Trần Văn Nam", NGAYSINH = "20/08/1985 12:00:00SA", KHOA = "CNTT" });

            return ds;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            flag = "add";
            txtid.Text = "";
            txttensv.Text = "";
            txtlop.Text = "";
            txtdiem.Text = "";
            cbkhoa.Text = "";
            dtp_DateOfBirth.Text = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkdata())
                {
                    dtSV.Rows.Add(txttensv.Text, txtid.Text, dtp_DateOfBirth.Text, txtdiem.Text, txtlop.Text, cbkhoa.Text);
                    datagridsinhvien.DataSource = dtSV;
                    datagridsinhvien.RefreshEdit();
                }
            }
            else if (flag == "edit")
            {
                if (checkdata())
                {
                    dtSV.Rows[index]["dtbid"] = txtid.Text;
                    dtSV.Rows[index]["dtbten"] = txttensv.Text;
                    dtSV.Rows[index]["dtblop"] = txtlop.Text;
                    dtSV.Rows[index]["dtbdiem"] = txtdiem.Text;
                    dtSV.Rows[index]["dtbkhoa"] = cbkhoa.Text;
                    dtSV.Rows[index]["dateofbirth"] = dtp_DateOfBirth.Text;
                    datagridsinhvien.DataSource = dtSV;
                    datagridsinhvien.RefreshEdit();
                }
            }
            khoacontrol();
        }
        public bool checkdata()
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Your ID is NULL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txttensv.Text))
            {
                MessageBox.Show("Your name is NULL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttensv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtdiem.Text))
            {
                MessageBox.Show("Your score is NULL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiem.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtlop.Text))
            {
                MessageBox.Show("Your class is NULL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlop.Focus();
                return false;
            }
            return true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            flag = "edit";
        }
        public DataTable creatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dtbtensv");
            dt.Columns.Add("dtbid");
            dt.Columns.Add("dateofbirth");
            dt.Columns.Add("dtblop");
            dt.Columns.Add("dtbdiem");
            dt.Columns.Add("dtbkhoa");
            return dt;

        }

        private void datagridsinhvien_SelectionChanged(object sender, EventArgs e)
        {
            index = datagridsinhvien.CurrentCell == null ? -1 : datagridsinhvien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)datagridsinhvien.DataSource;
            if (index != -1)
            {
                txtid.Text = datagridsinhvien.Rows[index].Cells["dtbid"].Value.ToString();
                txttensv.Text = datagridsinhvien.Rows[index].Cells["dtbten"].Value.ToString();
                // dtp_DateOfBirth.Text = datagridsinhvien.Rows[index].Cells["dateofbirth"].Value.ToString();
                txtlop.Text = datagridsinhvien.Rows[index].Cells["dtblop"].Value.ToString();
                txtdiem.Text = datagridsinhvien.Rows[index].Cells["dtbdiem"].Value.ToString();
                cbkhoa.Text = datagridsinhvien.Rows[index].Cells["dtbkhoa"].Value.ToString();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are u sure ??", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                datagridsinhvien.DataSource = dtSV;
                datagridsinhvien.RefreshEdit();

            }
        }

        private void datagridsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}