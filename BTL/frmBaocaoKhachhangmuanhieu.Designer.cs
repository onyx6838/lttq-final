namespace BTL
{
    partial class frmBaocaoKhachhangmuanhieu
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
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvChitiet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxQuy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxNghiepvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNghiepvu
            // 
            this.gbxNghiepvu.Controls.Add(this.cbxQuy);
            this.gbxNghiepvu.Controls.Add(this.label2);
            this.gbxNghiepvu.Controls.Add(this.btnLamlai);
            this.gbxNghiepvu.Controls.Add(this.btnOk);
            this.gbxNghiepvu.Controls.Add(this.comboBox1);
            this.gbxNghiepvu.Controls.Add(this.label1);
            this.gbxNghiepvu.Location = new System.Drawing.Point(12, 12);
            this.gbxNghiepvu.Name = "gbxNghiepvu";
            this.gbxNghiepvu.Size = new System.Drawing.Size(405, 144);
            this.gbxNghiepvu.TabIndex = 9;
            this.gbxNghiepvu.TabStop = false;
            this.gbxNghiepvu.Text = "Báo cáo khách hàng mua nhiều nhất năm";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(262, 91);
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
            this.btnOk.Location = new System.Drawing.Point(134, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn năm";
            // 
            // rpvChitiet
            // 
            this.rpvChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvChitiet.Location = new System.Drawing.Point(12, 162);
            this.rpvChitiet.Name = "rpvChitiet";
            this.rpvChitiet.ServerReport.BearerToken = null;
            this.rpvChitiet.Size = new System.Drawing.Size(679, 254);
            this.rpvChitiet.TabIndex = 8;
            // 
            // cbxQuy
            // 
            this.cbxQuy.FormattingEnabled = true;
            this.cbxQuy.Location = new System.Drawing.Point(102, 41);
            this.cbxQuy.Name = "cbxQuy";
            this.cbxQuy.Size = new System.Drawing.Size(75, 21);
            this.cbxQuy.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn quý";
            // 
            // frmBaocaoKhachhangmuanhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(702, 428);
            this.Controls.Add(this.gbxNghiepvu);
            this.Controls.Add(this.rpvChitiet);
            this.Name = "frmBaocaoKhachhangmuanhieu";
            this.Text = "frmBaocaoKhachhangmuanhieu";
            this.gbxNghiepvu.ResumeLayout(false);
            this.gbxNghiepvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxNghiepvu;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        public Microsoft.Reporting.WinForms.ReportViewer rpvChitiet;
        private System.Windows.Forms.ComboBox cbxQuy;
        private System.Windows.Forms.Label label2;
    }
}