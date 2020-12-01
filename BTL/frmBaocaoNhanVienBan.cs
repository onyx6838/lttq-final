using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class frmBaocaoNhanVienBan : Form
    {
        public frmBaocaoNhanVienBan()
        {
            InitializeComponent();
            frmBaocaoNhanVienBan_Load(null, null);
        }

        private void frmBaocaoNhanVienBan_Load(object sender, EventArgs e)
        {
            DataTable dt = B_NhanVien.GetAllNhanVien();
            FillCbo(dt, cbxNV, "MaNV", "TenNV");
            this.rpvChitiet.RefreshReport();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nv = cbxNV.Text;
            int sub = cbxNV.Text.LastIndexOf("-");
            string tenNV = nv.Substring(sub + 1);
            /*param*/
            string s = DateTime.Now.ToString("dd/MM/yyyy");
            ReportParameter[] parms = new ReportParameter[2];
            parms[0] = new ReportParameter("TenNV", tenNV);
            parms[1] = new ReportParameter("DateNow", s);
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"Reports\Report3.rdlc");
            rpvChitiet.LocalReport.ReportPath = reportPath;
            //rpvChitiet.LocalReport.ReportPath = "Report3.rdlc";
            rpvChitiet.LocalReport.SetParameters(parms);
            /* dataSet*/
            DataSet ds = B_HDBan.HDBTheoNV(cbxNV.SelectedValue.ToString());
            rpvChitiet.ProcessingMode = ProcessingMode.Local;
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "sp_HDBTheoNV";
                rds.Value = ds.Tables[0];
                rpvChitiet.LocalReport.DataSources.Clear();
                rpvChitiet.LocalReport.DataSources.Add(rds);
                rpvChitiet.RefreshReport();
            }
        }
    }
}
