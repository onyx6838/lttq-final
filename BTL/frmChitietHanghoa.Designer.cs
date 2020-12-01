namespace BTL
{
    partial class frmChitietHanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietHanghoa));
            this.label1 = new System.Windows.Forms.Label();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoHangHoa = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapKhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNhomHang = new System.Windows.Forms.ComboBox();
            this.cbxTheLoai = new System.Windows.Forms.ComboBox();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.cbxChatLieu = new System.Windows.Forms.ComboBox();
            this.cbxCongDung = new System.Windows.Forms.ComboBox();
            this.cbxNoiSX = new System.Windows.Forms.ComboBox();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtImageSource = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.gbxThongtin.SuspendLayout();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Hàng Hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoHangHoa);
            this.gbxChitiet.Controls.Add(this.dgvHangHoa);
            this.gbxChitiet.Location = new System.Drawing.Point(676, 47);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(652, 511);
            this.gbxChitiet.TabIndex = 37;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Dach sách sản phẩm";
            // 
            // lblIntoHangHoa
            // 
            this.lblIntoHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoHangHoa.AutoSize = true;
            this.lblIntoHangHoa.ForeColor = System.Drawing.Color.Red;
            this.lblIntoHangHoa.Location = new System.Drawing.Point(627, 3);
            this.lblIntoHangHoa.Name = "lblIntoHangHoa";
            this.lblIntoHangHoa.Size = new System.Drawing.Size(20, 17);
            this.lblIntoHangHoa.TabIndex = 98;
            this.lblIntoHangHoa.Text = "...";
            this.lblIntoHangHoa.Click += new System.EventHandler(this.lblIntoHangHoa_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(8, 23);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.Size = new System.Drawing.Size(636, 480);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            this.dgvHangHoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellDoubleClick);
            this.dgvHangHoa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHangHoa_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã vạch";
            // 
            // txtMaVach
            // 
            this.txtMaVach.Location = new System.Drawing.Point(123, 16);
            this.txtMaVach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVach.Name = "txtMaVach";
            this.txtMaVach.Size = new System.Drawing.Size(201, 22);
            this.txtMaVach.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tên hàng hóa";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(123, 57);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(201, 22);
            this.txtTenHangHoa.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nhóm Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Thể Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nhập khẩu";
            // 
            // txtNhapKhau
            // 
            this.txtNhapKhau.Location = new System.Drawing.Point(123, 384);
            this.txtNhapKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapKhau.Name = "txtNhapKhau";
            this.txtNhapKhau.Size = new System.Drawing.Size(201, 22);
            this.txtNhapKhau.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Đơn Vị";
            // 
            // cbxNhomHang
            // 
            this.cbxNhomHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNhomHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNhomHang.FormattingEnabled = true;
            this.cbxNhomHang.Location = new System.Drawing.Point(123, 97);
            this.cbxNhomHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhomHang.Name = "cbxNhomHang";
            this.cbxNhomHang.Size = new System.Drawing.Size(201, 24);
            this.cbxNhomHang.TabIndex = 55;
            // 
            // cbxTheLoai
            // 
            this.cbxTheLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTheLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTheLoai.FormattingEnabled = true;
            this.cbxTheLoai.Location = new System.Drawing.Point(123, 139);
            this.cbxTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTheLoai.Name = "cbxTheLoai";
            this.cbxTheLoai.Size = new System.Drawing.Size(201, 24);
            this.cbxTheLoai.TabIndex = 56;
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDonVi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Location = new System.Drawing.Point(123, 301);
            this.cbxDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(201, 24);
            this.cbxDonVi.TabIndex = 57;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::BTL.Properties.Resources.open;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(370, 16);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 42);
            this.btnOpen.TabIndex = 87;
            this.btnOpen.Text = "Mở";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(371, 90);
            this.picAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(264, 253);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 88;
            this.picAnh.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Chất Liệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 435);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 92;
            this.label9.Text = "Công Dụng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 477);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 93;
            this.label10.Text = "Nơi Sản Xuất";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 94;
            this.label11.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 181);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(201, 22);
            this.txtSoLuong.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 17);
            this.label12.TabIndex = 96;
            this.label12.Text = "Đơn giá nhập";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(123, 219);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(201, 22);
            this.txtDonGiaNhap.TabIndex = 97;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 263);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 98;
            this.label13.Text = "Đơn giá bán";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Enabled = false;
            this.txtDonGiaBan.Location = new System.Drawing.Point(123, 259);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(201, 22);
            this.txtDonGiaBan.TabIndex = 99;
            // 
            // cbxChatLieu
            // 
            this.cbxChatLieu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxChatLieu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxChatLieu.FormattingEnabled = true;
            this.cbxChatLieu.Location = new System.Drawing.Point(123, 342);
            this.cbxChatLieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChatLieu.Name = "cbxChatLieu";
            this.cbxChatLieu.Size = new System.Drawing.Size(201, 24);
            this.cbxChatLieu.TabIndex = 100;
            // 
            // cbxCongDung
            // 
            this.cbxCongDung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCongDung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCongDung.FormattingEnabled = true;
            this.cbxCongDung.Location = new System.Drawing.Point(123, 431);
            this.cbxCongDung.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCongDung.Name = "cbxCongDung";
            this.cbxCongDung.Size = new System.Drawing.Size(201, 24);
            this.cbxCongDung.TabIndex = 101;
            // 
            // cbxNoiSX
            // 
            this.cbxNoiSX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNoiSX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNoiSX.FormattingEnabled = true;
            this.cbxNoiSX.Location = new System.Drawing.Point(123, 473);
            this.cbxNoiSX.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNoiSX.Name = "cbxNoiSX";
            this.cbxNoiSX.Size = new System.Drawing.Size(201, 24);
            this.cbxNoiSX.TabIndex = 102;
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.cbxNoiSX);
            this.gbxThongtin.Controls.Add(this.cbxCongDung);
            this.gbxThongtin.Controls.Add(this.cbxChatLieu);
            this.gbxThongtin.Controls.Add(this.txtDonGiaBan);
            this.gbxThongtin.Controls.Add(this.txtNhapKhau);
            this.gbxThongtin.Controls.Add(this.label6);
            this.gbxThongtin.Controls.Add(this.txtSoLuong);
            this.gbxThongtin.Controls.Add(this.label11);
            this.gbxThongtin.Controls.Add(this.label12);
            this.gbxThongtin.Controls.Add(this.label13);
            this.gbxThongtin.Controls.Add(this.label10);
            this.gbxThongtin.Controls.Add(this.txtDonGiaNhap);
            this.gbxThongtin.Controls.Add(this.label9);
            this.gbxThongtin.Controls.Add(this.label8);
            this.gbxThongtin.Controls.Add(this.txtGhiChu);
            this.gbxThongtin.Controls.Add(this.label15);
            this.gbxThongtin.Controls.Add(this.picAnh);
            this.gbxThongtin.Controls.Add(this.btnOpen);
            this.gbxThongtin.Controls.Add(this.txtImageSource);
            this.gbxThongtin.Controls.Add(this.label14);
            this.gbxThongtin.Controls.Add(this.cbxDonVi);
            this.gbxThongtin.Controls.Add(this.cbxTheLoai);
            this.gbxThongtin.Controls.Add(this.cbxNhomHang);
            this.gbxThongtin.Controls.Add(this.label7);
            this.gbxThongtin.Controls.Add(this.label5);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Controls.Add(this.txtTenHangHoa);
            this.gbxThongtin.Controls.Add(this.label3);
            this.gbxThongtin.Controls.Add(this.txtMaVach);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Location = new System.Drawing.Point(20, 47);
            this.gbxThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Size = new System.Drawing.Size(648, 511);
            this.gbxThongtin.TabIndex = 40;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin sản phẩm";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(371, 368);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(264, 121);
            this.txtGhiChu.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 347);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 89;
            this.label15.Text = "Ghi chú";
            // 
            // txtImageSource
            // 
            this.txtImageSource.Enabled = false;
            this.txtImageSource.Location = new System.Drawing.Point(456, 16);
            this.txtImageSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtImageSource.Multiline = true;
            this.txtImageSource.Name = "txtImageSource";
            this.txtImageSource.Size = new System.Drawing.Size(179, 26);
            this.txtImageSource.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 85;
            this.label14.Text = "Ảnh";
            // 
            // gbxChucnang
            // 
            this.gbxChucnang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChucnang.Controls.Add(this.btnIn);
            this.gbxChucnang.Controls.Add(this.btnXoa);
            this.gbxChucnang.Controls.Add(this.btnThem);
            this.gbxChucnang.Controls.Add(this.btnSua);
            this.gbxChucnang.Location = new System.Drawing.Point(299, 565);
            this.gbxChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Size = new System.Drawing.Size(776, 90);
            this.gbxChucnang.TabIndex = 62;
            this.gbxChucnang.TabStop = false;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(669, 15);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(97, 70);
            this.btnIn.TabIndex = 55;
            this.btnIn.Text = "Xuất \r\nfile \r\nexcel";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(449, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 70);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::BTL.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(8, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 70);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.eraser1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(228, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 70);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCode.Image = global::BTL.Properties.Resources.add1;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCode.Location = new System.Drawing.Point(13, 580);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(260, 42);
            this.btnCreateCode.TabIndex = 87;
            this.btnCreateCode.Text = "Thêm Mã";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // frmChitietHanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1344, 657);
            this.Controls.Add(this.btnCreateCode);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietHanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết các mặt hàng";
            this.Load += new System.EventHandler(this.frmChitietHanghoa_Load);
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbxChitiet;
        public System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaVach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapKhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxNhomHang;
        private System.Windows.Forms.ComboBox cbxTheLoai;
        private System.Windows.Forms.ComboBox cbxDonVi;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.ComboBox cbxChatLieu;
        private System.Windows.Forms.ComboBox cbxCongDung;
        private System.Windows.Forms.ComboBox cbxNoiSX;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtImageSource;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblIntoHangHoa;
    }
}