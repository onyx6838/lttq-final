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
    public partial class frmBaocaoSanpham : Form
    {
        List<int> Nam = new List<int>();
        public frmBaocaoSanpham()
        {
            InitializeComponent();
            frmBaocaoSanpham_Load(null, null);
        }

        private void frmBaocaoSanpham_Load(object sender, EventArgs e)
        {
            DataTable dt = B_HDBan.GetYearHDB();
            Nam = dt.AsEnumerable().Select(r => r.Field<int>("NamHienCo")).ToList();
            cbxNam.DataSource = Nam;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*param*/
            string s = DateTime.Now.ToString("dd/MM/yyyy");
            ReportParameter[] parms = new ReportParameter[3];
            parms[0] = new ReportParameter("Month", cbxThang.Text);
            parms[1] = new ReportParameter("Year", cbxNam.Text);
            parms[2] = new ReportParameter("DateNow", s);
            /* get debug/report path*/
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"Reports\Report1.rdlc");
            rpvChitiet.LocalReport.ReportPath = reportPath;

            rpvChitiet.LocalReport.SetParameters(parms);
            /* dataSet*/
            DataSet ds = B_HDBan.SPBanChayNhatTheoThang(int.Parse(cbxThang.Text), int.Parse(cbxNam.Text));
            rpvChitiet.ProcessingMode = ProcessingMode.Local;
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "sp_SPBanChayNhatTheoThang";
                rds.Value = ds.Tables[0];
                rpvChitiet.LocalReport.DataSources.Clear();
                rpvChitiet.LocalReport.DataSources.Add(rds);
                rpvChitiet.RefreshReport();
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            cbxNam.SelectedIndex = cbxThang.SelectedIndex = -1;
        }
    }
}
