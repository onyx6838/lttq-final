namespace BTL
{
    partial class frmMenuBaocaokhachhang
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
            this.btnMuait = new System.Windows.Forms.Button();
            this.btnMuanhieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMuait
            // 
            this.btnMuait.Image = global::BTL.Properties.Resources.dislike;
            this.btnMuait.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMuait.Location = new System.Drawing.Point(160, 15);
            this.btnMuait.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuait.Name = "btnMuait";
            this.btnMuait.Size = new System.Drawing.Size(109, 101);
            this.btnMuait.TabIndex = 3;
            this.btnMuait.Text = "Mua \r\nít nhất";
            this.btnMuait.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuait.UseVisualStyleBackColor = true;
            this.btnMuait.Click += new System.EventHandler(this.BtnMuait_Click);
            // 
            // btnMuanhieu
            // 
            this.btnMuanhieu.Image = global::BTL.Properties.Resources.gold_medal;
            this.btnMuanhieu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMuanhieu.Location = new System.Drawing.Point(16, 15);
            this.btnMuanhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuanhieu.Name = "btnMuanhieu";
            this.btnMuanhieu.Size = new System.Drawing.Size(109, 101);
            this.btnMuanhieu.TabIndex = 2;
            this.btnMuanhieu.Text = "Mua nhiều nhất";
            this.btnMuanhieu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuanhieu.UseVisualStyleBackColor = true;
            this.btnMuanhieu.Click += new System.EventHandler(this.BtnMuanhieu_Click);
            // 
            // frmMenuBaocaokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(888, 128);
            this.Controls.Add(this.btnMuait);
            this.Controls.Add(this.btnMuanhieu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenuBaocaokhachhang";
            this.Text = "FormBaocaokhachhang";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMuanhieu;
        private System.Windows.Forms.Button btnMuait;
    }
}