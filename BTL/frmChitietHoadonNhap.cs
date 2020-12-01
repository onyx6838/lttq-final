using BUS;
using Constant;
using DTO;
using Handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Properties
{
    public partial class frmChitietHDN : Form
    {
        DataTable dt;
        SystemConstant sys = new SystemConstant();
        public frmChitietHDN()
        {
            InitializeComponent();
            frmChitietHDN_Load(null, null);
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }
        private void lblIntoHDN_Click(object sender, EventArgs e)
        {
            frmChitietHDN frm = new frmChitietHDN();
            Handling.FormHandling.PreventFormMultipleTimes(frm, "Hóa đơn nhập");
        }
        private void frmChitietHDN_Load(object sender, EventArgs e)
        {
            DataTable cthdn = B_HDNhap.GetAllHDNhap();
            dt = cthdn;
            dgvHDN.DataSource = cthdn;
            DataTable t = B_NCC.GetAllNCC();
            FillCbo(t, cbxMaNCC, "MaNCC", "TenNCC");
            DataTable ts = B_NhanVien.GetAllNhanVien();
            FillCbo(ts, cbxMaNV, "MaNV", "TenNV");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HDNhapDTO ob = checkDataHDN();             if (ob != null)             {                 if (DuplicatedOrNone() == 1)                 {                     MessageBox.Show("Số Hóa Đơn Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     txtSoHDN.Focus();                     return;                 }                 else                 {                     B_HDNhap.saveHDN(ob, sys.INSERT);                     MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_HDNhap.GetAllHDNhap();                     dgvHDN.DataSource = dt;                 }             }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DuplicatedOrNone() == 2)             {                 MessageBox.Show("Không Có Số Hóa Đơn Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtSoHDN.Text = "";                 return;             }             else             {                 HDNhapDTO ob = checkDataHDN();                 if (ob != null)                 {                     B_HDNhap.saveHDN(ob, sys.UPDATE);                     MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_HDNhap.GetAllHDNhap();                     dgvHDN.DataSource = dt;                 }             }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DuplicatedOrNone() == 2)             {                 MessageBox.Show("Không Có Số Hóa Đơn Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtSoHDN.Text = "";                 return;             }             else             {                 B_HDNhap.DeleteHDNhap(txtSoHDN.Text);                 MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 dt = B_HDNhap.GetAllHDNhap();
                dgvHDN.DataSource = dt;             }
        }
        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHDN.Rows[e.RowIndex];
                txtSoHDN.Text = row.Cells[0].Value.ToString();
                cbxMaNV.SelectedValue = row.Cells[1].Value.ToString();
                dtpNgayNhap.Text = row.Cells[2].Value.ToString();
                cbxMaNCC.SelectedValue = row.Cells[3].Value.ToString();
                txtTongTien.Text = row.Cells[4].Value.ToString();
                lblTongTienChu.Text = FormHandling.ChuyenSoSangChuoi(double.Parse(row.Cells[4].Value.ToString()));
            }
            catch
            {
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvHDN, "Thông Tin Các Hóa Đơn Nhập");
        }

        private void dgvHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvHDN.Rows.Count - 1)             {                 frmChitietHDN f1 = new frmChitietHDN();                 Handling.FormHandling.PreventFormMultipleTimes("Các Hóa Đơn Nhập", f1, "Hóa đơn nhập");             }
        }
        private void dgvHDN_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvHDN);
        }
        /* In Form Handler*/
        public int DuplicatedOrNone() // insert,update
        {             IEnumerable<DataRow> dtrow = default;             dtrow = dt.AsEnumerable().Where(x => x.Field<string>("SoHDN") == txtSoHDN.Text);             return dtrow.Count() > 0 ? 1 : 2;         }
        private HDNhapDTO checkDataHDN()
        {
            string soHDN = txtSoHDN.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;
            string maNV = cbxMaNV.Text;
            string maNCC = cbxMaNCC.Text;
            string tongTien = txtTongTien.Text;
            if (cbxMaNV.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNV.Focus();
                return null;
            }
            else if (cbxMaNCC.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Nhà Cung Cấp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNCC.Focus();
                return null;
            }
            maNV = cbxMaNV.SelectedValue.ToString();
            maNCC = cbxMaNCC.SelectedValue.ToString();
            HDNhapDTO dto = new HDNhapDTO(soHDN, maNV, ngayNhap, maNCC, int.Parse(tongTien));
            return dto;
        }
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }
        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            string newC = "NameAndCode";
            AddMultipleColumn(t, newC, ma, ten);
            cbo.DataSource = t;
            cbo.ValueMember = ma;
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }
    }
}
