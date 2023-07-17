namespace QLSV
{
    partial class FQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQLSV));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbPhongBan = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_MSNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Name = "label1";
            // 
            // dtgvNV
            // 
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtgvNV, "dtgvNV");
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowTemplate.Height = 24;
            this.dtgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNV_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.cmbPhongBan);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_MSNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_Name);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dtpkNgaySinh
            // 
            resources.ApplyResources(this.dtpkNgaySinh, "dtpkNgaySinh");
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // cmbPhongBan
            // 
            this.cmbPhongBan.AllowDrop = true;
            this.cmbPhongBan.FormattingEnabled = true;
            this.cmbPhongBan.Items.AddRange(new object[] {
            resources.GetString("cmbPhongBan.Items"),
            resources.GetString("cmbPhongBan.Items1"),
            resources.GetString("cmbPhongBan.Items2")});
            resources.ApplyResources(this.cmbPhongBan, "cmbPhongBan");
            this.cmbPhongBan.Name = "cmbPhongBan";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btn_Add
            // 
            resources.ApplyResources(this.btn_Add, "btn_Add");
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txb_MSNV
            // 
            resources.ApplyResources(this.txb_MSNV, "txb_MSNV");
            this.txb_MSNV.Name = "txb_MSNV";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txb_Name
            // 
            resources.ApplyResources(this.txb_Name, "txb_Name");
            this.txb_Name.Name = "txb_Name";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FQLSV
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvNV);
            this.Controls.Add(this.label1);
            this.Name = "FQLSV";
            this.Load += new System.EventHandler(this.FQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgvNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbPhongBan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MSNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Button button1;
    }
}

