using DevExpress.XtraEditors;
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

    public partial class Chonnam : DevExpress.XtraEditors.XtraForm
    {

        public Chonnam()
        {
            InitializeComponent();
        }
        QuanLyNhaTroDB ql = new QuanLyNhaTroDB();

        private void Chonnam_Load(object sender, EventArgs e)
        {
            dtpChonNam.Format = DateTimePickerFormat.Custom;
            dtpChonNam.CustomFormat = "yyyy";
            dtpChonNam.ShowUpDown = true;
        }

        private void dtpChonNam_ValueChanged(object sender, EventArgs e)
        {
            dtpChonNam.CustomFormat = "yyyy";
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool tienDV(DateTime nam)
        {
            CT_SuDungDV list = ql.CT_SuDungDV.FirstOrDefault(p =>p.PhieuThutien.DenNgay.Value.Year == nam.Year);
            if(list == null)
                return false;
            return true;
        }
        private bool tienphong(DateTime nam)
        {

            PhieuThuePhong phong = ql.PhieuThuePhongs.FirstOrDefault(p => p.NgayThue.Value.Year == nam.Year && p.NgayThue.Value.Month <= nam.Month && p.Phong.TrangThai == 1);
            PhieuTraPhong phieutra = ql.PhieuTraPhongs.FirstOrDefault(p => p.PhieuThuePhong.NgayThue.Value.Year == nam.Year && p.NgayTra.Value.Year == nam.Year && p.PhieuThuePhong.Phong.TrangThai == 0);
            if (phong == null && phieutra == null)
                return false;
            return true;

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpChonNam.Value;
            Form parentForm = this;
            if(!tienDV(dateTime) && !tienphong(dateTime))
            {
                MessageBox.Show("Chưa có dữ liệu của năm bạn chọn");
                return;
            }
            using (BieuDoThongKe bieuDoThongKe = new BieuDoThongKe(parentForm))
            {
                bieuDoThongKe.StartPosition = FormStartPosition.CenterParent;
                bieuDoThongKe.checkTime = dateTime;
                bieuDoThongKe.ShowDialog();
            }
            this.Hide();
        }
    }
}