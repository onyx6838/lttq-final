namespace BTL
{
    partial class frmChitietCalamviec
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
            this.lblIntoCaLam = new System.Windows.Forms.Label();
            this.dgvCaLam = new System.Windows.Forms.DataGridView();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxChucnang = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).BeginInit();
            this.gbxThongtin.SuspendLayout();
            this.gbxChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 88;
            this.label1.Text = "Danh Mục Ca Làm Việc";
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxChitiet.Controls.Add(this.lblIntoCaLam);
            this.gbxChitiet.Controls.Add(this.dgvCaLam);
            this.gbxChitiet.Location = new System.Drawing.Point(492, 66);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(564, 324);
            this.gbxChitiet.TabIndex = 82;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách ca làm việc";
            // 
            // lblIntoCaLam
            // 
            this.lblIntoCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntoCaLam.AutoSize = true;
            this.lblIntoCaLam.ForeColor = System.Drawing.Color.Red;
            this.lblIntoCaLam.Location = new System.Drawing.Point(538, 5);
            this.lblIntoCaLam.Name = "lblIntoCaLam";
            this.lblIntoCaLam.Size = new System.Drawing.Size(20, 18);
            this.lblIntoCaLam.TabIndex = 92;
            this.lblIntoCaLam.Text = "...";
            this.lblIntoCaLam.Click += new System.EventHandler(this.lblIntoCaLam_Click);
            // 
            // dgvCaLam
            // 
            this.dgvCaLam.AllowUserToDeleteRows = false;
            this.dgvCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaLam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaLam.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaLam.Location = new System.Drawing.Point(9, 25);
            this.dgvCaLam.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCaLam.Name = "dgvCaLam";
            this.dgvCaLam.ReadOnly = true;
            this.dgvCaLam.RowHeadersWidth = 51;
            this.dgvCaLam.Size = new System.Drawing.Size(546, 290);
            this.dgvCaLam.TabIndex = 0;
            this.dgvCaLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaLam_CellClick);
            this.dgvCaLam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaLam_CellDoubleClick);
            this.dgvCaLam.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCaLam_CellFormatting);
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.btnCreateCode);
            this.gbxThongtin.Controls.Add(this.txtTenCa);
            this.gbxThongtin.Controls.Add(this.txtMaCa);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Location = new System.Drawing.Point(18, 66);
            this.gbxThongtin.Margin = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Padding = new System.Windows.Forms.Padding(4);
            this.gbxThongtin.Size = new System.Drawing.Size(465, 324);
            this.gbxThongtin.TabIndex = 90;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin chi tiết";
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCode.Image = global::BTL.Properties.Resources.add1;
            this.btnCreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCode.Location = new System.Drawing.Point(80, 143);
            this.btnCreateCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(310, 47);
            this.btnCreateCode.TabIndex = 56;
            this.btnCreateCode.Text = "Thêm Mã";
            this.btnCreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // txtTenCa
            // 
            this.txtTenCa.Location = new System.Drawing.Point(80, 91);
            this.txtTenCa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(310, 24);
            this.txtTenCa.TabIndex = 92;
            // 
            // txtMaCa
            // 
            this.txtMaCa.Location = new System.Drawing.Point(80, 46);
            this.txtMaCa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(310, 24);
            this.txtMaCa.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Mã ca ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Tên ca";
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
            this.gbxChucnang.TabIndex = 91;
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
            // frmChitietCalamviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1074, 516);
            this.Controls.Add(this.gbxChucnang);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxChitiet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitietCalamviec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ca làm việc";
            this.Load += new System.EventHandler(this.frmChitietCalamviec_Load);
            this.gbxChitiet.ResumeLayout(false);
            this.gbxChitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).EndInit();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.gbxChucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbxChitiet;
        public System.Windows.Forms.DataGridView dgvCaLam;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxChucnang;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.Label lblIntoCaLam;
    }
}