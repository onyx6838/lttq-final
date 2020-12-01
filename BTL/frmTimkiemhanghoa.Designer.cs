namespace BTL
{
    partial class frmTimkiemhanghoa
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
            this.cbxFindCongDung = new System.Windows.Forms.ComboBox();
            this.lbyc3 = new System.Windows.Forms.Label();
            this.cbxFindNhom = new System.Windows.Forms.ComboBox();
            this.lbyc2 = new System.Windows.Forms.Label();
            this.cbxFindChatLieu = new System.Windows.Forms.ComboBox();
            this.lbyc1 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem.SuspendLayout();
            this.gbxKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTimkiem.Controls.Add(this.cbxFindCongDung);
            this.gbxTimkiem.Controls.Add(this.lbyc3);
            this.gbxTimkiem.Controls.Add(this.cbxFindNhom);
            this.gbxTimkiem.Controls.Add(this.lbyc2);
            this.gbxTimkiem.Controls.Add(this.cbxFindChatLieu);
            this.gbxTimkiem.Controls.Add(this.lbyc1);
            this.gbxTimkiem.Controls.Add(this.btnLamlai);
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Location = new System.Drawing.Point(16, 15);
            this.gbxTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTimkiem.Size = new System.Drawing.Size(487, 150);
            this.gbxTimkiem.TabIndex = 0;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm hàng hóa";
            // 
            // cbxFindCongDung
            // 
            this.cbxFindCongDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFindCongDung.FormattingEnabled = true;
            this.cbxFindCongDung.Location = new System.Drawing.Point(333, 60);
            this.cbxFindCongDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFindCongDung.Name = "cbxFindCongDung";
            this.cbxFindCongDung.Size = new System.Drawing.Size(144, 24);
            this.cbxFindCongDung.TabIndex = 21;
            // 
            // lbyc3
            // 
            this.lbyc3.AutoSize = true;
            this.lbyc3.Location = new System.Drawing.Point(340, 20);
            this.lbyc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyc3.Name = "lbyc3";
            this.lbyc3.Size = new System.Drawing.Size(77, 17);
            this.lbyc3.TabIndex = 20;
            this.lbyc3.Text = "Công dụng";
            // 
            // cbxFindNhom
            // 
            this.cbxFindNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFindNhom.FormattingEnabled = true;
            this.cbxFindNhom.Location = new System.Drawing.Point(168, 60);
            this.cbxFindNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFindNhom.Name = "cbxFindNhom";
            this.cbxFindNhom.Size = new System.Drawing.Size(139, 24);
            this.cbxFindNhom.TabIndex = 19;
            // 
            // lbyc2
            // 
            this.lbyc2.AutoSize = true;
            this.lbyc2.Location = new System.Drawing.Point(183, 20);
            this.lbyc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyc2.Name = "lbyc2";
            this.lbyc2.Size = new System.Drawing.Size(45, 17);
            this.lbyc2.TabIndex = 18;
            this.lbyc2.Text = "Nhóm";
            // 
            // cbxFindChatLieu
            // 
            this.cbxFindChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFindChatLieu.FormattingEnabled = true;
            this.cbxFindChatLieu.Location = new System.Drawing.Point(12, 60);
            this.cbxFindChatLieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFindChatLieu.Name = "cbxFindChatLieu";
            this.cbxFindChatLieu.Size = new System.Drawing.Size(129, 24);
            this.cbxFindChatLieu.TabIndex = 17;
            // 
            // lbyc1
            // 
            this.lbyc1.AutoSize = true;
            this.lbyc1.Location = new System.Drawing.Point(8, 20);
            this.lbyc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyc1.Name = "lbyc1";
            this.lbyc1.Size = new System.Drawing.Size(63, 17);
            this.lbyc1.TabIndex = 16;
            this.lbyc1.Text = "Chất liệu";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(283, 107);
            this.btnLamlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(100, 36);
            this.btnLamlai.TabIndex = 15;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.BtnLamlai_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BTL.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(103, 107);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
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
            this.gbxKetqua.Controls.Add(this.dgvResult);
            this.gbxKetqua.Location = new System.Drawing.Point(16, 172);
            this.gbxKetqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxKetqua.Size = new System.Drawing.Size(487, 150);
            this.gbxKetqua.TabIndex = 1;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả tìm kiếm";
            // 
            // dgvResult
            // 
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 23);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.Size = new System.Drawing.Size(467, 119);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResult_CellFormatting);
            // 
            // frmTimkiemhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.gbxKetqua);
            this.Controls.Add(this.gbxTimkiem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimkiemhanghoa";
            this.Text = "FormTimkiem";
            this.Load += new System.EventHandler(this.FormTimkiem_Load);
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.gbxKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxFindCongDung;
        private System.Windows.Forms.Label lbyc3;
        private System.Windows.Forms.ComboBox cbxFindNhom;
        private System.Windows.Forms.Label lbyc2;
        private System.Windows.Forms.ComboBox cbxFindChatLieu;
        private System.Windows.Forms.Label lbyc1;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxKetqua;
        private System.Windows.Forms.DataGridView dgvResult;
        public System.Windows.Forms.GroupBox gbxTimkiem;
    }
}