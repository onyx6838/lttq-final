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

namespace BTL
{
    public partial class frmNhapHang : Form
    {
        List<CTHDNDTO> cthdnList = new List<CTHDNDTO>();
        SystemConstant sys = new SystemConstant();
        public frmNhapHang()
        {
            InitializeComponent();
            frmNhapHang_Load(null, null);
            Handling.FormHandling.clearBorderGroupBox(groupBox1);
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            DataTable cthdn = B_HDNhap.GetAllHDNhap();
            dgvHDN.DataSource = cthdn;
            DataTable t = B_NCC.GetAllNCC();
            FillCbo(t, cbxMaNCC, "MaNCC", "TenNCC");
            DataTable ts = B_NhanVien.GetAllNhanVien();
            FillCbo(ts, cbxMaNV, "MaNV", "TenNV");
            DataTable hang = B_HangHoa.GetAllHangHoa();
            FillCbo(hang, cbxHang, "MaHang", "TenHangHoa");
            txtTongTien.Text = "0";
            txtThanhTien.Enabled = false;
            turnOffBtnUnder(false);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            turnOffBtnUnder(true);
            if (cthdnList.Count != 0)
            {
                DialogResult kq = MessageBox.Show("Hủy Đơn ?", "Thong bao", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes) cthdnList.Clear();
                else return;
            }
            txtSoHDN.Text = TimeHandling.CreateKey("HDN");
            loadTempTable(cthdnList);
            clrCbx();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThemVaoKho_Click(object sender, EventArgs e)
        {
            CTHDNDTO ob = checkDataGioHang();
            if (ob != null)
            {
                if (checkDuplicate() == true)
                {
                    MessageBox.Show("Chọn Hàng Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clrHang();
                    return;
                }
                else
                {
                    cthdnList.Add(ob);
                    loadTempTable(cthdnList);
                    tinhTongTien(cthdnList, txtTongTien);
                    clrHang();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Nhập Vào Kho Hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HDNhapDTO ob = checkDataHDN();
                if (ob != null)
                {
                    if (cthdnList.Count == 0)
                    {
                        MessageBox.Show("Phải Có Hàng Hóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxHang.Focus();
                        return;
                    }
                    else
                    {
                        B_HDNhap.saveHDN(ob, sys.INSERT);
                        foreach (CTHDNDTO cthdn in cthdnList)
                        {
                            B_CTHDN.saveCTHDN(cthdn, sys.INSERT);
                        }
                        MessageBox.Show("Tuyệt Vời", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cthdnList.Clear();
                        loadTempTable(cthdnList);
                        dgvHDN.DataSource = B_HDNhap.GetAllHDNhap();
                        clrHang();
                        clrHD();
                        clrCbx();
                        turnOffBtnUnder(false);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbxHang.Text == "") return;
            else if (MessageBox.Show("Muốn Sửa đồ này trong giỏ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int newSoLuong = int.Parse(txtSoLuong.Text);
                int giamGia = int.Parse(txtGiamGia.Text);
                var obj = cthdnList.FirstOrDefault(cthdn => cthdn.MaHang1 == cbxHang.SelectedValue.ToString());
                if (obj != null)
                {
                    obj.SoLuong1 = newSoLuong;
                    obj.GiamGia1 = giamGia;
                    obj.ThanhTien1 = int.Parse(txtThanhTien.Text);
                    MessageBox.Show("Sửa Số Lượng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tinhTongTien(cthdnList, txtTongTien);
                    loadTempTable(cthdnList);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxHang.Text == "") return;
            else if (MessageBox.Show("Muốn xóa đồ này trong giỏ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var item = cthdnList.Single(cthdn => cthdn.MaHang1 == cbxHang.SelectedValue.ToString());
                if (item != null)
                {
                    cthdnList.Remove(item);
                    MessageBox.Show("Xóa Thành Công Món Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tinhTongTien(cthdnList, txtTongTien);
                    clrHang();
                    loadTempTable(cthdnList);
                }
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int thanhTien, soLuong, donGia, giamGia;
            if (txtSoLuong.Text == "")
                soLuong = 0;
            else
                soLuong = int.Parse(txtSoLuong.Text);

            if (txtGiamGia.Text == "")
                giamGia = 0;
            else
                giamGia = int.Parse(txtGiamGia.Text);

            if (txtDonGia.Text == "")
                donGia = 0;
            else
                donGia = int.Parse(txtDonGia.Text);
            thanhTien = soLuong * donGia - soLuong * donGia * giamGia / 100;
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            int thanhTien, soLuong, donGia, giamGia;
            if (txtSoLuong.Text == "")
                soLuong = 0;
            else
                soLuong = int.Parse(txtSoLuong.Text);

            if (txtGiamGia.Text == "")
                giamGia = 0;
            else
                giamGia = int.Parse(txtGiamGia.Text);

            if (txtDonGia.Text == "")
                donGia = 0;
            else
                donGia = int.Parse(txtDonGia.Text);
            thanhTien = soLuong * donGia - soLuong * donGia * giamGia / 100;
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void cbxHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable hangDT = B_HangHoa.GetAllHangHoa();
            AddMultipleColumn(hangDT, "NameAndCode", "MaHang", "TenHangHoa");
            KeyToValueOfText(hangDT, cbxHang, "NameAndCode", "TenHangHoa", "DonGiaNhap", txtTenHang, txtDonGia);
        }

        private void intoCTHDN(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string arg = dgvHDN.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoHDN.Text = arg;
                cbxMaNV.SelectedValue = dgvHDN.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayNhap.Text = dgvHDN.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbxMaNCC.SelectedValue = dgvHDN.Rows[e.RowIndex].Cells[3].Value.ToString();
                DataTable cthdngg = B_CTHDN.GetInfoHangHoa(arg);
                dgvHDN.DataSource = cthdngg;
            }
            catch
            {
            }
        }

        private void backHDN(object sender, DataGridViewCellEventArgs e)
        {
            if (cthdnList.Count != 0)
            {
                try
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvHDN.Rows[e.RowIndex];
                    cbxHang.Text = row.Cells[0].Value.ToString();
                    txtTenHang.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();
                    txtDonGia.Text = row.Cells[3].Value.ToString();
                    txtGiamGia.Text = row.Cells[4].Value.ToString();
                    txtThanhTien.Text = row.Cells[5].Value.ToString();
                }
                catch
                {
                }
            }
            if (e.RowIndex == dgvHDN.Rows.Count - 1)
            {
                DialogResult kq = MessageBox.Show("Hủy Đơn ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    cthdnList.Clear();
                    dgvHDN.DataSource = B_HDNhap.GetAllHDNhap();
                    cbxMaNCC.SelectedIndex = cbxMaNV.SelectedIndex = -1;
                    dtpNgayNhap.Value = DateTime.Now;
                    clrCbx();
                    clrHD();
                    clrHang();
                    turnOffBtnUnder(false);
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            blockInputNotNumText(e);
            int i;
            txtSoLuong.Text = false == int.TryParse(txtSoLuong.Text, out i) || 0 > i || i > 1E+6 ? "" : i.ToString();
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            blockInputNotNumText(e);
            int i;
            txtGiamGia.Text = false == int.TryParse(txtGiamGia.Text, out i) || 0 > i || i > 10 ? "" : i.ToString();
        }
        public void blockInputNotNumText(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtSoHDN.Text == "")
            {
                MessageBox.Show("Chưa Có Thông Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (B_HDNhap.GetBillNhap(txtSoHDN.Text).Rows.Count == 0)
            {
                MessageBox.Show("Chưa Có Thông Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ExcelAutomate.automateHD
                (B_HDNhap.GetBillNhap(txtSoHDN.Text), B_HDNhap.XuatMatHangHDN(txtSoHDN.Text)
                , "HÓA ĐƠN NHẬP", "Nhà Cung Cấp");
            }
        }

        private void dgvHDN_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvHDN);
        }
        /* in form handler*/
        private CTHDNDTO checkDataGioHang()
        {
            string soHDN = txtSoHDN.Text;
            string maHang = cbxHang.Text;
            string soLuong = txtSoLuong.Text;
            string donGia = txtDonGia.Text;
            string giamGia = txtGiamGia.Text;
            string thanhTien = txtThanhTien.Text;
            string tenHang = txtTenHang.Text;
            if (cbxHang.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Hàng Muốn Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return null;
            }
            else if (txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Giảm Giá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return null;
            }
            maHang = cbxHang.SelectedValue.ToString();
            CTHDNDTO dto = new CTHDNDTO(soHDN, maHang,
                int.Parse(soLuong), int.Parse(donGia), int.Parse(giamGia), int.Parse(thanhTien), tenHang);
            return dto;
        }
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
        public void tinhTongTien(List<CTHDNDTO> lst, TextBox txt)
        {
            int tong = 0;
            foreach (CTHDNDTO cth in lst)
            {
                tong += cth.ThanhTien1;
            }
            txt.Text = tong.ToString();
            lblTongTienChu.Text = FormHandling.ChuyenSoSangChuoi(tong);
        }
        public bool checkDuplicate()
        {
            bool check = cthdnList.Any(x => x.MaHang1 == cbxHang.SelectedValue.ToString());
            return check;
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
        public void KeyToValueOfText(DataTable dt, ComboBox cbxKey, string key, string value, string value1, TextBox txtValue, TextBox txtValue1)
        {
            if (cbxKey.SelectedIndex == -1) txtValue.Text = txtValue1.Text = "";
            //txtValue.Text = txtValue1.Text = "";
            string name = cbxKey.Text;
            foreach (DataRow row in dt.Rows)
            {
                if (row[key].ToString() == name)
                {
                    txtValue.Text = row[value].ToString();
                    txtValue1.Text = row[value1].ToString();
                }
            }
        }
        public void turnOffBtnUnder(bool OnOrOff)
        {
            btnXoa.Enabled = OnOrOff;
            btnSua.Enabled = OnOrOff;
            btnTinhtien.Enabled = OnOrOff;
            btnThemVaoKho.Enabled = OnOrOff;
        }
        public void clrHD()
        {
            txtSoHDN.Text = "";
            dtpNgayNhap.Text = "";
        }
        public void clrHang()
        {
            cbxHang.Text = "";
            txtSoLuong.Text = txtTenHang.Text = txtGiamGia.Text = txtDonGia.Text = txtThanhTien.Text = "";
        }
        public void clrCbx()
        {
            cbxMaNCC.SelectedIndex = cbxMaNV.SelectedIndex = -1;
        }
        public void loadTempTable(List<CTHDNDTO> ctnLst)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã hàng", typeof(string));
            table.Columns.Add("Tên hàng", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Đơn giá", typeof(int));
            table.Columns.Add("Giảm giá %", typeof(int));
            table.Columns.Add("Thành tiền", typeof(int));

            foreach (CTHDNDTO item in ctnLst)
            {
                DataRow row = table.NewRow();
                row["Mã hàng"] = item.MaHang1;
                row["Tên hàng"] = item.TenHang;
                row["Số lượng"] = item.SoLuong1;
                row["Đơn giá"] = (decimal)item.DonGia1;
                row["Giảm giá %"] = item.GiamGia1;
                row["Thành tiền"] = item.ThanhTien1;
                table.Rows.Add(row);
            }
            dgvHDN.DataSource = table;
        }
    }
}
