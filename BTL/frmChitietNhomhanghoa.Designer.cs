namespace BTL
{
    partial class frmChitietNhomhanghoa
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
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoNhomHangHoa = new System.Windows.Forms.Label();
            this.dgvNhomHang = new System.Windows.Forms.DataGridView();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).BeginInit();
            this.gbxThongtin.SuspendLayout();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 31);
            this.label1.TabIndex = 95;
            this.label1.Text = "Danh Mục Nhóm Hàng Hóa";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoNhomHangHoa);
            this.gbxChitiet.Controls.Add(this.dgvNhomHang);
            this.gbxChitiet.Location = new System.Drawing.Point(492, 68);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(564, 324);
            this.gbxChitiet.TabIndex = 94;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách nhóm hàng hóa";
            // 
            // lblIntoNhomHangHoa
            // 
            this.lblIntoNhomHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoNhomHangHoa.AutoSize = true;
            this.lblIntoNhomHangHoa.ForeColor = System.Drawing.Color.Red;
            this.lblIntoNhomHangHoa.Location = new System.Drawing.Point(537, 5);
            this.lblIntoNhomHangHoa.Name = "lblIntoNhomHangHoa";
            this.lblIntoNhomHangHoa.Size = new System.Drawing.Size(20, 18);
            this.lblIntoNhomHangHoa.TabIndex = 102;
            this.lblIntoNhomHangHoa.Text = "...";
            this.lblIntoNhomHangHoa.Click += new System.EventHandler(this.lblIntoNhomHangHoa_Click);
            // 
            // dgvNhomHang
            // 
            this.dgvNhomHang.AllowUserToDeleteRows = false;
            this.dgvNhomHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhomHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHang.Location = new System.Drawing.Point(9, 26);
            this.dgvNhomHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhomHang.Name = "dgvNhomHang";
            this.dgvNhomHang.ReadOnly = true;
            this.dgvNhomHang.RowHeadersWidth = 51;
            this.dgvNhomHang.Size = new System.Drawing.Size(546, 289);
            this.dgvNhomHang.TabIndex = 0;
            this.dgvNhomHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHang_CellClick);
            this.dgvNhomHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHang_CellDoubleClick);
            this.dgvNhomHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhomHang_CellFormatting);
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.btnCreateCode);
            this.gbxThongtin.Controls.Add(this.txtTenNhom);
            this.gbxThongtin.Controls.Add(this.txtMaNhom);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Location = new System.Drawing.Point(18, 68);
            this.gbxThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Size = new System.Drawing.Size(465, 324);
            this.gbxThongtin.TabIndex = 96;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin chi tiết";
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCode.Image = global::BTL.Properties.Resources.add1;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCode.Location = new System.Drawing.Point(148, 135);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(302, 47);
            this.btnCreateCode.TabIndex = 98;
            this.btnCreateCode.Text = "Thêm Mã";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(148, 84);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(300, 24);
            this.txtTenNhom.TabIndex = 84;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(148, 38);
            this.txtMaNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(300, 24);
            this.txtMaNhom.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Tên nhóm";
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
            this.gbxChucnang.Location = new System.Drawing.Point(102, 400);
            this.gbxChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Size = new System.Drawing.Size(873, 101);
            this.gbxChucnang.TabIndex = 97;
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
            // frmChitietNhomhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1074, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.gbxChucnang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietNhomhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm hàng hóa";
            this.Load += new System.EventHandler(this.frmChitietNhomhanghoa_Load);
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHang)).EndInit();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbxChitiet;
        public System.Windows.Forms.DataGridView dgvNhomHang;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblIntoNhomHangHoa;
    }
}