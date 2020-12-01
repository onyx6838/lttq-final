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
using BUS;
using Microsoft.Reporting.WinForms;

namespace BTL
{
    public partial class frmBaocaoTopHDN : Form
    {
        List<int> Nam = new List<int>();
        public frmBaocaoTopHDN()
        {
            InitializeComponent();
            frmBaocaoTopHDN_Load(null, null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*param*/
            string s = DateTime.Now.ToString("dd/MM/yyyy");
            ReportParameter[] parms = new ReportParameter[2];
            parms[0] = new ReportParameter("Year", cbxNam.Text);
            parms[1] = new ReportParameter("DateNow", s);
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"Reports\Report2.rdlc");
            rpvChitiet.LocalReport.ReportPath = reportPath;
            //rpvChitiet.LocalReport.ReportPath = "Report2.rdlc";
            rpvChitiet.LocalReport.SetParameters(parms);
            /* dataSet*/
            DataSet ds = B_HDNhap.HDNBillMax(int.Parse(cbxNam.Text));
            rpvChitiet.ProcessingMode = ProcessingMode.Local;
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "sp_HDNTongTienMax";
                rds.Value = ds.Tables[0];
                rpvChitiet.LocalReport.DataSources.Clear();
                rpvChitiet.LocalReport.DataSources.Add(rds);
                rpvChitiet.RefreshReport();
            }
        }

        private void frmBaocaoTopHDN_Load(object sender, EventArgs e)
        {
            DataTable dt = B_HDNhap.GetYearHDN();
            Nam = dt.AsEnumerable().Select(r => r.Field<int>("NamHienCo")).ToList();
            cbxNam.DataSource = Nam;
            this.rpvChitiet.RefreshReport();
        }
    }
}
