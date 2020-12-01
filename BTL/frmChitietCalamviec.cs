﻿using BUS; using Constant; using DTO; using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace BTL {     public partial class frmChitietCalamviec : Form     {         DataTable dt;         SystemConstant sys = new SystemConstant();         public frmChitietCalamviec()         {             InitializeComponent();             frmChitietCalamviec_Load(null, null);             if (frmLogin.session.role == 2)             {                 btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;             }             Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);         }          private void frmChitietCalamviec_Load(object sender, EventArgs e)         {             dt = B_CaLam.GetAllCaLam();             dgvCaLam.DataSource = dt;         }         private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaCa", "CA");
            txtMaCa.Text = newCode;
            /*string[] exstCode = dt.AsEnumerable().Select(r => r.Field<string>("MaCa")).ToArray();
            Random rand = new Random();
            int index = exstCode.Length;

            string newCodex = exstCode[index - 1];
            string val = String.Join("", newCodex.Where(char.IsDigit));
            int valInt = int.Parse(val) + 1;
            string fnlCode = "CA" + valInt.ToString();
            txtMaCa.Text = fnlCode;*/
        }         private void btnThem_Click(object sender, EventArgs e)         {             CaLamDTO ob = checkData();             if (ob != null)             {                 if (checkDuplicate() == 1)                 {                     MessageBox.Show("Mã Ca Làm Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     txtMaCa.Focus();                     return;                 }                 else                 {                     B_CaLam.saveCaLam(ob, sys.INSERT);                     MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_CaLam.GetAllCaLam();                     dgvCaLam.DataSource = dt;                     clearTxt();                 }             }         }          private void btnSua_Click(object sender, EventArgs e)         {             if (checkDuplicate() == 2)             {                 MessageBox.Show("Không Có Mã Ca Làm Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCa.Text = "";                 return;             }             else             {                 CaLamDTO ob = checkData();                 if (ob != null)                 {                     B_CaLam.saveCaLam(ob, sys.UPDATE);                     MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_CaLam.GetAllCaLam();                     dgvCaLam.DataSource = B_CaLam.GetAllCaLam();                     clearTxt();                 }             }         }          private void btnXoa_Click(object sender, EventArgs e)         {             if (checkDuplicate() == 2)             {                 MessageBox.Show("Không Có Ca Làm Đó Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCa.Text = "";                 return;             }             else             {                 if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)                 {                     B_CaLam.DeleteCaLam(txtMaCa.Text);                     MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dgvCaLam.DataSource = B_CaLam.GetAllCaLam();                     dt = B_CaLam.GetAllCaLam();                     clearTxt();                 }             }         }         private void dgvCaLam_CellClick(object sender, DataGridViewCellEventArgs e)         {             try             {                 DataGridViewRow row = new DataGridViewRow();                 row = dgvCaLam.Rows[e.RowIndex];                 txtMaCa.Text = row.Cells[0].Value.ToString();                 txtTenCa.Text = row.Cells[1].Value.ToString();             }             catch             {             }         }
        private void dgvCaLam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)         {             if (e.RowIndex == dgvCaLam.Rows.Count - 1)             {                 frmChitietCalamviec f1 = new frmChitietCalamviec();                 Handling.FormHandling.PreventFormMultipleTimes("Ca Làm", f1, "Ca làm việc");             }         }          private void btnIn_Click(object sender, EventArgs e)         {             Handling.ExcelAutomate.automateEx(dgvCaLam, "Thông Tin Các Ca Làm");         }

        private void lblIntoCaLam_Click(object sender, EventArgs e)
        {
            frmChitietCalamviec frm = new frmChitietCalamviec();
            Handling.FormHandling.PreventFormMultipleTimes(frm, "Ca làm việc");
        }

        private void dgvCaLam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvCaLam);
        }
        /* in form handler */
        private CaLamDTO checkData()         {             string ma = txtMaCa.Text;             string ten = txtTenCa.Text;             string z = string.Join("", txtMaCa.Text.Where(char.IsDigit));             if (txtMaCa.Text.Trim().Length == 0)             {                 MessageBox.Show("Bạn Chưa Nhập Mã Ca Làm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCa.Focus();                 return null;             }             else if (txtTenCa.Text.Trim().Length == 0)             {                 MessageBox.Show("Bạn Chưa Nhập Tên Ca Làm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtTenCa.Focus();                 return null;             }             else if (txtMaCa.Text.Contains("CA") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CA\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCa.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"CA\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaCa.Focus();                 return null;
            }             CaLamDTO dto = new CaLamDTO(ma, Handling.FormHandling.formatString(ten));             return dto;         }         public int checkDuplicate() // insert
        {             IEnumerable<DataRow> dtrow = default;             dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaCa") == txtMaCa.Text);             return dtrow.Count() > 0 ? 1 : 2;         }         public void clearTxt()         {             txtMaCa.Text = txtTenCa.Text = "";         }
    } } 