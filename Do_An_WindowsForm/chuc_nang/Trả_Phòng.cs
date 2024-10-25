using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using Do_An_WindowsForm.model;
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

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class Tra_Phong : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhaTroDB quanly = new QuanLyNhaTroDB();

        public Tra_Phong()
        {
            InitializeComponent();

        }

       
        private void BindCheckoutData(List<PhieuTraPhong> list_traphong)
        {
            dgvDoanhThu.Rows.Clear();
            for (int i = 0; i < list_traphong.Count; i++)
            {
                int index = dgvDoanhThu.Rows.Add();
                dgvDoanhThu.Rows[index].Cells[0].Value = list_traphong[i].MaPTrP;
                dgvDoanhThu.Rows[index].Cells[1].Value = list_traphong[i].PhieuThuePhong.MaPhong;
                if (list_traphong[i].DaThanhtoan == 1)
                {
                    dgvDoanhThu.Rows[index].Cells[2].Value = true;
                }
                else
                {
                    dgvDoanhThu.Rows[index].Cells[2].Value = false;
                }
                dgvDoanhThu.Rows[index].Cells[3].Value = list_traphong[i].PhieuThuePhong.KhachHang.HoTen;
                dgvDoanhThu.Rows[index].Cells[4].Value = list_traphong[i].PhieuThuePhong.KhachHang.CMND_CanCuoc;
                dgvDoanhThu.Rows[index].Cells[5].Value = list_traphong[i].PhieuThuePhong.KhachHang.GioiTinh;
                dgvDoanhThu.Rows[index].Cells[6].Value = list_traphong[i].PhieuThuePhong.KhachHang.NgheNghiep;
                dgvDoanhThu.Rows[index].Cells[7].Value = list_traphong[i].PhieuThuePhong.KhachHang.QueQuan;
                dgvDoanhThu.Rows[index].Cells[8].Value = list_traphong[i].PhieuThuePhong.KhachHang.SDT;
                dgvDoanhThu.Rows[index].Cells[9].Value = list_traphong[i].NgayTra;


            }
        }

     

        
        private void FillDataChoiceRoom(List<Phong> phongList)
        {
            cmbChoiceRoom.DataSource = phongList;
            cmbChoiceRoom.DisplayMember = "MaPhong";
            cmbChoiceRoom.ValueMember = "MaPhong";
        }
        private void cmbChoiceRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb = cmbChoiceRoom.SelectedValue.ToString();
            PhieuThuePhong ph = quanly.PhieuThuePhongs.FirstOrDefault(p => p.MaPhong.ToString() == cmb);
            if (ph != null)
            {
                txtIDPhong.Text = ph.MaPhong.ToString();
                txtDienTich.Text = ph.Phong.DienTich.ToString();
                if (ph.Phong.TrangThai == 1)
                {
                    txtTrangThai.Text = "Đã thuê";
                }
                else
                {
                    txtTrangThai.Text = "Chưa cho thuê";
                }
                txtIDKhachThue.Text = ph.MaKH.ToString();
                txtTenNguoiThue.Text = ph.KhachHang.HoTen.ToString();
                txtCMND.Text = ph.KhachHang.CMND_CanCuoc
                    .ToString();
                txtNgheNghiep.Text = ph.KhachHang.NgheNghiep.ToString();
                txtNoiSinh.Text = ph.KhachHang.QueQuan;
            }
        }

        private void grpTTThuePhong_Enter(object sender, EventArgs e)
        {

        }
        private void setNull()
        {
            txtIDPhong.Text = "";
            txtDienTich.Text = "";            
                txtTrangThai.Text = "";
            txtIDKhachThue.Text = "";
            txtTenNguoiThue.Text = "";
            txtCMND.Text = "";
            txtNgheNghiep.Text = "";
            txtNoiSinh.Text = "";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PhieuTraPhong ph = quanly.PhieuTraPhongs.FirstOrDefault(p => p.PhieuThuePhong.Phong.MaPhong.ToString() == txtIDPhong.Text);
            if (ph == null)
            {
                Random random = new Random();
                int maPTrP = random.Next(100000, 999999);
                PhieuTraPhong ptrp = quanly.PhieuTraPhongs.FirstOrDefault(p => p.MaPTrP == maPTrP);
                if (ptrp != null)// nếu trùng thì random lại
                {
                    maPTrP = random.Next(100000, 999999);
                }
                PhieuThuePhong ptp = quanly.PhieuThuePhongs.FirstOrDefault(p => p.MaPhong.ToString() == txtIDPhong.Text);
                PhieuTraPhong data = new PhieuTraPhong();
                data.MaPTP = ptp.MaPTP;
                data.MaPTrP = maPTrP;
                data.NgayTra = dtbNgayTra.Value;
                data.DaThanhtoan = 0;
                quanly.PhieuTraPhongs.Add(data);
                quanly.SaveChanges();
                MessageBox.Show("Đăng ký trả phòng thành công!!!", "Thông báo", MessageBoxButtons.OK);
                setNull();
                List<PhieuTraPhong> list = quanly.PhieuTraPhongs.ToList();
                BindCheckoutData(list);

            }

        }

        private void Trả_Phòng_Load(object sender, EventArgs e)
        {
            List<PhieuTraPhong> list = quanly.PhieuTraPhongs.ToList();
            BindCheckoutData(list);
            List<Phong> listPhong = quanly.Phongs.Where(p => p.TrangThai == 1).ToList();
            FillDataChoiceRoom(listPhong);
            cmbChoiceRoom.Text = "";
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvDoanhThu.CurrentCell.RowIndex;
            int indexCell = dgvDoanhThu.CurrentCell.ColumnIndex;
            if (dgvDoanhThu.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                int data = int.Parse(dgvDoanhThu.Rows[e.RowIndex].Cells[1].Value.ToString());
                Phong phong = quanly.Phongs.FirstOrDefault(p => p.MaPhong== data);
                if (phong != null)
                {
                    phong.TrangThai = 0;
                    quanly.Phongs.AddOrUpdate(phong);
                }
                data = int.Parse(dgvDoanhThu.Rows[e.RowIndex].Cells[0].Value.ToString());
                PhieuTraPhong phieuTraPhong = quanly.PhieuTraPhongs.FirstOrDefault(p => p.MaPTrP == data);
                if (phieuTraPhong != null)
                {
                    phieuTraPhong.DaThanhtoan = 1;
                    quanly.PhieuTraPhongs.AddOrUpdate(phieuTraPhong);
                }
                quanly.SaveChanges();
                MessageBox.Show("Cập nhật trạng thái phiếu thành công", "Thông báo", MessageBoxButtons.OK);
                Trả_Phòng_Load(sender, e);
                setNull();
            }
        }
    }
}
