namespace BTL
{
    partial class frmMenuBaocaosanpham
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
            this.btnBanchay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBanchay
            // 
            this.btnBanchay.Image = global::BTL.Properties.Resources.hot_sale;
            this.btnBanchay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBanchay.Location = new System.Drawing.Point(12, 12);
            this.btnBanchay.Name = "btnBanchay";
            this.btnBanchay.Size = new System.Drawing.Size(82, 82);
            this.btnBanchay.TabIndex = 0;
            this.btnBanchay.Text = "Sản phẩm bán chạy";
            this.btnBanchay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBanchay.UseVisualStyleBackColor = true;
            this.btnBanchay.Click += new System.EventHandler(this.BtnBanchay_Click);
            // 
            // frmMenuBaocaosanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 99);
            this.Controls.Add(this.btnBanchay);
            this.Name = "frmMenuBaocaosanpham";
            this.Text = "FormBaocaosanpham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanchay;
    }
}