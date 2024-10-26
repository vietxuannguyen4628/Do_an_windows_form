using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.QuanLy
{
    public partial class QuanLyDichVucs : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public QuanLyDichVucs()
        {
            InitializeComponent();
            dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPhong_CellContentClick);
        }

        private void QuanLyDichVucs_Load(object sender, EventArgs e)
        {
            List<DichVu> dichVus = context.DichVus.ToList();
            BindGrid(dichVus);
            FillcmbPhong(dichVus);
        }
        private void BindGrid(List<DichVu> dichVus)
        {
            dgvDichVu.Rows.Clear();
            foreach (var dv in dichVus)
            {
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = dv.MaDV;
                dgvDichVu.Rows[index].Cells[1].Value = dv.TenDV;
                dgvDichVu.Rows[index].Cells[2].Value = dv.DonGia;

            }
        }

        private void FillcmbPhong(List<DichVu> dichVus)
        {
            cmbID_DichVu.Items.Clear();
            foreach (DichVu dv in dichVus)
            {
                cmbID_DichVu.Items.Add(dv.MaDV);
            }
        }
        private void Clear()
        {
            txtDonGia.Text = "";
            txtID_DichVu.Text = "";
            txtTenDV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtID_DichVu.Enabled == false)
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn tạo thêm dịch vụ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    Clear();
                    txtID_DichVu.Enabled = true;
                }

            }
            else
            {
                try
                {
                    int item = int.Parse(txtID_DichVu.Text);
                    var dv = context.DichVus.FirstOrDefault(p => p.MaDV == item);
                    if (dv != null)
                        throw new Exception("Dịch vụ đã tồn tại");
                    else
                    {
                        DichVu d = new DichVu();
                        d.MaDV = item;
                        d.TenDV = txtTenDV.Text;
                        d.DonGia = int.Parse(txtDonGia.Text);
                        

                        context.DichVus.Add(d);
                        context.SaveChanges();
                        MessageBox.Show("Đã thêm dịch vụ thành công", "Thông Báo", MessageBoxButtons.OK);
                        Clear();
                        txtID_DichVu.Enabled = false;
                        List<DichVu> list = context.DichVus.ToList();
                        FillcmbPhong(list);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int item = int.Parse(txtID_DichVu.Text);
                var dv = context.DichVus.FirstOrDefault(p => p.MaDV == item);
                if (dv != null)
                {
                   dv.TenDV = txtTenDV.Text;
                   dv.DonGia = int.Parse(txtDonGia.Text) ;

                    context.DichVus.AddOrUpdate(dv);
                    context.SaveChanges();
                    MessageBox.Show("Đã cập nhật dịch thành công", "Thông Báo", MessageBoxButtons.OK);
                    Clear();
                }
                else
                    MessageBox.Show("Không tìm thấy dịch vụ cần cập nhập", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbID_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int item = int.Parse(cmbID_DichVu.Text);
                var dv = context.DichVus.FirstOrDefault(p => p.MaDV == item);
                if (dv != null)
                {
                    txtID_DichVu.Text = dv.MaDV.ToString();
                    txtTenDV.Text = dv.TenDV.ToString();
                    txtDonGia.Text = dv.DonGia.ToString();
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
            if (index >= 0 && index < dgvDichVu.Rows.Count - 1)
            {
                txtID_DichVu.Text = dgvDichVu.Rows[index].Cells[0].Value.ToString();
                txtTenDV.Text = dgvDichVu.Rows[index].Cells[1].Value.ToString();
                txtDonGia.Text = dgvDichVu.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int item = int.Parse(txtID_DichVu.Text);
            var dv = context.DichVus.FirstOrDefault(p=>p.MaDV == item);
            if (dv != null)
            {
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xoá" , "Xác Nhận", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    context.DichVus.Remove(dv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xoá dịch vụ thành công !!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Không tìm thấy dịch vụ cần xoá !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    
}