using BUS;
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
    public partial class frmTimkiemHoadonNhap : Form
    {
        public frmTimkiemHoadonNhap()
        {
            InitializeComponent();
            frmTimkiemHoadonNhap_Load(null, null);
            Handling.FormHandling.clearBorderGroupBox(gbxKetqua);
        }
        private void dgvFindResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvFindResult.Rows.Count; i++)
            {
                if (i % 2 == 0) dgvFindResult.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 255, 240);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = B_HDNhap.GetDataForSearch();
            if (SearchingWithLinQ(dt, cbxHang, dtpStart, dtpEnd, cbxNCC) == null)
            {
                MessageBox.Show("Không Có Kết Quả Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamlai_Click_1(sender, e);
                dgvFindResult.DataSource = B_HDNhap.GetDataForSearch();
            }
            else
            {
                DataTable t = SearchingWithLinQ(dt, cbxHang, dtpStart, dtpEnd, cbxNCC);
                dgvFindResult.DataSource = t;
                dgvFindResult.Refresh();
            }

            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
            this.gbxKetqua.Dock = DockStyle.Fill;
            formMain.panelKetquaTimKiem.Controls.Add(this.gbxKetqua);
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;

            cbxHang.SelectedIndex = cbxNCC.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            dgvFindResult.DataSource = B_HDNhap.GetDataForSearch();

            formMain.panelKetquaTimKiem.Controls.Clear();
        }

        private void cbNgaythang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNgay.Checked == true)
            {
                gbxNgaythang.Visible = true;
            }
            else if (cbxNgay.Checked == false)
            {
                gbxNgaythang.Visible = false;
            }
        }

        private void frmTimkiemHoadonNhap_Load(object sender, EventArgs e)
        {
            dgvFindResult.DataSource = B_HDNhap.GetDataForSearch();
            DataTable t = B_NCC.GetAllNCC();
            FillCbo(t, cbxNCC, "TenNCC", "MaNCC");
            DataTable hang = B_HangHoa.GetAllHangHoa();
            FillCbo(hang, cbxHang, "MaHang", "TenHangHoa");
            gbxNgaythang.Visible = false;
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

        private void btnLamlai_Click_1(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
            cbxHang.SelectedIndex = cbxNCC.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            dgvFindResult.DataSource = B_HDNhap.GetDataForSearch();
        }

        public DataTable SearchingWithLinQ(DataTable findDT, ComboBox maHang, DateTimePicker before, DateTimePicker after, ComboBox ncc)
        {
            if (gbxNgaythang.Visible == false)
            {
                IEnumerable<DataRow> query = findDT.AsEnumerable().Where
                (
                    row =>
                    (
                    maHang.SelectedIndex == -1 ? true : row.Field<string>("MaHang").Contains(maHang.SelectedValue.ToString())
                    )
                    &&
                    (
                    ncc.SelectedIndex == -1 ? true : row.Field<string>("TenNCC").Contains(ncc.SelectedValue.ToString())
                    )
                );
                if (query.Any() == false)
                {
                    return null;
                }
                else
                {
                    DataTable searchWithoutDate = query.CopyToDataTable();
                    // select distinct
                    //DataView viewWithout = new DataView(searchWithoutDate);
                    //DataTable finalSearching = viewWithout.ToTable(true,"SoHDN","MaHang","NgayNhap","MaNCC","TenNCC","TongTien");
                    return searchWithoutDate;
                    //return finalSearching;
                }
            }
            else
            {
                IEnumerable<DataRow> query = findDT.AsEnumerable().Where
                (
                    row =>
                    (
                    maHang.SelectedIndex == -1 ? true : row.Field<string>("MaHang").Contains(maHang.SelectedValue.ToString())
                    )
                    &&
                    (
                    ncc.SelectedIndex == -1 ? true : row.Field<string>("TenNCC").Contains(ncc.SelectedValue.ToString())
                    )
                );
                if (before.Value > after.Value)
                {
                    query = query.Where
                        (row =>
                        (DateTime.Compare(row.Field<DateTime>("NgayNhap"), Convert.ToDateTime(before.Value.ToString("yyyy/MM/dd"))) <= 0)
                    && (DateTime.Compare(row.Field<DateTime>("NgayNhap"), Convert.ToDateTime(after.Value.ToString("yyyy/MM/dd"))) >= 0)
                        );
                }
                else if (before.Value < after.Value)
                {
                    query = query.Where
                         (row =>
                         (DateTime.Compare(row.Field<DateTime>("NgayNhap"), Convert.ToDateTime(before.Value.ToString("yyyy/MM/dd"))) >= 0)
                     && (DateTime.Compare(row.Field<DateTime>("NgayNhap"), Convert.ToDateTime(after.Value.ToString("yyyy/MM/dd"))) <= 0)
                         );
                }
                else
                {
                    query = query.Where
                         (row =>
                         (DateTime.Compare(row.Field<DateTime>("NgayNhap"), Convert.ToDateTime(before.Value.ToString("yyyy/MM/dd"))) == 0)
                         );
                }

                if (query.Any() == false)
                {
                    return null;
                }
                else
                {
                    DataTable searchWithDate = query.CopyToDataTable();
                    return searchWithDate;
                }
            }
        }

        
    }
}
