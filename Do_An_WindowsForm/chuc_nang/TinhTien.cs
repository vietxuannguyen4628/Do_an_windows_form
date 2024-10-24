using DevExpress.XtraEditors;
using Do_An_WindowsForm.model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaloCSharpSDK;

namespace Do_An_WindowsForm.chuc_nang
{
    //public partial class TinhTien : DevExpress.XtraEditors.XtraUserControl
    public partial class TinhTien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        //private int sodien;
        //private int sodien;
        //private int sodien;
        //private int sodien;
        //private int sodien;
        //private int sodien;
        public TinhTien()
        {
            InitializeComponent();
            cbDien.CheckedChanged += new EventHandler(txtTienDien_TextChanged);
            cbNuoc.CheckedChanged += new EventHandler(txtSoNuoc_TextChanged);
        }
        private void setNull()
        {
            txtSoDien.Text = "0";
            txtSoNuoc.Text = "0";
            txtTienNha.Text = "0";
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtTienInternet.Text = "0";
            txtTienInternet.Text = "0";
            txtTienGiuXe.Text = "0";
            txtTongTien.Text = "0";
        }
        private void fillPhongThue(List<PhieuThuePhong> phieuthue)
        {
            this.cmbChonPhong.DataSource = phieuthue;
            this.cmbChonPhong.DisplayMember = "MaPhong";
            this.cmbChonPhong.ValueMember = "MaPTP";
        }
        private void fillKhachThue(List<PhieuThuePhong> khachthue)
        {
            dgv_DanhSachPhieu.Rows.Clear();
            foreach (var item in khachthue)
            {
                int index = dgv_DanhSachPhieu.Rows.Add();
                dgv_DanhSachPhieu.Rows[index].Cells[0].Value = item.MaPTP;
                dgv_DanhSachPhieu.Rows[index].Cells[1].Value = item.MaPhong;
                dgv_DanhSachPhieu.Rows[index].Cells[2].Value = item.MaKH;
                dgv_DanhSachPhieu.Rows[index].Cells[3].Value = item.KhachHang.HoTen;
                //dgv_DanhSachPhieu.Rows[index].Cells[4].Value = item.MaPTP;
                dgv_DanhSachPhieu.Rows[index].Cells[5].Value = item.Phong.GiaTien;
                dgv_DanhSachPhieu.Rows[index].Cells[6].Value = item.MaPTP;
                dgv_DanhSachPhieu.Rows[index].Cells[7].Value = item.MaPTP;
            }
        }
        private void TinhTien_Load(object sender, EventArgs e)
        {
            setNull();
            cmbChonPhong.SelectedItem = null;
            List<PhieuThuePhong> listPhieuThue = context.PhieuThuePhongs.ToList();
            fillPhongThue(listPhieuThue);
        }
        private void tinhTong()
        {
            
            //int tientro = int.Parse(txtTienNha.Text);
            float tiendien = float.Parse(txtTienDien.Text);
            float tiennuoc = float.Parse(txtTienNuoc.Text);
            int tieninternet = int.Parse(txtTienInternet.Text);
            int tiengiuxe = int.Parse(txtTienGiuXe.Text);

            txtTongTien.Text = (tiendien + tiennuoc + tieninternet + tiengiuxe).ToString();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //// Lấy thông tin từ các TextBox
            //string hoTen = txtHoTen.Text;         // TextBox nhập họ tên
            //string phong = cmbChonPhong.Text;
            //string soDienThoai = txtSDT.Text;  // TextBox nhập số điện thoại
            //string soDien = txtSoDien.Text;   // 
            //string soNuoc = txtSoNuoc.Text;   // 
            //string tienNha = txtTienNha.Text;
            //string tienDien = txtTienDien.Text;
            //string tienInternet = txtTienInternet.Text;
            //string tienGiuXe = txtTienGiuXe.Text;
            //string tongTien = txtTongTien.Text;   // TextBox nhập tổng tiền

            //// Nội dung tin nhắn
            //string message = $"Xin chào {hoTen}\t{phong}\t{soDienThoai},\tSố tiền bạn phải trả tháng này là {tongTien} đồng.\n" +  
            //    $"Chi tiết: {soDien}\t{soNuoc}\t{tienNha}\t{tienDien}\t{tienInternet}\t{tienGiuXe}.";

            //// Gửi tin nhắn qua Zalo
            //SendMessage(soDienThoai, message);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Hàm gửi tin nhắn qua Zalo
        private void SendMessage(string phoneNumber, string message)
        {
            //try
            //{
            //    // Access Token của ứng dụng Zalo bạn đã tạo
            //    string accessToken = "YOUR_ZALO_ACCESS_TOKEN";

            //    // Khởi tạo SDK của Zalo
            //    ZaloAppInfo appInfo = new ZaloAppInfo(ACCESS_TOKEN, "APP_SECRET", "REDIRECT_URI");
            //    ZaloBaseClient zaloClient = new ZaloBaseClient(appInfo);

            //    // Tạo nội dung tin nhắn JSON
            //    JObject recipient = new JObject
            //    {
            //        { "user_id_by_phone", phoneNumber }
            //    };
            //    JObject content = new JObject
            //    {
            //        { "text", message }
            //    };

            //    // Gửi yêu cầu POST tới API Zalo để gửi tin nhắn
            //    JObject response = zaloClient.SendMessageText(recipient, content);

            //    if (response != null && response["message"]?.ToString() == "Success")
            //    {
            //        MessageBox.Show("Tin nhắn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Gửi tin nhắn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Đã xảy ra lỗi khi gửi tin nhắn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDien_TextChanged(object sender, EventArgs e)
        {
            int sodien = int.Parse(txtSoDien.Text);
            txtTienDien.Text = (sodien * 3300).ToString();
            tinhTong();
        }

        private void txtSoNuoc_TextChanged(object sender, EventArgs e)
        {
            int sonuoc = int.Parse(txtSoNuoc.Text);
            txtTienNuoc.Text = (sonuoc * 10000).ToString();
            tinhTong();
        }
    }
}
