namespace _3.PL.Views
{
    partial class DataStatistics
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
            this.dtg_hoadonchitiet = new System.Windows.Forms.DataGridView();
            this.tbx_tongdoanhthu = new System.Windows.Forms.TextBox();
            this.tbx_soluongdaban = new System.Windows.Forms.TextBox();
            this.btn_doanhthuhomnay = new System.Windows.Forms.Button();
            this.btn_theonam = new System.Windows.Forms.Button();
            this.btn_doanhthuthang = new System.Windows.Forms.Button();
            this.cbb_12thang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_sdtkhachhang = new System.Windows.Forms.TextBox();
            this.tbx_tongtienlai = new System.Windows.Forms.TextBox();
            this.tbx_tenkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_hotennhanvien = new System.Windows.Forms.TextBox();
            this.tbx_manhanvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_loctheongay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_timtheonam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_hoadonchitiet
            // 
            this.dtg_hoadonchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadonchitiet.Location = new System.Drawing.Point(290, 102);
            this.dtg_hoadonchitiet.Name = "dtg_hoadonchitiet";
            this.dtg_hoadonchitiet.RowTemplate.Height = 25;
            this.dtg_hoadonchitiet.Size = new System.Drawing.Size(709, 385);
            this.dtg_hoadonchitiet.TabIndex = 32;
            this.dtg_hoadonchitiet.UseWaitCursor = true;
            // 
            // tbx_tongdoanhthu
            // 
            this.tbx_tongdoanhthu.Location = new System.Drawing.Point(99, 56);
            this.tbx_tongdoanhthu.Name = "tbx_tongdoanhthu";
            this.tbx_tongdoanhthu.ReadOnly = true;
            this.tbx_tongdoanhthu.Size = new System.Drawing.Size(153, 23);
            this.tbx_tongdoanhthu.TabIndex = 33;
            // 
            // tbx_soluongdaban
            // 
            this.tbx_soluongdaban.Location = new System.Drawing.Point(120, 22);
            this.tbx_soluongdaban.Name = "tbx_soluongdaban";
            this.tbx_soluongdaban.ReadOnly = true;
            this.tbx_soluongdaban.Size = new System.Drawing.Size(43, 23);
            this.tbx_soluongdaban.TabIndex = 34;
            // 
            // btn_doanhthuhomnay
            // 
            this.btn_doanhthuhomnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_doanhthuhomnay.Location = new System.Drawing.Point(88, 114);
            this.btn_doanhthuhomnay.Name = "btn_doanhthuhomnay";
            this.btn_doanhthuhomnay.Size = new System.Drawing.Size(112, 37);
            this.btn_doanhthuhomnay.TabIndex = 35;
            this.btn_doanhthuhomnay.Text = "Hôm nay";
            this.btn_doanhthuhomnay.UseVisualStyleBackColor = false;
            this.btn_doanhthuhomnay.Click += new System.EventHandler(this.btn_doanhthuhomnay_Click);
            // 
            // btn_theonam
            // 
            this.btn_theonam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_theonam.Location = new System.Drawing.Point(88, 199);
            this.btn_theonam.Name = "btn_theonam";
            this.btn_theonam.Size = new System.Drawing.Size(112, 37);
            this.btn_theonam.TabIndex = 36;
            this.btn_theonam.Text = "Theo năm";
            this.btn_theonam.UseVisualStyleBackColor = false;
            this.btn_theonam.Click += new System.EventHandler(this.btn_theonam_Click);
            // 
            // btn_doanhthuthang
            // 
            this.btn_doanhthuthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_doanhthuthang.Location = new System.Drawing.Point(88, 154);
            this.btn_doanhthuthang.Name = "btn_doanhthuthang";
            this.btn_doanhthuthang.Size = new System.Drawing.Size(112, 37);
            this.btn_doanhthuthang.TabIndex = 37;
            this.btn_doanhthuthang.Text = "Theo tháng";
            this.btn_doanhthuthang.UseVisualStyleBackColor = false;
            this.btn_doanhthuthang.Click += new System.EventHandler(this.btn_doanhthuthang_Click);
            // 
            // cbb_12thang
            // 
            this.cbb_12thang.FormattingEnabled = true;
            this.cbb_12thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_12thang.Location = new System.Drawing.Point(11, 168);
            this.cbb_12thang.Name = "cbb_12thang";
            this.cbb_12thang.Size = new System.Drawing.Size(48, 23);
            this.cbb_12thang.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_timtheonam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbx_sdtkhachhang);
            this.groupBox1.Controls.Add(this.tbx_tongtienlai);
            this.groupBox1.Controls.Add(this.tbx_tenkh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_hotennhanvien);
            this.groupBox1.Controls.Add(this.btn_doanhthuhomnay);
            this.groupBox1.Controls.Add(this.tbx_manhanvien);
            this.groupBox1.Controls.Add(this.cbb_12thang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_theonam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_doanhthuthang);
            this.groupBox1.Controls.Add(this.tbx_tongdoanhthu);
            this.groupBox1.Controls.Add(this.tbx_soluongdaban);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 482);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Khách hàng mua nhiều laptop nhất";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nhân viên bán được nhiều laptop nhất";
            // 
            // tbx_sdtkhachhang
            // 
            this.tbx_sdtkhachhang.Location = new System.Drawing.Point(99, 397);
            this.tbx_sdtkhachhang.Name = "tbx_sdtkhachhang";
            this.tbx_sdtkhachhang.ReadOnly = true;
            this.tbx_sdtkhachhang.Size = new System.Drawing.Size(153, 23);
            this.tbx_sdtkhachhang.TabIndex = 7;
            // 
            // tbx_tongtienlai
            // 
            this.tbx_tongtienlai.Location = new System.Drawing.Point(99, 85);
            this.tbx_tongtienlai.Name = "tbx_tongtienlai";
            this.tbx_tongtienlai.ReadOnly = true;
            this.tbx_tongtienlai.Size = new System.Drawing.Size(153, 23);
            this.tbx_tongtienlai.TabIndex = 0;
            // 
            // tbx_tenkh
            // 
            this.tbx_tenkh.Location = new System.Drawing.Point(99, 368);
            this.tbx_tenkh.Name = "tbx_tenkh";
            this.tbx_tenkh.ReadOnly = true;
            this.tbx_tenkh.Size = new System.Drawing.Size(153, 23);
            this.tbx_tenkh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tổng tiền thu được";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tiền lãi thực tế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Laptop đã bán";
            // 
            // tbx_hotennhanvien
            // 
            this.tbx_hotennhanvien.Location = new System.Drawing.Point(97, 316);
            this.tbx_hotennhanvien.Name = "tbx_hotennhanvien";
            this.tbx_hotennhanvien.ReadOnly = true;
            this.tbx_hotennhanvien.Size = new System.Drawing.Size(155, 23);
            this.tbx_hotennhanvien.TabIndex = 3;
            // 
            // tbx_manhanvien
            // 
            this.tbx_manhanvien.Location = new System.Drawing.Point(96, 278);
            this.tbx_manhanvien.Name = "tbx_manhanvien";
            this.tbx_manhanvien.ReadOnly = true;
            this.tbx_manhanvien.Size = new System.Drawing.Size(156, 23);
            this.tbx_manhanvien.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // dtp_loctheongay
            // 
            this.dtp_loctheongay.Location = new System.Drawing.Point(602, 73);
            this.dtp_loctheongay.Name = "dtp_loctheongay";
            this.dtp_loctheongay.Size = new System.Drawing.Size(200, 23);
            this.dtp_loctheongay.TabIndex = 44;
            this.dtp_loctheongay.ValueChanged += new System.EventHandler(this.dtp_loctheongay_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(470, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Chọn ngày muốn xem";
            // 
            // cbb_timtheonam
            // 
            this.cbb_timtheonam.FormattingEnabled = true;
            this.cbb_timtheonam.Location = new System.Drawing.Point(11, 207);
            this.cbb_timtheonam.Name = "cbb_timtheonam";
            this.cbb_timtheonam.Size = new System.Drawing.Size(56, 23);
            this.cbb_timtheonam.TabIndex = 44;
            // 
            // DataStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 549);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_loctheongay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_hoadonchitiet);
            this.Name = "DataStatistics";
            this.Text = "DataStatistics";
            this.Load += new System.EventHandler(this.DataStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadonchitiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtg_hoadonchitiet;
        private TextBox tbx_tongdoanhthu;
        private TextBox tbx_soluongdaban;
        private Button btn_doanhthuhomnay;
        private Button btn_theonam;
        private Button btn_doanhthuthang;
        private ComboBox cbb_12thang;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tbx_tongtienlai;
        private DateTimePicker dtp_loctheongay;
        private TextBox tbx_hotennhanvien;
        private TextBox tbx_manhanvien;
        private Label label5;
        private Label label4;
        private TextBox tbx_sdtkhachhang;
        private TextBox tbx_tenkh;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cbb_timtheonam;
    }
}