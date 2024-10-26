using DevExpress.XtraEditors;
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
    public partial class PhieuDangKy : DevExpress.XtraEditors.XtraUserControl
    {
        public PhieuDangKy()
        {
            InitializeComponent();
        }

        private void PhieuDangKy_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}