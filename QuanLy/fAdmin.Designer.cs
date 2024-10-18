namespace QuanLy
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tpAdmin = new System.Windows.Forms.TabControl();
            this.tbBill = new System.Windows.Forms.TabPage();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.DateBill2 = new System.Windows.Forms.DateTimePicker();
            this.dateBill1 = new System.Windows.Forms.DateTimePicker();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.tbThucAn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nbGia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimDanhMuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXemThucAn = new System.Windows.Forms.Button();
            this.btnSuaThucAn = new System.Windows.Forms.Button();
            this.btnDeleteThucAn = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgThucAn = new System.Windows.Forms.DataGridView();
            this.tpDanhMuc = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDDanhMuc = new System.Windows.Forms.TextBox();
            this.btnXemDanhMuc = new System.Windows.Forms.Button();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.btnXoaDanhMuc = new System.Windows.Forms.Button();
            this.btnAddDanhMuc = new System.Windows.Forms.Button();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.tbBanAn = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTableName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDTable = new System.Windows.Forms.TextBox();
            this.btnXemTable = new System.Windows.Forms.Button();
            this.btnSuaTable = new System.Windows.Forms.Button();
            this.btnXoaTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.tbTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDatLaiMK = new System.Windows.Forms.Button();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnXemTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnAddTaiKhoan = new System.Windows.Forms.Button();
            this.dgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tpAdmin.SuspendLayout();
            this.tbBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.tbThucAn.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThucAn)).BeginInit();
            this.tpDanhMuc.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.tbBanAn.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.tbTaiKhoan.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.tbBill);
            this.tpAdmin.Controls.Add(this.tbThucAn);
            this.tpAdmin.Controls.Add(this.tpDanhMuc);
            this.tpAdmin.Controls.Add(this.tbBanAn);
            this.tpAdmin.Controls.Add(this.tbTaiKhoan);
            this.tpAdmin.Location = new System.Drawing.Point(23, 24);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.SelectedIndex = 0;
            this.tpAdmin.Size = new System.Drawing.Size(804, 585);
            this.tpAdmin.TabIndex = 0;
            // 
            // tbBill
            // 
            this.tbBill.Controls.Add(this.btnViewBill);
            this.tbBill.Controls.Add(this.DateBill2);
            this.tbBill.Controls.Add(this.dateBill1);
            this.tbBill.Controls.Add(this.dgBill);
            this.tbBill.Location = new System.Drawing.Point(4, 25);
            this.tbBill.Name = "tbBill";
            this.tbBill.Padding = new System.Windows.Forms.Padding(3);
            this.tbBill.Size = new System.Drawing.Size(796, 556);
            this.tbBill.TabIndex = 0;
            this.tbBill.Text = "Doanh thu";
            this.tbBill.UseVisualStyleBackColor = true;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBill.Location = new System.Drawing.Point(332, 8);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(136, 53);
            this.btnViewBill.TabIndex = 3;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // DateBill2
            // 
            this.DateBill2.Location = new System.Drawing.Point(504, 21);
            this.DateBill2.Name = "DateBill2";
            this.DateBill2.Size = new System.Drawing.Size(263, 22);
            this.DateBill2.TabIndex = 2;
            // 
            // dateBill1
            // 
            this.dateBill1.Location = new System.Drawing.Point(16, 21);
            this.dateBill1.Name = "dateBill1";
            this.dateBill1.Size = new System.Drawing.Size(263, 22);
            this.dateBill1.TabIndex = 1;
            // 
            // dgBill
            // 
            this.dgBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Location = new System.Drawing.Point(16, 67);
            this.dgBill.Name = "dgBill";
            this.dgBill.ReadOnly = true;
            this.dgBill.RowHeadersWidth = 51;
            this.dgBill.RowTemplate.Height = 24;
            this.dgBill.Size = new System.Drawing.Size(763, 468);
            this.dgBill.TabIndex = 0;
            // 
            // tbThucAn
            // 
            this.tbThucAn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbThucAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbThucAn.BackgroundImage")));
            this.tbThucAn.Controls.Add(this.panel1);
            this.tbThucAn.Controls.Add(this.txtTim);
            this.tbThucAn.Controls.Add(this.btnTim);
            this.tbThucAn.Controls.Add(this.btnXemThucAn);
            this.tbThucAn.Controls.Add(this.btnSuaThucAn);
            this.tbThucAn.Controls.Add(this.btnDeleteThucAn);
            this.tbThucAn.Controls.Add(this.btnAddFood);
            this.tbThucAn.Controls.Add(this.dgThucAn);
            this.tbThucAn.Location = new System.Drawing.Point(4, 25);
            this.tbThucAn.Name = "tbThucAn";
            this.tbThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tbThucAn.Size = new System.Drawing.Size(796, 556);
            this.tbThucAn.TabIndex = 1;
            this.tbThucAn.Text = "Thức ăn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nbGia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTimDanhMuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTenMon);
            this.panel1.Controls.Add(this.txtTenMon);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(440, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 422);
            this.panel1.TabIndex = 8;
            // 
            // nbGia
            // 
            this.nbGia.Location = new System.Drawing.Point(104, 233);
            this.nbGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbGia.Name = "nbGia";
            this.nbGia.Size = new System.Drawing.Size(233, 22);
            this.nbGia.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giá";
            // 
            // cbTimDanhMuc
            // 
            this.cbTimDanhMuc.FormattingEnabled = true;
            this.cbTimDanhMuc.Location = new System.Drawing.Point(99, 168);
            this.cbTimDanhMuc.Name = "cbTimDanhMuc";
            this.cbTimDanhMuc.Size = new System.Drawing.Size(238, 24);
            this.cbTimDanhMuc.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh mục";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(3, 102);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(72, 19);
            this.lblTenMon.TabIndex = 11;
            this.lblTenMon.Text = "Tên món";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenMon.Location = new System.Drawing.Point(99, 99);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(238, 22);
            this.txtTenMon.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(23, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 19);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 23);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(238, 22);
            this.txtID.TabIndex = 8;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtTim
            // 
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTim.Location = new System.Drawing.Point(439, 44);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(238, 22);
            this.txtTim.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(708, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(73, 58);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXemThucAn
            // 
            this.btnXemThucAn.Location = new System.Drawing.Point(307, 26);
            this.btnXemThucAn.Name = "btnXemThucAn";
            this.btnXemThucAn.Size = new System.Drawing.Size(73, 58);
            this.btnXemThucAn.TabIndex = 5;
            this.btnXemThucAn.Text = "Xem";
            this.btnXemThucAn.UseVisualStyleBackColor = true;
            this.btnXemThucAn.Click += new System.EventHandler(this.btnXemThucAn_Click);
            // 
            // btnSuaThucAn
            // 
            this.btnSuaThucAn.Location = new System.Drawing.Point(217, 26);
            this.btnSuaThucAn.Name = "btnSuaThucAn";
            this.btnSuaThucAn.Size = new System.Drawing.Size(65, 58);
            this.btnSuaThucAn.TabIndex = 4;
            this.btnSuaThucAn.Text = "Sửa";
            this.btnSuaThucAn.UseVisualStyleBackColor = true;
            this.btnSuaThucAn.Click += new System.EventHandler(this.btnSuaThucAn_Click);
            // 
            // btnDeleteThucAn
            // 
            this.btnDeleteThucAn.Location = new System.Drawing.Point(126, 26);
            this.btnDeleteThucAn.Name = "btnDeleteThucAn";
            this.btnDeleteThucAn.Size = new System.Drawing.Size(72, 58);
            this.btnDeleteThucAn.TabIndex = 3;
            this.btnDeleteThucAn.Text = "Xóa thức ăn";
            this.btnDeleteThucAn.UseVisualStyleBackColor = true;
            this.btnDeleteThucAn.Click += new System.EventHandler(this.btnDeleteThucAn_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddFood.ForeColor = System.Drawing.Color.Red;
            this.btnAddFood.Location = new System.Drawing.Point(31, 26);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(77, 58);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm thức ăn";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgThucAn
            // 
            this.dgThucAn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgThucAn.Location = new System.Drawing.Point(17, 110);
            this.dgThucAn.Name = "dgThucAn";
            this.dgThucAn.ReadOnly = true;
            this.dgThucAn.RowHeadersWidth = 51;
            this.dgThucAn.RowTemplate.Height = 24;
            this.dgThucAn.Size = new System.Drawing.Size(363, 425);
            this.dgThucAn.TabIndex = 1;
            // 
            // tpDanhMuc
            // 
            this.tpDanhMuc.BackColor = System.Drawing.Color.DodgerBlue;
            this.tpDanhMuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDanhMuc.BackgroundImage")));
            this.tpDanhMuc.Controls.Add(this.panel2);
            this.tpDanhMuc.Controls.Add(this.btnXemDanhMuc);
            this.tpDanhMuc.Controls.Add(this.btnSuaDanhMuc);
            this.tpDanhMuc.Controls.Add(this.btnXoaDanhMuc);
            this.tpDanhMuc.Controls.Add(this.btnAddDanhMuc);
            this.tpDanhMuc.Controls.Add(this.dgDanhMuc);
            this.tpDanhMuc.Location = new System.Drawing.Point(4, 25);
            this.tpDanhMuc.Name = "tpDanhMuc";
            this.tpDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tpDanhMuc.Size = new System.Drawing.Size(796, 556);
            this.tpDanhMuc.TabIndex = 2;
            this.tpDanhMuc.Text = "Danh mục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDanhMuc);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIDDanhMuc);
            this.panel2.Location = new System.Drawing.Point(438, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 289);
            this.panel2.TabIndex = 15;
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDanhMuc.Location = new System.Drawing.Point(99, 78);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(238, 22);
            this.txtDanhMuc.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // txtIDDanhMuc
            // 
            this.txtIDDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDDanhMuc.Location = new System.Drawing.Point(99, 23);
            this.txtIDDanhMuc.Name = "txtIDDanhMuc";
            this.txtIDDanhMuc.ReadOnly = true;
            this.txtIDDanhMuc.Size = new System.Drawing.Size(238, 22);
            this.txtIDDanhMuc.TabIndex = 8;
            // 
            // btnXemDanhMuc
            // 
            this.btnXemDanhMuc.Location = new System.Drawing.Point(306, 24);
            this.btnXemDanhMuc.Name = "btnXemDanhMuc";
            this.btnXemDanhMuc.Size = new System.Drawing.Size(73, 58);
            this.btnXemDanhMuc.TabIndex = 12;
            this.btnXemDanhMuc.Text = "Xem";
            this.btnXemDanhMuc.UseVisualStyleBackColor = true;
            this.btnXemDanhMuc.Click += new System.EventHandler(this.btnXemDanhMuc_Click);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(216, 24);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(65, 58);
            this.btnSuaDanhMuc.TabIndex = 11;
            this.btnSuaDanhMuc.Text = "Sửa";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = true;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(125, 24);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(72, 58);
            this.btnXoaDanhMuc.TabIndex = 10;
            this.btnXoaDanhMuc.Text = "Xóa";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = true;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnAddDanhMuc
            // 
            this.btnAddDanhMuc.Location = new System.Drawing.Point(30, 24);
            this.btnAddDanhMuc.Name = "btnAddDanhMuc";
            this.btnAddDanhMuc.Size = new System.Drawing.Size(77, 58);
            this.btnAddDanhMuc.TabIndex = 9;
            this.btnAddDanhMuc.Text = "Thêm";
            this.btnAddDanhMuc.UseVisualStyleBackColor = true;
            this.btnAddDanhMuc.Click += new System.EventHandler(this.btnAddDanhMuc_Click);
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Location = new System.Drawing.Point(16, 108);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.RowHeadersWidth = 51;
            this.dgDanhMuc.RowTemplate.Height = 24;
            this.dgDanhMuc.Size = new System.Drawing.Size(363, 292);
            this.dgDanhMuc.TabIndex = 8;
            // 
            // tbBanAn
            // 
            this.tbBanAn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbBanAn.Controls.Add(this.panel3);
            this.tbBanAn.Controls.Add(this.btnXemTable);
            this.tbBanAn.Controls.Add(this.btnSuaTable);
            this.tbBanAn.Controls.Add(this.btnXoaTable);
            this.tbBanAn.Controls.Add(this.btnAddTable);
            this.tbBanAn.Controls.Add(this.dgTable);
            this.tbBanAn.Location = new System.Drawing.Point(4, 25);
            this.tbBanAn.Name = "tbBanAn";
            this.tbBanAn.Padding = new System.Windows.Forms.Padding(3);
            this.tbBanAn.Size = new System.Drawing.Size(796, 556);
            this.tbBanAn.TabIndex = 4;
            this.tbBanAn.Text = "Bàn ăn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTableName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTenTable);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtIDTable);
            this.panel3.Location = new System.Drawing.Point(438, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 422);
            this.panel3.TabIndex = 21;
            // 
            // cbTableName
            // 
            this.cbTableName.FormattingEnabled = true;
            this.cbTableName.Location = new System.Drawing.Point(99, 130);
            this.cbTableName.Name = "cbTableName";
            this.cbTableName.Size = new System.Drawing.Size(238, 24);
            this.cbTableName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Trạng thái";
            // 
            // txtTenTable
            // 
            this.txtTenTable.Location = new System.Drawing.Point(99, 77);
            this.txtTenTable.Name = "txtTenTable";
            this.txtTenTable.Size = new System.Drawing.Size(238, 22);
            this.txtTenTable.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên bàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // txtIDTable
            // 
            this.txtIDTable.Location = new System.Drawing.Point(99, 23);
            this.txtIDTable.Name = "txtIDTable";
            this.txtIDTable.Size = new System.Drawing.Size(238, 22);
            this.txtIDTable.TabIndex = 8;
            // 
            // btnXemTable
            // 
            this.btnXemTable.Location = new System.Drawing.Point(307, 24);
            this.btnXemTable.Name = "btnXemTable";
            this.btnXemTable.Size = new System.Drawing.Size(73, 58);
            this.btnXemTable.TabIndex = 20;
            this.btnXemTable.Text = "Xem";
            this.btnXemTable.UseVisualStyleBackColor = true;
            // 
            // btnSuaTable
            // 
            this.btnSuaTable.Location = new System.Drawing.Point(217, 24);
            this.btnSuaTable.Name = "btnSuaTable";
            this.btnSuaTable.Size = new System.Drawing.Size(65, 58);
            this.btnSuaTable.TabIndex = 19;
            this.btnSuaTable.Text = "Sửa";
            this.btnSuaTable.UseVisualStyleBackColor = true;
            // 
            // btnXoaTable
            // 
            this.btnXoaTable.Location = new System.Drawing.Point(126, 24);
            this.btnXoaTable.Name = "btnXoaTable";
            this.btnXoaTable.Size = new System.Drawing.Size(72, 58);
            this.btnXoaTable.TabIndex = 18;
            this.btnXoaTable.Text = "Xóa";
            this.btnXoaTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(31, 24);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(77, 58);
            this.btnAddTable.TabIndex = 17;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Location = new System.Drawing.Point(17, 108);
            this.dgTable.Name = "dgTable";
            this.dgTable.ReadOnly = true;
            this.dgTable.RowHeadersWidth = 51;
            this.dgTable.RowTemplate.Height = 24;
            this.dgTable.Size = new System.Drawing.Size(363, 425);
            this.dgTable.TabIndex = 16;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbTaiKhoan.Controls.Add(this.panel4);
            this.tbTaiKhoan.Controls.Add(this.btnXemTaiKhoan);
            this.tbTaiKhoan.Controls.Add(this.btnSuaTaiKhoan);
            this.tbTaiKhoan.Controls.Add(this.btnXoaTaiKhoan);
            this.tbTaiKhoan.Controls.Add(this.btnAddTaiKhoan);
            this.tbTaiKhoan.Controls.Add(this.dgTaiKhoan);
            this.tbTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tbTaiKhoan.Size = new System.Drawing.Size(796, 556);
            this.tbTaiKhoan.TabIndex = 5;
            this.tbTaiKhoan.Text = "Tài khoản";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDatLaiMK);
            this.panel4.Controls.Add(this.cbLoaiTaiKhoan);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtTenHienThi);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtTenTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(424, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 422);
            this.panel4.TabIndex = 27;
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.Location = new System.Drawing.Point(221, 175);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(104, 58);
            this.btnDatLaiMK.TabIndex = 27;
            this.btnDatLaiMK.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMK.UseVisualStyleBackColor = true;
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(136, 130);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(213, 24);
            this.cbLoaiTaiKhoan.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Loại tài khoản";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(136, 77);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(213, 22);
            this.txtTenHienThi.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên hiển thị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(136, 23);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(213, 22);
            this.txtTenTaiKhoan.TabIndex = 8;
            // 
            // btnXemTaiKhoan
            // 
            this.btnXemTaiKhoan.Location = new System.Drawing.Point(308, 24);
            this.btnXemTaiKhoan.Name = "btnXemTaiKhoan";
            this.btnXemTaiKhoan.Size = new System.Drawing.Size(73, 58);
            this.btnXemTaiKhoan.TabIndex = 26;
            this.btnXemTaiKhoan.Text = "Xem";
            this.btnXemTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(218, 24);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(65, 58);
            this.btnSuaTaiKhoan.TabIndex = 25;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(127, 24);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(72, 58);
            this.btnXoaTaiKhoan.TabIndex = 24;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnAddTaiKhoan
            // 
            this.btnAddTaiKhoan.Location = new System.Drawing.Point(32, 24);
            this.btnAddTaiKhoan.Name = "btnAddTaiKhoan";
            this.btnAddTaiKhoan.Size = new System.Drawing.Size(77, 58);
            this.btnAddTaiKhoan.TabIndex = 23;
            this.btnAddTaiKhoan.Text = "Thêm";
            this.btnAddTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dgTaiKhoan
            // 
            this.dgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaiKhoan.Location = new System.Drawing.Point(18, 108);
            this.dgTaiKhoan.Name = "dgTaiKhoan";
            this.dgTaiKhoan.ReadOnly = true;
            this.dgTaiKhoan.RowHeadersWidth = 51;
            this.dgTaiKhoan.RowTemplate.Height = 24;
            this.dgTaiKhoan.Size = new System.Drawing.Size(400, 425);
            this.dgTaiKhoan.TabIndex = 22;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(839, 606);
            this.Controls.Add(this.tpAdmin);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tpAdmin.ResumeLayout(false);
            this.tbBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.tbThucAn.ResumeLayout(false);
            this.tbThucAn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgThucAn)).EndInit();
            this.tpDanhMuc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.tbBanAn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.tbTaiKhoan.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpAdmin;
        private System.Windows.Forms.TabPage tbBill;
        private System.Windows.Forms.TabPage tbThucAn;
        private System.Windows.Forms.TabPage tpDanhMuc;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker DateBill2;
        private System.Windows.Forms.DateTimePicker dateBill1;
        private System.Windows.Forms.Button btnXemThucAn;
        private System.Windows.Forms.Button btnSuaThucAn;
        private System.Windows.Forms.Button btnDeleteThucAn;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DataGridView dgThucAn;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown nbGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDDanhMuc;
        private System.Windows.Forms.Button btnXemDanhMuc;
        private System.Windows.Forms.Button btnSuaDanhMuc;
        private System.Windows.Forms.Button btnXoaDanhMuc;
        private System.Windows.Forms.Button btnAddDanhMuc;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.TabPage tbBanAn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDTable;
        private System.Windows.Forms.Button btnXemTable;
        private System.Windows.Forms.Button btnSuaTable;
        private System.Windows.Forms.Button btnXoaTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTableName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTable;
        private System.Windows.Forms.TabPage tbTaiKhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDatLaiMK;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Button btnXemTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnAddTaiKhoan;
        private System.Windows.Forms.DataGridView dgTaiKhoan;
    }
}