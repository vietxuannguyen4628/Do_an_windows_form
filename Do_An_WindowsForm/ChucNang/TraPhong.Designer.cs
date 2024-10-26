namespace Do_An_WindowsForm.chuc_nang
{
    partial class TraPhong
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChoiceRoom = new System.Windows.Forms.ComboBox();
            this.grpTTThuePhong = new System.Windows.Forms.GroupBox();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTTChuThue = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDKhachThue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpTTKhachThue = new System.Windows.Forms.GroupBox();
            this.dgvTraPhong = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpTraPhong = new System.Windows.Forms.GroupBox();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTTThuePhong.SuspendLayout();
            this.grpTTChuThue.SuspendLayout();
            this.grpTTKhachThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraPhong)).BeginInit();
            this.grpTraPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(653, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng:";
            // 
            // cmbChoiceRoom
            // 
            this.cmbChoiceRoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbChoiceRoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChoiceRoom.FormattingEnabled = true;
            this.cmbChoiceRoom.Location = new System.Drawing.Point(829, 31);
            this.cmbChoiceRoom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbChoiceRoom.Name = "cmbChoiceRoom";
            this.cmbChoiceRoom.Size = new System.Drawing.Size(394, 30);
            this.cmbChoiceRoom.TabIndex = 3;
            this.cmbChoiceRoom.SelectedIndexChanged += new System.EventHandler(this.cmbChoiceRoom_SelectedIndexChanged);
            // 
            // grpTTThuePhong
            // 
            this.grpTTThuePhong.Controls.Add(this.dateNgayTra);
            this.grpTTThuePhong.Controls.Add(this.txtIDPhong);
            this.grpTTThuePhong.Controls.Add(this.label4);
            this.grpTTThuePhong.Controls.Add(this.label2);
            this.grpTTThuePhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTThuePhong.ForeColor = System.Drawing.Color.Black;
            this.grpTTThuePhong.Location = new System.Drawing.Point(17, 86);
            this.grpTTThuePhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTThuePhong.Name = "grpTTThuePhong";
            this.grpTTThuePhong.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTThuePhong.Size = new System.Drawing.Size(558, 265);
            this.grpTTThuePhong.TabIndex = 6;
            this.grpTTThuePhong.TabStop = false;
            this.grpTTThuePhong.Text = "THÔNG TIN PHÒNG";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dateNgayTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(194, 135);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(316, 30);
            this.dateNgayTra.TabIndex = 4;
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Enabled = false;
            this.txtIDPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhong.Location = new System.Drawing.Point(194, 62);
            this.txtIDPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(316, 30);
            this.txtIDPhong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // grpTTChuThue
            // 
            this.grpTTChuThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTTChuThue.Controls.Add(this.txtSDT);
            this.grpTTChuThue.Controls.Add(this.txtNgheNghiep);
            this.grpTTChuThue.Controls.Add(this.txtCMND);
            this.grpTTChuThue.Controls.Add(this.txtTenNguoiThue);
            this.grpTTChuThue.Controls.Add(this.label5);
            this.grpTTChuThue.Controls.Add(this.txtIDKhachThue);
            this.grpTTChuThue.Controls.Add(this.label11);
            this.grpTTChuThue.Controls.Add(this.label10);
            this.grpTTChuThue.Controls.Add(this.label7);
            this.grpTTChuThue.Controls.Add(this.label6);
            this.grpTTChuThue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTChuThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTChuThue.Location = new System.Drawing.Point(692, 126);
            this.grpTTChuThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTChuThue.Name = "grpTTChuThue";
            this.grpTTChuThue.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTChuThue.Size = new System.Drawing.Size(680, 275);
            this.grpTTChuThue.TabIndex = 7;
            this.grpTTChuThue.TabStop = false;
            this.grpTTChuThue.Text = "THÔNG TIN CHỦ THUÊ";
            this.grpTTChuThue.Enter += new System.EventHandler(this.grpTTChuThue_Enter);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(278, 227);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(394, 30);
            this.txtSDT.TabIndex = 13;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(278, 177);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(394, 30);
            this.txtNgheNghiep.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(278, 126);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(394, 30);
            this.txtCMND.TabIndex = 11;
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiThue.Location = new System.Drawing.Point(278, 78);
            this.txtTenNguoiThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(394, 30);
            this.txtTenNguoiThue.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "SDT";
            // 
            // txtIDKhachThue
            // 
            this.txtIDKhachThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKhachThue.Location = new System.Drawing.Point(278, 31);
            this.txtIDKhachThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtIDKhachThue.Name = "txtIDKhachThue";
            this.txtIDKhachThue.Size = new System.Drawing.Size(394, 30);
            this.txtIDKhachThue.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(102, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nghề nghiệp ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 136);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên người thuê";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách thuê";
            // 
            // grpTTKhachThue
            // 
            this.grpTTKhachThue.Controls.Add(this.dgvTraPhong);
            this.grpTTKhachThue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKhachThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTKhachThue.Location = new System.Drawing.Point(0, 421);
            this.grpTTKhachThue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTKhachThue.Name = "grpTTKhachThue";
            this.grpTTKhachThue.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTTKhachThue.Size = new System.Drawing.Size(1432, 258);
            this.grpTTKhachThue.TabIndex = 8;
            this.grpTTKhachThue.TabStop = false;
            this.grpTTKhachThue.Text = "THÔNG TIN KHÁCH THUÊ";
            // 
            // dgvTraPhong
            // 
            this.dgvTraPhong.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTraPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.MaKV,
            this.MaKT,
            this.HoTen,
            this.CMND,
            this.GioiTinh,
            this.NgheNghiep,
            this.Column1,
            this.SDT});
            this.dgvTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraPhong.Location = new System.Drawing.Point(4, 29);
            this.dgvTraPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvTraPhong.Name = "dgvTraPhong";
            this.dgvTraPhong.RowHeadersWidth = 51;
            this.dgvTraPhong.RowTemplate.Height = 24;
            this.dgvTraPhong.Size = new System.Drawing.Size(1424, 227);
            this.dgvTraPhong.TabIndex = 0;
            this.dgvTraPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(51, 359);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 46);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // grpTraPhong
            // 
            this.grpTraPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTraPhong.AutoSize = true;
            this.grpTraPhong.BackColor = System.Drawing.Color.Gainsboro;
            this.grpTraPhong.Controls.Add(this.btnXacNhan);
            this.grpTraPhong.Controls.Add(this.grpTTKhachThue);
            this.grpTraPhong.Controls.Add(this.grpTTChuThue);
            this.grpTraPhong.Controls.Add(this.grpTTThuePhong);
            this.grpTraPhong.Controls.Add(this.cmbChoiceRoom);
            this.grpTraPhong.Controls.Add(this.label1);
            this.grpTraPhong.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTraPhong.Location = new System.Drawing.Point(0, 0);
            this.grpTraPhong.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTraPhong.Name = "grpTraPhong";
            this.grpTraPhong.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpTraPhong.Size = new System.Drawing.Size(1440, 771);
            this.grpTraPhong.TabIndex = 0;
            this.grpTraPhong.TabStop = false;
            this.grpTraPhong.Text = "TRẢ PHÒNG";
            this.grpTraPhong.Enter += new System.EventHandler(this.grpTraPhong_Enter);
            // 
            // MaPT
            // 
            this.MaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPT.HeaderText = "Mã Phiếu Thuê";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            // 
            // MaKV
            // 
            this.MaKV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKV.HeaderText = "Mã phòng thuê";
            this.MaKV.MinimumWidth = 6;
            this.MaKV.Name = "MaKV";
            // 
            // MaKT
            // 
            this.MaKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKT.HeaderText = "Mã  khách hàng";
            this.MaKT.MinimumWidth = 6;
            this.MaKT.Name = "MaKT";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.HeaderText = "CCCD";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgheNghiep.HeaderText = "Nghề nghiệp";
            this.NgheNghiep.MinimumWidth = 6;
            this.NgheNghiep.Name = "NgheNghiep";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Quê quán";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpTraPhong);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "TraPhong";
            this.Size = new System.Drawing.Size(1412, 773);
            this.Load += new System.EventHandler(this.TraPhong_Load);
            this.grpTTThuePhong.ResumeLayout(false);
            this.grpTTThuePhong.PerformLayout();
            this.grpTTChuThue.ResumeLayout(false);
            this.grpTTChuThue.PerformLayout();
            this.grpTTKhachThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraPhong)).EndInit();
            this.grpTraPhong.ResumeLayout(false);
            this.grpTraPhong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChoiceRoom;
        private System.Windows.Forms.GroupBox grpTTThuePhong;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTTChuThue;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenNguoiThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDKhachThue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpTTKhachThue;
        private System.Windows.Forms.DataGridView dgvTraPhong;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox grpTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}