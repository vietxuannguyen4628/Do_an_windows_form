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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Do_An_WindowsForm
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        string username = "admin";
        string password = "abc@123";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Hãy nhập đủ thông tin người dùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtUsername.Text != username || txtPassword.Text != password)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu đăng nhập không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập chính xác!", "Thông Báo", MessageBoxButtons.OK);
                        this.Hide();
                        frm_Quan_Ly ql = new frm_Quan_Ly();
                        ql.ShowDialog();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tính năng đang được cập nhật!", ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chứ!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}