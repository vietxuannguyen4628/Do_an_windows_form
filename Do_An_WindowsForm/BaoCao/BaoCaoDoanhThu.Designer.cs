﻿namespace Do_An_WindowsForm.BaoCao
{
    partial class BaoCaoDoanhThu
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
            this.reportDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportDoanhThu
            // 
            this.reportDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDoanhThu.LocalReport.ReportEmbeddedResource = "Do_An_WindowsForm.BaoCao.DoanhThu.rdlc";
            this.reportDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.reportDoanhThu.Name = "reportDoanhThu";
            this.reportDoanhThu.ServerReport.BearerToken = null;
            this.reportDoanhThu.Size = new System.Drawing.Size(1367, 601);
            this.reportDoanhThu.TabIndex = 0;
            this.reportDoanhThu.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.reportDoanhThu);
            this.Name = "BaoCaoDoanhThu";
            this.Size = new System.Drawing.Size(1367, 601);
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDoanhThu;
    }
}