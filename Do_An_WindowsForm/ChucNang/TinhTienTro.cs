using DevExpress.XtraEditors;
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

namespace Do_An_WindowsForm
{
    public partial class TinhTienTro : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();

        public TinhTienTro()
        {
            InitializeComponent();
        }
        private void setNull()
        {
            txtID_Khach.Text = "";
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
            txtTienNha.Text = "0";
            txtSoDienCu.Text = "0";
            txtSoDienMoi.Text = "0";
            txtSoNuocCu.Text = "0";
            txtSoNuocMoi.Text = "0";
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtTienInternet.Text = "0";
            txtTienRac.Text = "0";
            //txtSLXe.Text = "0";
            txtTienGiuXe.Text = "0";
            txtTongTien.Text = "0";
            txtID_Phong.Text = "0";
            dateThue.EditValue = "";
        }
        private void load()
        {
            cmbChonPhong.SelectedItem = null;
            setNull();
        }

        private void fillPhongThue(List<PhieuThuePhong> phieuthue)
        {
            cmbChonPhong.Items.Clear();
            List<Phong> list = context.Phongs.ToList();
            foreach (var item in list)
            {
                if (item.TrangThai == 1)
                {
                    cmbChonPhong.Items.Add(item.MaPhong);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void TinhTienTro_Load(object sender, EventArgs e)
        {

            List<PhieuThuePhong> listPhieuThue = context.PhieuThuePhongs.ToList();
            fillPhongThue(listPhieuThue);
            load();
        }

        private void cmbChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            setNull();
            txtID_Phong.Text = cmbChonPhong.Text;
            PhieuThuePhong _phieuthue = context.PhieuThuePhongs.FirstOrDefault(pt => pt.MaPhong.ToString() == cmbChonPhong.Text);
            //DichVu dichvudien = context.DichVus.FirstOrDefault(dv => dv.TenDV == "Điện");

            if (_phieuthue != null)
            {
                txtID_Phong.Text = _phieuthue.MaPhong.ToString();
                dateThue.EditValue = _phieuthue.NgayThue.Value;
                txtID_Khach.Text = _phieuthue.MaKH.ToString();
                txtHoTen.Text = _phieuthue.KhachHang.HoTen.ToString();
                txtCCCD.Text = _phieuthue.KhachHang.CMND_CanCuoc.ToString();
                txtNgheNghiep.Text = _phieuthue.KhachHang.NgheNghiep.ToString();
                txtSDT.Text = _phieuthue.KhachHang.SDT.ToString();
                txtTienNha.Text = _phieuthue.Phong.GiaTien.ToString();

                //var ctDien = context.CT_SuDungDV.FirstOrDefault(c => c.DichVu.TenDV == "Điện" && c.MaPTP == _phieuthue.MaPTP);
                //if (ctDien != null)
                //{
                //    txtSoDienCu.Text = ctDien.ChiSoMoi.ToString();
                //}
                //var ctNuoc = context.CT_SuDungDV.FirstOrDefault(c => c.DichVu.TenDV == "Nước" && c.MaPTP == _phieuthue.MaPTP);
                //if (ctNuoc != null)
                //{
                //    txtSoNuocCu.Text = ctNuoc.ChiSoMoi.ToString();
                //}

                showDichVu(_phieuthue);
            }
        }

        private void showDichVu(PhieuThuePhong p)
        {
            // Hiển thị chỉ số điện
            var dichVuDien = context.DichVus.FirstOrDefault(dv => dv.TenDV == "Điện");
            var chiTietDien = context.CT_SuDungDV.FirstOrDefault(ctdv => ctdv.MaPTP == p.MaPTP && dichVuDien.MaDV == ctdv.MaDV);

            if (chiTietDien != null)
            {
                txtSoDienCu.Text = chiTietDien.ChiSoMoi.ToString();
                txtSoDienMoi.Text = chiTietDien.ChiSoMoi.ToString();
            }
            else
            {
                txtSoDienCu.Text = "0";
                txtSoDienMoi.Text = "0";
            }


            // Hiển thị chỉ số nước
            var dichVuNuoc = context.DichVus.FirstOrDefault(dv => dv.TenDV == "Nước");
            if (dichVuNuoc != null)
            {
                var chiTietNuoc = context.CT_SuDungDV.FirstOrDefault(ctdv => ctdv.MaPTP == p.MaPTP && ctdv.MaDV == dichVuNuoc.MaDV);
                if (chiTietNuoc != null)
                {
                    txtSoNuocCu.Text = chiTietNuoc.ChiSoMoi.ToString();
                    txtSoNuocMoi.Text = chiTietNuoc.ChiSoMoi.ToString();
                }
                else
                {
                    txtSoNuocCu.Text = "0";
                    txtSoNuocMoi.Text = "0";
                }
            }
        }

        private void cbDien_CheckedChanged(object sender, EventArgs e)
        {
            PhieuThuePhong _phieuthue = context.PhieuThuePhongs.FirstOrDefault(pt => pt.MaPhong.ToString() == cmbChonPhong.Text);

            if (cbDien.Checked == true)
            {
                txtSoDienMoi.Enabled = true;
            }
            else if (cbDien.Checked == false)
            {
                txtSoDienMoi.Enabled = false;
                //txtSoDienMoi.Text = ct_DV.ChiSoCu.ToString();
            }
        }

        private void cbNuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNuoc.Checked == true)
            {
                txtSoNuocMoi.Enabled = true;
            }
            else if (cbNuoc.Checked == false)
            {
                txtSoNuocMoi.Enabled = false;
            }
        }

