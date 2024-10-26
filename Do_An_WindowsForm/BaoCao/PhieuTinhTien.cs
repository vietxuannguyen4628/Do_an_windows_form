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
    public partial class PhieuTinhTien : DevExpress.XtraEditors.XtraForm
    {
        public PhieuTinhTien()
        {
            InitializeComponent();
        }

        private void PhieuTinhTien_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}