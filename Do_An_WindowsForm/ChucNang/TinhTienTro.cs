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
        //private string tendichvu = null;
        public TinhTienTro()
        {
            InitializeComponent();
            cbDien.CheckedChanged += new EventHandler(xuly);
            cbNuoc.CheckedChanged += new EventHandler(xuly);
        }
        private void setNull()
        {
            txtID_Khach.Text = "";
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
            txtTienNha.Text = "";
            txtSoDienCu.Text = "";
            txtSoDienMoi.Text = "";
            txtSoNuocCu.Text = "";
            txtSoNuocMoi.Text = "";
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtTienInternet.Text = "0";
            txtTienRac.Text = "0";
            txtSLXe.Text = "0";
            txtTienGiuXe.Text = "0";
            txtTongTien.Text = "0";
            txtSoDienMoi.Text = "";
            txtSoNuocMoi.Text = "";
            txtSLXe.Text = "0";
        }
        private void load()
        {
            cmbChonPhong.SelectedItem = null;
            setNull();
        }

        private void fillPhongThue(List<PhieuThuePhong> phieuthue)
        {
            this.cmbChonPhong.DataSource = phieuthue;
            this.cmbChonPhong.DisplayMember = "MaPhong";
            this.cmbChonPhong.ValueMember = "MaPTP";
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
            if (_phieuthue != null)
            {
                dateThue.EditValue = _phieuthue.NgayThue.Value;
                txtID_Khach.Text = _phieuthue.MaKH.ToString();
                txtHoTen.Text = _phieuthue.KhachHang.HoTen.ToString();
                txtCCCD.Text = _phieuthue.KhachHang.CMND_CanCuoc.ToString();
                txtNgheNghiep.Text = _phieuthue.KhachHang.NgheNghiep.ToString();
                txtSDT.Text = _phieuthue.KhachHang.SDT.ToString();
                txtTienNha.Text = _phieuthue.Phong.GiaTien.ToString();

                var ctDien = context.CT_SuDungDV.FirstOrDefault(c => c.DichVu.TenDV == "Điện" && c.MaPTP == _phieuthue.MaPTP);
                if (ctDien != null)
                {
                    txtSoDienCu.Text = ctDien.ChiSoMoi.ToString();
                }
                var ctNuoc = context.CT_SuDungDV.FirstOrDefault(c => c.DichVu.TenDV == "Nước" && c.MaPTP == _phieuthue.MaPTP);
                if (ctNuoc != null)
                {
                    txtSoNuocCu.Text = ctNuoc.ChiSoMoi.ToString();
                }

            }
        }

        private void xuly(object sender, EventArgs e)
        {
            
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
                txtSLXe.Enabled = true;
                txtTienGiuXe.Text = ((dichVu.DonGia) * int.Parse(txtSLXe.Text)).ToString();
            }
            else if (cbGiuXe.Checked == false)
            {               
                txtSLXe.Enabled = false;
                txtTienGiuXe.Text = "0";
            }
        }

        private void txtSLXe_TextChanged(object sender, EventArgs e)
        {
            DichVu dichVu = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == "Giữ Xe");
            txtTienGiuXe.Text = ((dichVu.DonGia) * int.Parse(txtSLXe.Text)).ToString();
        }

        private void txtSoDienMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNuocMoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}