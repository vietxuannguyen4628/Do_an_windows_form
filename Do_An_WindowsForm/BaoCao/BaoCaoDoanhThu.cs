using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.BaoCao
{
    public partial class BaoCaoDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.RefreshReport();
                reportViewer1.Visible = true;
                List<KhachHang> kh = context.KhachHangs.ToList();
                string folderPath = Path.Combine(Application.StartupPath, @"..\..\BaoCao\DoanhThu.rdlc");
                reportViewer1.LocalReport.ReportPath = folderPath;
                ReportDataSource report = new ReportDataSource("DataSet1", kh);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(report);
                reportViewer1.RefreshReport();
            }
            catch
            {
            }


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}