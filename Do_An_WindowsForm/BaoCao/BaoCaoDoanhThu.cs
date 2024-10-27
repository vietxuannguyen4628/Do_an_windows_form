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
                this.reportDoanhThu.RefreshReport();
                reportDoanhThu.Visible = true;

                List<DOANHTHUTHEOPHONG> doanhThu = context.DOANHTHUTHEOPHONGs.ToList();
                string folderPath = Path.Combine(Application.StartupPath, @"..\..\BaoCao\DoanhThu.rdlc");
                reportDoanhThu.LocalReport.ReportPath = folderPath;

                ReportDataSource report = new ReportDataSource("DoanhThuTheoTungPhong", doanhThu);
                reportDoanhThu.LocalReport.DataSources.Clear();
                reportDoanhThu.LocalReport.DataSources.Add(report);
                reportDoanhThu.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}