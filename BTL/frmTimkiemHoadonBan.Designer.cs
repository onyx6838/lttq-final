namespace BTL
{
    partial class frmTimkiemHoadonBan
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
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.cbNgaythang = new System.Windows.Forms.CheckBox();
            this.gbxNgaythang = new System.Windows.Forms.GroupBox();
            this.dtpNgaycuoi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaudau = new System.Windows.Forms.DateTimePicker();
            this.lbyc2 = new System.Windows.Forms.Label();
            this.cbxyc3 = new System.Windows.Forms.ComboBox();
            this.lbyc3 = new System.Windows.Forms.Label();
            this.cbxyc1 = new System.Windows.Forms.ComboBox();
            this.lbyc1 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem.SuspendLayout();
            this.gbxNgaythang.SuspendLayout();
            this.gbxKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.cbNgaythang);
            this.gbxTimkiem.Controls.Add(this.gbxNgaythang);
            this.gbxTimkiem.Controls.Add(this.cbxyc3);
            this.gbxTimkiem.Controls.Add(this.lbyc3);
            this.gbxTimkiem.Controls.Add(this.cbxyc1);
            this.gbxTimkiem.Controls.Add(this.lbyc1);
            this.gbxTimkiem.Controls.Add(this.btnLamlai);
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Location = new System.Drawing.Point(12, 12);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(402, 144);
            this.gbxTimkiem.TabIndex = 1;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm hóa đơn bán";
            // 
            // cbNgaythang
            // 
            this.cbNgaythang.AutoSize = true;
            this.cbNgaythang.Location = new System.Drawing.Point(9, 113);
            this.cbNgaythang.Name = "cbNgaythang";
            this.cbNgaythang.Size = new System.Drawing.Size(123, 17);
            this.cbNgaythang.TabIndex = 23;
            this.cbNgaythang.Text = "Tìm theo ngày tháng";
            this.cbNgaythang.UseVisualStyleBackColor = true;
            this.cbNgaythang.CheckedChanged += new System.EventHandler(this.cbNgaythang_CheckedChanged);
            // 
            // gbxNgaythang
            // 
            this.gbxNgaythang.Controls.Add(this.dtpNgaycuoi);
            this.gbxNgaythang.Controls.Add(this.label2);
            this.gbxNgaythang.Controls.Add(this.label1);
            this.gbxNgaythang.Controls.Add(this.dtpNgaudau);
            this.gbxNgaythang.Controls.Add(this.lbyc2);
            this.gbxNgaythang.Location = new System.Drawing.Point(220, 16);
            this.gbxNgaythang.Name = "gbxNgaythang";
            this.gbxNgaythang.Size = new System.Drawing.Size(175, 122);
            this.gbxNgaythang.TabIndex = 22;
            this.gbxNgaythang.TabStop = false;
            this.gbxNgaythang.Visible = false;
            // 
            // dtpNgaycuoi
            // 
            this.dtpNgaycuoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaycuoi.Location = new System.Drawing.Point(69, 91);
            this.dtpNgaycuoi.Name = "dtpNgaycuoi";
            this.dtpNgaycuoi.Size = new System.Drawing.Size(95, 20);
            this.dtpNgaycuoi.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Từ ngày";
            // 
            // dtpNgaudau
            // 
            this.dtpNgaudau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaudau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaudau.Location = new System.Drawing.Point(69, 51);
            this.dtpNgaudau.Name = "dtpNgaudau";
            this.dtpNgaudau.Size = new System.Drawing.Size(95, 20);
            this.dtpNgaudau.TabIndex = 27;
            // 
            // lbyc2
            // 
            this.lbyc2.AutoSize = true;
            this.lbyc2.Location = new System.Drawing.Point(6, 16);
            this.lbyc2.Name = "lbyc2";
            this.lbyc2.Size = new System.Drawing.Size(102, 13);
            this.lbyc2.TabIndex = 26;
            this.lbyc2.Text = "Ngày nhập hóa đơn";
            // 
            // cbxyc3
            // 
            this.cbxyc3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxyc3.FormattingEnabled = true;
            this.cbxyc3.Location = new System.Drawing.Point(9, 72);
            this.cbxyc3.Name = "cbxyc3";
            this.cbxyc3.Size = new System.Drawing.Size(109, 21);
            this.cbxyc3.TabIndex = 21;
            // 
            // lbyc3
            // 
            this.lbyc3.AutoSize = true;
            this.lbyc3.Location = new System.Drawing.Point(6, 56);
            this.lbyc3.Name = "lbyc3";
            this.lbyc3.Size = new System.Drawing.Size(75, 13);
            this.lbyc3.TabIndex = 20;
            this.lbyc3.Text = "Nhà cung cấp";
            // 
            // cbxyc1
            // 
            this.cbxyc1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxyc1.FormattingEnabled = true;
            this.cbxyc1.Location = new System.Drawing.Point(9, 32);
            this.cbxyc1.Name = "cbxyc1";
            this.cbxyc1.Size = new System.Drawing.Size(109, 21);
            this.cbxyc1.TabIndex = 17;
            // 
            // lbyc1
            // 
            this.lbyc1.AutoSize = true;
            this.lbyc1.Location = new System.Drawing.Point(6, 16);
            this.lbyc1.Name = "lbyc1";
            this.lbyc1.Size = new System.Drawing.Size(65, 13);
            this.lbyc1.TabIndex = 16;
            this.lbyc1.Text = "Mã hóa đơn";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(139, 67);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 29);
            this.btnLamlai.TabIndex = 15;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.BtnLamlai_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BTL.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(139, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // gbxKetqua
            // 
            this.gbxKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxKetqua.Controls.Add(this.dgvKetqua);
            this.gbxKetqua.Location = new System.Drawing.Point(12, 162);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Size = new System.Drawing.Size(563, 198);
            this.gbxKetqua.TabIndex = 2;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả tìm kiếm";
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Location = new System.Drawing.Point(9, 19);
            this.dgvKetqua.Name = "dgvKetqua";
            this.dgvKetqua.Size = new System.Drawing.Size(548, 173);
            this.dgvKetqua.TabIndex = 0;
            // 
            // frmTimkiemHoadonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(587, 372);
            this.Controls.Add(this.gbxKetqua);
            this.Controls.Add(this.gbxTimkiem);
            this.Name = "frmTimkiemHoadonBan";
            this.Text = "FormTimkiemHoadon";
            this.Load += new System.EventHandler(this.frmTimkiemHoadonBan_Load);
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.gbxNgaythang.ResumeLayout(false);
            this.gbxNgaythang.PerformLayout();
            this.gbxKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxyc3;
        private System.Windows.Forms.Label lbyc3;
        private System.Windows.Forms.ComboBox cbxyc1;
        private System.Windows.Forms.Label lbyc1;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxKetqua;
        private System.Windows.Forms.DataGridView dgvKetqua;
        public System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.GroupBox gbxNgaythang;
        private System.Windows.Forms.DateTimePicker dtpNgaycuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaudau;
        private System.Windows.Forms.Label lbyc2;
        private System.Windows.Forms.CheckBox cbNgaythang;
    }
}