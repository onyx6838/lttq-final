namespace BTL
{
    partial class frmMenuBaocaohoadon
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
            this.btnTonghoadonban = new System.Windows.Forms.Button();
            this.btnHoaTonghoadonnhap = new System.Windows.Forms.Button();
            this.btnTopNhap = new System.Windows.Forms.Button();
            this.btnTopBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTonghoadonban
            // 
            this.btnTonghoadonban.Image = global::BTL.Properties.Resources.export_total;
            this.btnTonghoadonban.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTonghoadonban.Location = new System.Drawing.Point(160, 15);
            this.btnTonghoadonban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTonghoadonban.Name = "btnTonghoadonban";
            this.btnTonghoadonban.Size = new System.Drawing.Size(109, 101);
            this.btnTonghoadonban.TabIndex = 2;
            this.btnTonghoadonban.Text = "Tổng hóa đơn bán";
            this.btnTonghoadonban.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTonghoadonban.UseVisualStyleBackColor = true;
            this.btnTonghoadonban.Click += new System.EventHandler(this.BtnTonghoadonban_Click);
            // 
            // btnHoaTonghoadonnhap
            // 
            this.btnHoaTonghoadonnhap.Image = global::BTL.Properties.Resources.import__total;
            this.btnHoaTonghoadonnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHoaTonghoadonnhap.Location = new System.Drawing.Point(16, 15);
            this.btnHoaTonghoadonnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHoaTonghoadonnhap.Name = "btnHoaTonghoadonnhap";
            this.btnHoaTonghoadonnhap.Size = new System.Drawing.Size(109, 101);
            this.btnHoaTonghoadonnhap.TabIndex = 1;
            this.btnHoaTonghoadonnhap.Text = "Tổng hóa đơn nhập";
            this.btnHoaTonghoadonnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoaTonghoadonnhap.UseVisualStyleBackColor = true;
            this.btnHoaTonghoadonnhap.Click += new System.EventHandler(this.BtnHoaTonghoadonnhap_Click);
            // 
            // btnTopNhap
            // 
            this.btnTopNhap.Image = global::BTL.Properties.Resources.top_three;
            this.btnTopNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTopNhap.Location = new System.Drawing.Point(304, 15);
            this.btnTopNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopNhap.Name = "btnTopNhap";
            this.btnTopNhap.Size = new System.Drawing.Size(109, 101);
            this.btnTopNhap.TabIndex = 3;
            this.btnTopNhap.Text = "Top nhập nhiều nhất";
            this.btnTopNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTopNhap.UseVisualStyleBackColor = true;
            this.btnTopNhap.Click += new System.EventHandler(this.btnTopNhap_Click);
            // 
            // btnTopBan
            // 
            this.btnTopBan.Image = global::BTL.Properties.Resources.top_three;
            this.btnTopBan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTopBan.Location = new System.Drawing.Point(448, 15);
            this.btnTopBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTopBan.Name = "btnTopBan";
            this.btnTopBan.Size = new System.Drawing.Size(109, 101);
            this.btnTopBan.TabIndex = 4;
            this.btnTopBan.Text = "Top bán nhiều nhất";
            this.btnTopBan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTopBan.UseVisualStyleBackColor = true;
            this.btnTopBan.Click += new System.EventHandler(this.btnTopBan_Click);
            // 
            // frmMenuBaocaohoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(888, 130);
            this.Controls.Add(this.btnTopBan);
            this.Controls.Add(this.btnTopNhap);
            this.Controls.Add(this.btnTonghoadonban);
            this.Controls.Add(this.btnHoaTonghoadonnhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuBaocaohoadon";
            this.Text = "FormBaocaohoadon";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoaTonghoadonnhap;
        private System.Windows.Forms.Button btnTonghoadonban;
        private System.Windows.Forms.Button btnTopNhap;
        private System.Windows.Forms.Button btnTopBan;
    }
}