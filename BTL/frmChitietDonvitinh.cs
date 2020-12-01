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
    public partial class frmChitietDonvitinh : Form
    {
        SystemConstant sys = new SystemConstant();
        DataTable dt;
        public frmChitietDonvitinh()
        {
            InitializeComponent();
            frmChitietDonvitinh_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);
        }

        private void frmChitietDonvitinh_Load(object sender, EventArgs e)
        {
            dt = B_DonViTinh.GetAllDVT();
            dgvDonViTinh.DataSource = dt;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaDonVi", "DV");
            txtMaDonVi.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DonViTinhDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Mã Đơn Vị Tính Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDonVi.Focus();
                    return;
                }
                else
                {
                    B_DonViTinh.saveDVT(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_DonViTinh.GetAllDVT();
                    dgvDonViTinh.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDonVi.Text = "";
                return;
            }
            else
            {
                DonViTinhDTO ob = checkData();
                if (ob != null)
                {
                    B_DonViTinh.saveDVT(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_DonViTinh.GetAllDVT();
                    dgvDonViTinh.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDonVi.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_DonViTinh.DeleteDVT(txtMaDonVi.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDonViTinh.DataSource = B_DonViTinh.GetAllDVT();
                    dt = B_DonViTinh.GetAllDVT();
                    clearTxt();
                }
            }
        }

        private void dgvDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDonViTinh.Rows[e.RowIndex];
                txtMaDonVi.Text = row.Cells[0].Value.ToString();
                txtTenDonVi.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }
        private void dgvDonViTinh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvDonViTinh.Rows.Count - 1)
            {
                frmChitietDonvitinh f1 = new frmChitietDonvitinh();
                Handling.FormHandling.PreventFormMultipleTimes("Đơn Vị Tính", f1, "Đơn vị tính");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvDonViTinh, "Thông Tin Đơn Vị Tính");
        }

        private void lblIntoDonViTinh_Click(object sender, EventArgs e)
        {
            frmChitietDonvitinh f1 = new frmChitietDonvitinh();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Đơn vị tính");
        }

        private void dgvDonViTinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvDonViTinh);
        }
        /* in form*/
        public void clearTxt()
        {
            txtMaDonVi.Text = txtTenDonVi.Text = "";
        }
        private DonViTinhDTO checkData()
        {
            string ma = txtMaDonVi.Text;
            string ten = txtTenDonVi.Text;
            string z = string.Join("", txtMaDonVi.Text.Where(char.IsDigit));
            if (txtMaDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Đơn Vị Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDonVi.Focus();
                return null;
            }
            else if (txtTenDonVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Đơn Vị Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDonVi.Focus();
                return null;
            }
            else if (txtMaDonVi.Text.Contains("DV") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"DV\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaDonVi.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"DV\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaDonVi.Focus();                 return null;
            }
            DonViTinhDTO dto = new DonViTinhDTO(ma, Handling.FormHandling.formatString(ten));
            return dto;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaDonVi") == txtMaDonVi.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
    }
}
