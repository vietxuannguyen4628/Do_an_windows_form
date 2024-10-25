namespace Do_An_WindowsForm.chuc_nang
{
    partial class Tra_Phong
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
            this.grpTraPhong = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dtbNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpTTChuThue = new System.Windows.Forms.GroupBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.txtIDKhachThue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpTTThuePhong = new System.Windows.Forms.GroupBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbChoiceRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChonPhong = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MaPTrP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTraPhong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.grpTTChuThue.SuspendLayout();
            this.grpTTThuePhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTraPhong
            // 
            this.grpTraPhong.Controls.Add(this.groupBox1);
            this.grpTraPhong.Controls.Add(this.dtbNgayTra);
            this.grpTraPhong.Controls.Add(this.btnXacNhan);
            this.grpTraPhong.Controls.Add(this.grpTTChuThue);
            this.grpTraPhong.Controls.Add(this.grpTTThuePhong);
            this.grpTraPhong.Controls.Add(this.cmbChoiceRoom);
            this.grpTraPhong.Controls.Add(this.label2);
            this.grpTraPhong.Controls.Add(this.lblChonPhong);
            this.grpTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTraPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTraPhong.Location = new System.Drawing.Point(0, 0);
            this.grpTraPhong.Name = "grpTraPhong";
            this.grpTraPhong.Size = new System.Drawing.Size(942, 505);
            this.grpTraPhong.TabIndex = 0;
            this.grpTraPhong.TabStop = false;
            this.grpTraPhong.Text = "TRẢ PHÒNG";
//            this.grpTraPhong.Enter += new System.EventHandler(this.grpTraPhong_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hiển thị";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPTrP,
            this.MaPhong,
            this.TrangThaiThue,
            this.HoTen,
            this.CMND,
            this.GioiTinh,
            this.NgheNghiep,
            this.NoiSinh,
            this.SDT,
            this.NgayTra});
            this.dgvDoanhThu.Location = new System.Drawing.Point(19, 25);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(890, 116);
            this.dgvDoanhThu.TabIndex = 11;
            this.dgvDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick);
            // 
            // dtbNgayTra
            // 
            this.dtbNgayTra.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgayTra.Location = new System.Drawing.Point(713, 34);
            this.dtbNgayTra.Name = "dtbNgayTra";
            this.dtbNgayTra.Size = new System.Drawing.Size(119, 23);
            this.dtbNgayTra.TabIndex = 10;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(15, 261);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(117, 45);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // grpTTChuThue
            // 
            this.grpTTChuThue.Controls.Add(this.txtNoiSinh);
            this.grpTTChuThue.Controls.Add(this.txtNgheNghiep);
            this.grpTTChuThue.Controls.Add(this.txtCMND);
            this.grpTTChuThue.Controls.Add(this.txtTenNguoiThue);
            this.grpTTChuThue.Controls.Add(this.txtIDKhachThue);
            this.grpTTChuThue.Controls.Add(this.label12);
            this.grpTTChuThue.Controls.Add(this.label11);
            this.grpTTChuThue.Controls.Add(this.label10);
            this.grpTTChuThue.Controls.Add(this.label7);
            this.grpTTChuThue.Controls.Add(this.label6);
            this.grpTTChuThue.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTChuThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTChuThue.Location = new System.Drawing.Point(444, 72);
            this.grpTTChuThue.Name = "grpTTChuThue";
            this.grpTTChuThue.Size = new System.Drawing.Size(486, 245);
            this.grpTTChuThue.TabIndex = 7;
            this.grpTTChuThue.TabStop = false;
            this.grpTTChuThue.Text = "THÔNG TIN CHỦ THUÊ";
