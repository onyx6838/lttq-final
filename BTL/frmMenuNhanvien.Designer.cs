namespace BTL
{
    partial class frmMenuNhanvien
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
            this.btnCalam = new System.Windows.Forms.Button();
            this.btnCongviec = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalam
            // 
            this.btnCalam.Image = global::BTL.Properties.Resources.clock;
            this.btnCalam.Location = new System.Drawing.Point(116, 11);
            this.btnCalam.Name = "btnCalam";
            this.btnCalam.Size = new System.Drawing.Size(83, 82);
            this.btnCalam.TabIndex = 4;
            this.btnCalam.Text = "Ca làm việc";
            this.btnCalam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalam.UseVisualStyleBackColor = true;
            this.btnCalam.Click += new System.EventHandler(this.BtnCalam_Click);
            // 
            // btnCongviec
            // 
            this.btnCongviec.Image = global::BTL.Properties.Resources.portfolio;
            this.btnCongviec.Location = new System.Drawing.Point(220, 11);
            this.btnCongviec.Name = "btnCongviec";
            this.btnCongviec.Size = new System.Drawing.Size(83, 82);
            this.btnCongviec.TabIndex = 3;
            this.btnCongviec.Text = "Công việc";
            this.btnCongviec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCongviec.UseVisualStyleBackColor = true;
            this.btnCongviec.Click += new System.EventHandler(this.BtnCongviec_Click);
            // 
            // btnList
            // 
            this.btnList.Image = global::BTL.Properties.Resources.list_icon1;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnList.Location = new System.Drawing.Point(12, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(83, 82);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Danh sách nhân viên";
            this.btnList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // frmMenuNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(666, 105);
            this.Controls.Add(this.btnCalam);
            this.Controls.Add(this.btnCongviec);
            this.Controls.Add(this.btnList);
            this.Name = "frmMenuNhanvien";
            this.Text = "FormNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCongviec;
        private System.Windows.Forms.Button btnCalam;
    }
}