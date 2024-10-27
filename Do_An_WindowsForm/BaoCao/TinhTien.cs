using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm.BaoCao
{
    public partial class TinhTien : DevExpress.XtraEditors.XtraForm
    {
        public TinhTien()
        {
            InitializeComponent();
        }
        public void LoadData(int phieuThue, int thang, int nam)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLyPhongTroDB_Viet"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("PHIEUTHUTIENKH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Truyền tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@PHIEUTHUE", phieuThue);
                        cmd.Parameters.AddWithValue("@THANG", thang);
                        cmd.Parameters.AddWithValue("@NAM", nam);

                        // Thực hiện và lấy dữ liệu vào DataTable
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Đường dẫn đến file .rdlc
                        reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\BaoCao\PhieuTinhTien.rdlc";

                        // Đặt nguồn dữ liệu cho ReportViewer
                        ReportDataSource rds = new ReportDataSource("RegistrationDataSet", dataTable);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);

                        // Làm mới report để hiển thị
                        reportViewer1.RefreshReport();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra: " + ex.Message);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}