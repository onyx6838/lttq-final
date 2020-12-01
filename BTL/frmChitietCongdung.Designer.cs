namespace BTL
{
    partial class frmChitietCongdung
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
            this.grxChitiet = new System.Windows.Forms.GroupBox();
            this.lblIntoCongDung = new System.Windows.Forms.Label();
            this.dgvCongDung = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.txtTenCongDung = new System.Windows.Forms.TextBox();
            this.txtMaCongDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 80;
            this.label1.Text = "Danh Mục Công Dụng";
            // 
            // grxChitiet
            // 
            this.grxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grxChitiet.Controls.Add(this.lblIntoCongDung);
            this.grxChitiet.Controls.Add(this.dgvCongDung);
            this.grxChitiet.Location = new System.Drawing.Point(492, 66);
            this.grxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.grxChitiet.Name = "grxChitiet";
            this.grxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.grxChitiet.Size = new System.Drawing.Size(564, 324);
            this.grxChitiet.TabIndex = 74;
            this.grxChitiet.TabStop = false;
            this.grxChitiet.Text = "Danh sách công dụng hàng hóa";
            // 
            // lblIntoCongDung
            // 
            this.lblIntoCongDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoCongDung.AutoSize = true;
            this.lblIntoCongDung.ForeColor = System.Drawing.Color.Red;
            this.lblIntoCongDung.Location = new System.Drawing.Point(537, 6);
            this.lblIntoCongDung.Name = "lblIntoCongDung";
            this.lblIntoCongDung.Size = new System.Drawing.Size(20, 18);
            this.lblIntoCongDung.TabIndex = 95;
            this.lblIntoCongDung.Text = "...";
            this.lblIntoCongDung.Click += new System.EventHandler(this.lblIntoCongDung_Click);
            // 
            // dgvCongDung
            // 
            this.dgvCongDung.AllowUserToDeleteRows = false;
            this.dgvCongDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCongDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCongDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongDung.Location = new System.Drawing.Point(9, 26);
            this.dgvCongDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCongDung.Name = "dgvCongDung";
            this.dgvCongDung.ReadOnly = true;
            this.dgvCongDung.RowHeadersWidth = 51;
            this.dgvCongDung.Size = new System.Drawing.Size(546, 289);
            this.dgvCongDung.TabIndex = 0;
            this.dgvCongDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongDung_CellClick);
            this.dgvCongDung.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongDung_CellDoubleClick);
            this.dgvCongDung.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCongDung_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateCode);
            this.groupBox1.Controls.Add(this.txtTenCongDung);
            this.groupBox1.Controls.Add(this.txtMaCongDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 324);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCode.Image = global::BTL.Properties.Resources.add1;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCode.Location = new System.Drawing.Point(148, 135);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(300, 47);
            this.btnCreateCode.TabIndex = 87;
            this.btnCreateCode.Text = "Thêm Mã";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // txtTenCongDung
            // 
            this.txtTenCongDung.Location = new System.Drawing.Point(148, 84);
            this.txtTenCongDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCongDung.Name = "txtTenCongDung";
            this.txtTenCongDung.Size = new System.Drawing.Size(300, 24);
            this.txtTenCongDung.TabIndex = 84;
            // 
            // txtMaCongDung
            // 
            this.txtMaCongDung.Location = new System.Drawing.Point(148, 38);
            this.txtMaCongDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCongDung.Name = "txtMaCongDung";
            this.txtMaCongDung.Size = new System.Drawing.Size(300, 24);
            this.txtMaCongDung.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mã công dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 85;
            this.label4.Text = "Tên công dụng";
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
            this.gbxChucnang.Location = new System.Drawing.Point(102, 398);
            this.gbxChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Name = "gbxChucnang";
            this.gbxChucnang.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChucnang.Size = new System.Drawing.Size(873, 101);
            this.gbxChucnang.TabIndex = 92;
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
            // frmChitietCongdung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1074, 516);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grxChitiet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietCongdung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công dụng";
            this.Load += new System.EventHandler(this.frmChitietCongdung_Load);
            this.grxChitiet.ResumeLayout(false);
            this.grxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongDung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grxChitiet;
        public System.Windows.Forms.DataGridView dgvCongDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenCongDung;
        private System.Windows.Forms.TextBox txtMaCongDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblIntoCongDung;
    }
}