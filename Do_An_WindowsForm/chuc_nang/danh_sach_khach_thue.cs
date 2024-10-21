using Do_An_WindowsForm.model;
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

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class danh_sach_khach_thue : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyNhaTroDB qltro = new QuanLyNhaTroDB();
        public danh_sach_khach_thue()
        {
            InitializeComponent();
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FillTable(List<PhieuSuDungDV> phieuSDDV)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in phieuSDDV)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.PhieuThuePhong.MaKH;
                dgvKhachHang.Rows[index].Cells[1].Value = item.PhieuThuePhong.MaPhong;
                dgvKhachHang.Rows[index].Cells[2].Value = item.PhieuThuePhong.KhachHang.HoTen;
                dgvKhachHang.Rows[index].Cells[3].Value = item.PhieuThuePhong.KhachHang.GioiTinh;
                dgvKhachHang.Rows[index].Cells[4].Value = item.TuNgay;
                dgvKhachHang.Rows[index].Cells[5].Value = item.PhieuThuePhong.KhachHang.SDT;
            }
        }
        private void danh_sach_khach_thue_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvKhachHang);
            List<PhieuSuDungDV> phieuSuDungDVs = qltro.PhieuSuDungDVs.ToList();
            FillTable(phieuSuDungDVs);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}