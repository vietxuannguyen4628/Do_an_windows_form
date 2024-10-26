using Do_An_WindowsForm.chuc_nang;
using Do_An_WindowsForm.QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frm_Quan_Ly());
            //Application.Run(new Login());
            //Application.Run(new TinhTien());
            Application.Run(new TinhTienTro());
        }
    }
}
