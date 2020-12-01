namespace BTL
{
    partial class frmChitietNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitietNhanvien));
            this.label1 = new System.Windows.Forms.Label();
            this.gbxNhanvien = new System.Windows.Forms.GroupBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.cbxCV = new System.Windows.Forms.ComboBox();
            this.cbxCa = new System.Windows.Forms.ComboBox();
            this.cbxNhom = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdxFemale = new System.Windows.Forms.RadioButton();
            this.rdxMale = new System.Windows.Forms.RadioButton();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoNV = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbxNhanvien.SuspendLayout();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Nhân Viên";
            // 
            // gbxNhanvien
            // 
            this.gbxNhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxNhanvien.Controls.Add(this.btnCreateCode);
            this.gbxNhanvien.Controls.Add(this.mtbDienThoai);
            this.gbxNhanvien.Controls.Add(this.cbxCV);
            this.gbxNhanvien.Controls.Add(this.cbxCa);
            this.gbxNhanvien.Controls.Add(this.cbxNhom);
            this.gbxNhanvien.Controls.Add(this.dtpNgaySinh);
            this.gbxNhanvien.Controls.Add(this.rdxFemale);
            this.gbxNhanvien.Controls.Add(this.rdxMale);
            this.gbxNhanvien.Controls.Add(this.txtTenNhanVien);
            this.gbxNhanvien.Controls.Add(this.txtDiaChi);
            this.gbxNhanvien.Controls.Add(this.txtMaNhanVien);
            this.gbxNhanvien.Controls.Add(this.label10);
            this.gbxNhanvien.Controls.Add(this.label6);
            this.gbxNhanvien.Controls.Add(this.label7);
            this.gbxNhanvien.Controls.Add(this.label8);
            this.gbxNhanvien.Controls.Add(this.label9);
            this.gbxNhanvien.Controls.Add(this.label5);
            this.gbxNhanvien.Controls.Add(this.label4);
            this.gbxNhanvien.Controls.Add(this.label3);
            this.gbxNhanvien.Controls.Add(this.label2);
            this.gbxNhanvien.Location = new System.Drawing.Point(18, 62);
            this.gbxNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.gbxNhanvien.Name = "gbxNhanvien";
            this.gbxNhanvien.Padding = new System.Windows.Forms.Padding(4);
            this.gbxNhanvien.Size = new System.Drawing.Size(1009, 215);
            this.gbxNhanvien.TabIndex = 1;
            this.gbxNhanvien.TabStop = false;
            this.gbxNhanvien.Text = "Thông tin nhân viên";
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCode.Image = global::BTL.Properties.Resources.add1;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCode.Location = new System.Drawing.Point(696, 163);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(303, 47);
            this.btnCreateCode.TabIndex = 89;
            this.btnCreateCode.Text = "Thêm Mã";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(158, 171);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(302, 24);
            this.mtbDienThoai.TabIndex = 19;
            // 
            // cbxCV
            // 
            this.cbxCV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCV.FormattingEnabled = true;
            this.cbxCV.Location = new System.Drawing.Point(696, 130);
            this.cbxCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCV.Name = "cbxCV";
            this.cbxCV.Size = new System.Drawing.Size(302, 26);
            this.cbxCV.TabIndex = 18;
            // 
            // cbxCa
            // 
            this.cbxCa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCa.FormattingEnabled = true;
            this.cbxCa.Location = new System.Drawing.Point(696, 93);
            this.cbxCa.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCa.Name = "cbxCa";
            this.cbxCa.Size = new System.Drawing.Size(302, 26);
            this.cbxCa.TabIndex = 17;
            // 
            // cbxNhom
            // 
            this.cbxNhom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNhom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNhom.FormattingEnabled = true;
            this.cbxNhom.Location = new System.Drawing.Point(696, 56);
            this.cbxNhom.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhom.Name = "cbxNhom";
            this.cbxNhom.Size = new System.Drawing.Size(302, 26);
            this.cbxNhom.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(696, 18);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(163, 24);
            this.dtpNgaySinh.TabIndex = 15;
            this.dtpNgaySinh.Value = new System.DateTime(2020, 10, 23, 22, 14, 50, 0);
            // 
            // rdxFemale
            // 
            this.rdxFemale.AutoSize = true;
            this.rdxFemale.Location = new System.Drawing.Point(328, 98);
            this.rdxFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdxFemale.Name = "rdxFemale";
            this.rdxFemale.Size = new System.Drawing.Size(48, 22);
            this.rdxFemale.TabIndex = 14;
            this.rdxFemale.TabStop = true;
            this.rdxFemale.Text = "Nữ";
            this.rdxFemale.UseVisualStyleBackColor = true;
            // 
            // rdxMale
            // 
            this.rdxMale.AutoSize = true;
            this.rdxMale.Location = new System.Drawing.Point(158, 98);
            this.rdxMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdxMale.Name = "rdxMale";
            this.rdxMale.Size = new System.Drawing.Size(61, 22);
            this.rdxMale.TabIndex = 13;
            this.rdxMale.TabStop = true;
            this.rdxMale.Text = "Nam";
            this.rdxMale.UseVisualStyleBackColor = true;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(158, 60);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(302, 24);
            this.txtTenNhanVien.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(158, 138);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(302, 24);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(158, 24);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(302, 24);
            this.txtMaNhanVien.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Công Việc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ca Làm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhóm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoNV);
            this.gbxChitiet.Controls.Add(this.dgvNhanVien);
            this.gbxChitiet.Location = new System.Drawing.Point(18, 286);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(1009, 362);
            this.gbxChitiet.TabIndex = 2;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách nhân viên";
            // 
            // lblIntoNV
            // 
            this.lblIntoNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoNV.AutoSize = true;
            this.lblIntoNV.ForeColor = System.Drawing.Color.Red;
            this.lblIntoNV.Location = new System.Drawing.Point(982, 6);
            this.lblIntoNV.Name = "lblIntoNV";
            this.lblIntoNV.Size = new System.Drawing.Size(20, 18);
            this.lblIntoNV.TabIndex = 101;
            this.lblIntoNV.Text = "...";
            this.lblIntoNV.Click += new System.EventHandler(this.lblIntoNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(9, 26);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(991, 328);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellDoubleClick);
            this.dgvNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhanVien_CellFormatting);
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
            this.gbxChucnang.Location = new System.Drawing.Point(89, 659);
            this.gbxChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Size = new System.Drawing.Size(873, 101);
            this.gbxChucnang.TabIndex = 94;
            this.gbxChucnang.TabStop = false;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(753, 17);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(109, 79);
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
            this.btnXoa.Location = new System.Drawing.Point(505, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 79);
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
            this.btnThem.Location = new System.Drawing.Point(9, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 79);
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
            this.btnSua.Location = new System.Drawing.Point(256, 17);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 79);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmChitietNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1045, 776);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.gbxNhanvien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmChitietNhanvien_Load);
            this.gbxNhanvien.ResumeLayout(false);
            this.gbxNhanvien.PerformLayout();
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxNhanvien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdxFemale;
        private System.Windows.Forms.RadioButton rdxMale;
        private System.Windows.Forms.ComboBox cbxCV;
        private System.Windows.Forms.ComboBox cbxCa;
        private System.Windows.Forms.ComboBox cbxNhom;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        public System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblIntoNV;
    }
}