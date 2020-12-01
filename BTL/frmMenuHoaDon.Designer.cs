namespace BTL
{
    partial class frmMenuHoaDon
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
            this.btnHDB = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHDB
            // 
            this.btnHDB.Image = global::BTL.Properties.Resources.export;
            this.btnHDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHDB.Location = new System.Drawing.Point(118, 12);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.Size = new System.Drawing.Size(83, 82);
            this.btnHDB.TabIndex = 1;
            this.btnHDB.Text = "Hóa đơn bán";
            this.btnHDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHDB.UseVisualStyleBackColor = true;
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.Image = global::BTL.Properties.Resources.import_file;
            this.btnHDN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHDN.Location = new System.Drawing.Point(12, 12);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(83, 82);
            this.btnHDN.TabIndex = 0;
            this.btnHDN.Text = "Hóa đơn nhập";
            this.btnHDN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHDN.UseVisualStyleBackColor = true;
            this.btnHDN.Click += new System.EventHandler(this.BtnHDN_Click);
            // 
            // frmMenuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 105);
            this.Controls.Add(this.btnHDB);
            this.Controls.Add(this.btnHDN);
            this.Name = "frmMenuHoaDon";
            this.Text = "FormMenuHoaDon";
            this.Load += new System.EventHandler(this.FormMenuHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHDN;
        private System.Windows.Forms.Button btnHDB;
    }
}