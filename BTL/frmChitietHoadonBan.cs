using BUS;
using Constant;
using DTO;
using Handling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmChitietHDB : Form
    {
        DataTable dt;
        SystemConstant sys = new SystemConstant();
        public frmChitietHDB()
        {
            InitializeComponent();
            frmChitietHDB_Load(null, null);
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietHDB_Load(object sender, EventArgs e)
        {
            DataTable cthdb = B_HDBan.GetAllHDBan();
            dgvHDB.DataSource = cthdb;
            dt = cthdb;
            DataTable t = B_KhachHang.GetAllKhachHang();
            FillCbo(t, cbxMaKH, "MaKhach", "TenKhach");
            DataTable ts = B_NhanVien.GetAllNhanVien();
            FillCbo(ts, cbxMaNV, "MaNV", "TenNV");
            //btnXoa.Enabled = false;
            txtTongTien.Enabled = false;
        }
        private void lblIntoHDB_Click(object sender, EventArgs e)
        {
            frmChitietHDB frm = new frmChitietHDB();
            Handling.FormHandling.PreventFormMultipleTimes(frm, "Hóa đơn bán");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HDBanDTO ob = checkDataHDB();             if (ob != null)             {                 if (DuplicatedOrNone() == 1)                 {                     MessageBox.Show("Số Hóa Đơn Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     txtSoHDB.Focus();                     return;                 }                 else                 {                     B_HDBan.saveHDB(ob, sys.INSERT);                     MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_HDBan.GetAllHDBan();                     dgvHDB.DataSource = dt;                 }             }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (DuplicatedOrNone() == 2)             {                 MessageBox.Show("Không Có Số Hóa Đơn Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtSoHDB.Text = "";                 return;             }             else             {                 HDBanDTO ob = checkDataHDB();                 if (ob != null)                 {                     B_HDBan.saveHDB(ob, sys.UPDATE);                     MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                     dt = B_HDBan.GetAllHDBan();                     dgvHDB.DataSource = dt;                 }             }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DuplicatedOrNone() == 2)             {                 MessageBox.Show("Không Có Số Hóa Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtSoHDB.Text = "";                 return;             }             else             {                 B_HDBan.DeleteHDBan(txtSoHDB.Text);                 MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 dt = B_HDBan.GetAllHDBan();
                dgvHDB.DataSource = dt;             }
        }
        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHDB.Rows[e.RowIndex];
                txtSoHDB.Text = row.Cells[0].Value.ToString();
                cbxMaNV.SelectedValue = row.Cells[1].Value.ToString();
                dtpNgayBan.Text = row.Cells[2].Value.ToString();
                cbxMaKH.SelectedValue = row.Cells[3].Value.ToString();
                txtTongTien.Text = row.Cells[4].Value.ToString();
                lblTongTien.Text = FormHandling.ChuyenSoSangChuoi(double.Parse(row.Cells[4].Value.ToString()));
            }
            catch
            {
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvHDB, "Thông Tin Các Hóa Đơn Bán");
        }

        private void dgvHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvHDB.Rows.Count - 1)             {                 frmChitietHDB f1 = new frmChitietHDB();                 Handling.FormHandling.PreventFormMultipleTimes("Các Hóa Đơn Bán", f1, "Hóa đơn bán");             }
        }
        private void dgvHDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvHDB);
        }
        /* In Form handler*/
        public int DuplicatedOrNone() // insert,update
        {             IEnumerable<DataRow> dtrow = default;             dtrow = dt.AsEnumerable().Where(x => x.Field<string>("SoHDB") == txtSoHDB.Text);             return dtrow.Count() > 0 ? 1 : 2;         }
        private HDBanDTO checkDataHDB()
        {
            string soHDB = txtSoHDB.Text;
            DateTime ngayNhap = dtpNgayBan.Value;
            string maNV = cbxMaNV.Text;
            string maKH = cbxMaKH.Text;
            string tongTien = txtTongTien.Text;
            if (cbxMaNV.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNV.Focus();
                return null;
            }
            else if (cbxMaKH.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Khách Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaKH.Focus();
                return null;
            }
            maNV = cbxMaNV.SelectedValue.ToString();
            maKH = cbxMaKH.SelectedValue.ToString();
            HDBanDTO dto = new HDBanDTO(soHDB, maNV, ngayNhap, maKH, int.Parse(tongTien));
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
