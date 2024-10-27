using DevExpress.XtraEditors;
using Do_An_WindowsForm.ChucNang;
using Do_An_WindowsForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.ChucNang
{
    public partial class ChonNam : DevExpress.XtraEditors.XtraForm
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public ChonNam()
        {
            InitializeComponent();
        }
        private bool tienDV(DateTime nam)
        {
<<<<<<< HEAD
            PhieuThutien list = context.PhieuThutiens.FirstOrDefault(p => p.DenNgay.Value.Year == nam.Year);
=======
            PhieuThutien list = context.PhieuThutiens.FirstOrDefault(p => p.NgayThanhToan.Value.Year == nam.Year);
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2
            if (list == null)
                return false;
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool tienphong(DateTime nam)
        {

            PhieuThuePhong phong = context.PhieuThuePhongs.FirstOrDefault(p => p.NgayThue.Value.Year == nam.Year && p.NgayThue.Value.Month <= nam.Month && p.Phong.TrangThai == 1);
            PhieuTraPhong phieutra = context.PhieuTraPhongs.FirstOrDefault(p => p.PhieuThuePhong.NgayThue.Value.Year == nam.Year && p.NgayTra.Value.Year == nam.Year && p.PhieuThuePhong.Phong.TrangThai == 0);
            if (phong == null && phieutra == null)
                return false;
            return true;

        }

        private void dtpChonNam_ValueChanged(object sender, EventArgs e)
        {
            dtpChonNam.CustomFormat = "yyyy";
        }

        private void ChonNam_Load(object sender, EventArgs e)
        {
            dtpChonNam.Format = DateTimePickerFormat.Custom;
            dtpChonNam.CustomFormat = "yyyy";
            dtpChonNam.ShowUpDown = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpChonNam.Value;
            Form parentForm = this;
            if (!tienDV(dateTime) && !tienphong(dateTime))
            {
                MessageBox.Show("Chưa có dữ liệu của năm " + dateTime.Year);
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