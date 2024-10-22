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
            this.NGAYTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpThoigian = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHONG,
            this.TENNGUOITHUE,
            this.NGAYTHU,
            this.TIENDV,
            this.TIENPHONG,
            this.THANHTIEN});
            this.dgvDoanhThu.Location = new System.Drawing.Point(139, 71);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(803, 460);
            this.dgvDoanhThu.TabIndex = 0;
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
            // NGAYTHU
            // 
            this.NGAYTHU.HeaderText = "NGAYTHU";
            this.NGAYTHU.MinimumWidth = 6;
            this.NGAYTHU.Name = "NGAYTHU";
            this.NGAYTHU.Width = 125;
            // 
            // TIENDV
            // 
            this.TIENDV.HeaderText = "Tiền dịch vụ ";
            this.TIENDV.MinimumWidth = 6;
            this.TIENDV.Name = "TIENDV";
            this.TIENDV.Width = 125;
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
            // dtpThoigian
            // 
            this.dtpThoigian.Location = new System.Drawing.Point(327, 26);
            this.dtpThoigian.Name = "dtpThoigian";
            this.dtpThoigian.Size = new System.Drawing.Size(200, 23);
            this.dtpThoigian.TabIndex = 1;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpThoigian);
            this.Controls.Add(this.dgvDoanhThu);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1061, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DateTimePicker dtpThoigian;
    }
}
