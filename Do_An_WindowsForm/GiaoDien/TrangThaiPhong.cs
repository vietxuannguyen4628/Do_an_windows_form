using DevExpress.XtraEditors;
using Do_An_WindowsForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.QuanLy
{
    public partial class TrangThaiPhong : DevExpress.XtraEditors.XtraUserControl
    {
        QuanLyPhongTroDB context = new QuanLyPhongTroDB();
        public TrangThaiPhong()
        {
            InitializeComponent();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            List<Phong> list = context.Phongs.ToList();
            foreach(var item in list)
            {
                int buttonWidth = 150;
                int buttonHeight = 150;
                int margin = 10;

                // Tạo button động dựa trên danh sách phòng
                for (int i = 0; i < list.Count; i++)
                {
                    Button btn = new Button();
                    btn.Width = buttonWidth;
                    btn.Height = buttonHeight;
                    

                    // Xác định vị trí của button trên form (tính toán theo hàng và cột)
                    int xPos = (i % 10) * (buttonWidth + margin);  // mỗi hàng có 10 button
                    int yPos = (i / 10) * (buttonHeight + margin); // các button kế tiếp nhau theo chiều dọc

                    btn.Left = xPos;
                    btn.Top = yPos;

                    // Đặt tên và trạng thái cho button
                    btn.Text = $"Phòng {list[i].MaPhong}";
                    btn.Tag = list[i].MaPhong; // Bạn có thể gắn thêm ID của phòng nếu cần

                    // Kiểm tra trạng thái thuê (0: chưa thuê, 1: đã thuê)
                    if (list[i].TrangThai == 1) // Đã thuê
                    {
                        btn.BackColor = Color.Yellow;
                    }
                    else // Chưa thuê
                    {
                        btn.BackColor = Color.White;
                    }

                    // Thêm button vào form
                    this.Controls.Add(btn);
                }
            }

        }
    }
}