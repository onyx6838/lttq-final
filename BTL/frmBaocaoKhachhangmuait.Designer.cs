﻿namespace BTL
{
    partial class frmBaocaoKhachhangmuait
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.cbxQuy = new System.Windows.Forms.ComboBox();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rpvChitiet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbxNghiepvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNghiepvu
            // 
            this.gbxNghiepvu.Controls.Add(this.label2);
            this.gbxNghiepvu.Controls.Add(this.label1);
            this.gbxNghiepvu.Controls.Add(this.cbxNam);
            this.gbxNghiepvu.Controls.Add(this.cbxQuy);
            this.gbxNghiepvu.Controls.Add(this.btnLamlai);
            this.gbxNghiepvu.Controls.Add(this.btnOk);
            this.gbxNghiepvu.Location = new System.Drawing.Point(13, 15);
            this.gbxNghiepvu.Margin = new System.Windows.Forms.Padding(4);
            this.gbxNghiepvu.Name = "gbxNghiepvu";
            this.gbxNghiepvu.Padding = new System.Windows.Forms.Padding(4);
            this.gbxNghiepvu.Size = new System.Drawing.Size(484, 190);
            this.gbxNghiepvu.TabIndex = 11;
            this.gbxNghiepvu.TabStop = false;
            this.gbxNghiepvu.Text = "Báo cáo khách hàng mua ít trong năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quý";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Location = new System.Drawing.Point(300, 31);
            this.cbxNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(96, 24);
            this.cbxNam.TabIndex = 12;
            // 
            // cbxQuy
            // 
            this.cbxQuy.FormattingEnabled = true;
            this.cbxQuy.Location = new System.Drawing.Point(104, 31);
            this.cbxQuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxQuy.Name = "cbxQuy";
            this.cbxQuy.Size = new System.Drawing.Size(96, 24);
            this.cbxQuy.TabIndex = 11;
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(297, 92);
            this.btnLamlai.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnOk.Location = new System.Drawing.Point(101, 92);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 38);
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
            this.rpvChitiet.Location = new System.Drawing.Point(13, 212);
            this.rpvChitiet.Margin = new System.Windows.Forms.Padding(4);
            this.rpvChitiet.Name = "rpvChitiet";
            this.rpvChitiet.ServerReport.BearerToken = null;
            this.rpvChitiet.Size = new System.Drawing.Size(915, 302);
            this.rpvChitiet.TabIndex = 10;
            // 
            // frmBaocaoKhachhangmuait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(936, 527);
            this.Controls.Add(this.gbxNghiepvu);
            this.Controls.Add(this.rpvChitiet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaocaoKhachhangmuait";
            this.Text = "frmBaocaoKhachhangmuait";
            this.Load += new System.EventHandler(this.frmBaocaoKhachhangmuait_Load);
            this.gbxNghiepvu.ResumeLayout(false);
            this.gbxNghiepvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbxNghiepvu;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnOk;
        public Microsoft.Reporting.WinForms.ReportViewer rpvChitiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.ComboBox cbxQuy;
    }
}