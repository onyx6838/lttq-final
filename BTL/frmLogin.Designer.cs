namespace BTL
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.llbDangky = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVisible = new System.Windows.Forms.CheckBox();
            this.llbQMK = new System.Windows.Forms.LinkLabel();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(93, 77);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(216, 24);
            this.txtAccount.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // llbDangky
            // 
            this.llbDangky.AutoSize = true;
            this.llbDangky.Location = new System.Drawing.Point(12, 285);
            this.llbDangky.Name = "llbDangky";
            this.llbDangky.Size = new System.Drawing.Size(308, 18);
            this.llbDangky.TabIndex = 6;
            this.llbDangky.TabStop = true;
            this.llbDangky.Text = "Chưa có tài khoản? Nhấp vào đây để đăng ký!";
            this.llbDangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangky_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hệ thống bán hàng siêu thị";
            // 
            // cbxVisible
            // 
            this.cbxVisible.AutoSize = true;
            this.cbxVisible.Location = new System.Drawing.Point(93, 157);
            this.cbxVisible.Name = "cbxVisible";
            this.cbxVisible.Size = new System.Drawing.Size(125, 22);
            this.cbxVisible.TabIndex = 11;
            this.cbxVisible.Text = "Hiện mật khẩu";
            this.cbxVisible.UseVisualStyleBackColor = true;
            this.cbxVisible.CheckedChanged += new System.EventHandler(this.cbxVisible_CheckedChanged);
            // 
            // llbQMK
            // 
            this.llbQMK.AutoSize = true;
            this.llbQMK.Location = new System.Drawing.Point(217, 158);
            this.llbQMK.Name = "llbQMK";
            this.llbQMK.Size = new System.Drawing.Size(96, 18);
            this.llbQMK.TabIndex = 12;
            this.llbQMK.TabStop = true;
            this.llbQMK.Text = "Đổi mật khẩu";
            this.llbQMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQMK_LinkClicked);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Image = global::BTL.Properties.Resources.close;
            this.btnHuybo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuybo.Location = new System.Drawing.Point(220, 195);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(89, 53);
            this.btnHuybo.TabIndex = 5;
            this.btnHuybo.Text = "Thoát";
            this.btnHuybo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Image = global::BTL.Properties.Resources.enter1;
            this.btnDangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangnhap.Location = new System.Drawing.Point(93, 195);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(89, 53);
            this.btnDangnhap.TabIndex = 4;
            this.btnDangnhap.Text = "Đăng\r\nnhập";
            this.btnDangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(349, 309);
            this.Controls.Add(this.llbQMK);
            this.Controls.Add(this.cbxVisible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.llbDangky);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.LinkLabel llbDangky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxVisible;
        private System.Windows.Forms.LinkLabel llbQMK;
    }
}