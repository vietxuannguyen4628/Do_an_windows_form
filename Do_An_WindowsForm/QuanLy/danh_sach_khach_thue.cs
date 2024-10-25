﻿using Do_An_WindowsForm.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class danh_sach_khach_thue : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB qltro = new QuanLyPhongTroDB();
        public danh_sach_khach_thue()
        {
            InitializeComponent();
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void FillTable(List<PhieuThuePhong> phieuthue)
        {
            dgvKhachHang.Rows.Clear();
            foreach (var item in phieuthue)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.MaKH;
                dgvKhachHang.Rows[index].Cells[1].Value = item.MaPhong;
                dgvKhachHang.Rows[index].Cells[2].Value = item.KhachHang.HoTen;
                dgvKhachHang.Rows[index].Cells[3].Value = item.KhachHang.GioiTinh;
                dgvKhachHang.Rows[index].Cells[4].Value = item.NgayThue;
                dgvKhachHang.Rows[index].Cells[5].Value = item.KhachHang.SDT;
            }
        }
        private void danh_sach_khach_thue_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvKhachHang);
            List<PhieuThuePhong> phieuthue = qltro.PhieuThuePhongs.ToList();
            FillTable(phieuthue);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}