//            this.grpTTChuThue.Enter += new System.EventHandler(this.grpTTChuThue_Enter);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(168, 178);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(248, 28);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(168, 134);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(248, 28);
            this.txtNgheNghiep.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(168, 90);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(248, 28);
            this.txtCMND.TabIndex = 11;
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Location = new System.Drawing.Point(168, 52);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(248, 28);
            this.txtTenNguoiThue.TabIndex = 8;
            // 
            // txtIDKhachThue
            // 
            this.txtIDKhachThue.Location = new System.Drawing.Point(168, 18);
            this.txtIDKhachThue.Name = "txtIDKhachThue";
            this.txtIDKhachThue.Size = new System.Drawing.Size(248, 28);
            this.txtIDKhachThue.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nơi sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nghề nghiệp: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "CMND:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên người thuê:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách thuê:";
            // 
            // grpTTThuePhong
            // 
            this.grpTTThuePhong.Controls.Add(this.txtDienTich);
            this.grpTTThuePhong.Controls.Add(this.txtTrangThai);
            this.grpTTThuePhong.Controls.Add(this.label3);
            this.grpTTThuePhong.Controls.Add(this.lblTrangThai);
            this.grpTTThuePhong.Controls.Add(this.txtIDPhong);
            this.grpTTThuePhong.Controls.Add(this.label5);
            this.grpTTThuePhong.Controls.Add(this.label4);
            this.grpTTThuePhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTThuePhong.ForeColor = System.Drawing.Color.Black;
            this.grpTTThuePhong.Location = new System.Drawing.Point(15, 72);
            this.grpTTThuePhong.Name = "grpTTThuePhong";
            this.grpTTThuePhong.Size = new System.Drawing.Size(423, 183);
            this.grpTTThuePhong.TabIndex = 6;
            this.grpTTThuePhong.TabStop = false;
            this.grpTTThuePhong.Text = "THÔNG TIN THUÊ PHÒNG";
            this.grpTTThuePhong.Enter += new System.EventHandler(this.grpTTThuePhong_Enter);
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(85, 127);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(254, 28);
            this.txtDienTich.TabIndex = 6;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(85, 78);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(254, 28);
            this.txtTrangThai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diện tích ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(7, 90);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(66, 16);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(85, 35);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(254, 28);
            this.txtIDPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // cmbChoiceRoom
            // 
            this.cmbChoiceRoom.FormattingEnabled = true;
            this.cmbChoiceRoom.Location = new System.Drawing.Point(107, 24);
            this.cmbChoiceRoom.Name = "cmbChoiceRoom";
            this.cmbChoiceRoom.Size = new System.Drawing.Size(180, 32);
            this.cmbChoiceRoom.TabIndex = 0;
            this.cmbChoiceRoom.SelectedIndexChanged += new System.EventHandler(this.cmbChoiceRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(624, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày trả:";
            // 
            // lblChonPhong
            // 
            this.lblChonPhong.AutoSize = true;
            this.lblChonPhong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonPhong.ForeColor = System.Drawing.Color.Black;
            this.lblChonPhong.Location = new System.Drawing.Point(12, 34);
            this.lblChonPhong.Name = "lblChonPhong";
            this.lblChonPhong.Size = new System.Drawing.Size(80, 16);
            this.lblChonPhong.TabIndex = 0;
            this.lblChonPhong.Text = "Chọn phòng:";
            // 
            // MaPTrP
            // 
            this.MaPTrP.HeaderText = "MaPTrP";
            this.MaPTrP.MinimumWidth = 6;
            this.MaPTrP.Name = "MaPTrP";
            this.MaPTrP.Width = 125;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 125;
            // 
            // TrangThaiThue
            // 
            this.TrangThaiThue.HeaderText = "DaThanhToan";
            this.TrangThaiThue.MinimumWidth = 6;
            this.TrangThaiThue.Name = "TrangThaiThue";
            this.TrangThaiThue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TrangThaiThue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TrangThaiThue.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "GioiTinh";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.HeaderText = "NgheNghiep";
            this.NgheNghiep.MinimumWidth = 6;
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Width = 125;
            // 
            // NoiSinh
            // 
            this.NoiSinh.HeaderText = "NoiSinh";
            this.NoiSinh.MinimumWidth = 6;
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "NgayTra";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 125;
            // 
            // Tra_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 505);
            this.Controls.Add(this.grpTraPhong);
            this.Name = "Tra_Phong";
            this.Text = "Trả_Phòng";
            this.Load += new System.EventHandler(this.Trả_Phòng_Load);
            this.grpTraPhong.ResumeLayout(false);
            this.grpTraPhong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.grpTTChuThue.ResumeLayout(false);
            this.grpTTChuThue.PerformLayout();
            this.grpTTThuePhong.ResumeLayout(false);
            this.grpTTThuePhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTraPhong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbChoiceRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChonPhong;
        private System.Windows.Forms.GroupBox grpTTChuThue;
        private System.Windows.Forms.GroupBox grpTTThuePhong;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenNguoiThue;
        private System.Windows.Forms.TextBox txtIDKhachThue;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DateTimePicker dtbNgayTra;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPTrP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TrangThaiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}