        private void cbInternet_CheckedChanged(object sender, EventArgs e)
        {
            DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == cbInternet.Text);
            if (cbInternet.Checked == true)
            {
                //txtTienInternet.Enabled = true;
                txtTienInternet.Text = dichVu.DonGia.ToString();
            }
            else if (cbInternet.Checked == false)
            {
                //txtTienInternet.Enabled = false;
                txtTienInternet.Text = "0";
            }
        }

        private void cbRac_CheckedChanged(object sender, EventArgs e)
        {
            DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == cbRac.Text);
            if (cbRac.Checked == true)
            {
                //txtTienRac.Enabled = true;
                txtTienRac.Text = dichVu.DonGia.ToString();
            }
            else if (cbNuoc.Checked == false)
            {
                //txtTienRac.Enabled = false;
                txtTienRac.Text = "0";
            }
        }

        private void cbGiuXe_CheckedChanged(object sender, EventArgs e)
        {
            DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == cbGiuXe.Text);
            if (cbGiuXe.Checked == true)
            {

                txtTienGiuXe.Text = (dichVu.DonGia).ToString();
            }
            else if (cbGiuXe.Checked == false)
            {
                txtTienGiuXe.Text = "0";
            }
        }



        private void txtSoDienMoi_TextChanged(object sender, EventArgs e)
        {
            PhieuThuePhong _phieuthue = context.PhieuThuePhongs.FirstOrDefault(pt => pt.MaPhong.ToString() == cmbChonPhong.Text);
            if (_phieuthue != null)
            {
                DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == "Điện");
                if (dichVu != null)
                {
                    txtTienDien.Text = (((int.Parse(txtSoDienMoi.Text)) - (int.Parse(txtSoDienCu.Text))) * (dichVu.DonGia)).ToString();
                }
                else
                {
                    txtTienDien.Text = "0";
                }
            }
            else
            {
                return;
            }

        }

        private void txtSoNuocMoi_TextChanged(object sender, EventArgs e)
        {
            PhieuThuePhong _phieuthue = context.PhieuThuePhongs.FirstOrDefault(pt => pt.MaPhong.ToString() == cmbChonPhong.Text);
            if (_phieuthue != null)
            {
                DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == "Nước");
                if (dichVu != null)
                {
                    txtTienNuoc.Text = (((int.Parse(txtSoNuocMoi.Text)) - (int.Parse(txtSoNuocCu.Text))) * (dichVu.DonGia)).ToString();
                }
                else
                {
                    txtTienDien.Text = "0";
                }
            }
            else
            {
                return;
            }
        }
        private void TinhTongTien()
        {
            // Chuyển đổi giá trị Text sang số nguyên để tính toán, nếu có lỗi thì gán bằng 0
            int tienNha = int.TryParse(txtTienNha.Text, out tienNha) ? tienNha : 0;
            int tienDien = int.TryParse(txtTienDien.Text, out tienDien) ? tienDien : 0;
            int tienNuoc = int.TryParse(txtTienNuoc.Text, out tienNuoc) ? tienNuoc : 0;
            int tienInternet = int.TryParse(txtTienInternet.Text, out tienInternet) ? tienInternet : 0;
            int tienRac = int.TryParse(txtTienRac.Text, out tienRac) ? tienRac : 0;
            int tienGiuXe = int.TryParse(txtTienGiuXe.Text, out tienGiuXe) ? tienGiuXe : 0;

            // Tính tổng tiền
            int tongTien = tienNha + tienDien + tienNuoc + tienInternet + tienRac + tienGiuXe;

            // Hiển thị tổng tiền lên txtTongTien
            txtTongTien.Text = tongTien.ToString();
        }

        private void txtTienNha_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTienInternet_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTienRac_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtTienGiuXe_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }
    }
}