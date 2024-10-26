namespace Do_An_WindowsForm.chuc_nang
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
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNGUOITHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHONG,
            this.TENNGUOITHUE,
            this.CMND,
            this.NGAYTHU,
            this.TONGTIENDV,
            this.TIENPHONG,
            this.THANHTIEN});
            this.dgvDoanhThu.Location = new System.Drawing.Point(66, 82);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(932, 449);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick);
            // 
            // MAPHONG
            // 
            this.MAPHONG.HeaderText = "Mã phòng thuê";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.Width = 125;
            // 
            // TENNGUOITHUE
            // 
            this.TENNGUOITHUE.HeaderText = "Tên người thuê";
            this.TENNGUOITHUE.MinimumWidth = 6;
            this.TENNGUOITHUE.Name = "TENNGUOITHUE";
            this.TENNGUOITHUE.Width = 125;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 125;
            // 
            // NGAYTHU
            // 
            this.NGAYTHU.HeaderText = "NGAYTHU";
            this.NGAYTHU.MinimumWidth = 6;
            this.NGAYTHU.Name = "NGAYTHU";
            this.NGAYTHU.Width = 125;
            // 
            // TONGTIENDV
            // 
            this.TONGTIENDV.HeaderText = "Tổng tiền dịch vụ";
            this.TONGTIENDV.MinimumWidth = 6;
            this.TONGTIENDV.Name = "TONGTIENDV";
            this.TONGTIENDV.Width = 125;
            // 
            // TIENPHONG
            // 
            this.TIENPHONG.HeaderText = "Tiền phòng ";
            this.TIENPHONG.MinimumWidth = 6;
            this.TIENPHONG.Name = "TIENPHONG";
            this.TIENPHONG.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // dtptungay
            // 
            this.dtptungay.Location = new System.Drawing.Point(204, 26);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(200, 23);
            this.dtptungay.TabIndex = 1;
            this.dtptungay.ValueChanged += new System.EventHandler(this.dtptungay_ValueChanged);
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Location = new System.Drawing.Point(438, 26);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(200, 23);
            this.dtpdenngay.TabIndex = 2;
            this.dtpdenngay.ValueChanged += new System.EventHandler(this.dtpdenngay_ValueChanged);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(826, 531);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(172, 23);
            this.txttongtien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(120, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(410, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(803, 24);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(195, 30);
            this.btnChart.TabIndex = 7;
            this.btnChart.Text = "Biểu đồ thống kê";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.dtpdenngay);
            this.Controls.Add(this.dtptungay);
            this.Controls.Add(this.dgvDoanhThu);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1061, 566);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChart;
    }
}
