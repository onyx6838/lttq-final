namespace BTL
{
    partial class frmMenuHanghoa
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
            this.btnNoisanxuat = new System.Windows.Forms.Button();
            this.btnCongdung = new System.Windows.Forms.Button();
            this.btnChatlieu = new System.Windows.Forms.Button();
            this.btnDonvitinh = new System.Windows.Forms.Button();
            this.btnTheloai = new System.Windows.Forms.Button();
            this.btnNhom = new System.Windows.Forms.Button();
            this.btnListhanghoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoisanxuat
            // 
            this.btnNoisanxuat.Image = global::BTL.Properties.Resources.factory;
            this.btnNoisanxuat.Location = new System.Drawing.Point(570, 10);
            this.btnNoisanxuat.Name = "btnNoisanxuat";
            this.btnNoisanxuat.Size = new System.Drawing.Size(83, 82);
            this.btnNoisanxuat.TabIndex = 7;
            this.btnNoisanxuat.Text = "Nơi sản xuât";
            this.btnNoisanxuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNoisanxuat.UseVisualStyleBackColor = true;
            this.btnNoisanxuat.Click += new System.EventHandler(this.BtnNoisanxuat_Click);
            // 
            // btnCongdung
            // 
            this.btnCongdung.Image = global::BTL.Properties.Resources.crafts;
            this.btnCongdung.Location = new System.Drawing.Point(477, 10);
            this.btnCongdung.Name = "btnCongdung";
            this.btnCongdung.Size = new System.Drawing.Size(83, 82);
            this.btnCongdung.TabIndex = 6;
            this.btnCongdung.Text = "Công dụng";
            this.btnCongdung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCongdung.UseVisualStyleBackColor = true;
            this.btnCongdung.Click += new System.EventHandler(this.BtnCongdung_Click);
            // 
            // btnChatlieu
            // 
            this.btnChatlieu.Image = global::BTL.Properties.Resources.tape;
            this.btnChatlieu.Location = new System.Drawing.Point(384, 10);
            this.btnChatlieu.Name = "btnChatlieu";
            this.btnChatlieu.Size = new System.Drawing.Size(83, 82);
            this.btnChatlieu.TabIndex = 5;
            this.btnChatlieu.Text = "Chất liệu";
            this.btnChatlieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChatlieu.UseVisualStyleBackColor = true;
            this.btnChatlieu.Click += new System.EventHandler(this.BtnChatlieu_Click);
            // 
            // btnDonvitinh
            // 
            this.btnDonvitinh.Image = global::BTL.Properties.Resources.kitchen_scale;
            this.btnDonvitinh.Location = new System.Drawing.Point(291, 10);
            this.btnDonvitinh.Name = "btnDonvitinh";
            this.btnDonvitinh.Size = new System.Drawing.Size(83, 82);
            this.btnDonvitinh.TabIndex = 4;
            this.btnDonvitinh.Text = "Đơn vị tính";
            this.btnDonvitinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDonvitinh.UseVisualStyleBackColor = true;
            this.btnDonvitinh.Click += new System.EventHandler(this.BtnDonvitinh_Click);
            // 
            // btnTheloai
            // 
            this.btnTheloai.Image = global::BTL.Properties.Resources.category;
            this.btnTheloai.Location = new System.Drawing.Point(198, 10);
            this.btnTheloai.Name = "btnTheloai";
            this.btnTheloai.Size = new System.Drawing.Size(83, 82);
            this.btnTheloai.TabIndex = 3;
            this.btnTheloai.Text = "Thể loại";
            this.btnTheloai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTheloai.UseVisualStyleBackColor = true;
            this.btnTheloai.Click += new System.EventHandler(this.BtnTheloai_Click);
            // 
            // btnNhom
            // 
            this.btnNhom.Image = global::BTL.Properties.Resources.jigsaw;
            this.btnNhom.Location = new System.Drawing.Point(105, 10);
            this.btnNhom.Name = "btnNhom";
            this.btnNhom.Size = new System.Drawing.Size(83, 82);
            this.btnNhom.TabIndex = 2;
            this.btnNhom.Text = "Nhóm";
            this.btnNhom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhom.UseVisualStyleBackColor = true;
            this.btnNhom.Click += new System.EventHandler(this.BtnNhom_Click);
            // 
            // btnListhanghoa
            // 
            this.btnListhanghoa.Image = global::BTL.Properties.Resources.list_icon;
            this.btnListhanghoa.Location = new System.Drawing.Point(12, 10);
            this.btnListhanghoa.Name = "btnListhanghoa";
            this.btnListhanghoa.Size = new System.Drawing.Size(83, 82);
            this.btnListhanghoa.TabIndex = 1;
            this.btnListhanghoa.Text = "Danh sách";
            this.btnListhanghoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListhanghoa.UseVisualStyleBackColor = true;
            this.btnListhanghoa.Click += new System.EventHandler(this.BtnListhanghoa_Click);
            // 
            // frmMenuHanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 105);
            this.Controls.Add(this.btnNoisanxuat);
            this.Controls.Add(this.btnCongdung);
            this.Controls.Add(this.btnChatlieu);
            this.Controls.Add(this.btnDonvitinh);
            this.Controls.Add(this.btnTheloai);
            this.Controls.Add(this.btnNhom);
            this.Controls.Add(this.btnListhanghoa);
            this.Name = "frmMenuHanghoa";
            this.Text = "FrmHanghoa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListhanghoa;
        private System.Windows.Forms.Button btnNhom;
        private System.Windows.Forms.Button btnTheloai;
        private System.Windows.Forms.Button btnDonvitinh;
        private System.Windows.Forms.Button btnChatlieu;
        private System.Windows.Forms.Button btnCongdung;
        private System.Windows.Forms.Button btnNoisanxuat;
    }
}