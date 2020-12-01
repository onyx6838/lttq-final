namespace BTL
{
    partial class frmMenuKhachHang
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
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Image = global::BTL.Properties.Resources.list_icon;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnList.Location = new System.Drawing.Point(12, 11);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(83, 82);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Danh sách khách hàng";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmMenuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 105);
            this.Controls.Add(this.btnList);
            this.Name = "frmMenuKhachHang";
            this.Text = "FormKhachHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
    }
}