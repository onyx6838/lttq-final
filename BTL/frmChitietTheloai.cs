using BUS;
using Constant;
using DTO;
using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;  namespace BTL {     public partial class frmChitietTheloai : Form     {
        static SystemConstant sys = new SystemConstant();
        DataTable dt;         public frmChitietTheloai()         {             InitializeComponent();
            frmChitietTheloai_Load(null, null);
            if (frmLogin.session.role == 2)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            }             Handling.FormHandling.clearBorderGroupBox(gbxChitiet);             Handling.FormHandling.clearBorderGroupBox(gbxChucnang);         }          private void frmChitietTheloai_Load(object sender, EventArgs e)         {             DataTable dtx = B_TheLoai.GetAllTL();
            dgvTheLoai.DataSource = dtx;
            dt = dtx;
            DataTable nh = B_NhomHang.GetAllNhomHang();
            FillCbo(nh, cbxMaNhom, "MaNhom", "TenNhom");         }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string newCode = Handling.InstanceHandling.AutoCreateKey(dt, "MaLoai", "ML");
            txtMaTheLoai.Text = newCode;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoaiDTO ob = checkData();
            if (ob != null)
            {
                if (checkDuplicate() == 1)
                {
                    MessageBox.Show("Mã Thể Loại Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaTheLoai.Focus();
                    return;
                }
                else
                {
                    B_TheLoai.saveTL(ob, sys.INSERT);
                    MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_TheLoai.GetAllTL();
                    dgvTheLoai.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTheLoai.Text = "";
                return;
            }
            else
            {
                TheLoaiDTO ob = checkData();
                if (ob != null)
                {
                    B_TheLoai.saveTL(ob, sys.UPDATE);
                    MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt = B_TheLoai.GetAllTL();
                    dgvTheLoai.DataSource = dt;
                    clearTxt();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkDuplicate() == 2)
            {
                MessageBox.Show("Không Có Mã Đó Để Thay Đổi Liên Quan", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTheLoai.Text = "";
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Xóa Không ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    B_TheLoai.DeleteTL(txtMaTheLoai.Text);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTheLoai.DataSource = B_TheLoai.GetAllTL();
                    dt = B_TheLoai.GetAllTL();
                    clearTxt();
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Handling.ExcelAutomate.automateEx(dgvTheLoai, "Thông Tin Thể Loại");
        }

        private void dgvChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTheLoai.Rows[e.RowIndex];
                txtMaTheLoai.Text = row.Cells[0].Value.ToString();
                txtTenTheLoai.Text = row.Cells[2].Value.ToString();
                cbxMaNhom.SelectedValue = row.Cells[1].Value.ToString();
            }
            catch
            {
            }
        }

        private void dgvChitiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvTheLoai.Rows.Count - 1)
            {
                frmChitietTheloai f1 = new frmChitietTheloai();
                Handling.FormHandling.PreventFormMultipleTimes("Thể Loại", f1, "Thể loại");
            }
        }
        private void lblIntoTheLoai_Click(object sender, EventArgs e)
        {
            frmChitietTheloai f1 = new frmChitietTheloai();
            Handling.FormHandling.PreventFormMultipleTimes(f1, "Thể loại");
        }
        private void dgvTheLoai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvTheLoai);
        }
        /* in form handler */
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
        private TheLoaiDTO checkData()
        {
            string ma = txtMaTheLoai.Text;
            string ten = txtTenTheLoai.Text;
            string nhom;
            string z = string.Join("", txtMaTheLoai.Text.Where(char.IsDigit));
            if (txtMaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Thể Loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTheLoai.Focus();
                return null;
            }
            else if (txtTenTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Thể Loại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTheLoai.Focus();
                return null;
            }
            else if (cbxMaNhom.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaNhom.Focus();
                return null;
            }
            else if (txtMaTheLoai.Text.Contains("ML") == false)
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"ML\"", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaTheLoai.Focus();                 return null;
            }             else if (z == "")
            {
                MessageBox.Show("Nhập Theo Định Dạng Là \"ML\" và Thêm Số Đằng Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                 txtMaTheLoai.Focus();                 return null;
            }
            nhom = cbxMaNhom.SelectedValue.ToString();
            TheLoaiDTO dto = new TheLoaiDTO(ma, nhom, ten);
            return dto;
        }
        public int checkDuplicate() // insert
        {
            IEnumerable<DataRow> dtrow = default;
            dtrow = dt.AsEnumerable().Where(x => x.Field<string>("MaLoai") == txtMaTheLoai.Text);
            return dtrow.Count() > 0 ? 1 : 2;
        }
        public void clearTxt()
        {
            txtMaTheLoai.Text = txtTenTheLoai.Text = "";
            cbxMaNhom.SelectedIndex = -1;
        }
    } } 