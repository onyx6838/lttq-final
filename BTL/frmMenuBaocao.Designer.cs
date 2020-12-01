namespace BTL
{
    partial class frmMenuBaocao
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
            this.btnBChoadon = new System.Windows.Forms.Button();
            this.btnBCKhachhang = new System.Windows.Forms.Button();
            this.btnBCnhanvien = new System.Windows.Forms.Button();
            this.btnBCsanpham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBChoadon
            // 
            this.btnBChoadon.FlatAppearance.BorderSize = 0;
            this.btnBChoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBChoadon.Image = global::BTL.Properties.Resources.delivery;
            this.btnBChoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBChoadon.Location = new System.Drawing.Point(12, 57);
            this.btnBChoadon.Name = "btnBChoadon";
            this.btnBChoadon.Size = new System.Drawing.Size(190, 39);
            this.btnBChoadon.TabIndex = 1;
            this.btnBChoadon.Text = "Hóa đơn ";
            this.btnBChoadon.UseVisualStyleBackColor = true;
            this.btnBChoadon.Click += new System.EventHandler(this.BtnBChoadon_Click);
            // 
            // btnBCKhachhang
            // 
            this.btnBCKhachhang.FlatAppearance.BorderSize = 0;
            this.btnBCKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCKhachhang.Image = global::BTL.Properties.Resources.customer_people;
            this.btnBCKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCKhachhang.Location = new System.Drawing.Point(12, 147);
            this.btnBCKhachhang.Name = "btnBCKhachhang";
            this.btnBCKhachhang.Size = new System.Drawing.Size(190, 39);
            this.btnBCKhachhang.TabIndex = 3;
            this.btnBCKhachhang.Text = "Khách hàng";
            this.btnBCKhachhang.UseVisualStyleBackColor = true;
            this.btnBCKhachhang.Click += new System.EventHandler(this.BtnBCKhachhang_Click);
            // 
            // btnBCnhanvien
            // 
            this.btnBCnhanvien.FlatAppearance.BorderSize = 0;
            this.btnBCnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCnhanvien.Image = global::BTL.Properties.Resources.salesman;
            this.btnBCnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCnhanvien.Location = new System.Drawing.Point(12, 102);
            this.btnBCnhanvien.Name = "btnBCnhanvien";
            this.btnBCnhanvien.Size = new System.Drawing.Size(190, 39);
            this.btnBCnhanvien.TabIndex = 2;
            this.btnBCnhanvien.Text = "Nhân viên sale";
            this.btnBCnhanvien.UseVisualStyleBackColor = true;
            this.btnBCnhanvien.Click += new System.EventHandler(this.BtnBCnhanvien_Click);
            // 
            // btnBCsanpham
            // 
            this.btnBCsanpham.FlatAppearance.BorderSize = 0;
            this.btnBCsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCsanpham.Image = global::BTL.Properties.Resources.box;
            this.btnBCsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCsanpham.Location = new System.Drawing.Point(12, 12);
            this.btnBCsanpham.Name = "btnBCsanpham";
            this.btnBCsanpham.Size = new System.Drawing.Size(190, 39);
            this.btnBCsanpham.TabIndex = 0;
            this.btnBCsanpham.Text = "Sản phẩm ";
            this.btnBCsanpham.UseVisualStyleBackColor = true;
            this.btnBCsanpham.Click += new System.EventHandler(this.BtnBCsanpham_Click);
            // 
            // frmMenuBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(214, 198);
            this.Controls.Add(this.btnBCKhachhang);
            this.Controls.Add(this.btnBCnhanvien);
            this.Controls.Add(this.btnBChoadon);
            this.Controls.Add(this.btnBCsanpham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuBaocao";
            this.Text = "FormMenuBaocao";
            this.Load += new System.EventHandler(this.FrmMenuBaocao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBCsanpham;
        private System.Windows.Forms.Button btnBChoadon;
        private System.Windows.Forms.Button btnBCnhanvien;
        private System.Windows.Forms.Button btnBCKhachhang;
    }
}