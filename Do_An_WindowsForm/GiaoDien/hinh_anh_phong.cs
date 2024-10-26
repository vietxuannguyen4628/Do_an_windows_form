
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.XtraPrinting;

namespace Do_An_WindowsForm.chuc_nang
{
    public partial class hinh_anh_phong : System.Windows.Forms.UserControl
    {
        private string folderPath;

        public hinh_anh_phong()
        {
            InitializeComponent();
            SetupImageFolder();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void SetupImageFolder()
        {
            // Đường dẫn tương đối đến thư mục "anh" trong solution
            folderPath = Path.Combine(Application.StartupPath, @"..\..\Images");
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục ảnh không tồn tại!");
            }
        }

        private void LoadImages()
        {
            try
            {
                string[] supportedExtensions = new[] { "*.jpg", "*.jpeg", "*.png", "*.gif", "*.bmp" };
                var files = supportedExtensions.SelectMany(ext => Directory.GetFiles(folderPath, ext)).ToList();

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    Image img = Image.FromFile(file);
                    imageList1.Images.Add(fileName, img);

                    ListViewItem item = new ListViewItem(fileName);
                    item.ImageKey = fileName;
                    listView1.Items.Add(item);
                }

                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy ảnh trong thư mục!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }

        private void hinh_anh_phong_Load(object sender, EventArgs e)
        {
            SetupImageFolder();
            SetupListView();
            LoadImages();
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Tên file", 500);

            imageList1.ImageSize = new Size(50, 50);
            listView1.SmallImageList = imageList1;
        }

    }
}

        
