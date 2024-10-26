namespace Do_An_WindowsForm.chuc_nang
{
    partial class BieuDoThongKe
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
            this.ctcThongKe = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctcThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // ctcThongKe
            // 
            this.ctcThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctcThongKe.Location = new System.Drawing.Point(0, 0);
            this.ctcThongKe.Name = "ctcThongKe";
            this.ctcThongKe.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ctcThongKe.Size = new System.Drawing.Size(686, 499);
            this.ctcThongKe.TabIndex = 0;
            this.ctcThongKe.Click += new System.EventHandler(this.ctcThongKe_Click);
            // 
            // BieuDoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 499);
            this.Controls.Add(this.ctcThongKe);
            this.Name = "BieuDoThongKe";
            this.Text = "Biểu đồ thống kê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.BieuDoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctcThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ctcThongKe;
    }
}