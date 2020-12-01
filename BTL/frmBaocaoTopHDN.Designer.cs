namespace BTL
{
    partial class frmBaocaoTopHDN
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
            this.gbxNghiepvu = new System.Windows.Forms.GroupBox();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rpvChitiet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxNghiepvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNghiepvu
            // 
            this.gbxNghiepvu.Controls.Add(this.cbxNam);
            this.gbxNghiepvu.Controls.Add(this.label1);
            this.gbxNghiepvu.Controls.Add(this.btnLamlai);
            this.gbxNghiepvu.Controls.Add(this.btnOk);
            this.gbxNghiepvu.Location = new System.Drawing.Point(12, 12);
            this.gbxNghiepvu.Name = "gbxNghiepvu";
            this.gbxNghiepvu.Size = new System.Drawing.Size(405, 107);
            this.gbxNghiepvu.TabIndex = 9;
            this.gbxNghiepvu.TabStop = false;
            this.gbxNghiepvu.Text = "Báo cáo TOP 3 hóa đơn nhập ";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(158, 27);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(121, 21);
            this.cbxNam.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn năm";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(202, 62);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 31);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::BTL.Properties.Resources.check;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(70, 62);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rpvChitiet
            // 
            this.rpvChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvChitiet.Location = new System.Drawing.Point(12, 126);
            this.rpvChitiet.Name = "rpvChitiet";
            this.rpvChitiet.ServerReport.BearerToken = null;
            this.rpvChitiet.Size = new System.Drawing.Size(679, 292);
            this.rpvChitiet.TabIndex = 8;
            // 
            // frmBaocaoTopHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.gbxNghiepvu);
            this.Controls.Add(this.rpvChitiet);
            this.Name = "frmBaocaoTopHDN";
            this.Text = "frnBaocaoTopHDN";
            this.Load += new System.EventHandler(this.frmBaocaoTopHDN_Load);
            this.gbxNghiepvu.ResumeLayout(false);
            this.gbxNghiepvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxNghiepvu;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnOk;
        public Microsoft.Reporting.WinForms.ReportViewer rpvChitiet;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.Label label1;
    }
}