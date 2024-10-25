//using Newtonsoft.Json.Linq;
//using ZaloCSharpSDK;
using Do_An_WindowsForm.chuc_nang;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;


namespace Do_An_WindowsForm
{
    public partial class frm_Quan_Ly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public frm_Quan_Ly()
        {
            InitializeComponent();
            // mở thuộc tính để hiển thị nút "x" trên tab có sẵn trong dev expess
            xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            // xử lý sự kiện đóng tab khi người dùng nhấn vào dấu "x"
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
        }

        private void dev1_information_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTrangThaiPhong_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Kiểm tra xem tab đã tồn tại hay chưa
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        // Nếu tab đã tồn tại, chọn tab đó và thoát khỏi phương thức
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHinhAnhPhong_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;
                //newTab.AutoSizeChanged();
                // Tạo một instance của UserControl
                hinh_anh_phong hinhAnhPhongControl = new hinh_anh_phong();

                // Đặt DockStyle cho UserControl
                hinhAnhPhongControl.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(hinhAnhPhongControl);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Xử lý sự kiện khi người dùng nhấn vào nút "X" để đóng tab
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            // Xác định tab mà người dùng nhấn "X"
            DevExpress.XtraTab.XtraTabPage tabPage = (sender as DevExpress.XtraTab.XtraTabControl).SelectedTabPage;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng tab này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa tab
                xtraTabControl1.TabPages.Remove(tabPage);
            }
        }

        private void btnDSkhachthue_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Kiểm tra xem tab đã tồn tại hay chưa
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        // Nếu tab đã tồn tại, chọn tab đó và thoát khỏi phương thức
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                // Tạo một instance của UserControl
                danh_sach_khach_thue ds_khach_thue = new danh_sach_khach_thue();

                // Đặt DockStyle cho UserControl
                ds_khach_thue.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(ds_khach_thue);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Chương trình quản lý phòng trọ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes)
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frm_Quan_Ly_Load(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                newTab.Text = "Giới Thiệu";

                // Tạo một instance của UserControl
                backgound bg = new backgound();

                // Đặt DockStyle cho UserControl
                bg.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(bg);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Kiểm tra xem tab đã tồn tại hay chưa
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        // Nếu tab đã tồn tại, chọn tab đó và thoát khỏi phương thức
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                // Tạo một instance của UserControl
                DangKy dk_hopDong = new DangKy();

                // Đặt DockStyle cho UserControl
                dk_hopDong.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(dk_hopDong);

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnTinhTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Kiểm tra xem tab đã tồn tại hay chưa
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        // Nếu tab đã tồn tại, chọn tab đó và thoát khỏi phương thức
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

            
               

                

                // Thêm XtraTabPage vào XtraTabControl
                xtraTabControl1.TabPages.Add(newTab);

                // Chọn tab mới
                xtraTabControl1.SelectedTabPage = newTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnSendMessage_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    
        //}
    }
}