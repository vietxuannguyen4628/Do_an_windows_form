using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static DevExpress.Data.Mask.Internal.MaskSettings<T>;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

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
            cbDien.Checked = false;
            cbNuoc.Checked = false;
            cbInternet.Checked = false;
            cbRac.Checked = false;
            cbGiuXe.Checked = false;
            cmbChonPhong.SelectedText = "";
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
            try
            {
                if (cbDien.Checked == false && cbNuoc.Checked ==  false && cbInternet.Checked == false && cbRac.Checked == false && cbGiuXe.Checked ==false) 
                    throw new Exception("Vui lòng chọn dịch vụ muốn tính tiền");
                long item = int.Parse(txtID_Phong.Text) + int.Parse(txtID_Khach.Text);
                var ptp = context.PhieuThuePhongs.FirstOrDefault(p => p.MaPTP == item);
                if (ptp != null)
                {
                    if (cbDien.Checked)
                    {
                        var dien = context.DichVus.FirstOrDefault(p => p.TenDV == "Điện");
                        var ct = context.CT_SuDungDV.FirstOrDefault(p => p.MaPTP == ptp.MaPTP && p.MaDV == dien.MaDV);
                        if (ct != null)
                        {
                            long id = dien.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                            var ptt = context.PhieuThutiens.FirstOrDefault(p => p.MaPTT == id);
                            if (ptt == null)
                            {
                                PhieuThutien pThu = new PhieuThutien();
                                pThu.MaPTT = dien.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                                pThu.MaPTP = ptp.MaPTP;
                                pThu.MaDV = dien.MaDV;
                                pThu.NgayThanhToan = dateThu.Value;
                                pThu.ThanhTien = int.Parse(txtTienDien.Text);
                                context.PhieuThutiens.Add(pThu);
                                context.SaveChanges();
                                MessageBox.Show("Tiền điện tháng này đã thu thành công", "Thông Báo", MessageBoxButtons.OK);
                                setNull();

                                ct.ChiSoCu = ct.ChiSoMoi;
                                ct.ChiSoMoi = int.Parse(txtSoDienMoi.Text);
                                context.CT_SuDungDV.AddOrUpdate(ct);
                                context.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Tiền điện tháng này đã được thu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                setNull();
                            }

                        }
                    }

                    if (cbNuoc.Checked)
                    {
                        var dv = context.DichVus.FirstOrDefault(p => p.TenDV == "Nước");
                        var ct = context.CT_SuDungDV.FirstOrDefault(p => p.MaPTP == ptp.MaPTP && p.MaDV == dv.MaDV);
                        if (ct != null)
                        {
                            int id = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                            var ptt = context.PhieuThutiens.FirstOrDefault(p => p.MaPTT == id);
                            if (ptt == null)
                            {
                                PhieuThutien pThu = new PhieuThutien();
                                pThu.MaPTT = id;
                                pThu.MaPTP = ptp.MaPTP;
                                pThu.MaDV = dv.MaDV;
                                pThu.NgayThanhToan = dateThu.Value;
                                pThu.ThanhTien = int.Parse(txtTienNuoc.Text);
                                context.PhieuThutiens.Add(pThu);
                                context.SaveChanges();
                                MessageBox.Show("Tiền nước tháng này đã thu thành công", "Thông Báo", MessageBoxButtons.OK);
                                setNull();

                                ct.ChiSoCu = ct.ChiSoMoi;
                                ct.ChiSoMoi = int.Parse(txtSoNuocMoi.Text);
                                context.CT_SuDungDV.AddOrUpdate(ct);
                                context.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Tiền nước tháng này đã được thu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                setNull();
                            }
                        }
                    }
                    if (cbInternet.Checked)
                    {
                        var dv = context.DichVus.FirstOrDefault(p => p.TenDV == "Internet");
                        int id = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                        var ptt = context.PhieuThutiens.FirstOrDefault(p => p.MaPTT == id);
                        if (ptt == null)
                        {
                            PhieuThutien pThu = new PhieuThutien();
                            pThu.MaPTT = id;
                            pThu.MaPTP = ptp.MaPTP;
                            pThu.MaDV = dv.MaDV;
                            pThu.NgayThanhToan = dateThu.Value;
                            pThu.ThanhTien = int.Parse(txtTienInternet.Text);
                            context.PhieuThutiens.Add(pThu);
                            context.SaveChanges();
                            MessageBox.Show("Tiền internet tháng này đã thu thành công", "Thông Báo", MessageBoxButtons.OK);
                            setNull();
                        }
                        else
                        {
                            MessageBox.Show("Tiền internet tháng này đã được thu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            setNull();
                        }


                    }
                    if (cbRac.Checked)
                    {
                        var dv = context.DichVus.FirstOrDefault(p => p.TenDV == "Rác");
                        long id = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                        var ptt = context.PhieuThutiens.FirstOrDefault(p => p.MaPTT == id);
                        if (ptt == null)
                        {
                            PhieuThutien pThu = new PhieuThutien();
                            pThu.MaPTT = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                            pThu.MaPTP = ptp.MaPTP;
                            pThu.MaDV = dv.MaDV;
                            pThu.NgayThanhToan = dateThu.Value;
                            pThu.ThanhTien = int.Parse(txtTienRac.Text);
                            context.PhieuThutiens.Add(pThu);
                            context.SaveChanges();
                            MessageBox.Show("Tiền rác tháng này đã thu thành công", "Thông Báo", MessageBoxButtons.OK);
                            setNull();
                        }
                        else
                        {
                            MessageBox.Show("Tiền rác tháng này đã được thu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            setNull();
                        }
                    }
                    if (cbGiuXe.Checked)
                    {
                        var dv = context.DichVus.FirstOrDefault(p => p.TenDV == "Giữ Xe");
                        long id = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                        var ptt = context.PhieuThutiens.FirstOrDefault(p => p.MaPTT == id);
                        if (ptt == null)
                        {
                            PhieuThutien pThu = new PhieuThutien();
                            pThu.MaPTT = dv.MaDV + ptp.MaPTP + dateThu.Value.Month + dateThu.Value.Year;
                            pThu.MaPTP = ptp.MaPTP;
                            pThu.MaDV = dv.MaDV;
                            pThu.NgayThanhToan = dateThu.Value;
                            pThu.ThanhTien = int.Parse(txtTienGiuXe.Text);
                            context.PhieuThutiens.Add(pThu);
                            context.SaveChanges();
                            MessageBox.Show("Tiền giữ xe tháng này đã thu thành công", "Thông Báo", MessageBoxButtons.OK);
                            setNull();
                        }
                        else
                        {
                            MessageBox.Show("Tiền giữ xe tháng này đã được thu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            setNull();
                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
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



        private void txtSoDienMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TinhTienDien_Nuoc();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void txtSoDienMoi_Leave(object sender, EventArgs e)
        {
            TinhTienDien_Nuoc();
        }

        private void TinhTienDien_Nuoc()
        {
            PhieuThuePhong _phieuthue = context.PhieuThuePhongs.FirstOrDefault(pt => pt.MaPhong.ToString() == cmbChonPhong.Text);
            if (_phieuthue != null)
            {
                // tim dich vu dien
                DichVu dichVuDien = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == "Điện");
                int dvDien = 0;
                if (dichVuDien != null)
                {
                    if (txtSoDienMoi.Text != "")
                    {
                        if (int.Parse(txtSoDienMoi.Text) < int.Parse(txtSoDienCu.Text))
                        {
                            MessageBox.Show("Chỉ số điện mới không được nhỏ hơn chỉ số cũ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSoDienMoi.Text = txtSoDienCu.Text;
                        }
                        else
                        {
                            dvDien = (int.Parse(txtSoDienMoi.Text) - int.Parse(txtSoDienCu.Text)) * dichVuDien.DonGia.Value;
                        }
                        txtTienDien.Text = dvDien.ToString();
                    }
                    else
                    {
                        txtSoDienMoi.Text = txtSoDienCu.Text;
                    }
                }

                // tim dich vu nuoc
                DichVu dichVuNuoc = context.DichVus.FirstOrDefault(dvI => dvI.TenDV == "Nước");
                int dvNuoc = 0;
                if (dichVuNuoc != null)
                {
                    if (txtSoNuocMoi.Text != "")
                    {
                        if (int.Parse(txtSoNuocMoi.Text) < int.Parse(txtSoNuocCu.Text))
                        {
                            MessageBox.Show("Chỉ số nước mới không được nhỏ hơn chỉ số cũ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSoNuocMoi.Text = txtSoNuocCu.Text;
                        }
                        else
                        {
                            dvNuoc = (int.Parse(txtSoNuocMoi.Text) - int.Parse(txtSoNuocCu.Text)) * dichVuNuoc.DonGia.Value;
                        }
                        txtTienNuoc.Text = dvNuoc.ToString();
                    }
                    else
                    {
                        txtSoNuocMoi.Text = txtSoNuocCu.Text;
                    }
                }

            }

        }

        private void txtSoNuocMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TinhTienDien_Nuoc();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtSoNuocMoi_Leave(object sender, EventArgs e)
        {
            TinhTienDien_Nuoc();
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