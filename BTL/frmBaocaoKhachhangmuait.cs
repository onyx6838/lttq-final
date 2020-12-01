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
    public partial class frmBaocaoKhachhangmuait : Form
    {
        List<int> Nam = new List<int>();
        public frmBaocaoKhachhangmuait()
        {
            InitializeComponent();
            frmBaocaoKhachhangmuait_Load(null, null);
        }

        private void frmBaocaoKhachhangmuait_Load(object sender, EventArgs e)
        {
            DataTable dt = B_HDBan.GetYearHDB();
            
            Nam = dt.AsEnumerable().Select(r => r.Field<int>("NamHienCo")).ToList();
            cbxNam.DataSource = Nam;
            for (int i = 1; i <= 4; i++) cbxQuy.Items.Add(i);
            rpvChitiet.RefreshReport();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*param*/
            int truoc = 0;
            int sau = 0;
            switch (cbxQuy.Text)
            {
                case "1":
                    truoc = 1;
                    sau = 3;
                    break;
                case "2":
                    truoc = 4;
                    sau = 6;
                    break;
                case "3":
                    truoc = 7;
                    sau = 9;
                    break;
                case "4":
                    truoc = 10;
                    sau = 12;
                    break;
                default:
                    break;
            }
            string s = DateTime.Now.ToString("dd/MM/yyyy");
            ReportParameter[] parms = new ReportParameter[3];
            parms[0] = new ReportParameter("Quy", cbxQuy.Text);
            parms[1] = new ReportParameter("Nam", cbxNam.Text);
            parms[2] = new ReportParameter("DateNow", s);
            string exeFolder = Application.StartupPath; 
            string reportPath = Path.Combine(exeFolder, @"Reports\Report4.rdlc");
            rpvChitiet.LocalReport.ReportPath = reportPath;
            //rpvChitiet.LocalReport.ReportPath = "Report4.rdlc";
            rpvChitiet.LocalReport.SetParameters(parms);
            /* dataSet*/
            DataSet ds = B_HDBan.KhachMuaItHangNhat(truoc, sau, int.Parse(cbxNam.Text));
            rpvChitiet.ProcessingMode = ProcessingMode.Local;
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không Có Kết Quả Để Xuất Báo Cáo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "sp_KhachHangMuaItHangNhat";
                rds.Value = ds.Tables[0];
                rpvChitiet.LocalReport.DataSources.Clear();
                rpvChitiet.LocalReport.DataSources.Add(rds);
                rpvChitiet.RefreshReport();
            }
        }
    }
}
