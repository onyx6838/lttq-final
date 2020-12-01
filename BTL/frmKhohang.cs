using BUS;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmKhohang : Form
    {
        DataSet ds = new DataSet();
        public frmKhohang()
        {
            InitializeComponent();
            Handling.FormHandling.clearBorderGroupBox(gbxChitiet);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //
            frmNhapHang frm = new frmNhapHang();
            Handling.FormHandling.PreventFormMultipleTimes(frm, "Nhập hàng");
            Close();
            //
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            //
            frmBanhang frm = new frmBanhang();
            Handling.FormHandling.PreventFormMultipleTimes(frm, "Bán hàng");
            Close();
            //
        }

        private void frmKhohang_Load(object sender, EventArgs e)
        {
            DataTable dt = B_HangHoa.GetAllHangHoa();
            dgvHangHoa.DataSource = dt;
            ds.Tables.Add(dt);
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvHangHoa.Rows.Count - 1)
            {
                frmChitietHanghoa f1 = new frmChitietHanghoa();
                Handling.FormHandling.PreventFormMultipleTimes("Mặt Hàng", f1, "Chi tiết các mặt hàng");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = string.Format("TenHangHoa LIKE '{0}%'", txtTimKiem.Text);
            dgvHangHoa.DataSource = dv;
        }

        private void dgvHangHoa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvHangHoa);
        }
    }
}
