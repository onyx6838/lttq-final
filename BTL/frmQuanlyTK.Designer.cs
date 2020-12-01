namespace BTL
{
    partial class frmQuanlyTK
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
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.gbxThongtin = new System.Windows.Forms.GroupBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            this.gbxThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Controls.Add(this.dgvChitiet);
            this.gbxChitiet.Location = new System.Drawing.Point(14, 187);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Size = new System.Drawing.Size(460, 276);
            this.gbxChitiet.TabIndex = 0;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Danh sách tài khoản";
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChitiet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Location = new System.Drawing.Point(7, 22);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.Size = new System.Drawing.Size(446, 247);
            this.dgvChitiet.TabIndex = 0;
            this.dgvChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellClick);
            this.dgvChitiet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChitiet_CellFormatting);
            // 
            // gbxThongtin
            // 
            this.gbxThongtin.Controls.Add(this.cbxRole);
            this.gbxThongtin.Controls.Add(this.label4);
            this.gbxThongtin.Controls.Add(this.txtID);
            this.gbxThongtin.Controls.Add(this.label3);
            this.gbxThongtin.Controls.Add(this.txtMK);
            this.gbxThongtin.Controls.Add(this.txtTenTK);
            this.gbxThongtin.Controls.Add(this.label2);
            this.gbxThongtin.Controls.Add(this.label1);
            this.gbxThongtin.Location = new System.Drawing.Point(14, 14);
            this.gbxThongtin.Name = "gbxThongtin";
            this.gbxThongtin.Size = new System.Drawing.Size(460, 166);
            this.gbxThongtin.TabIndex = 1;
            this.gbxThongtin.TabStop = false;
            this.gbxThongtin.Text = "Thông tin tài khoản";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxRole.Location = new System.Drawing.Point(170, 94);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(234, 26);
            this.cbxRole.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID";
            this.label4.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(170, 131);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(234, 24);
            this.txtID.TabIndex = 22;
            this.txtID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Quyền";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(170, 59);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(234, 24);
            this.txtMK.TabIndex = 20;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(170, 23);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(234, 24);
            this.txtTenTK.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tài khoản";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(263, 479);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 30);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(380, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 27);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 27);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 481);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanlyTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(488, 519);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbxThongtin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gbxChitiet);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanlyTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmQuanlyTK_Load);
            this.gbxChitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            this.gbxThongtin.ResumeLayout(false);
            this.gbxThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.GroupBox gbxThongtin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}