namespace BTL
{
    partial class frmTimkiemNhanvien
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
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbxCongviec = new System.Windows.Forms.ComboBox();
            this.cbxCalam = new System.Windows.Forms.ComboBox();
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem.SuspendLayout();
            this.gbxKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTimkiem.Controls.Add(this.button2);
            this.gbxTimkiem.Controls.Add(this.button1);
            this.gbxTimkiem.Controls.Add(this.label3);
            this.gbxTimkiem.Controls.Add(this.label2);
            this.gbxTimkiem.Controls.Add(this.label1);
            this.gbxTimkiem.Controls.Add(this.txtMaNV);
            this.gbxTimkiem.Controls.Add(this.cbxCongviec);
            this.gbxTimkiem.Controls.Add(this.cbxCalam);
            this.gbxTimkiem.Location = new System.Drawing.Point(12, 12);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(365, 100);
            this.gbxTimkiem.TabIndex = 0;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm nhân viên";
            // 
            // button2
            // 
            this.button2.Image = global::BTL.Properties.Resources.redo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(273, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Làm lại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BTL.Properties.Resources.search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(273, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ca làm ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(112, 72);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(121, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // cbxCongviec
            // 
            this.cbxCongviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCongviec.FormattingEnabled = true;
            this.cbxCongviec.Location = new System.Drawing.Point(112, 45);
            this.cbxCongviec.Name = "cbxCongviec";
            this.cbxCongviec.Size = new System.Drawing.Size(121, 21);
            this.cbxCongviec.TabIndex = 1;
            // 
            // cbxCalam
            // 
            this.cbxCalam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCalam.FormattingEnabled = true;
            this.cbxCalam.Location = new System.Drawing.Point(112, 18);
            this.cbxCalam.Name = "cbxCalam";
            this.cbxCalam.Size = new System.Drawing.Size(121, 21);
            this.cbxCalam.TabIndex = 0;
            // 
            // gbxKetqua
            // 
            this.gbxKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxKetqua.Controls.Add(this.dgvKetqua);
            this.gbxKetqua.Location = new System.Drawing.Point(12, 118);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Size = new System.Drawing.Size(365, 144);
            this.gbxKetqua.TabIndex = 1;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả tìm kiếm";
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Location = new System.Drawing.Point(6, 19);
            this.dgvKetqua.Name = "dgvKetqua";
            this.dgvKetqua.Size = new System.Drawing.Size(353, 119);
            this.dgvKetqua.TabIndex = 0;
            // 
            // frmTimkiemNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(389, 274);
            this.Controls.Add(this.gbxKetqua);
            this.Controls.Add(this.gbxTimkiem);
            this.Name = "frmTimkiemNhanvien";
            this.Text = "FormTimkiemNhanvien";
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.gbxKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbxCongviec;
        private System.Windows.Forms.ComboBox cbxCalam;
        private System.Windows.Forms.DataGridView dgvKetqua;
        public System.Windows.Forms.GroupBox gbxTimkiem;
        public System.Windows.Forms.GroupBox gbxKetqua;
    }
}