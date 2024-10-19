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
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.dev_1 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_2 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_3 = new DevExpress.XtraBars.BarButtonItem();
            this.Dev_4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbGroupThaoTacDuLieu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
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
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.dev_1,
            this.Dev_2,
            this.Dev_3,
            this.Dev_4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1031, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbGroupThaoTacDuLieu});
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
            this.ribbonPageGroup2});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Hợp đồng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống kê";
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 675);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1031, 24);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 158);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1031, 517);
            this.xtraTabControl1.TabIndex = 15;
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // frm_Quan_Ly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 699);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Quan_Ly.IconOptions.Image")));
            this.Name = "frm_Quan_Ly";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Phòng Trọ - Designed By Dev Lor";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem dev_1;
        private DevExpress.XtraBars.BarButtonItem Dev_2;
        private DevExpress.XtraBars.BarButtonItem Dev_3;
        private DevExpress.XtraBars.BarButtonItem Dev_4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbGroupThaoTacDuLieu;
    }
}