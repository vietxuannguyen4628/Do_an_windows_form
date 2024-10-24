using DevExpress.XtraCharts;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class BieuDoThongKe : DevExpress.XtraEditors.XtraForm
    {
        Series bieudo = new Series();
        public BieuDoThongKe()
        {
            InitializeComponent();
        }

        private void BieuDoThongKe_Load(object sender, EventArgs e)
        {
            

        }
        //private void Bindata(int nam) {
        //    int money = 0;
        //    var list = ql.CT_SuDungDV.Where(p => p.MaPTP == check).ToList();
        //    for (int i = 0; i < list.Count; i++)
        //        money = money + (int.Parse(list[i].SoLuong.ToString()) * int.Parse(list[i].DichVu.DonGia.ToString()));
        //    return money.ToString();
        //}
    }
}