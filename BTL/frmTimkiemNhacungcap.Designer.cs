namespace BTL
{
    partial class frmTimkiemNhacungcap
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
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.dgvKetqua = new System.Windows.Forms.DataGridView();
            this.gbxTimkiem = new System.Windows.Forms.GroupBox();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.gbxKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).BeginInit();
            this.gbxTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxKetqua
            // 
            this.gbxKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxKetqua.Controls.Add(this.dgvKetqua);
            this.gbxKetqua.Location = new System.Drawing.Point(12, 140);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Size = new System.Drawing.Size(365, 121);
            this.gbxKetqua.TabIndex = 3;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả tìm kiếm";
            // 
            // dgvKetqua
            // 
            this.dgvKetqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetqua.Location = new System.Drawing.Point(7, 20);
            this.dgvKetqua.Name = "dgvKetqua";
            this.dgvKetqua.Size = new System.Drawing.Size(352, 95);
            this.dgvKetqua.TabIndex = 0;
            // 
            // gbxTimkiem
            // 
            this.gbxTimkiem.Controls.Add(this.btnLamlai);
            this.gbxTimkiem.Controls.Add(this.btnSearch);
            this.gbxTimkiem.Controls.Add(this.label1);
            this.gbxTimkiem.Controls.Add(this.txtSodienthoai);
            this.gbxTimkiem.Location = new System.Drawing.Point(12, 12);
            this.gbxTimkiem.Name = "gbxTimkiem";
            this.gbxTimkiem.Size = new System.Drawing.Size(365, 122);
            this.gbxTimkiem.TabIndex = 2;
            this.gbxTimkiem.TabStop = false;
            this.gbxTimkiem.Text = "Tìm kiếm nhà cung cấp";
            // 
            // btnLamlai
            // 
            this.btnLamlai.Image = global::BTL.Properties.Resources.redo;
            this.btnLamlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamlai.Location = new System.Drawing.Point(268, 70);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 33);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::BTL.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(268, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số điện thoại";
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(110, 33);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(126, 20);
            this.txtSodienthoai.TabIndex = 0;
            // 
            // frmTimkiemNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(389, 274);
            this.Controls.Add(this.gbxKetqua);
            this.Controls.Add(this.gbxTimkiem);
            this.Name = "frmTimkiemNhacungcap";
            this.Text = "FormTimkiemNhacungcap";
            this.gbxKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetqua)).EndInit();
            this.gbxTimkiem.ResumeLayout(false);
            this.gbxTimkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxKetqua;
        private System.Windows.Forms.DataGridView dgvKetqua;
        public System.Windows.Forms.GroupBox gbxTimkiem;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSodienthoai;
    }
}