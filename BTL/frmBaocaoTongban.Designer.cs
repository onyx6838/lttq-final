namespace BTL
{
    partial class frmBaocaoTongban
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
            this.rpvChitiet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxNghiepvu = new System.Windows.Forms.GroupBox();
            this.cbxQuy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxNghiepvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpvChitiet
            // 
            this.rpvChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvChitiet.Location = new System.Drawing.Point(16, 199);
            this.rpvChitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvChitiet.Name = "rpvChitiet";
            this.rpvChitiet.ServerReport.BearerToken = null;
            this.rpvChitiet.Size = new System.Drawing.Size(905, 312);
            this.rpvChitiet.TabIndex = 0;
            // 
            // gbxNghiepvu
            // 
            this.gbxNghiepvu.Controls.Add(this.cbxQuy);
            this.gbxNghiepvu.Controls.Add(this.label2);
            this.gbxNghiepvu.Controls.Add(this.cbxNam);
            this.gbxNghiepvu.Controls.Add(this.label1);
            this.gbxNghiepvu.Controls.Add(this.btnLamlai);
            this.gbxNghiepvu.Controls.Add(this.btnOk);
            this.gbxNghiepvu.Location = new System.Drawing.Point(16, 15);
            this.gbxNghiepvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNghiepvu.Name = "gbxNghiepvu";
            this.gbxNghiepvu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxNghiepvu.Size = new System.Drawing.Size(540, 177);
            this.gbxNghiepvu.TabIndex = 1;
            this.gbxNghiepvu.TabStop = false;
            this.gbxNghiepvu.Text = "Báo cáo tổng doanh thu bán hàng";
            // 
            // cbxQuy
            // 
            this.cbxQuy.FormattingEnabled = true;
            this.cbxQuy.Location = new System.Drawing.Point(107, 48);
            this.cbxQuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxQuy.Name = "cbxQuy";
            this.cbxQuy.Size = new System.Drawing.Size(160, 24);
            this.cbxQuy.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn quý";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(371, 48);
            this.cbxNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(160, 24);
            this.cbxNam.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn năm";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(371, 132);
            this.btnLamlai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(100, 38);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::BTL.Properties.Resources.check;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(168, 132);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 38);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmBaocaoTongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(936, 527);
            this.Controls.Add(this.gbxNghiepvu);
            this.Controls.Add(this.rpvChitiet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaocaoTongban";
            this.gbxNghiepvu.ResumeLayout(false);
            this.gbxNghiepvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.GroupBox gbxNghiepvu;
        public Microsoft.Reporting.WinForms.ReportViewer rpvChitiet;
        private System.Windows.Forms.ComboBox cbxQuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label label1;
    }
}