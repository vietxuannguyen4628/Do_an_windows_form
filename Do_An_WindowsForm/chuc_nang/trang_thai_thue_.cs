using DevExpress.XtraEditors;
using Do_An_WindowsForm.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.XtraInputBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class trang_thai_thue_ : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        List<Button> buttons = new List<Button>();
        private Button selectedRoom = null;
        
        public trang_thai_thue_()
        {
            InitializeComponent();
            groupPhong.Resize += new EventHandler(groupPhong_SizeChanged);
        }

        //private void trang_thai_thue__Load(object sender, EventArgs e)
        //{
        //    // khởi tạo màu cho backgroud của groupBox
        //    groupPhong.BackColor = Color.FromArgb(255, 224, 192);

        //    // Tạo và gán sự kiện cho các button GroupBox 
        //    foreach (Control control in groupPhong.Controls)
        //    {
        //        if (control is Button btn)
        //        {
        //            btn.BackColor = Color.White; // Mặc định màu là trắng
        //            btn.Click += new EventHandler(btnChooseASeat);
        //            buttons.Add(btn); // Thêm nút vào danh sách
        //        }
        //    }
        //    btnHuy.BackColor = Color.Red;
        //    btnThue.BackColor = Color.LimeGreen;

        //}
        private void trang_thai_thue__Load(object sender, EventArgs e)
        {
            // khởi tạo màu cho backgroud của groupBox
            groupPhong.BackColor = Color.FromArgb(255, 224, 192);
            List<Phong> listPhong = context.Phongs.ToList();
            // Tạo và gán sự kiện cho các button GroupBox 
             foreach (var item in listPhong)
            {
                foreach (Control control in groupPhong.Controls)
                {
                    //var find = context.Phongs.Where(p => p.TrangThai == 0).Select(p => p.TrangThai).FirstOrDefault();
                    //int aaaa = int.Parse(find);
                    if (control is Button btn)
                    {
                        //switch (var)
                        //{
                        //    case 
                        //}
                        btn.BackColor = Color.White; // Mặc định màu là trắng
                        btn.Click += new EventHandler(btnChooseASeat);
                        buttons.Add(btn); // Thêm nút vào danh sách
                    }
                }
            }           
            btnHuy.BackColor = Color.Red;
            btnThue.BackColor = Color.LimeGreen;
        }
        private void goupPhong_Enter(object sender, EventArgs e)
        {
            
        }
        private void btnChooseASeat(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if (btn.BackColor == Color.White) // phòng chưa được thuê
                {
                    if (selectedRoom != null)
                    {
                        MessageBox.Show("Bạn chỉ có thể chọn một phòng tại một thời điểm. Vui lòng bỏ chọn phòng hiện tại trước khi chọn phòng mới.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btn.BackColor = Color.Blue; // chọn phòng
                    selectedRoom = btn;
                }
                else if (btn.BackColor == Color.Blue) // phòng đã được chọn
                {
                    btn.BackColor = Color.White;
                    selectedRoom = null;
                }
                else if (btn.BackColor == Color.Yellow)
                {
                    MessageBox.Show("Phòng đã được thuê", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn huỷ bỏ lựa chọn?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (selectedRoom != null)
                {
                    selectedRoom.BackColor = Color.White;

                    selectedRoom = null;
                }
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (selectedRoom == null)
            {
                MessageBox.Show("Vui lòng chọn một phòng trước khi thuê.", "Thông Báo");
                return;
            }

            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thuê phòng này?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                selectedRoom.BackColor = Color.Yellow;
                selectedRoom = null;
            }
        }

        private void grTinhTrang_SizeChanged(object sender, EventArgs e)
        {

        }


        private void groupPhong_SizeChanged(object sender, EventArgs e)
        {
            //foreach (Control control in groupPhong.Controls)
            //{
            //    control.Width = groupPhong.Width / 12; // Điều chỉnh theo tỷ lệ mong muốn
            //    control.Height = groupPhong.Height / 6; // Điều chỉnh theo tỷ lệ mong muốn
            //    //control.Left = (groupPhong.Width - control.Width) / 12; // Căn giữa theo chiều ngang
            //    //control.Top = (groupPhong.Height - control.Height) / 6; // Căn giữa theo chiều dọc
            //}
        }

        private void fillPhong(List<Phong> listPhong)
        {

        }
    }   
}