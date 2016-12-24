namespace QuanLiThietBi
{
    partial class F_quanlithietbi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvthietbi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nguyengia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycapnhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvsoluong = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.dtngaysl = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbhu = new System.Windows.Forms.Label();
            this.lbsd = new System.Windows.Forms.Label();
            this.lbmoi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimkiem2 = new System.Windows.Forms.TextBox();
            this.dgvtinhtrang = new System.Windows.Forms.DataGridView();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaycapnhat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dtngaytt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txttimkiem1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthietbi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsoluong)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhtrang)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ THIẾT BỊ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvthietbi
            // 
            this.dgvthietbi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvthietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ten,
            this.LoaiTB,
            this.Nguyengia,
            this.Donvi,
            this.ngaycapnhat,
            this.NamSD});
            this.dgvthietbi.Location = new System.Drawing.Point(3, 0);
            this.dgvthietbi.Name = "dgvthietbi";
            this.dgvthietbi.Size = new System.Drawing.Size(872, 357);
            this.dgvthietbi.TabIndex = 1;
            this.dgvthietbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvthietbi_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.Width = 200;
            // 
            // LoaiTB
            // 
            this.LoaiTB.HeaderText = "Loại thiết bị";
            this.LoaiTB.Name = "LoaiTB";
            this.LoaiTB.Width = 200;
            // 
            // Nguyengia
            // 
            this.Nguyengia.HeaderText = "Nguyên giá";
            this.Nguyengia.Name = "Nguyengia";
            // 
            // Donvi
            // 
            this.Donvi.HeaderText = "Đơn vị";
            this.Donvi.Name = "Donvi";
            // 
            // ngaycapnhat
            // 
            this.ngaycapnhat.HeaderText = "Ngày cập nhật";
            this.ngaycapnhat.Name = "ngaycapnhat";
            // 
            // NamSD
            // 
            this.NamSD.HeaderText = "Năm sử dụng";
            this.NamSD.Name = "NamSD";
            this.NamSD.Width = 150;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(881, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "SỬA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(881, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 69);
            this.button3.TabIndex = 4;
            this.button3.Text = "THÊM";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(598, 199);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 24);
            this.txttimkiem.TabIndex = 5;
            this.txttimkiem.Text = "Nhập tên thiết bị......";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 395);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dgvsoluong);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dtngaysl);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê số lượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 24);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nhập tên thiết bị....";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvsoluong
            // 
            this.dgvsoluong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvsoluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsoluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.ten2,
            this.loaithietbi,
            this.soluong});
            this.dgvsoluong.Location = new System.Drawing.Point(25, 119);
            this.dgvsoluong.Name = "dgvsoluong";
            this.dgvsoluong.Size = new System.Drawing.Size(941, 179);
            this.dgvsoluong.TabIndex = 3;
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            this.ID2.Visible = false;
            // 
            // ten2
            // 
            this.ten2.HeaderText = "Tên thiết bị";
            this.ten2.Name = "ten2";
            this.ten2.Width = 300;
            // 
            // loaithietbi
            // 
            this.loaithietbi.HeaderText = "Loại thiết bị";
            this.loaithietbi.Name = "loaithietbi";
            this.loaithietbi.Width = 300;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 300;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Thống kê";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtngaysl
            // 
            this.dtngaysl.CustomFormat = "MM/dd/yyyy";
            this.dtngaysl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaysl.Location = new System.Drawing.Point(204, 40);
            this.dtngaysl.Name = "dtngaysl";
            this.dtngaysl.Size = new System.Drawing.Size(278, 24);
            this.dtngaysl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn thời điểm";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txttimkiem2);
            this.tabPage2.Controls.Add(this.dgvtinhtrang);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dtngaytt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê tình trạng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbhu);
            this.groupBox1.Controls.Add(this.lbsd);
            this.groupBox1.Controls.Add(this.lbmoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(785, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 298);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tình trạng";
            // 
            // lbhu
            // 
            this.lbhu.AutoSize = true;
            this.lbhu.Location = new System.Drawing.Point(91, 136);
            this.lbhu.Name = "lbhu";
            this.lbhu.Size = new System.Drawing.Size(0, 18);
            this.lbhu.TabIndex = 11;
            // 
            // lbsd
            // 
            this.lbsd.AutoSize = true;
            this.lbsd.Location = new System.Drawing.Point(145, 95);
            this.lbsd.Name = "lbsd";
            this.lbsd.Size = new System.Drawing.Size(0, 18);
            this.lbsd.TabIndex = 10;
            this.lbsd.Click += new System.EventHandler(this.lbsd_Click);
            // 
            // lbmoi
            // 
            this.lbmoi.AutoSize = true;
            this.lbmoi.Location = new System.Drawing.Point(104, 56);
            this.lbmoi.Name = "lbmoi";
            this.lbmoi.Size = new System.Drawing.Size(0, 18);
            this.lbmoi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hư:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đã qua sử dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mới:";
            // 
            // txttimkiem2
            // 
            this.txttimkiem2.Location = new System.Drawing.Point(47, 135);
            this.txttimkiem2.Multiline = true;
            this.txttimkiem2.Name = "txttimkiem2";
            this.txttimkiem2.Size = new System.Drawing.Size(200, 44);
            this.txttimkiem2.TabIndex = 4;
            this.txttimkiem2.Text = "\r\nNhập tên thiết bị....";
            this.txttimkiem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttimkiem2.TextChanged += new System.EventHandler(this.txttimkiem2_TextChanged);
            // 
            // dgvtinhtrang
            // 
            this.dgvtinhtrang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvtinhtrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtinhtrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID1,
            this.Ten1,
            this.loai,
            this.ngaycapnhat1,
            this.tinhtrang1});
            this.dgvtinhtrang.Location = new System.Drawing.Point(6, 135);
            this.dgvtinhtrang.Name = "dgvtinhtrang";
            this.dgvtinhtrang.Size = new System.Drawing.Size(737, 203);
            this.dgvtinhtrang.TabIndex = 3;
            // 
            // ID1
            // 
            this.ID1.HeaderText = "ID";
            this.ID1.Name = "ID1";
            this.ID1.Visible = false;
            // 
            // Ten1
            // 
            this.Ten1.HeaderText = "Tên thiết bị";
            this.Ten1.Name = "Ten1";
            this.Ten1.Width = 200;
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại";
            this.loai.Name = "loai";
            this.loai.Width = 200;
            // 
            // ngaycapnhat1
            // 
            this.ngaycapnhat1.HeaderText = "Ngày cập nhật";
            this.ngaycapnhat1.Name = "ngaycapnhat1";
            // 
            // tinhtrang1
            // 
            this.tinhtrang1.HeaderText = "Tình Trạng";
            this.tinhtrang1.Name = "tinhtrang1";
            this.tinhtrang1.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtngaytt
            // 
            this.dtngaytt.CustomFormat = "MM/dd/yyyy";
            this.dtngaytt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaytt.Location = new System.Drawing.Point(157, 45);
            this.dtngaytt.Name = "dtngaytt";
            this.dtngaytt.Size = new System.Drawing.Size(329, 24);
            this.dtngaytt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn thời điểm";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.txttimkiem1);
            this.tabPage3.Controls.Add(this.dgvthietbi);
            this.tabPage3.Controls.Add(this.txttimkiem);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1032, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thiết bị";
            // 
            // txttimkiem1
            // 
            this.txttimkiem1.Location = new System.Drawing.Point(44, 3);
            this.txttimkiem1.Multiline = true;
            this.txttimkiem1.Name = "txttimkiem1";
            this.txttimkiem1.Size = new System.Drawing.Size(200, 41);
            this.txttimkiem1.TabIndex = 6;
            this.txttimkiem1.Text = "Nhập tên thiết bị...";
            this.txttimkiem1.TextChanged += new System.EventHandler(this.txttimkiem1_TextChanged);
            // 
            // F_quanlithietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 440);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "F_quanlithietbi";
            this.Text = "F_quanlithietbi";
            this.Load += new System.EventHandler(this.F_quanlithietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthietbi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsoluong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtinhtrang)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvthietbi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txttimkiem1;
        private System.Windows.Forms.DateTimePicker dtngaytt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvtinhtrang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycapnhat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang1;
        private System.Windows.Forms.TextBox txttimkiem2;
        private System.Windows.Forms.DataGridView dgvsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten2;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtngaysl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbhu;
        private System.Windows.Forms.Label lbsd;
        private System.Windows.Forms.Label lbmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nguyengia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaycapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSD;
    }
}