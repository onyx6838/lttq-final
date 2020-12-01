namespace BTL
{
    partial class frmBanhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanhang));
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.cbxMaKH = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxChitietHD = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cbxMaHang = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.gbxThongtin.SuspendLayout();
            this.gbxChitietHD.SuspendLayout();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.cbxMaKH);
            this.gbxThongtin.Controls.Add(this.cbxMaNV);
            this.gbxThongtin.Controls.Add(this.dtpNgayBan);
            this.gbxThongtin.Controls.Add(this.txtSoHDB);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Controls.Add(this.label3);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.label1);
            this.gbxThongtin.Location = new System.Drawing.Point(15, 17);
            this.gbxThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Size = new System.Drawing.Size(586, 227);
            this.gbxThongtin.TabIndex = 0;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin hóa đơn bán";
            // 
            // cbxMaKH
            // 
            this.cbxMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaKH.FormattingEnabled = true;
            this.cbxMaKH.Location = new System.Drawing.Point(156, 186);
            this.cbxMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaKH.Name = "cbxMaKH";
            this.cbxMaKH.Size = new System.Drawing.Size(259, 26);
            this.cbxMaKH.TabIndex = 10;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(156, 80);
            this.cbxMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(259, 26);
            this.cbxMaNV.TabIndex = 9;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dddd  dd/MM/yyyy    -    hh:mm tt";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(156, 130);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(360, 24);
            this.dtpNgayBan.TabIndex = 7;
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Enabled = false;
            this.txtSoHDB.Location = new System.Drawing.Point(156, 28);
            this.txtSoHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(259, 24);
            this.txtSoHDB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // gbxChitietHD
            // 
            this.gbxChitietHD.Controls.Add(this.btnIn);
            this.gbxChitietHD.Controls.Add(this.btnThemHD);
            this.gbxChitietHD.Controls.Add(this.cbxMaHang);
            this.gbxChitietHD.Controls.Add(this.txtSoLuong);
            this.gbxChitietHD.Controls.Add(this.txtGiamGia);
            this.gbxChitietHD.Controls.Add(this.txtThanhTien);
            this.gbxChitietHD.Controls.Add(this.label8);
            this.gbxChitietHD.Controls.Add(this.label7);
            this.gbxChitietHD.Controls.Add(this.label5);
            this.gbxChitietHD.Controls.Add(this.label9);
            this.gbxChitietHD.Location = new System.Drawing.Point(611, 17);
            this.gbxChitietHD.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitietHD.Name = "gbxChitietHD";
            this.gbxChitietHD.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitietHD.Size = new System.Drawing.Size(572, 227);
            this.gbxChitietHD.TabIndex = 1;
            this.gbxChitietHD.TabStop = false;
            this.gbxChitietHD.Text = "Chi tiết";
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(411, 98);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(150, 60);
            this.btnIn.TabIndex = 58;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.Image = global::BTL.Properties.Resources.add1;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(411, 20);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(150, 60);
            this.btnThemHD.TabIndex = 57;
            this.btnThemHD.Text = "Thêm HD";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cbxMaHang
            // 
            this.cbxMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaHang.FormattingEnabled = true;
            this.cbxMaHang.Location = new System.Drawing.Point(143, 20);
            this.cbxMaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaHang.Name = "cbxMaHang";
            this.cbxMaHang.Size = new System.Drawing.Size(257, 26);
            this.cbxMaHang.TabIndex = 19;
            this.cbxMaHang.SelectedIndexChanged += new System.EventHandler(this.cbxMaHang_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(143, 79);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(259, 24);
            this.txtSoLuong.TabIndex = 18;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(143, 132);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(259, 24);
            this.txtGiamGia.TabIndex = 17;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(143, 188);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(259, 24);
            this.txtThanhTien.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã vạch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(754, 263);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(258, 24);
            this.txtDonGia.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn giá";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Controls.Add(this.dgvHDB);
            this.gbxChitiet.Location = new System.Drawing.Point(15, 307);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(1167, 352);
            this.gbxChitiet.TabIndex = 2;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Giỏ hàng";
            // 
            // dgvHDB
            // 
            this.dgvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Location = new System.Drawing.Point(9, 26);
            this.dgvHDB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 51;
            this.dgvHDB.Size = new System.Drawing.Size(1149, 317);
            this.dgvHDB.TabIndex = 0;
            this.dgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.intoCTHDB);
            this.dgvHDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backHDB);
            this.dgvHDB.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHDB_CellFormatting);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tên mặt hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(507, 717);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Bằng chữ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(620, 673);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(726, 668);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(259, 24);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BTL.Properties.Resources.budgeting;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(996, 668);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(177, 73);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Xác Nhận";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Image = global::BTL.Properties.Resources.carts1;
            this.btnThemVaoGio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoGio.Location = new System.Drawing.Point(24, 668);
            this.btnThemVaoGio.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(152, 73);
            this.btnThemVaoGio.TabIndex = 18;
            this.btnThemVaoGio.Text = "Thêm\r\nvào giỏ";
            this.btnThemVaoGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(354, 668);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 72);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.eraser1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(195, 668);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 72);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(171, 266);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(360, 24);
            this.txtTenHang.TabIndex = 11;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(591, 719);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(0, 18);
            this.lblTongTien.TabIndex = 57;
            // 
            // frmBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.gbxChitietHD);
            this.Controls.Add(this.gbxThongtin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.frmBanhang_Load);
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.gbxChitietHD.ResumeLayout(false);
            this.gbxChitietHD.PerformLayout();
            this.gbxChitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxChitietHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbxMaHang;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox cbxMaKH;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblTongTien;
    }
}