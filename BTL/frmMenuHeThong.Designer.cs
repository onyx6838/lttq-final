namespace BTL
{
    partial class FrmMenuHeThong
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
            this.btnNhacungcap = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnHanghoa = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhacungcap
            // 
            this.btnNhacungcap.FlatAppearance.BorderSize = 0;
            this.btnNhacungcap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhacungcap.Image = global::BTL.Properties.Resources.supplier;
            this.btnNhacungcap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhacungcap.Location = new System.Drawing.Point(12, 135);
            this.btnNhacungcap.Name = "btnNhacungcap";
            this.btnNhacungcap.Size = new System.Drawing.Size(197, 40);
            this.btnNhacungcap.TabIndex = 3;
            this.btnNhacungcap.Text = "Nhà cung cấp";
            this.btnNhacungcap.UseVisualStyleBackColor = true;
            this.btnNhacungcap.Click += new System.EventHandler(this.BtnNhacungcap_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Image = global::BTL.Properties.Resources.customer;
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(12, 94);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(197, 40);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.BtnKhachhang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Image = global::BTL.Properties.Resources.employee;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(12, 48);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(197, 40);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.BtnNhanvien_Click);
            // 
            // btnHanghoa
            // 
            this.btnHanghoa.FlatAppearance.BorderSize = 0;
            this.btnHanghoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHanghoa.Image = global::BTL.Properties.Resources.shopping;
            this.btnHanghoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHanghoa.Location = new System.Drawing.Point(12, 2);
            this.btnHanghoa.Name = "btnHanghoa";
            this.btnHanghoa.Size = new System.Drawing.Size(197, 40);
            this.btnHanghoa.TabIndex = 0;
            this.btnHanghoa.Text = "Hàng hóa";
            this.btnHanghoa.UseVisualStyleBackColor = true;
            this.btnHanghoa.Click += new System.EventHandler(this.BtnHanghoa_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.Image = global::BTL.Properties.Resources.invoice;
            this.btnHoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.Location = new System.Drawing.Point(12, 176);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(197, 40);
            this.btnHoadon.TabIndex = 4;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = true;
            this.btnHoadon.Click += new System.EventHandler(this.BtnHoadon_Click);
            // 
            // FrmMenuHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(214, 220);
            this.Controls.Add(this.btnHoadon);
            this.Controls.Add(this.btnNhacungcap);
            this.Controls.Add(this.btnKhachhang);
            this.Controls.Add(this.btnNhanvien);
            this.Controls.Add(this.btnHanghoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMenuHeThong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenuHeThong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnHanghoa;
        public System.Windows.Forms.Button btnNhanvien;
        public System.Windows.Forms.Button btnKhachhang;
        public System.Windows.Forms.Button btnNhacungcap;
        public System.Windows.Forms.Button btnHoadon;
    }
}