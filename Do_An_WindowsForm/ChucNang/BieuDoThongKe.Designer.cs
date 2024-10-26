namespace Do_An_WindowsForm.ChucNang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BieuDoThongKe));
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
            this.ctcThongKe.Size = new System.Drawing.Size(941, 514);
            this.ctcThongKe.TabIndex = 0;
            // 
            // BieuDoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(941, 514);
            this.Controls.Add(this.ctcThongKe);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BieuDoThongKe.IconOptions.LargeImage")));
            this.Name = "BieuDoThongKe";
            this.Text = "Biểu đồ thống kê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BieuDoThongKe_FormClosing);
            this.Load += new System.EventHandler(this.BieuDoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctcThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ctcThongKe;
    }
}
