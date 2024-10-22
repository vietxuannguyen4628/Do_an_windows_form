using DevExpress.Data.Filtering;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using Do_An_WindowsForm.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class DoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyNhaTroDB ql = new QuanLyNhaTroDB();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            List<PhieuThuePhong> list = ql.PhieuThuePhongs.ToList();
            BinDaTa(list);
        }
        private string tinhtien(int check)
        {
            int money = 0;
            var list = ql.CT_SuDungDV.Where(p => p.MaPTP == check).ToList();
            for (int i = 0; i < list.Count; i++)
                money = money + (int.Parse(list[i].SoLuong.ToString()) * int.Parse(list[i].DichVu.DonGia.ToString()));


            return money.ToString();

        }
        private string ngay(int check)
        {
            string ng = "";
            var checkdata = ql.CT_SuDungDV.FirstOrDefault(p => p.MaPTP == check);
            if (checkdata != null && checkdata.PhieuThutien != null)
                ng = checkdata.PhieuThutien.DenNgay.ToString();
            return ng;

        }
        private void tongtien()
        {
            int money = 0;
            for(int i = 0;i < dgvDoanhThu.Rows.Count;i++)
            {
                if(dgvDoanhThu.Rows[i].Cells[6].Value != null)
                    money = money + int.Parse(dgvDoanhThu.Rows[i].Cells[6].Value.ToString());
            }
            txttongtien.Text = money +"đ";
        }
        private void BinDaTa(List<PhieuThuePhong> list_thutien)
        {
            dgvDoanhThu.Rows.Clear();
            for (int i = 0; i < list_thutien.Count; i++)
            {
                int index = dgvDoanhThu.Rows.Add();
                string dl = tinhtien(int.Parse(list_thutien[i].MaPTP.ToString()));
                string dl1 = ngay(int.Parse(list_thutien[i].MaPTP.ToString()));
                dgvDoanhThu.Rows[index].Cells[0].Value = list_thutien[i].MaPhong;
                dgvDoanhThu.Rows[index].Cells[1].Value = list_thutien[i].KhachHang.HoTen;
                dgvDoanhThu.Rows[index].Cells[2].Value = list_thutien[i].KhachHang.CMND_CanCuoc;
                dgvDoanhThu.Rows[index].Cells[3].Value = dl1;
                dgvDoanhThu.Rows[index].Cells[4].Value = dl;
                dgvDoanhThu.Rows[index].Cells[5].Value = list_thutien[i].Phong.GiaTien;
                int money = int.Parse(dl) + int.Parse(list_thutien[i].Phong.GiaTien.ToString());
                dgvDoanhThu.Rows[index].Cells[6].Value = money.ToString();
            }
            tongtien();
        }

        private void dtpThoigian_ValueChanged(object sender, EventArgs e)
        {
            try
            {
               
               
                if (dtptungay.Value > dtpdenngay.Value)
                    dtpdenngay.Value = dtptungay.Value;
                DateTime tn = dtptungay.Value;
                DateTime dn = dtpdenngay.Value;
                for (int i = 0; i < dgvDoanhThu.Rows.Count; i++)
                {
                    if (dgvDoanhThu.Rows[i] != null && !dgvDoanhThu.Rows[i].IsNewRow)
                    {
                        DateTime data = Convert.ToDateTime(dgvDoanhThu.Rows[i].Cells[3].Value);

                        if (tn <= data && dn >= data)
                            dgvDoanhThu.Rows[i].Visible = true;
                        else
                            dgvDoanhThu.Rows[i].Visible = false;
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
