﻿//using Newtonsoft.Json.Linq;
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
using Do_An_WindowsForm.QuanLy;
using Do_An_WindowsForm.BaoCao;
using Do_An_WindowsForm.ChucNang;
using System.Threading;
using System.Data.SqlClient;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using System.IO;
using System.Xml.Linq;


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

        private async Task LoadUserControlDataAsync(Control userControl)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
            });
        }

        private async Task ShowWithDelayAsync(XtraTabPage tabPage, Control waitForm, Control mainForm, int delay)
        {
            tabPage.Controls.Add(waitForm);
            waitForm.Dock = DockStyle.Fill;

            // Bắt đầu tải dữ liệu cho mainForm ở chế độ nền
            await LoadUserControlDataAsync(mainForm);

            // Đợi thêm delay để giữ WaitForm hiển thị đủ thời gian
            await Task.Delay(delay);

            // Sau khi delay, thay WaitForm bằng mainForm
            tabPage.Controls.Remove(waitForm);
            tabPage.Controls.Add(mainForm);
            mainForm.Dock = DockStyle.Fill;
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
                newTab.Text = e.Item.Caption;
                TrangThaiPhong trangThaiPhong = new TrangThaiPhong();
                trangThaiPhong.Dock = DockStyle.Fill;
                newTab.Controls.Add(trangThaiPhong);


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

        private async void frm_Quan_Ly_Load(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage
                {
                    Text = "Giới Thiệu"
                };

                // Tạo WaitForm và background
                WaitForm wait = new WaitForm();
                backgound bg = new backgound();

                // Thêm tab vào XtraTabControl và chọn tab này
                xtraTabControl1.TabPages.Add(newTab);
                xtraTabControl1.SelectedTabPage = newTab;

                // Gọi hàm ShowWithDelay với thời gian delay là 1,5s
                await ShowWithDelayAsync(newTab, wait, bg, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void btnDk_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage
                {
                    Text = e.Item.Caption
                };

                // Tạo WaitForm và background
                WaitForm wait = new WaitForm();
                DangKy dk  = new DangKy();

                // Thêm tab vào XtraTabControl và chọn tab này
                xtraTabControl1.TabPages.Add(newTab);
                xtraTabControl1.SelectedTabPage = newTab;

                // Gọi hàm ShowWithDelay với thời gian delay là 1,5s
                await ShowWithDelayAsync(newTab, wait, dk, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
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
                BaoCaoDoanhThu doanhThu = new BaoCaoDoanhThu();

                // Đặt DockStyle cho UserControl
                doanhThu.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(doanhThu);

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
                TinhTienTro tinhTienTro = new TinhTienTro();
                tinhTienTro.Dock = DockStyle.Fill;
                newTab.Controls.Add(tinhTienTro);

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

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                
                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {                       
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                QuanLyPhong quanLyPhong = new QuanLyPhong();
                quanLyPhong.Dock = DockStyle.Fill;
                newTab.Controls.Add(quanLyPhong);
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                QuanLyDichVucs quanLyDichvu = new QuanLyDichVucs();
                quanLyDichvu.Dock = DockStyle.Fill;
                newTab.Controls.Add(quanLyDichvu);
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

        private void btnTraPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                {
                    if (tab.Text == e.Item.Caption)
                    {
                        xtraTabControl1.SelectedTabPage = tab;
                        return;
                    }
                }

                // Nếu tab chưa tồn tại, tạo một XtraTabPage mới
                DevExpress.XtraTab.XtraTabPage newTab = new DevExpress.XtraTab.XtraTabPage();

                // Đặt tên tab giống với tên button
                newTab.Text = e.Item.Caption;

                TraPhong traPhong = new TraPhong();
                traPhong.Dock = DockStyle.Fill;
                newTab.Controls.Add(traPhong);
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

        private void btnDoanh_Thu_ItemClick(object sender, ItemClickEventArgs e)
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
                DoanhThu doanhthus = new DoanhThu();

                // Đặt DockStyle cho UserControl
                doanhthus.Dock = DockStyle.Fill;

                // Thêm UserControl vào XtraTabPage
                newTab.Controls.Add(doanhthus);

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

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}