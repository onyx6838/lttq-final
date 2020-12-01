namespace BTL
{
    partial class frmChitietHDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cbxMaKH = new System.Windows.Forms.ComboBox();
            this.cbxMaNV = new System.Windows.Forms.ComboBox();
            this.txtSoHDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoHDB = new System.Windows.Forms.Label();
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.cbxMaKH);
            this.groupBox1.Controls.Add(this.cbxMaNV);
            this.groupBox1.Controls.Add(this.txtSoHDB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(136, 234);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(235, 24);
            this.dtpNgayBan.TabIndex = 10;
            // 
            // cbxMaKH
            // 
            this.cbxMaKH.FormattingEnabled = true;
            this.cbxMaKH.Location = new System.Drawing.Point(136, 324);
            this.cbxMaKH.Name = "cbxMaKH";
            this.cbxMaKH.Size = new System.Drawing.Size(235, 26);
            this.cbxMaKH.TabIndex = 9;
            // 
            // cbxMaNV
            // 
            this.cbxMaNV.FormattingEnabled = true;
            this.cbxMaNV.Location = new System.Drawing.Point(136, 124);
            this.cbxMaNV.Name = "cbxMaNV";
            this.cbxMaNV.Size = new System.Drawing.Size(235, 26);
            this.cbxMaNV.TabIndex = 8;
            // 
            // txtSoHDB
            // 
            this.txtSoHDB.Location = new System.Drawing.Point(136, 28);
            this.txtSoHDB.Name = "txtSoHDB";
            this.txtSoHDB.Size = new System.Drawing.Size(240, 24);
            this.txtSoHDB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Mục Hóa Đơn Bán";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoHDB);
            this.gbxChitiet.Controls.Add(this.dgvHDB);
            this.gbxChitiet.Location = new System.Drawing.Point(408, 40);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Size = new System.Drawing.Size(745, 509);
            this.gbxChitiet.TabIndex = 3;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách hóa đơn bán";
            // 
            // lblIntoHDB
            // 
            this.lblIntoHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoHDB.AutoSize = true;
            this.lblIntoHDB.ForeColor = System.Drawing.Color.Red;
            this.lblIntoHDB.Location = new System.Drawing.Point(716, 10);
            this.lblIntoHDB.Name = "lblIntoHDB";
            this.lblIntoHDB.Size = new System.Drawing.Size(20, 18);
            this.lblIntoHDB.TabIndex = 50;
            this.lblIntoHDB.Text = "...";
            this.lblIntoHDB.Click += new System.EventHandler(this.lblIntoHDB_Click);
            // 
            // dgvHDB
            // 
            this.dgvHDB.AllowUserToDeleteRows = false;
            this.dgvHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDB.Location = new System.Drawing.Point(7, 31);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.ReadOnly = true;
            this.dgvHDB.RowHeadersWidth = 51;
            this.dgvHDB.Size = new System.Drawing.Size(731, 472);
            this.dgvHDB.TabIndex = 0;
            this.dgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellClick);
            this.dgvHDB.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellDoubleClick);
            this.dgvHDB.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHDB_CellFormatting);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(93, 480);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(285, 24);
            this.txtTongTien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Bằng chữ";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.eraser1;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(223, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 50);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::BTL.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(15, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 52);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Lưu";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.delete1;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(421, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 49);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.printer1;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(621, 13);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(99, 52);
            this.btnIn.TabIndex = 55;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.gbxChucnang.Location = new System.Drawing.Point(414, 550);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Size = new System.Drawing.Size(737, 75);
            this.gbxChucnang.TabIndex = 48;
            this.gbxChucnang.TabStop = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(92, 522);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(70, 18);
            this.lblTongTien.TabIndex = 49;
            this.lblTongTien.Text = "Bằng chữ";
            // 
            // frmChitietHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1160, 628);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChitietHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmChitietHDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoHDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMaKH;
        private System.Windows.Forms.ComboBox cbxMaNV;
        public System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblIntoHDB;
    }
}