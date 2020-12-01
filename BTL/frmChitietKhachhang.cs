using BUS;
using Constant;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmChitietKhachhang : Form
    {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietKhachhang()
        {
            InitializeComponent();
            frmChitietKhachhang_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietKhachhang_Load(object sender, EventArgs e)
        {
            dt = B_KhachHang.GetAllKhachHang();
            dgvKhachHang.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaKhach", "KH");
            txtMaKhachHang.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicated() == 1)
                {
                    MessageBox.Show("Mã KH trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhachHang.Focus();
                    return;
                }
                else
                {
                    B_KhachHang.saveKH(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_KhachHang.GetAllKhachHang();
                    dgvKhachHang.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Text = "";
                return;
            }
            else
            {
                KhachHangDTO ob = checkData();
                if (ob != null)
                {
                    B_KhachHang.saveKH(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_KhachHang.GetAllKhachHang();
                    dgvKhachHang.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_KhachHang.DeleteKhachHang(txtMaKhachHang.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhachHang.DataSource = B_KhachHang.GetAllKhachHang();
                    dt = B_KhachHang.GetAllKhachHang();
                    clearTxt();
                }
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                mtbDienThoai.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvKhachHang.Rows.Count - 1)
            {
                frmChitietKhachhang f1 = new frmChitietKhachhang();
                Handling.FormHandling.PreventFormMultipleTimes("Khách Hàng", f1, "Khách hàng");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvKhachHang, "Thông Tin Các Khách Hàng");
        }

        private void lblIntoKhachHang_Click(object sender, EventArgs e)
        {
            frmChitietKhachhang f1 = new frmChitietKhachhang();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Khách hàng");
        }

        private void dgvKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvKhachHang);
        }
        /* in form*/
        private KhachHangDTO checkData()
        {
            string ma = txtMaKhachHang.Text;
            string ten = txtTenKhachHang.Text;
            string diaChi = txtDiaChi.Text;
            string SDT = mtbDienThoai.Text;
            string z = string.Join("", txtMaKhachHang.Text.Where(char.IsDigit));
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã KH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return null;
            }
            else if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên KH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus();
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
            else if (txtMaKhachHang.Text.Contains("KH") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"KH\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaKhachHang.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"KH\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaKhachHang.Focus();                 return null;
            }
            KhachHangDTO dto = new KhachHangDTO(ma, Handling.FormHandling.formatString(ten), diaChi, SDT);
            return dto;
        }
        public int checkDuplicated() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaKhach") == txtMaKhachHang.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaKhachHang.Text = txtTenKhachHang.Text = "";
            txtDiaChi.Text = mtbDienThoai.Text = "";
        }

    }
}
