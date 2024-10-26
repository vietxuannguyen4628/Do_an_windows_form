﻿using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Do_An_WindowsForm.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class BieuDoThongKe : DevExpress.XtraEditors.XtraForm
    {
        QuanLyNhaTroDB ql = new QuanLyNhaTroDB();
        public DateTime checkTime { get; set; }
        private Form parentform;
        public BieuDoThongKe(Form parentform)
        {
            InitializeComponent();
            this.parentform = parentform;
        }

        private void BieuDoThongKe_Load(object sender, EventArgs e)
        {
            int nam = 0;
            nam = int.Parse(checkTime.ToString("yyyy"));
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "BIỂU ĐỒ THỐNG KÊ DOANH THU NĂM" + nam.ToString();
            chartTitle.Dock = ChartTitleDockStyle.Top;  
            chartTitle.Alignment = StringAlignment.Center; 
            chartTitle.Font = new Font("Tahoma", 16, FontStyle.Bold); 
            chartTitle.TextColor = Color.Red;  
            ctcThongKe.Titles.Add(chartTitle);
            Series series = new Series(string.Empty, ViewType.Bar);
            ((BarSeriesView)series.View).BarWidth = 0.5;
            Bindata(nam, series);            
            ctcThongKe.Series.Add(series);
            ctcThongKe.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Center;
            ctcThongKe.Legend.AlignmentVertical = LegendAlignmentVertical.Bottom;
            ctcThongKe.Padding.Top = 20;  
        }
        private int tienDV(int thang, int nam)
        {
            int money = 0;
            DateTime tgxet = new DateTime(nam, thang, 1);
            List<CT_SuDungDV> list = ql.CT_SuDungDV.Where(p => p.PhieuThutien.DenNgay.Value.Month == tgxet.Month && p.PhieuThutien.DenNgay.Value.Year == tgxet.Year).ToList();
            for (int i = 0; i < list.Count; i++)
                money = money + ((int.Parse(list[i].ChiSoMoi.ToString()) - int.Parse(list[i].ChiSoCu.ToString())) * int.Parse(list[i].DichVu.DonGia.ToString()));
            return money;
        }
        private int tienphong(int thang, int nam)
        {

            DateTime tgxet = new DateTime(nam, thang, 1);

            if (tgxet.Year <= DateTime.Now.Year)
            {
                List<PhieuThuePhong> phong = ql.PhieuThuePhongs.Where(p => p.NgayThue.Value.Year == tgxet.Year && p.NgayThue.Value.Month <= tgxet.Month && p.Phong.TrangThai == 1).ToList();
                int money = 0;
                if (phong != null)
                {
                    for (int i = 0; i < phong.Count; i++)
                    {
                        money = money + int.Parse(phong[i].Phong.GiaTien.ToString());
                    }
                }
                List<PhieuTraPhong> phieutra = ql.PhieuTraPhongs.Where(p => p.PhieuThuePhong.NgayThue.Value.Year == tgxet.Year && p.PhieuThuePhong.NgayThue.Value.Month <= tgxet.Month && p.NgayTra.Value.Year == tgxet.Year && p.NgayTra.Value.Month >= tgxet.Month && p.PhieuThuePhong.Phong.TrangThai == 0).ToList();
                if (phieutra != null)
                {
                    for (int i = 0; i < phieutra.Count; i++)
                        money = money + int.Parse(phieutra[i].PhieuThuePhong.Phong.GiaTien.ToString());
                }
                return money;
            }
            else
            { return 0; }

        }
        private void Bindata(int nam, Series sr)
        {
            for (int i = 1; i <= 12; i++)
            {
                sr.Points.Add(new SeriesPoint("Tháng " + i, (tienphong(i, nam) + tienDV(i, nam))));
            }
        }

       

        private void Exit(object sender, FormClosingEventArgs e)
        {
            parentform.Close();
        }

        private void ctcThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}