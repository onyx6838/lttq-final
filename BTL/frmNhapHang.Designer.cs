namespace BTL
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemVaoKho = new System.Windows.Forms.Button();
            this.lblTongTienChu = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.cbxHang = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.cbxMaNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxChitiet.SuspendLayout();
            this.gbxThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHDN
            // 
            this.dgvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Location = new System.Drawing.Point(9, 26);
            this.dgvHDN.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowHeadersWidth = 51;
            this.dgvHDN.Size = new System.Drawing.Size(1149, 317);
            this.dgvHDN.TabIndex = 0;
            this.dgvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.backHDN);
            this.dgvHDN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.intoCTHDN);
            this.dgvHDN.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHDN_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHDN);
            this.groupBox1.Location = new System.Drawing.Point(17, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1167, 352);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Image = global::BTL.Properties.Resources.budgeting;
            this.btnTinhtien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinhtien.Location = new System.Drawing.Point(1007, 667);
            this.btnTinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(177, 73);
            this.btnTinhtien.TabIndex = 33;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(378, 669);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 72);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.eraser1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(225, 669);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 72);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemVaoKho
            // 
            this.btnThemVaoKho.Image = global::BTL.Properties.Resources.import1;
            this.btnThemVaoKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoKho.Location = new System.Drawing.Point(26, 669);
            this.btnThemVaoKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemVaoKho.Name = "btnThemVaoKho";
            this.btnThemVaoKho.Size = new System.Drawing.Size(177, 73);
            this.btnThemVaoKho.TabIndex = 61;
            this.btnThemVaoKho.Text = "Thêm Vào Kho";
            this.btnThemVaoKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoKho.UseVisualStyleBackColor = true;
            this.btnThemVaoKho.Click += new System.EventHandler(this.btnThemVaoKho_Click);
            // 
            // lblTongTienChu
            // 
            this.lblTongTienChu.AutoSize = true;
            this.lblTongTienChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTienChu.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTienChu.Location = new System.Drawing.Point(644, 711);
            this.lblTongTienChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTienChu.Name = "lblTongTienChu";
            this.lblTongTienChu.Size = new System.Drawing.Size(2, 20);
            this.lblTongTienChu.TabIndex = 68;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(703, 669);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(259, 24);
            this.txtTongTien.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(550, 711);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 66;
            this.label12.Text = "Bằng chữ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(613, 674);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 67;
            this.label13.Text = "Tổng tiền";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Controls.Add(this.cbxHang);
            this.gbxChitiet.Controls.Add(this.btnIn);
            this.gbxChitiet.Controls.Add(this.txtGiamGia);
            this.gbxChitiet.Controls.Add(this.btnThemHD);
            this.gbxChitiet.Controls.Add(this.txtDonGia);
            this.gbxChitiet.Controls.Add(this.txtThanhTien);
            this.gbxChitiet.Controls.Add(this.label8);
            this.gbxChitiet.Controls.Add(this.label7);
            this.gbxChitiet.Controls.Add(this.label6);
            this.gbxChitiet.Controls.Add(this.label5);
            this.gbxChitiet.Location = new System.Drawing.Point(616, 15);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(572, 227);
            this.gbxChitiet.TabIndex = 70;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Chi tiết";
            // 
            // cbxHang
            // 
            this.cbxHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxHang.FormattingEnabled = true;
            this.cbxHang.Location = new System.Drawing.Point(143, 18);
            this.cbxHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxHang.Name = "cbxHang";
            this.cbxHang.Size = new System.Drawing.Size(259, 26);
            this.cbxHang.TabIndex = 9;
            this.cbxHang.SelectedIndexChanged += new System.EventHandler(this.cbxHang_SelectedIndexChanged);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(413, 94);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(151, 60);
            this.btnIn.TabIndex = 62;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            // btnThemHD
            // 
            this.btnThemHD.Image = global::BTL.Properties.Resources.export;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(413, 18);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(151, 60);
            this.btnThemHD.TabIndex = 61;
            this.btnThemHD.Text = "Thêm HD";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(143, 74);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(259, 24);
            this.txtDonGia.TabIndex = 16;
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
            this.label8.Location = new System.Drawing.Point(25, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Thành tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giảm giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã vạch";
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.cbxMaNV);
            this.gbxThongtin.Controls.Add(this.cbxMaNCC);
            this.gbxThongtin.Controls.Add(this.dtpNgayNhap);
            this.gbxThongtin.Controls.Add(this.txtSoHDN);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Controls.Add(this.label3);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.label1);
            this.gbxThongtin.Location = new System.Drawing.Point(21, 15);
            this.gbxThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Size = new System.Drawing.Size(586, 227);
            this.gbxThongtin.TabIndex = 69;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin hóa nhập";
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(156, 80);
            this.cbxMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(259, 26);
            this.cbxMaNV.TabIndex = 9;
            // 
            // cbxMaNCC
            // 
            this.cbxMaNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaNCC.FormattingEnabled = true;
            this.cbxMaNCC.Location = new System.Drawing.Point(156, 190);
            this.cbxMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaNCC.Name = "cbxMaNCC";
            this.cbxMaNCC.Size = new System.Drawing.Size(259, 26);
            this.cbxMaNCC.TabIndex = 8;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dddd  dd/MM/yyyy    -    hh:mm tt";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(156, 130);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(360, 24);
            this.dtpNgayNhap.TabIndex = 7;
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Enabled = false;
            this.txtSoHDN.Location = new System.Drawing.Point(156, 24);
            this.txtSoHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(259, 24);
            this.txtSoHDN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
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
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(760, 261);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(259, 24);
            this.txtSoLuong.TabIndex = 66;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(179, 261);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(360, 24);
            this.txtTenHang.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tên mặt hàng";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1200, 757);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTongTienChu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemVaoKho);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemVaoKho;
        private System.Windows.Forms.Label lblTongTienChu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.ComboBox cbxHang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.ComboBox cbxMaNCC;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}