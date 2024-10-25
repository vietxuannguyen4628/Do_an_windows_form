namespace Do_An_WindowsForm
{
    partial class frm_Quan_Ly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Quan_Ly));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTrangThaiPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnHinhAnhPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSkhachthue = new DevExpress.XtraBars.BarButtonItem();
            this.btnDk = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.dev_1 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_2 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_3 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.btnTinhTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendMessage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbGroupThaoTacDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbHopDong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Silver;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnTrangThaiPhong,
            this.btnHinhAnhPhong,
            this.btnLogout,
            this.btnDSkhachthue,
            this.btnDk,
            this.barButtonItem5,
            this.barButtonItem6,
            this.dev_1,
            this.Dev_2,
            this.Dev_3,
            this.Dev_4,
            this.btnTraPhong,
            this.btnThongKe,
            this.btnTinhTien,
            this.btnSendMessage,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(1286, 158);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnTrangThaiPhong
            // 
            this.btnTrangThaiPhong.Caption = "Trạng thái thuê";
            this.btnTrangThaiPhong.Id = 1;
            this.btnTrangThaiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangThaiPhong.ImageOptions.Image")));
            this.btnTrangThaiPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrangThaiPhong.ImageOptions.LargeImage")));
            this.btnTrangThaiPhong.Name = "btnTrangThaiPhong";
            this.btnTrangThaiPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrangThaiPhong_Click);
            // 
            // btnHinhAnhPhong
            // 
            this.btnHinhAnhPhong.Caption = "Hình ảnh phòng";
            this.btnHinhAnhPhong.Id = 2;
            this.btnHinhAnhPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHinhAnhPhong.ImageOptions.Image")));
            this.btnHinhAnhPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHinhAnhPhong.ImageOptions.LargeImage")));
            this.btnHinhAnhPhong.Name = "btnHinhAnhPhong";
            this.btnHinhAnhPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHinhAnhPhong_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnDSkhachthue
            // 
            this.btnDSkhachthue.Caption = "Danh sách khách thuê";
            this.btnDSkhachthue.Id = 4;
            this.btnDSkhachthue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSkhachthue.ImageOptions.Image")));
            this.btnDSkhachthue.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSkhachthue.ImageOptions.LargeImage")));
            this.btnDSkhachthue.Name = "btnDSkhachthue";
            this.btnDSkhachthue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSkhachthue_Click);
            // 
            // btnDk
            // 
            this.btnDk.Caption = "Đăng ký hợp đồng thuê";
            this.btnDk.Id = 5;
            this.btnDk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDk.ImageOptions.Image")));
            this.btnDk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDk.ImageOptions.LargeImage")));
            this.btnDk.Name = "btnDk";
            this.btnDk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDk_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Sao lưu dữ liệu";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Backup";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // dev_1
            // 
            this.dev_1.Caption = "Nguyễn Xuân Việt";
            this.dev_1.Id = 9;
            this.dev_1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dev_1.ImageOptions.Image")));
            this.dev_1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dev_1.ImageOptions.LargeImage")));
            this.dev_1.Name = "dev_1";
            // 
            // Dev_2
            // 
            this.Dev_2.Caption = "Huỳnh Minh Quyền ";
            this.Dev_2.Id = 10;
            this.Dev_2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dev_2.ImageOptions.Image")));
            this.Dev_2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Dev_2.ImageOptions.LargeImage")));
            this.Dev_2.Name = "Dev_2";
            // 
            // Dev_3
            // 
            this.Dev_3.Caption = "Bạch Huỳnh Như Thuỷ";
            this.Dev_3.Id = 11;
            this.Dev_3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dev_3.ImageOptions.Image")));
            this.Dev_3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Dev_3.ImageOptions.LargeImage")));
            this.Dev_3.Name = "Dev_3";
            // 
            // Dev_4
            // 
            this.Dev_4.Caption = "Nguyễn Kim Quang";
            this.Dev_4.Id = 12;
            this.Dev_4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dev_4.ImageOptions.Image")));
            this.Dev_4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Dev_4.ImageOptions.LargeImage")));
            this.Dev_4.Name = "Dev_4";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Caption = "Hợp đồng trả phòng";
            this.btnTraPhong.Id = 13;
            this.btnTraPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.ImageOptions.Image")));
            this.btnTraPhong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.ImageOptions.LargeImage")));
            this.btnTraPhong.Name = "btnTraPhong";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Caption = "Thống Kê";
            this.btnThongKe.Id = 14;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.LargeImage")));
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThongKe_ItemClick);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Caption = "Tính Tiền";
            this.btnTinhTien.Id = 15;
            this.btnTinhTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhTien.ImageOptions.Image")));
            this.btnTinhTien.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Postponed;
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTinhTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhTien_ItemClick);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Caption = "Gửi Tin Nhắn";
            this.btnSendMessage.Id = 16;
            this.btnSendMessage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.ImageOptions.Image")));
            this.btnSendMessage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.ImageOptions.LargeImage")));
            this.btnSendMessage.Name = "btnSendMessage";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 17;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lí dịch vụ";
            this.barButtonItem2.Id = 18;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản Lý Phòng";
            this.barButtonItem3.Id = 19;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbGroupThaoTacDuLieu,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // rbGroupThaoTacDuLieu
            // 
            this.rbGroupThaoTacDuLieu.ItemLinks.Add(this.barButtonItem5);
            this.rbGroupThaoTacDuLieu.ItemLinks.Add(this.btnLogout);
            this.rbGroupThaoTacDuLieu.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.rbGroupThaoTacDuLieu.Name = "rbGroupThaoTacDuLieu";
            this.rbGroupThaoTacDuLieu.Text = "Thao tác với dữ liệu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý nhà trọ";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Phòng trọ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTrangThaiPhong);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnHinhAnhPhong);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTinhTien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Quản Lý Phòng Trọ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDSkhachthue);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Khách trọ";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbHopDong});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Hợp đồng";
            // 
            // rbHopDong
            // 
            this.rbHopDong.ItemLinks.Add(this.btnDk);
            this.rbHopDong.ItemLinks.Add(this.btnTraPhong);
            this.rbHopDong.Name = "rbHopDong";
            this.rbHopDong.Text = "Hợp Đồng";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbThongKe});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống kê";
            // 
            // rbThongKe
            // 
            this.rbThongKe.ItemLinks.Add(this.btnThongKe);
            this.rbThongKe.Name = "rbThongKe";
            this.rbThongKe.Text = "Thống Kê";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý phòng trọ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 158);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1286, 605);
            this.xtraTabControl1.TabIndex = 15;
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // frm_Quan_Ly
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1286, 763);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Quan_Ly.IconOptions.Image")));
            this.Name = "frm_Quan_Ly";
            this.Ribbon = this.ribbon;
            this.Text = "Quản Lý Phòng Trọ - Designed By Dev Lor";
            this.Load += new System.EventHandler(this.frm_Quan_Ly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTrangThaiPhong;
        private DevExpress.XtraBars.BarButtonItem btnHinhAnhPhong;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnDSkhachthue;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbHopDong;
        private DevExpress.XtraBars.BarButtonItem btnDk;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem dev_1;
        private DevExpress.XtraBars.BarButtonItem Dev_2;
        private DevExpress.XtraBars.BarButtonItem Dev_3;
        private DevExpress.XtraBars.BarButtonItem Dev_4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGroupThaoTacDuLieu;
        private DevExpress.XtraBars.BarButtonItem btnTraPhong;
        private DevExpress.XtraBars.BarButtonItem btnThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbThongKe;
        private DevExpress.XtraBars.BarButtonItem btnTinhTien;
        private DevExpress.XtraBars.BarButtonItem btnSendMessage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}