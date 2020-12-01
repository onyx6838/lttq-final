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
using System.Runtime.InteropServices;

namespace BTL
{
    public partial class frmBanhang : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        /* placeholder*/
        private int currentLeastAmount = 0;
        List<HangHoaEntity> amountHang = new List<HangHoaEntity>();
        List<CTHDBDTO> cthdbList = new List<CTHDBDTO>();
        SystemConstant sys = new SystemConstant();
        public frmBanhang()
        {
            InitializeComponent();
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);
        }
        private void loadTextBox()
        {
            SendMessage(txtSoLuong.Handle, EM_SETCUEBANNER, 0, "Nhập Số");
            SendMessage(txtGiamGia.Handle, EM_SETCUEBANNER, 0, "Nhập Số");
        }
        private void frmBanhang_Load(object sender, EventArgs e)
        {
            DataTable cthdb = B_HDBan.GetAllHDBan();
            dgvHDB.DataSource = cthdb;
            #region Instance To List
            DataTable amountHangDt = removeHangWithNonePriceAndAmount(B_HangHoa.GetAllHangHoa());
            amountHang = InstanceHandling.ConvertDataTable<HangHoaEntity>(amountHangDt);
            #endregion
            DataTable t = B_KhachHang.GetAllKhachHang();
            FillCbo(t, cbxMaKH, "MaKhach", "TenKhach");
            DataTable ts = B_NhanVien.GetAllNhanVien();
            FillCbo(ts, cbxMaNV, "MaNV", "TenNV");
            DataTable hang = removeHangWithNonePriceAndAmount(B_HangHoa.GetAllHangHoa());
            FillCbo(hang, cbxMaHang, "MaHang", "TenHangHoa");
            txtTongTien.Text = "0";
            txtThanhTien.Enabled = false;
            // setup btn
            turnOffBtnUnder(false);
            //
            loadTextBox();
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            turnOffBtnUnder(true);
            if (cthdbList.Count != 0)
            {
                DialogResult kq = MessageBox.Show("Hủy Đơn ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes) cthdbList.Clear();
                else return;
            }
            txtSoHDB.Text = TimeHandling.CreateKey("HDB");
            loadTempTable(cthdbList);
            clrCbx();
        }
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            CTHDBDTO ob = checkDataGioHang();
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
                    var obj = amountHang.FirstOrDefault(cthdn => cthdn.MaHang == cbxMaHang.SelectedValue.ToString());
                    if (obj != null)
                    {
                        int remain = ob.SoLuong1 - obj.SoLuong;
                        if (remain > 0)
                        {
                            MessageBox.Show("Mặt Hàng " + obj.TenHangHoa + " Chỉ Có " + obj.SoLuong, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSoLuong.Text = "";
                            return;
                        }
                        else
                        {
                            obj.SoLuong -= ob.SoLuong1;
                        }
                    }
                }
                cthdbList.Add(ob);
                loadTempTable(cthdbList);
                tinhTongTien(cthdbList, txtTongTien);
                clrHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbxMaHang.Text == "") return;
            else if (MessageBox.Show("Muốn Sửa Đồ Này Trong Giỏ Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int newSoLuong = int.Parse(txtSoLuong.Text);
                int giamGia = int.Parse(txtGiamGia.Text);
                var objAmount = amountHang.FirstOrDefault(cthdn => cthdn.MaHang == cbxMaHang.SelectedValue.ToString());

                if (currentLeastAmount < newSoLuong)
                {
                    //int remaining = newSoLuong - objAmount.SoLuong;
                    MessageBox.Show("Mặt Hàng " + objAmount.TenHangHoa + " Còn Lại " + currentLeastAmount);
                    txtSoLuong.Text = "";
                    return;
                }
                else
                {
                    currentLeastAmount -= newSoLuong;
                    var obj = cthdbList.FirstOrDefault(cthdn => cthdn.MaHang1 == cbxMaHang.SelectedValue.ToString());
                    if (obj != null)
                    {
                        objAmount.SoLuong = currentLeastAmount;
                        obj.SoLuong1 = newSoLuong;
                        obj.GiamGia1 = giamGia;
                        obj.ThanhTien1 = int.Parse(txtThanhTien.Text);
                        MessageBox.Show("Sửa Số Lượng Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tinhTongTien(cthdbList, txtTongTien);
                        loadTempTable(cthdbList);
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxMaHang.Text == "") return;
            else if (MessageBox.Show("Muốn Xóa Đồ Này Trong Giỏ Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var item = cthdbList.Single(cthdn => cthdn.MaHang1 == cbxMaHang.SelectedValue.ToString());
                if (item != null)
                {
                    var objAmount = amountHang.FirstOrDefault(cthdn => cthdn.MaHang == cbxMaHang.SelectedValue.ToString());
                    objAmount.SoLuong = currentLeastAmount;
                    cthdbList.Remove(item);

                    MessageBox.Show("Xóa Thành Công Món Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tinhTongTien(cthdbList, txtTongTien);
                    clrHang();
                    loadTempTable(cthdbList);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Mua Hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HDBanDTO ob = checkDataHDB();
                if (ob != null)
                {
                    if (cthdbList.Count == 0)
                    {
                        MessageBox.Show("Phải Có Hàng Hóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbxMaHang.Focus();
                        return;
                    }
                    else
                    {
                        B_HDBan.saveHDB(ob, sys.INSERT);
                        foreach (CTHDBDTO cthdb in cthdbList)
                        {
                            B_CTHDB.saveCTHDB(cthdb, sys.INSERT);
                        }
                        MessageBox.Show("Tuyệt Vời", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cthdbList.Clear();
                        loadTempTable(cthdbList);
                        dgvHDB.DataSource = B_HDBan.GetAllHDBan();
                        clrHang();
                        clrHD();
                        clrCbx();
                        turnOffBtnUnder(false);
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtSoHDB.Text == "")
            {
                MessageBox.Show("Chưa Có Thông Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (B_HDBan.GetBillBan(txtSoHDB.Text).Rows.Count == 0)
            {
                MessageBox.Show("Chưa Có Thông Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ExcelAutomate.automateHD
                (B_HDBan.GetBillBan(txtSoHDB.Text), B_HDBan.XuatMatHangHDB(txtSoHDB.Text)
                , "HÓA ĐƠN BÁN", "Khách Hàng");
            }
        }

        private void cbxMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable hangDT = B_HangHoa.GetAllHangHoa();
            AddMultipleColumn(hangDT, "NameAndCode", "MaHang", "TenHangHoa");
            KeyToValueOfText(hangDT, cbxMaHang, "NameAndCode", "TenHangHoa", "DonGiaBan", txtTenHang, txtDonGia);
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

        private void intoCTHDB(object sender, DataGridViewCellEventArgs e)
        {
            if (cthdbList.Count != 0)
            {
                try
                {
                    currentLeastAmount = 0;
                    var obj = amountHang.FirstOrDefault(cthdn => cthdn.MaHang == cbxMaHang.SelectedValue.ToString());
                    currentLeastAmount = obj.SoLuong;
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgvHDB.Rows[e.RowIndex];
                    cbxMaHang.Text = row.Cells[0].Value.ToString();
                    txtTenHang.Text = row.Cells[1].Value.ToString();
                    txtSoLuong.Text = row.Cells[2].Value.ToString();
                    currentLeastAmount += int.Parse(txtSoLuong.Text);

                    txtDonGia.Text = row.Cells[3].Value.ToString();
                    txtGiamGia.Text = row.Cells[4].Value.ToString();
                    txtThanhTien.Text = row.Cells[5].Value.ToString();
                }
                catch
                {
                }
            }
            if (e.RowIndex == dgvHDB.Rows.Count - 1)
            {
                DialogResult kq = MessageBox.Show("Hủy Đơn ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    cthdbList.Clear();
                    currentLeastAmount = 0;
                    dgvHDB.DataSource = B_HDBan.GetAllHDBan();
                    cbxMaKH.SelectedIndex = cbxMaNV.SelectedIndex = -1;
                    dtpNgayBan.Value = DateTime.Now;
                    turnOffBtnUnder(false);
                    clrHang();
                    clrHD();
                    clrCbx();
                }
            }
        }

        private void backHDB(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string arg = dgvHDB.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoHDB.Text = arg;
                cbxMaNV.SelectedValue = dgvHDB.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayBan.Text = dgvHDB.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbxMaKH.SelectedValue = dgvHDB.Rows[e.RowIndex].Cells[3].Value.ToString();
                DataTable cthdngg = B_CTHDB.GetInfoHangHoaHDB(arg);
                dgvHDB.DataSource = cthdngg;
                btnLuu.Enabled = false;
                btnThemVaoGio.Enabled = false;
            }
            catch { }
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
        private void dgvHDB_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvHDB);
        }
        /* In Form handler*/
        public DataTable removeHangWithNonePriceAndAmount(DataTable dt)
        {
            IEnumerable<DataRow> rows = dt.AsEnumerable().Where(r => r["DonGiaNhap"] != DBNull.Value && (int)r["SoLuong"] != 0);
            DataTable rs = rows.CopyToDataTable();
            return rs;
        }
        public bool checkDuplicate()
        {
            bool check = cthdbList.Any(x => x.MaHang1 == cbxMaHang.SelectedValue.ToString());
            return check;
        }
        private CTHDBDTO checkDataGioHang()
        {
            string soHDB = txtSoHDB.Text;
            string maHang = cbxMaHang.Text;
            string soLuong = txtSoLuong.Text;
            string donGia = txtDonGia.Text;
            string giamGia = txtGiamGia.Text;
            string thanhTien = txtThanhTien.Text;
            string tenHang = txtTenHang.Text;
            if (cbxMaHang.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Hàng Muốn Bán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            maHang = cbxMaHang.SelectedValue.ToString();
            CTHDBDTO dto = new CTHDBDTO(soHDB, maHang,
                int.Parse(soLuong), int.Parse(giamGia), int.Parse(thanhTien), tenHang, int.Parse(donGia));
            return dto;
        }
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
        public void turnOffBtnUnder(bool OnOrOff)
        {
            btnXoa.Enabled = OnOrOff;
            btnSua.Enabled = OnOrOff;
            btnLuu.Enabled = OnOrOff;
            btnThemVaoGio.Enabled = OnOrOff;
        }
        public void clrHD()
        {
            txtSoHDB.Text = "";
            dtpNgayBan.Text = "";
        }
        public void clrHang()
        {
            cbxMaHang.Text = "";
            txtSoLuong.Text = txtTenHang.Text = txtGiamGia.Text = txtDonGia.Text = txtThanhTien.Text = "";
        }
        public void clrCbx()
        {
            cbxMaKH.SelectedIndex = cbxMaNV.SelectedIndex = -1;
        }
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + ' - ' + " + column2;
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
        public void blockInputNotNumText(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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
        public void tinhTongTien(List<CTHDBDTO> lst, TextBox txt)
        {
            int tong = 0;
            foreach (CTHDBDTO cth in lst)
            {
                tong += cth.ThanhTien1;
            }
            txt.Text = tong.ToString();
            lblTongTien.Text = FormHandling.ChuyenSoSangChuoi(tong);
        }
        public void loadTempTable(List<CTHDBDTO> ctnLst)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã hàng", typeof(string));
            table.Columns.Add("Tên hàng", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Đơn giá", typeof(int));
            table.Columns.Add("Giảm giá %", typeof(int));
            table.Columns.Add("Thành tiền", typeof(int));

            foreach (CTHDBDTO item in ctnLst)
            {
                DataRow row = table.NewRow();
                row["Mã hàng"] = item.MaHang1;
                row["Tên hàng"] = item.TenHang;
                row["Số lượng"] = item.SoLuong1;
                row["Đơn giá"] = (decimal)item.TempDonGia1;
                row["Giảm giá %"] = item.GiamGia1;
                row["Thành tiền"] = item.ThanhTien1;
                table.Rows.Add(row);
            }
            dgvHDB.DataSource = table;
        }

    }
}
