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
    public partial class frmChitietNhacungcap : Form
    {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietNhacungcap()
        {
            InitializeComponent();
            frmChitietNhacungcap_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietNhacungcap_Load(object sender, EventArgs e)
        {
            dt = B_NCC.GetAllNCC();
            dgvNCC.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaNCC", "NCC");
            txtMaNCC.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NCCDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicated() == 1)
                {
                    MessageBox.Show("Mã Nhà Cung Cấp Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNCC.Focus();
                    return;
                }
                else
                {
                    B_NCC.saveNCC(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NCC.GetAllNCC();
                    dgvNCC.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Text = "";
                return;
            }
            else
            {
                NCCDTO ob = checkData();
                if (ob != null)
                {
                    B_NCC.saveNCC(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NCC.GetAllNCC();
                    dgvNCC.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_NCC.DeleteNCC(txtMaNCC.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNCC.DataSource = B_NCC.GetAllNCC();
                    dt = B_NCC.GetAllNCC();
                    clearTxt();
                }
            }
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                mtbDienThoai.Text = row.Cells[3].Value.ToString();
            }
            catch
            {
            }
        }

        private void dgvNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvNCC.Rows.Count - 1)
            {
                frmChitietNhacungcap f1 = new frmChitietNhacungcap();
                Handling.FormHandling.PreventFormMultipleTimes("Nhà Cung Cấp", f1, "Nhà cung cấp");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvNCC, "Thông Tin Các Nhà Cung Cấp");
        }

        private void lblIntoNCC_Click(object sender, EventArgs e)
        {
            frmChitietNhacungcap f1 = new frmChitietNhacungcap();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Nhà cung cấp");
        }

        private void dgvNCC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvNCC);
        }
        /* in form*/
        private NCCDTO checkData()
        {
            string ma = txtMaNCC.Text;
            string ten = txtTenNCC.Text;
            string diaChi = txtDiaChi.Text;
            string SDT = mtbDienThoai.Text;
            string z = string.Join("", txtMaNCC.Text.Where(char.IsDigit));
            if (txtMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã KH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNCC.Focus();
                return null;
            }
            else if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên KH", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
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
            else if (txtMaNCC.Text.Contains("NCC") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NCC\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNCC.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NCC\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNCC.Focus();                 return null;
            }

            NCCDTO dto = new NCCDTO(ma, Handling.FormHandling.formatString(ten), diaChi, SDT);
            return dto;
        }
        public int checkDuplicated() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaNCC") == txtMaNCC.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaNCC.Text = txtTenNCC.Text = "";
            txtDiaChi.Text = mtbDienThoai.Text = "";
        }
    }
}
