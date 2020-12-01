namespace BTL
{
    partial class frmMenuBaocaonhanvien
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
            this.btnNVBan = new System.Windows.Forms.Button();
            this.btnNVNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNVBan
            // 
            this.btnNVBan.Image = global::BTL.Properties.Resources.export1;
            this.btnNVBan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNVBan.Location = new System.Drawing.Point(125, 12);
            this.btnNVBan.Name = "btnNVBan";
            this.btnNVBan.Size = new System.Drawing.Size(82, 82);
            this.btnNVBan.TabIndex = 1;
            this.btnNVBan.Text = "Nhân viên bán hàng";
            this.btnNVBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNVBan.UseVisualStyleBackColor = true;
            this.btnNVBan.Click += new System.EventHandler(this.BtnNVBan_Click);
            // 
            // btnNVNhap
            // 
            this.btnNVNhap.Image = global::BTL.Properties.Resources.import1;
            this.btnNVNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNVNhap.Location = new System.Drawing.Point(12, 12);
            this.btnNVNhap.Name = "btnNVNhap";
            this.btnNVNhap.Size = new System.Drawing.Size(82, 82);
            this.btnNVNhap.TabIndex = 0;
            this.btnNVNhap.Text = "Nhân viên nhập hàng";
            this.btnNVNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNVNhap.UseVisualStyleBackColor = true;
            this.btnNVNhap.Click += new System.EventHandler(this.BtnNVNhap_Click);
            // 
            // frmMenuBaocaonhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 109);
            this.Controls.Add(this.btnNVBan);
            this.Controls.Add(this.btnNVNhap);
            this.Name = "frmMenuBaocaonhanvien";
            this.Text = "s";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNVNhap;
        private System.Windows.Forms.Button btnNVBan;
    }
}