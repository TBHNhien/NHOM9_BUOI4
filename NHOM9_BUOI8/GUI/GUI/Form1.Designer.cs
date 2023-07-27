namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.txbDTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvQLSV = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUYENNGANH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(343, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý sinh viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.txbHoTen);
            this.panel1.Controls.Add(this.txbMaSV);
            this.panel1.Controls.Add(this.txbDTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 364);
            this.panel1.TabIndex = 2;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(120, 124);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(193, 24);
            this.cmbKhoa.TabIndex = 12;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(120, 79);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(193, 22);
            this.txbHoTen.TabIndex = 11;
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(120, 34);
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(193, 22);
            this.txbMaSV.TabIndex = 10;
            // 
            // txbDTB
            // 
            this.txbDTB.Location = new System.Drawing.Point(120, 171);
            this.txbDTB.Name = "txbDTB";
            this.txbDTB.Size = new System.Drawing.Size(193, 22);
            this.txbDTB.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ảnh đại diện :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Điểm Trung Bình :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khoa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Sinh Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức Năng";
            // 
            // dtgvQLSV
            // 
            this.dtgvQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEMTB,
            this.CHUYENNGANH});
            this.dtgvQLSV.Location = new System.Drawing.Point(336, 74);
            this.dtgvQLSV.Name = "dtgvQLSV";
            this.dtgvQLSV.RowHeadersWidth = 51;
            this.dtgvQLSV.RowTemplate.Height = 24;
            this.dtgvQLSV.Size = new System.Drawing.Size(915, 364);
            this.dtgvQLSV.TabIndex = 4;
            this.dtgvQLSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQLSV_CellClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1095, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Chưa ĐK chuyên ngành";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MASV
            // 
            this.MASV.HeaderText = "MASV";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "HOTEN";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // DIEMTB
            // 
            this.DIEMTB.HeaderText = "DIEMTB";
            this.DIEMTB.MinimumWidth = 6;
            this.DIEMTB.Name = "DIEMTB";
            this.DIEMTB.Width = 125;
            // 
            // CHUYENNGANH
            // 
            this.CHUYENNGANH.HeaderText = "CHUYENNGANH";
            this.CHUYENNGANH.MinimumWidth = 6;
            this.CHUYENNGANH.Name = "CHUYENNGANH";
            this.CHUYENNGANH.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dtgvQLSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvQLSV;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.TextBox txbDTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUYENNGANH;
    }
}

