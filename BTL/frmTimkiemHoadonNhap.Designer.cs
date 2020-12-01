namespace BTL
{
    partial class frmTimkiemHoadonNhap
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
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.dgvFindResult = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.cbxNgay = new System.Windows.Forms.CheckBox();
            this.gbxNgaythang = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxHang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).BeginInit();
            this.gbxTimkiem.SuspendLayout();
            this.gbxNgaythang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKetqua
            // 
            this.gbxKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxKetqua.Controls.Add(this.dgvFindResult);
            this.gbxKetqua.Location = new System.Drawing.Point(16, 199);
            this.gbxKetqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxKetqua.Size = new System.Drawing.Size(751, 244);
            this.gbxKetqua.TabIndex = 4;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả tìm kiếm";
            // 
            // dgvFindResult
            // 
            this.dgvFindResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFindResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFindResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindResult.Location = new System.Drawing.Point(12, 23);
            this.dgvFindResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvFindResult.Name = "dgvFindResult";
            this.dgvFindResult.RowHeadersWidth = 51;
            this.dgvFindResult.Size = new System.Drawing.Size(731, 213);
            this.dgvFindResult.TabIndex = 0;
            this.dgvFindResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFindResult_CellFormatting);
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.cbxNgay);
            this.gbxTimkiem.Controls.Add(this.gbxNgaythang);
            this.gbxTimkiem.Controls.Add(this.cbxNCC);
            this.gbxTimkiem.Controls.Add(this.label6);
            this.gbxTimkiem.Controls.Add(this.cbxHang);
            this.gbxTimkiem.Controls.Add(this.label7);
            this.gbxTimkiem.Controls.Add(this.btnLamlai);
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Location = new System.Drawing.Point(16, 15);
            this.gbxTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTimkiem.Size = new System.Drawing.Size(536, 177);
            this.gbxTimkiem.TabIndex = 26;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm hóa đơn nhập";
            // 
            // cbxNgay
            // 
            this.cbxNgay.AutoSize = true;
            this.cbxNgay.Location = new System.Drawing.Point(12, 139);
            this.cbxNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNgay.Name = "cbxNgay";
            this.cbxNgay.Size = new System.Drawing.Size(160, 21);
            this.cbxNgay.TabIndex = 23;
            this.cbxNgay.Text = "Tìm theo ngày tháng";
            this.cbxNgay.UseVisualStyleBackColor = true;
            this.cbxNgay.CheckedChanged += new System.EventHandler(this.cbNgaythang_CheckedChanged);
            // 
            // gbxNgaythang
            // 
            this.gbxNgaythang.Controls.Add(this.dtpEnd);
            this.gbxNgaythang.Controls.Add(this.label3);
            this.gbxNgaythang.Controls.Add(this.label4);
            this.gbxNgaythang.Controls.Add(this.dtpStart);
            this.gbxNgaythang.Controls.Add(this.label5);
            this.gbxNgaythang.Location = new System.Drawing.Point(293, 20);
            this.gbxNgaythang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNgaythang.Name = "gbxNgaythang";
            this.gbxNgaythang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNgaythang.Size = new System.Drawing.Size(233, 150);
            this.gbxNgaythang.TabIndex = 22;
            this.gbxNgaythang.TabStop = false;
            this.gbxNgaythang.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(92, 112);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(125, 22);
            this.dtpEnd.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Từ ngày";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(92, 63);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(125, 22);
            this.dtpStart.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày nhập hóa đơn";
            // 
            // cbxNCC
            // 
            this.cbxNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(12, 89);
            this.cbxNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(144, 24);
            this.cbxNCC.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhà cung cấp";
            // 
            // cbxHang
            // 
            this.cbxHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHang.FormattingEnabled = true;
            this.cbxHang.Location = new System.Drawing.Point(12, 39);
            this.cbxHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxHang.Name = "cbxHang";
            this.cbxHang.Size = new System.Drawing.Size(144, 24);
            this.cbxHang.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã hàng hóa";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(185, 82);
            this.btnLamlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(100, 36);
            this.btnLamlai.TabIndex = 15;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BTL.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(185, 39);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTimkiemHoadonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(783, 458);
            this.Controls.Add(this.gbxTimkiem);
            this.Controls.Add(this.gbxKetqua);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimkiemHoadonNhap";
            this.Text = "FormTimkiemHoadonNhap";
            this.Load += new System.EventHandler(this.frmTimkiemHoadonNhap_Load);
            this.gbxKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindResult)).EndInit();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.gbxNgaythang.ResumeLayout(false);
            this.gbxNgaythang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxKetqua;
        private System.Windows.Forms.DataGridView dgvFindResult;
        public System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.CheckBox cbxNgay;
        private System.Windows.Forms.GroupBox gbxNgaythang;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnSearch;
    }
}