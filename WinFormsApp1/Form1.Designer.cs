namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txttensv = new TextBox();
            txtid = new TextBox();
            txtdiem = new TextBox();
            txtlop = new TextBox();
            cbkhoa = new ComboBox();
            btnadd = new Button();
            btndel = new Button();
            btnupdate = new Button();
            btnsave = new Button();
            btncancel = new Button();
            btnfind = new Button();
            label6 = new Label();
            txtfind = new TextBox();
            label7 = new Label();
            dtp_DateOfBirth = new DateTimePicker();
            datagridsinhvien = new DataGridView();
            dtbten = new DataGridViewTextBoxColumn();
            dtbid = new DataGridViewTextBoxColumn();
            dtbdiem = new DataGridViewTextBoxColumn();
            dtblop = new DataGridViewTextBoxColumn();
            dtbkhoa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)datagridsinhvien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 28);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên sinh viên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-1, 72);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã sinh viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(418, 16);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 2;
            label3.Text = "Lớp :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(415, 71);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 3;
            label4.Text = "Điểm :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(718, 16);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 4;
            label5.Text = "Khoa :";
            // 
            // txttensv
            // 
            txttensv.Location = new Point(126, 29);
            txttensv.Name = "txttensv";
            txttensv.Size = new Size(271, 27);
            txttensv.TabIndex = 5;
            // 
            // txtid
            // 
            txtid.Location = new Point(126, 72);
            txtid.Name = "txtid";
            txtid.Size = new Size(271, 27);
            txtid.TabIndex = 6;
            // 
            // txtdiem
            // 
            txtdiem.Location = new Point(485, 76);
            txtdiem.Name = "txtdiem";
            txtdiem.Size = new Size(50, 27);
            txtdiem.TabIndex = 7;
            // 
            // txtlop
            // 
            txtlop.Location = new Point(485, 20);
            txtlop.Name = "txtlop";
            txtlop.Size = new Size(227, 27);
            txtlop.TabIndex = 8;
            // 
            // cbkhoa
            // 
            cbkhoa.FormattingEnabled = true;
            cbkhoa.Items.AddRange(new object[] { "CNTT", "XD", "NNA" });
            cbkhoa.Location = new Point(790, 16);
            cbkhoa.Name = "cbkhoa";
            cbkhoa.Size = new Size(213, 28);
            cbkhoa.TabIndex = 9;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(104, 123);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 35);
            btnadd.TabIndex = 10;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndel
            // 
            btndel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndel.Location = new Point(201, 124);
            btndel.Name = "btndel";
            btndel.Size = new Size(75, 34);
            btndel.TabIndex = 11;
            btndel.Text = "Xóa";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnupdate.Location = new Point(300, 123);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 35);
            btnupdate.TabIndex = 12;
            btnupdate.Text = "Sửa";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(485, 123);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(74, 35);
            btnsave.TabIndex = 13;
            btnsave.Text = "Lưu";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncancel.Location = new Point(607, 123);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(82, 35);
            btncancel.TabIndex = 14;
            btncancel.Text = "Hủy";
            btncancel.UseVisualStyleBackColor = true;
            // 
            // btnfind
            // 
            btnfind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnfind.Location = new Point(537, 198);
            btnfind.Name = "btnfind";
            btnfind.Size = new Size(74, 35);
            btnfind.TabIndex = 15;
            btnfind.Text = "Tìm";
            btnfind.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 208);
            label6.Name = "label6";
            label6.Size = new Size(174, 28);
            label6.TabIndex = 16;
            label6.Text = " Sinh viên cần tìm :";
            // 
            // txtfind
            // 
            txtfind.Location = new Point(201, 209);
            txtfind.Name = "txtfind";
            txtfind.Size = new Size(298, 27);
            txtfind.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(607, 76);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 19;
            label7.Text = "Ngày Sinh :";
            label7.Click += label7_Click;
            // 
            // dtp_DateOfBirth
            // 
            dtp_DateOfBirth.Location = new Point(763, 78);
            dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            dtp_DateOfBirth.Size = new Size(240, 27);
            dtp_DateOfBirth.TabIndex = 20;
            // 
            // datagridsinhvien
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagridsinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagridsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridsinhvien.Columns.AddRange(new DataGridViewColumn[] { dtbten, dtbid, dtbdiem, dtblop, dtbkhoa });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datagridsinhvien.DefaultCellStyle = dataGridViewCellStyle2;
            datagridsinhvien.Dock = DockStyle.Bottom;
            datagridsinhvien.Location = new Point(0, 240);
            datagridsinhvien.Name = "datagridsinhvien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datagridsinhvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datagridsinhvien.RowHeadersWidth = 51;
            datagridsinhvien.RowTemplate.Height = 25;
            datagridsinhvien.Size = new Size(1017, 302);
            datagridsinhvien.TabIndex = 18;
            datagridsinhvien.CellContentClick += datagridsinhvien_CellContentClick;
            datagridsinhvien.SelectionChanged += datagridsinhvien_SelectionChanged;
            // 
            // dtbten
            // 
            dtbten.DataPropertyName = "dtbtensv";
            dtbten.FillWeight = 200F;
            dtbten.HeaderText = "Tên sinh viên";
            dtbten.MinimumWidth = 6;
            dtbten.Name = "dtbten";
            dtbten.Width = 200;
            // 
            // dtbid
            // 
            dtbid.DataPropertyName = "dtbid";
            dtbid.FillWeight = 200F;
            dtbid.HeaderText = "Mã sinh viên";
            dtbid.MinimumWidth = 6;
            dtbid.Name = "dtbid";
            dtbid.Width = 200;
            // 
            // dtbdiem
            // 
            dtbdiem.DataPropertyName = "dtbdiem";
            dtbdiem.HeaderText = "Điểm";
            dtbdiem.MinimumWidth = 6;
            dtbdiem.Name = "dtbdiem";
            dtbdiem.Width = 125;
            // 
            // dtblop
            // 
            dtblop.DataPropertyName = "dtblop";
            dtblop.FillWeight = 250F;
            dtblop.HeaderText = "Lớp";
            dtblop.MinimumWidth = 6;
            dtblop.Name = "dtblop";
            dtblop.Width = 200;
            // 
            // dtbkhoa
            // 
            dtbkhoa.DataPropertyName = "dtbkhoa";
            dtbkhoa.HeaderText = "Khoa";
            dtbkhoa.MinimumWidth = 6;
            dtbkhoa.Name = "dtbkhoa";
            dtbkhoa.Width = 350;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 542);
            Controls.Add(dtp_DateOfBirth);
            Controls.Add(label7);
            Controls.Add(datagridsinhvien);
            Controls.Add(txtfind);
            Controls.Add(label6);
            Controls.Add(btnfind);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(btnupdate);
            Controls.Add(btndel);
            Controls.Add(btnadd);
            Controls.Add(cbkhoa);
            Controls.Add(txtlop);
            Controls.Add(txtdiem);
            Controls.Add(txtid);
            Controls.Add(txttensv);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagridsinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txttensv;
        private TextBox txtid;
        private TextBox txtdiem;
        private TextBox txtlop;
        private ComboBox cbkhoa;
        private Button btnadd;
        private Button btndel;
        private Button btnupdate;
        private Button btnsave;
        private Button btncancel;
        private Button btnfind;
        private Label label6;
        private TextBox txtfind;
        private Label label7;
        private DateTimePicker dtp_DateOfBirth;
        private DataGridView datagridsinhvien;
        private DataGridViewTextBoxColumn dtbten;
        private DataGridViewTextBoxColumn dtbid;
        private DataGridViewTextBoxColumn dtbdiem;
        private DataGridViewTextBoxColumn dtblop;
        private DataGridViewTextBoxColumn dtbkhoa;
    }
}