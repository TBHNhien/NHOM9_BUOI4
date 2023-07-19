namespace BAI2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.txbTenSV = new System.Windows.Forms.TextBox();
            this.txbDiem = new System.Windows.Forms.TextBox();
            this.txbKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(591, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = ">|";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MÃ SV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TÊN SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐIỂM SV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "KHOA";
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(187, 111);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(265, 22);
            this.txbMa.TabIndex = 9;
            // 
            // txbTenSV
            // 
            this.txbTenSV.Location = new System.Drawing.Point(187, 164);
            this.txbTenSV.Name = "txbTenSV";
            this.txbTenSV.Size = new System.Drawing.Size(265, 22);
            this.txbTenSV.TabIndex = 10;
            this.txbTenSV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbDiem
            // 
            this.txbDiem.Location = new System.Drawing.Point(187, 218);
            this.txbDiem.Name = "txbDiem";
            this.txbDiem.Size = new System.Drawing.Size(265, 22);
            this.txbDiem.TabIndex = 11;
            // 
            // txbKhoa
            // 
            this.txbKhoa.Location = new System.Drawing.Point(187, 273);
            this.txbKhoa.Name = "txbKhoa";
            this.txbKhoa.Size = new System.Drawing.Size(265, 22);
            this.txbKhoa.TabIndex = 12;
            this.txbKhoa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "1/1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "THÊM";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 48);
            this.button6.TabIndex = 15;
            this.button6.Text = "XÓA";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(377, 345);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 48);
            this.button7.TabIndex = 16;
            this.button7.Text = "SỬA";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbKhoa);
            this.Controls.Add(this.txbDiem);
            this.Controls.Add(this.txbTenSV);
            this.Controls.Add(this.txbMa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.TextBox txbTenSV;
        private System.Windows.Forms.TextBox txbDiem;
        private System.Windows.Forms.TextBox txbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

