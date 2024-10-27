namespace Do_An_WindowsForm.ChucNang
{
    partial class DoanhThu
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
            this.btnChart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNGUOITHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChart
            // 
            this.btnChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChart.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnChart.Location = new System.Drawing.Point(1152, 12);
            this.btnChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(195, 60);
            this.btnChart.TabIndex = 15;
            this.btnChart.Text = "Biểu đồ thống kê";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(498, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời gian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(1047, 689);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttongtien.Location = new System.Drawing.Point(1152, 691);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(168, 21);
            this.txttongtien.TabIndex = 11;
            this.txttongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpdenngay.CustomFormat = "dd/MM/yyyy";
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdenngay.Location = new System.Drawing.Point(597, 33);
            this.dtpdenngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(156, 21);
            this.dtpdenngay.TabIndex = 10;
            this.dtpdenngay.ValueChanged += new System.EventHandler(this.dtpdenngay_ValueChanged);
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHONG,
            this.TENNGUOITHUE,
            this.CMND,
            this.NGAYTHU,
            this.TONGTIENDV,
            this.TIENPHONG,
            this.THANHTIEN});
            this.dgvDoanhThu.Location = new System.Drawing.Point(0, 79);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1400, 597);
            this.dgvDoanhThu.TabIndex = 8;
            // 
            // MAPHONG
            // 
            this.MAPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPHONG.HeaderText = "Mã phòng thuê";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            // 
            // TENNGUOITHUE
            // 
            this.TENNGUOITHUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNGUOITHUE.HeaderText = "Tên người thuê";
            this.TENNGUOITHUE.MinimumWidth = 6;
            this.TENNGUOITHUE.Name = "TENNGUOITHUE";
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            // 
            // NGAYTHU
            // 
            this.NGAYTHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTHU.HeaderText = "Ngày thu";
            this.NGAYTHU.MinimumWidth = 6;
            this.NGAYTHU.Name = "NGAYTHU";
            // 
            // TONGTIENDV
            // 
            this.TONGTIENDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TONGTIENDV.HeaderText = "Tổng tiền dịch vụ";
            this.TONGTIENDV.MinimumWidth = 6;
            this.TONGTIENDV.Name = "TONGTIENDV";
            // 
            // TIENPHONG
            // 
            this.TIENPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TIENPHONG.HeaderText = "Tiền phòng ";
            this.TIENPHONG.MinimumWidth = 6;
            this.TIENPHONG.Name = "TIENPHONG";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.dtpdenngay);
            this.Controls.Add(this.dgvDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1401, 743);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}
