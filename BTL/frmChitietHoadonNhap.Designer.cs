namespace BTL.Properties
{
    partial class frmChitietHDN
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
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbxMaNCC = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoHDN = new System.Windows.Forms.Label();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTienChu = new System.Windows.Forms.Label();
            this.gbxChucnang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(650, 15);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(88, 60);
            this.btnIn.TabIndex = 55;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(430, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 60);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.eraser1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(214, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 60);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.gbxChucnang.Location = new System.Drawing.Point(397, 540);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Size = new System.Drawing.Size(745, 75);
            this.gbxChucnang.TabIndex = 60;
            this.gbxChucnang.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::BTL.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(17, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 60);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Lưu";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 54;
            this.label11.Text = "Bằng chữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tổng tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.cbxMaNCC);
            this.groupBox1.Controls.Add(this.cbxMaNV);
            this.groupBox1.Controls.Add(this.txtSoHDN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 377);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(115, 221);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(262, 24);
            this.dtpNgayNhap.TabIndex = 10;
            // 
            // cbxMaNCC
            // 
            this.cbxMaNCC.FormattingEnabled = true;
            this.cbxMaNCC.Location = new System.Drawing.Point(111, 312);
            this.cbxMaNCC.Name = "cbxMaNCC";
            this.cbxMaNCC.Size = new System.Drawing.Size(262, 26);
            this.cbxMaNCC.TabIndex = 9;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(111, 116);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(262, 26);
            this.cbxMaNV.TabIndex = 8;
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(111, 25);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(262, 24);
            this.txtSoHDN.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã NCC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(123, 484);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(262, 24);
            this.txtTongTien.TabIndex = 53;
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoHDN);
            this.gbxChitiet.Controls.Add(this.dgvHDN);
            this.gbxChitiet.Location = new System.Drawing.Point(407, 38);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Size = new System.Drawing.Size(745, 509);
            this.gbxChitiet.TabIndex = 51;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách hóa đơn nhập";
            // 
            // lblIntoHDN
            // 
            this.lblIntoHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoHDN.AutoSize = true;
            this.lblIntoHDN.ForeColor = System.Drawing.Color.Red;
            this.lblIntoHDN.Location = new System.Drawing.Point(709, 12);
            this.lblIntoHDN.Name = "lblIntoHDN";
            this.lblIntoHDN.Size = new System.Drawing.Size(24, 18);
            this.lblIntoHDN.TabIndex = 51;
            this.lblIntoHDN.Text = "....";
            this.lblIntoHDN.Click += new System.EventHandler(this.lblIntoHDN_Click);
            // 
            // dgvHDN
            // 
            this.dgvHDN.AllowUserToDeleteRows = false;
            this.dgvHDN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDN.Location = new System.Drawing.Point(7, 30);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.ReadOnly = true;
            this.dgvHDN.RowHeadersWidth = 51;
            this.dgvHDN.Size = new System.Drawing.Size(731, 467);
            this.dgvHDN.TabIndex = 0;
            this.dgvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDN_CellClick);
            this.dgvHDN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDN_CellDoubleClick);
            this.dgvHDN.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHDN_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(768, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.TabIndex = 63;
            this.label1.Text = "Danh Mục Hóa Đơn Nhập";
            // 
            // lblTongTienChu
            // 
            this.lblTongTienChu.AutoSize = true;
            this.lblTongTienChu.Location = new System.Drawing.Point(94, 517);
            this.lblTongTienChu.Name = "lblTongTienChu";
            this.lblTongTienChu.Size = new System.Drawing.Size(0, 18);
            this.lblTongTienChu.TabIndex = 64;
            // 
            // frmChitietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1160, 628);
            this.Controls.Add(this.lblTongTienChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.gbxChitiet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChitietHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.frmChitietHDN_Load);
            this.gbxChucnang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxMaNCC;
        private System.Windows.Forms.ComboBox cbxMaNV;
        private System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        public System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblTongTienChu;
        private System.Windows.Forms.Label lblIntoHDN;
    }
}