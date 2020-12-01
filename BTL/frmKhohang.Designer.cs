namespace BTL
{
    partial class frmKhohang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhohang));
            this.gbxChitiet = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.gbxChitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxChitiet
            // 
            this.gbxChitiet.Controls.Add(this.dgvHangHoa);
            this.gbxChitiet.Location = new System.Drawing.Point(16, 15);
            this.gbxChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Name = "gbxChitiet";
            this.gbxChitiet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChitiet.Size = new System.Drawing.Size(1035, 624);
            this.gbxChitiet.TabIndex = 0;
            this.gbxChitiet.TabStop = false;
            this.gbxChitiet.Text = "Thông tin kho hàng";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(8, 23);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.Size = new System.Drawing.Size(1019, 593);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            this.dgvHangHoa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHangHoa_CellFormatting);
            // 
            // btnNhap
            // 
            this.btnNhap.Image = global::BTL.Properties.Resources.import;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(360, 647);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(161, 63);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập hàng";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnBan
            // 
            this.btnBan.Image = global::BTL.Properties.Resources.goods;
            this.btnBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBan.Location = new System.Drawing.Point(580, 646);
            this.btnBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(161, 63);
            this.btnBan.TabIndex = 2;
            this.btnBan.Text = "Bán hàng";
            this.btnBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(53, 666);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(211, 22);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmKhohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1067, 725);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.gbxChitiet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhohang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.frmKhohang_Load);
            this.gbxChitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxChitiet;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}