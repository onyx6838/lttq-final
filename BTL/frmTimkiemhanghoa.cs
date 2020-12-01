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
    public partial class frmTimkiemhanghoa : Form
    {
        public frmTimkiemhanghoa()
        {
            InitializeComponent();
            FormTimkiem_Load(null, null); 
            Handling.FormHandling.clearBorderGroupBox(gbxKetqua);
        }
        private void FormTimkiem_Load(object sender, EventArgs e)
        {
            DataTable dt = B_HangHoa.getDataForSearch();
            dgvResult.DataSource = dt;
            cbxFindChatLieu.SelectedIndex = -1;
            cbxFindNhom.SelectedIndex = -1;
            cbxFindCongDung.SelectedIndex = -1;
            DataTable clieu = B_ChatLieu.GetAllCL();
            FillCbo(clieu, cbxFindChatLieu, "MaChatLieu", "TenChatLieu");
            DataTable cdung = B_CongDung.GetAllCD();
            FillCbo(cdung, cbxFindCongDung, "MaCongDung", "TenCongDung");
            DataTable nhom = B_NhomHang.GetAllNhomHang();
            FillCbo(nhom, cbxFindNhom, "MaNhom", "TenNhom");
        }
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = B_HangHoa.getDataForSearch();
            if (cbxFindChatLieu.SelectedIndex == -1 && cbxFindCongDung.SelectedIndex == -1 && cbxFindNhom.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa Chọn Hạng Mục Tìm Kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResult.DataSource = dt;
            }
            else
            {
                IEnumerable<DataRow> rows =
                    dt.AsEnumerable().Where
                    (
                         r =>
                         (
                         cbxFindChatLieu.SelectedIndex == -1 ? true :
                         r.Field<string>("TenChatLieu").Contains(cbxFindChatLieu.SelectedValue.ToString())
                         )
                         &&
                         (
                         cbxFindNhom.SelectedIndex == -1 ? true :
                         r.Field<string>("TenNhom").Contains(cbxFindNhom.SelectedValue.ToString())
                         )
                         &&
                         (
                         cbxFindCongDung.SelectedIndex == -1 ? true :
                         r.Field<string>("TenCongDung").Contains(cbxFindCongDung.SelectedValue.ToString())
                         )
                    );
                /*try
                {
                    DataTable t = rows.CopyToDataTable();
                    dgvResult.DataSource = t;
                    dgvResult.Refresh();
                }
                catch
                {
                }*/
                if(rows.Any() == false)
                {
                    MessageBox.Show("Không Có Kết Quả Hợp Lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnLamlai_Click_1(sender, e);
                    dgvResult.DataSource = B_HangHoa.getDataForSearch();
                }
                else
                {
                    DataTable t = rows.CopyToDataTable();
                    dgvResult.DataSource = t;
                    dgvResult.Refresh();
                }
            }

            //Show ket qua
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();
            this.gbxKetqua.Dock = DockStyle.Fill;
            formMain.panelKetquaTimKiem.Controls.Add(this.gbxKetqua);
        }

        private void BtnLamlai_Click_1(object sender, EventArgs e)
        {
            frmMain formMain = (frmMain)frmMain.ActiveForm;
            formMain.panelKetquaTimKiem.Controls.Clear();

            cbxFindChatLieu.SelectedIndex = -1;
            cbxFindCongDung.SelectedIndex = -1;
            cbxFindNhom.SelectedIndex = -1;
            DataTable dt = B_HangHoa.getDataForSearch();
            dgvResult.DataSource = dt;
        }
        private void dgvResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Handling.FormHandling.changeColorRowDataGridView(dgvResult);
        }
        /* in form handler*/
        public void FillCbo(DataTable t, ComboBox cbo, string ma, string ten)
        {
            string newC = "NameAndCode";
            AddMultipleColumn(t, newC, ma, ten);
            cbo.DataSource = t;
            cbo.ValueMember = ten;
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + ' - ' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }
    }
}
