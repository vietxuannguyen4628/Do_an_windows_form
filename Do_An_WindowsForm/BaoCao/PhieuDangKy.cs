using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.BaoCao
{
    public partial class PhieuDangKy : System.Windows.Forms.Form
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public PhieuDangKy()
        {
            InitializeComponent();
        }

        private void PhieuDangKy_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = true;

            
            List<KhachHang> kh = context.KhachHangs.ToList();
            reportViewer1.LocalReport.ReportPath = "./PhieuDangKy.rdlc";
            ReportDataSource report = new ReportDataSource("DataSet1", kh);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(report);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}