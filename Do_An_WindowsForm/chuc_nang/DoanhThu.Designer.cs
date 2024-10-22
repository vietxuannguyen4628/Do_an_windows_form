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
            this.dgvDoanhThu.Location = new System.Drawing.Point(66, 76);
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
            this.dtptungay.Location = new System.Drawing.Point(240, 26);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(200, 23);
            this.dtptungay.TabIndex = 1;
            this.dtptungay.ValueChanged += new System.EventHandler(this.dtpThoigian_ValueChanged);
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Location = new System.Drawing.Point(564, 26);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(200, 23);
            this.dtpdenngay.TabIndex = 2;
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
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
