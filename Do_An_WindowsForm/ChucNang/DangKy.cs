using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class DangKy : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public DangKy()
        {
            InitializeComponent();
            dgv_PhongTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgv_PhongTro_CellContentClick_1);
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            List<PhieuThuePhong> phieuThuePhongs = context.PhieuThuePhongs.ToList();
            List<Phong> phongs = context.Phongs.Where(p=>p.TrangThai == 0).ToList();
            BindGrid(phieuThuePhongs);
            cmbID_Phong.Text = "";
            cbFalse.Checked = true;
            cbNu.Checked = true;
        }

        private void BindGrid(List<PhieuThuePhong> phieuThuePhongs) 
        {
            dgv_PhongTro.Rows.Clear();
            foreach(var  p in phieuThuePhongs)
            {
                int index = dgv_PhongTro.Rows.Add();
                dgv_PhongTro.Rows[index].Cells[0].Value = p.Phong.MaPhong;
                dgv_PhongTro.Rows[index].Cells[1].Value = p.KhachHang.MaKH;
                dgv_PhongTro.Rows[index].Cells[2].Value = p.KhachHang.HoTen;
                dgv_PhongTro.Rows[index].Cells[3].Value = p.KhachHang.CMND_CanCuoc;
                dgv_PhongTro.Rows[index].Cells[4].Value = p.KhachHang.GioiTinh;
                dgv_PhongTro.Rows[index].Cells[5].Value = p.KhachHang.NgheNghiep;
                dgv_PhongTro.Rows[index].Cells[6].Value = p.KhachHang.QueQuan;
                dgv_PhongTro.Rows[index].Cells[7].Value = p.KhachHang.SDT;
                dgv_PhongTro.Rows[index].Cells[8].Value = p.NgayThue;
                dgv_PhongTro.Rows[index].Cells[9].Value = p.TienDacCoc;
                dgv_PhongTro.Rows[index].Cells[10].Value = p.Phong.GiaTien;
            }
        }

        private void Clear()
        {
            txtCCCD.Text = "";
            txtGiaTien.Text = "";
            txtHoTen.Text = "";
            txtID_Khach.Text = "";
            txtID_Phong.Text = "";
            txtNgheNghiep.Text = "";
            txtQueQuan.Text = "";
            txtSDT.Text = "";
        }

        private void dgv_PhongTro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cbTrue.Checked = true;
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_PhongTro.Rows.Count - 1)
            {
                txtID_Phong.Text = dgv_PhongTro.Rows[index].Cells[0].Value.ToString();
                txtID_Khach.Text = dgv_PhongTro.Rows[index].Cells[1].Value.ToString();
                txtHoTen.Text = dgv_PhongTro.Rows[index].Cells[2].Value.ToString();
                txtCCCD.Text = dgv_PhongTro.Rows[index].Cells[3].Value.ToString();
                if (dgv_PhongTro.Rows[index].Cells[4].Value.ToString() == "Nữ")
                    cbNu.Checked = true;
                else
                    cbNam.Checked = true;
                txtNgheNghiep.Text = dgv_PhongTro.Rows[index].Cells[5].Value.ToString();
                txtQueQuan.Text = dgv_PhongTro.Rows[index].Cells[6].Value.ToString();
                txtSDT.Text = dgv_PhongTro.Rows[index].Cells[7].Value.ToString();
                dtNgayThue.Text = dgv_PhongTro.Rows[index].Cells[8].Value.ToString();
                txtTienCoc.Text = dgv_PhongTro.Rows[index].Cells[9].Value.ToString();
                txtGiaTien.Text = dgv_PhongTro.Rows[index].Cells[10].Value.ToString();
            }
        }

        private void cmbID_Phong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int item = int.Parse(cmbID_Phong.Text);
            var p = context.Phongs.FirstOrDefault(pc => pc.MaPhong == item);
            if (p != null)
            {
                txtID_Phong.Text = p.MaPhong.ToString();
                txtGiaTien.Text = p.GiaTien.ToString();
                var ph = context.PhieuThuePhongs.FirstOrDefault(a => a.Phong.MaPhong == p.MaPhong);
                if (cbTrue.Checked && ph != null)
                {
                    txtID_Khach.Text = ph.KhachHang.MaKH.ToString();
                    txtHoTen.Text = ph.KhachHang.HoTen.ToString();
                    txtCCCD.Text = ph.KhachHang.CMND_CanCuoc.ToString();
                    txtNgheNghiep.Text = ph.KhachHang.NgheNghiep.ToString();
                    txtQueQuan.Text = ph.KhachHang.QueQuan.ToString();
                    txtSDT.Text = ph.KhachHang.SDT.ToString();
                    txtTienCoc.Text = ph.TienDacCoc.ToString();
                    if (ph.KhachHang.GioiTinh == "Nữ")
                        cbNu.Checked = true;
                    else
                        cbNam.Checked = true;

                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbTrue_CheckedChanged(object sender, EventArgs e)
        {
            List<Phong> phongs = context.Phongs.ToList();
            cmbID_Phong.Text = "";
            cmbID_Phong.Items.Clear();
            foreach (var p in phongs)
            {
                if (p.TrangThai == 1)
                {
                    cmbID_Phong.Items.Add(p.MaPhong);
                }
            }
            Clear();
        }

        private void cbFalse_CheckedChanged(object sender, EventArgs e)
        {
            List<Phong> phongs = context.Phongs.ToList();
            cmbID_Phong.Text = "";
            cmbID_Phong.Items.Clear();
            foreach (var p in phongs)
            {
                if (p.TrangThai == 0)
                {
                    cmbID_Phong.Items.Add(p.MaPhong);
                }
            }
            Clear();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTrue.Checked && cmbID_Phong.Text != "")
                    throw new Exception("Phòng này đã được thuê");
                if (txtID_Phong.Text == "")
                    throw new Exception("Vui lòng chọn phòng muốn thuê");
                if (txtID_Khach.Text == "" || txtHoTen.Text == "" || txtCCCD.Text == "" || txtNgheNghiep.Text == "" || txtQueQuan.Text == "" || txtSDT.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng");


                int item = int.Parse(txtID_Khach.Text);
                int idP = int.Parse(cmbID_Phong.Text);
                var phieu = context.PhieuThuePhongs.FirstOrDefault(p => p.MaKH == item && p.MaPhong == idP);
                if (phieu != null)
                {
                    throw new Exception("Phiếu đã tồn tại");
                }
                else
                {

                    var k = context.KhachHangs.FirstOrDefault(p => p.MaKH == item);
                    if (k == null)
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = int.Parse(txtID_Khach.Text);
                        kh.HoTen = txtHoTen.Text;
                        kh.CMND_CanCuoc = txtCCCD.Text;
                        kh.SDT = txtSDT.Text;
                        kh.QueQuan = txtQueQuan.Text;
                        kh.NgheNghiep = txtNgheNghiep.Text;
                        if (cbNu.Checked)
                            kh.GioiTinh = "Nữ";
                        else
                            kh.GioiTinh = "Nam";

                        context.KhachHangs.Add(kh);
                        context.SaveChanges();

                        PhieuThuePhong ph = new PhieuThuePhong();
                        ph.MaPTP = idP + item;
                        ph.MaPhong = idP;
                        ph.MaKH = item;
                        ph.TienDacCoc = int.Parse(txtTienCoc.Text);
                        ph.NgayThue = dtNgayThue.Value;
                        //ph.DaThanhToan = 0;
                        context.PhieuThuePhongs.Add(ph);
                        context.SaveChanges();
                        MessageBox.Show("Đã đăng ký thuê phòng thành công!", "Thông báo", MessageBoxButtons.OK);

                        var phong = context.Phongs.FirstOrDefault(p => p.MaPhong == idP);
                        phong.TrangThai = 1;
                        context.Phongs.AddOrUpdate(phong);
                        context.SaveChanges();
                        Clear();
                        DangKy_Load(sender, e);
                    }
                    else
                        throw new Exception("Khách hàng đã tồn tại");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Clear();
            try
            {

                for (int i = 0; i < dgv_PhongTro.Rows.Count; i++)
                {
                    if (dgv_PhongTro.Rows[i].Cells[0].Value != null)
                        if (dgv_PhongTro.Rows[i].Cells[0].Value.ToString().ToLower().Contains(txtSearch.Text))
                        {
                            dgv_PhongTro.Rows[i].Visible = true;
                        }
                        else
                            dgv_PhongTro.Rows[i].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Khach.Text == "" || txtHoTen.Text == "" || txtCCCD.Text == "" || txtNgheNghiep.Text == "" || txtQueQuan.Text == "" || txtSDT.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin khách hàng!!");

                int item = int.Parse(txtID_Khach.Text);
                var k = context.KhachHangs.FirstOrDefault(p => p.MaKH == item);
                if (k != null)
                {
                    k.HoTen = txtHoTen.Text;
                    k.CMND_CanCuoc = txtCCCD.Text;
                    k.SDT = txtSDT.Text;
                    k.QueQuan = txtQueQuan.Text;
                    k.NgheNghiep = txtNgheNghiep.Text;
                    if (cbNu.Checked)
                        k.GioiTinh = "Nữ";
                    else
                        k.GioiTinh = "Nam";

                    context.KhachHangs.AddOrUpdate(k);
                    context.SaveChanges();
                    var ph = context.PhieuThuePhongs.FirstOrDefault(p => p.KhachHang.MaKH == k.MaKH);
                    ph.TienDacCoc = int.Parse(txtTienCoc.Text);
                    MessageBox.Show("Đã cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    Clear();
                    DangKy_Load(sender, e);
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin khách hàng!!", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thoát??", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}