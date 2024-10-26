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

namespace Do_An_WindowsForm.QuanLy
{
    public partial class QuanLyPhong : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public QuanLyPhong()
        {
            InitializeComponent();
            dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPhong_CellContentClick);
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            List<Phong> phong = context.Phongs.ToList();
            BindGrid(phong);
            FillcmbPhong(phong);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BindGrid(List<Phong> phongs)
        {
            dgvPhong.Rows.Clear();
            foreach (Phong phong in phongs)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = phong.MaPhong;
                dgvPhong.Rows[index].Cells[1].Value = phong.DienTich;
                if (phong.TrangThai == 0)
                    dgvPhong.Rows[index].Cells[2].Value = "Chưa thuê";
                else
                    dgvPhong.Rows[index].Cells[2].Value = "Đã thuê";
                dgvPhong.Rows[index].Cells[3].Value = phong.GiaTien;

            }
        }
        private void FillcmbPhong(List<Phong> phongs)
        {
            cmbID_Phong.Items.Clear();
            foreach(Phong phong in phongs)
            {
                cmbID_Phong.Items.Add(phong.MaPhong);
            }
        }

        private void cmbID_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int item = int.Parse(cmbID_Phong.Text);
                var phong = context.Phongs.FirstOrDefault(p => p.MaPhong == item);
                if (phong != null)
                {
                    txtID_Phong.Text = phong.MaPhong.ToString();
                    txtDienTich.Text = phong.DienTich.ToString();
                    txtGiaTien.Text = phong.GiaTien.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvPhong.Rows.Count - 1)
            {
                txtID_Phong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
                txtDienTich.Text = dgvPhong.Rows[index].Cells[1].Value.ToString();
                txtGiaTien.Text = dgvPhong.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int item = int.Parse(txtID_Phong.Text);
                var phong = context.Phongs.FirstOrDefault(p=>p.MaPhong == item);
                if (phong != null) 
                {
                    phong.DienTich = float.Parse(txtDienTich.Text);
                    phong.GiaTien = int.Parse(txtGiaTien.Text);

                    context.Phongs.AddOrUpdate(phong);
                    context.SaveChanges();
                    List<Phong> p = context.Phongs.ToList();
                    BindGrid(p);
                    MessageBox.Show("Đã cập nhật phòng thành công", "Thông Báo", MessageBoxButtons.OK);
                    Clear();
                }
                else
                    MessageBox.Show("Không tìm thấy phòng cần cập nhập", "Thông Báo", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            txtDienTich.Text = "";
            txtGiaTien.Text = "";
            txtID_Phong.Text = "";
            cmbID_Phong.Text = "";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtID_Phong.Enabled == false)
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn tạo thêm phòng?" , "Xác Nhận" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    Clear();
                    txtID_Phong.Enabled = true;
                }
               

            }
            else
            {
                try
                {
                    int item = int.Parse(txtID_Phong.Text);
                    var phong = context.Phongs.FirstOrDefault(p=>p.MaPhong == item);
                    if (phong != null)
                        throw new Exception("Phòng đã tồn tại");
                    else
                    {
                        Phong p = new Phong();
                        p.MaPhong = item;
                        p.DienTich = float.Parse(txtDienTich.Text);
                        p.TrangThai = 0;
                        p.GiaTien = int.Parse(txtGiaTien.Text);

                        context.Phongs.Add(p);
                        context.SaveChanges();
                        MessageBox.Show("Đã thêm phòng thành công", "Thông Báo", MessageBoxButtons.OK);
                        Clear();
                        txtID_Phong.Enabled = false;
                        List<Phong> list = context.Phongs.ToList();
                        FillcmbPhong(list);
                        List<Phong> ph = context.Phongs.ToList();
                        BindGrid(ph);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}