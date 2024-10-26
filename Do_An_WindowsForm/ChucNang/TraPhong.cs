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

namespace Do_An_WindowsForm.chuc_nang
{

    public partial class TraPhong : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public TraPhong()
        {
            InitializeComponent();
            dgvTraPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvDoanhThu_CellContentClick);
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            List<PhieuTraPhong> list = context.PhieuTraPhongs.ToList();
            BindCheckoutData(list);
            List<Phong> listPhong = context.Phongs.Where(p => p.TrangThai == 1).ToList();
            FillDataChoiceRoom(listPhong);
            cmbChoiceRoom.Text = "";
        }

        private void grpTTChuThue_Enter(object sender, EventArgs e)
        {

        }

        private void grpTraPhong_Enter(object sender, EventArgs e)
        {

        }

        private void BindCheckoutData(List<PhieuTraPhong> list_traphong)
        {
            dgvTraPhong.Rows.Clear();
            for (int i = 0; i < list_traphong.Count; i++)
            {
                int index = dgvTraPhong.Rows.Add();
                dgvTraPhong.Rows[index].Cells[0].Value = list_traphong[i].PhieuThuePhong.MaPTP;
                dgvTraPhong.Rows[index].Cells[1].Value = list_traphong[i].PhieuThuePhong.MaPhong;
                dgvTraPhong.Rows[index].Cells[2].Value = list_traphong[i].PhieuThuePhong.MaKH;
                dgvTraPhong.Rows[index].Cells[3].Value = list_traphong[i].PhieuThuePhong.KhachHang.HoTen;
                dgvTraPhong.Rows[index].Cells[4].Value = list_traphong[i].PhieuThuePhong.KhachHang.CMND_CanCuoc;
                dgvTraPhong.Rows[index].Cells[5].Value = list_traphong[i].PhieuThuePhong.KhachHang.GioiTinh;
                dgvTraPhong.Rows[index].Cells[6].Value = list_traphong[i].PhieuThuePhong.KhachHang.NgheNghiep;
                dgvTraPhong.Rows[index].Cells[7].Value = list_traphong[i].PhieuThuePhong.KhachHang.QueQuan;
                dgvTraPhong.Rows[index].Cells[8].Value = list_traphong[i].PhieuThuePhong.KhachHang.SDT;



            }
        }




        private void FillDataChoiceRoom(List<Phong> phongList)
        {
            cmbChoiceRoom.DataSource = phongList;
            cmbChoiceRoom.DisplayMember = "MaPhong";
            cmbChoiceRoom.ValueMember = "MaPhong";
        }

        private void setNull()
        {
            txtIDPhong.Text = "";
            txtIDKhachThue.Text = "";
            txtTenNguoiThue.Text = "";
            txtCMND.Text = "";
            txtNgheNghiep.Text = "";
            txtSDT.Text = "";
        }

        private void cmbChoiceRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb = cmbChoiceRoom.SelectedValue.ToString();
            PhieuThuePhong ph = context.PhieuThuePhongs.FirstOrDefault(p => p.MaPhong.ToString() == cmb);
            if (ph != null)
            {
                txtIDPhong.Text = ph.MaPhong.ToString();

                txtIDKhachThue.Text = ph.MaKH.ToString();
                txtTenNguoiThue.Text = ph.KhachHang.HoTen.ToString();
                txtCMND.Text = ph.KhachHang.CMND_CanCuoc
                    .ToString();
                txtNgheNghiep.Text = ph.KhachHang.NgheNghiep.ToString();
                txtSDT.Text = ph.KhachHang.QueQuan;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PhieuTraPhong ph = context.PhieuTraPhongs.FirstOrDefault(p => p.PhieuThuePhong.Phong.MaPhong.ToString() == txtIDPhong.Text);
            if (ph == null)
            {
                Random random = new Random();
                int maPTrP = random.Next(100000, 999999);
                PhieuTraPhong ptrp = context.PhieuTraPhongs.FirstOrDefault(p => p.MaPTrP == maPTrP);
                if (ptrp != null)// nếu trùng thì random lại
                {
                    maPTrP = random.Next(100000, 999999);
                }
                PhieuThuePhong ptp = context.PhieuThuePhongs.FirstOrDefault(p => p.MaPhong.ToString() == txtIDPhong.Text);
                PhieuTraPhong data = new PhieuTraPhong();
                data.MaPTP = ptp.MaPTP;
                data.MaPTrP = maPTrP;
                data.NgayTra = dateNgayTra.Value;
                data.DaThanhtoan = 0;
                context.PhieuTraPhongs.Add(data);
                context.SaveChanges();
                MessageBox.Show("Trả phòng thành công!!!", "Thông báo", MessageBoxButtons.OK);
                setNull();
                List<PhieuTraPhong> list = context.PhieuTraPhongs.ToList();
                BindCheckoutData(list);

            }
        }

        private void dgvDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; 
            if (index >= 0 && index < dgvTraPhong.Rows.Count -1 )
            {
                txtIDPhong.Text = dgvTraPhong.Rows[index].Cells[1].Value.ToString(); ;
                txtIDKhachThue.Text = dgvTraPhong.Rows[index].Cells[2].Value.ToString();
                txtTenNguoiThue.Text = dgvTraPhong.Rows[index].Cells[3].Value.ToString();
                txtCMND.Text = dgvTraPhong.Rows[index].Cells[4].Value.ToString();
                txtNgheNghiep.Text = dgvTraPhong.Rows[index].Cells[6].Value.ToString();
                txtSDT.Text = dgvTraPhong.Rows[index].Cells[8].Value.ToString();
            }
        }

        private void grpTTKhachThue_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNguoiThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtIDKhachThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void grpTTThuePhong_Enter(object sender, EventArgs e)
        {

        }

        private void txtIDPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}