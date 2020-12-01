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
    public partial class frmChitietNoisanxuat : Form
    {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietNoisanxuat()
        {
            InitializeComponent();
            frmChitietNoisanxuat_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietNoisanxuat_Load(object sender, EventArgs e)
        {
            dt = B_NoiSX.GetAllNSX();
            dgvNoiSX.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaNoiSX", "NSX");
            txtMaNoiSX.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NoiSXDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicated() == 1)
                {
                    MessageBox.Show("Mã Nơi Sản Xuất Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNoiSX.Focus();
                    return;
                }
                else
                {
                    B_NoiSX.saveNSX(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NoiSX.GetAllNSX();
                    dgvNoiSX.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNoiSX.Text = "";
                return;
            }
            else
            {
                NoiSXDTO ob = checkData();
                if (ob != null)
                {
                    B_NoiSX.saveNSX(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_NoiSX.GetAllNSX();
                    dgvNoiSX.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicated() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNoiSX.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_NoiSX.DeleteNSX(txtMaNoiSX.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNoiSX.DataSource = B_NoiSX.GetAllNSX();
                    dt = B_NoiSX.GetAllNSX();
                    clearTxt();
                }
            }
        }

        private void dgvNoiSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNoiSX.Rows[e.RowIndex];
                txtMaNoiSX.Text = row.Cells[0].Value.ToString();
                txtTenNoiSX.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
        private void dgvNoiSX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvNoiSX.Rows.Count - 1)
            {
                frmChitietNoisanxuat f1 = new frmChitietNoisanxuat();
                Handling.FormHandling.PreventFormMultipleTimes("Nơi Sản Xuất", f1, "Nơi sản xuất");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvNoiSX, "Thông Tin Nơi Sản Xuất");
        }

        private void lblIntoNoiSX_Click(object sender, EventArgs e)
        {
            frmChitietNoisanxuat f1 = new frmChitietNoisanxuat();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Nơi sản xuất");
        }

        private void dgvNoiSX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvNoiSX);
        }
        /* in form*/
        private NoiSXDTO checkData()
        {
            string ma = txtMaNoiSX.Text;
            string ten = txtTenNoiSX.Text;
            string z = string.Join("", txtMaNoiSX.Text.Where(char.IsDigit));
            if (txtMaNoiSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Nơi Sản Xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNoiSX.Focus();
                return null;
            }
            else if (txtTenNoiSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Nơi Sản Xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNoiSX.Focus();
                return null;
            }
            else if (txtMaNoiSX.Text.Contains("NSX") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NSX\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNoiSX.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"NSX\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaNoiSX.Focus();                 return null;
            }
            NoiSXDTO dto = new NoiSXDTO(ma, ten);
            return dto;
        }
        public int checkDuplicated() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaNoiSX") == txtMaNoiSX.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaNoiSX.Text = txtTenNoiSX.Text = "";
        }
    }
}
