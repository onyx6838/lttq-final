using BUS;
using Constant;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmChitietNhanvien : Form
    {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietNhanvien()
        {
            InitializeComponent();
            frmChitietNhanvien_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietNhanvien_Load(object sender, EventArgs e)
        {
            DataTable dtx = B_NhanVien.GetAllNhanVien();
            dt = dtx;
            dgvNhanVien.DataSource = dtx;
            DataTable nhom = B_NhomHang.GetAllNhomHang();
            FillCbo(nhom, cbxNhom, "MaNhom", "TenNhom");
            DataTable ca = B_CaLam.GetAllCaLam();
            FillCbo(ca, cbxCa, "MaCa", "TenCa");
            DataTable cv = B_CongViec.GetAllCV();
            FillCbo(cv, cbxCV, "MaCV", "TenCV");
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaNV", "NV");
            txtMaNhanVien.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVienDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicated() == 1)
                {
                    MessageBox.Show("Mã NV Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNhanVien.Focus();
                    return;
                }
                else
                {
                    B_NhanVien.saveNV(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NhanVien.GetAllNhanVien();
                    dgvNhanVien.DataSource = dt;
                    clearTxt();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Text = "";
                return;
            }
            else
            {
                NhanVienDTO ob = checkData();
                if (ob != null)
                {
                    B_NhanVien.saveNV(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NhanVien.GetAllNhanVien();
                    dgvNhanVien.DataSource = dt;
                    clearTxt();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_NhanVien.DeleteNhanVien(txtMaNhanVien.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = B_NhanVien.GetAllNhanVien();
                    dt = B_NhanVien.GetAllNhanVien();
                    clearTxt();
                }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rdxMale.Checked = true;
                }
                else if (row.Cells[2].Value.ToString() == "Nữ")
                {
                    rdxFemale.Checked = true;
                }
                dtpNgaySinh.Text = row.Cells[3].Value.ToString();
                mtbDienThoai.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                cbxNhom.SelectedValue = row.Cells[6].Value.ToString();
                cbxCa.SelectedValue = row.Cells[7].Value.ToString();
                cbxCV.SelectedValue = row.Cells[8].Value.ToString();
            }
            catch
            {
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvNhanVien.Rows.Count - 1)
            {
                frmChitietNhanvien f1 = new frmChitietNhanvien();
                Handling.FormHandling.PreventFormMultipleTimes("Nhân Viên", f1, "Nhân viên");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvNhanVien, "Thông Tin Các Nhân Viên");
        }

        private void lblIntoNV_Click(object sender, EventArgs e)
        {
            frmChitietNhanvien f1 = new frmChitietNhanvien();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Nhân viên");
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvNhanVien);
        }
        /* in form handler */
        private NhanVienDTO checkData()
        {
            Regex phoneNumberRegex = new Regex(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            string ma = txtMaNhanVien.Text;
            string ten = txtTenNhanVien.Text;
            string gioiTinh = "";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string dienThoai = mtbDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string maNhom = cbxNhom.Text;
            string maCa = cbxCa.Text;
            string maCV = cbxCV.Text;
            string z = string.Join("", txtMaNhanVien.Text.Where(char.IsDigit));
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return null;
            }
            else if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return null;
            }
            else if (mtbDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return null;
            }
            else if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Địa Chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return null;
            }
            else if (rdxMale.Checked == false && rdxFemale.Checked == false)
            {
                MessageBox.Show("Bạn Chưa Chọn Giới Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return null;
            }
            else if (cbxNhom.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxNhom.Focus();
                return null;
            }
            else if (cbxCa.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCa.Focus();
                return null;
            }
            else if (cbxCV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn CV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCV.Focus();
                return null;
            }
            else if (phoneNumberRegex.IsMatch(mtbDienThoai.Text) == false)
            {
                MessageBox.Show("Sai Định Dạng SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return null;
            }
            else if (txtMaNhanVien.Text.Contains("NV") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NV\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNhanVien.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NV\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNhanVien.Focus();                 return null;
            }
            // sex
            if (rdxMale.Checked == true)
            {
                gioiTinh = "nam";
            }
            else if (rdxFemale.Checked == true)
            {
                gioiTinh = "Nữ";
            }
            maNhom = cbxNhom.SelectedValue.ToString();
            maCa = cbxCa.SelectedValue.ToString();
            maCV = cbxCV.SelectedValue.ToString();
            NhanVienDTO dto = new NhanVienDTO(ma, Handling.FormHandling.formatString(ten), gioiTinh, ngaySinh, dienThoai, diaChi, maNhom, maCa, maCV);
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
        public int checkDuplicated() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaNV") == txtMaNhanVien.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaNhanVien.Text = txtTenNhanVien.Text = "";
            mtbDienThoai.Text = txtDiaChi.Text = "";
            rdxMale.Checked = rdxFemale.Checked = false;
            cbxNhom.SelectedIndex = cbxCa.SelectedIndex = cbxCV.SelectedIndex = -1;
        }
    }
}
