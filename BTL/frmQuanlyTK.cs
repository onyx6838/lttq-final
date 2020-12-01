using Constant;
using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms; using BUS; using DTO;

namespace BTL {     public partial class frmQuanlyTK : Form     {         DataTable dt;         SystemConstant sys = new SystemConstant();         public frmQuanlyTK()         {             InitializeComponent();             frmQuanlyTK_Load(null, null);         }          private void frmQuanlyTK_Load(object sender, EventArgs e)         {             dt = B_User.getAllAccount();
            dgvChitiet.DataSource = dt;         }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UserDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Tên TK trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTK.Focus();
                    return;
                }
                else
                {
                    B_User.saveAccount(ob, sys.INSERT);
                    MessageBox.Show("Them Thanh Cong");
                    dt = B_User.getAllAccount();
                    dgvChitiet.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn TK Đế Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChitiet.Focus();
                return;
            }
            else if (checkDuplicate() == 2)
            {
                MessageBox.Show("TK Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            else if (checkExst() == 2)
            {
                IEnumerable<DataRow> dtrow = default;
                dtrow = dt.AsEnumerable().Where(x => x.Field<int>("id") == int.Parse(txtID.Text));
                DataTable ss = dtrow.CopyToDataTable();
                List<UserDTO> listUs = Handling.InstanceHandling.ConvertDataTable<UserDTO>(ss);
                var dto = listUs.First();
                MessageBox.Show("Đang Sửa TK " + dto.userName + " Mà", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return;
            }
            else
            {
                UserDTO ob = checkData();
                if (ob != null)
                {
                    B_User.updateAccount(ob, int.Parse(txtID.Text), sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_User.getAllAccount();
                    dgvChitiet.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn TK Đế Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvChitiet.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xóa không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_User.deleteAccount(int.Parse(txtID.Text));
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvChitiet.DataSource = B_User.getAllAccount();
                    dt = B_User.getAllAccount();
                    clearTxt();
                }
            }
        }
        private void dgvChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvChitiet.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenTK.Text = row.Cells[1].Value.ToString();
                txtMK.Text = row.Cells[2].Value.ToString();
                cbxRole.Text = row.Cells[4].Value.ToString();
            }
            catch { }
        }
        private void dgvChitiet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvChitiet);
        }
        /* in form handler*/
        private UserDTO checkData()
        {
            string ma = txtMK.Text;
            string ten = txtTenTK.Text;
            string role = cbxRole.Text;
            if (txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return null;
            }
            else if (txtTenTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTK.Focus();
                return null;
            }
            else if (cbxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa Chọn Role", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxRole.Focus();
                return null;
            }
            UserDTO dto = new UserDTO(ten, ma, 1, int.Parse(role));
            return dto;
        }
        public void clearTxt()
        {
            txtMK.Text = txtTenTK.Text = "";
            cbxRole.SelectedIndex = -1;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("userName") == txtTenTK.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public int checkExst()
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("userName") == txtTenTK.Text
            && x.Field<int>("id") == int.Parse(txtID.Text));
            return dtrow.Count() > 0 ? 1 : 2;
        }
    } } 