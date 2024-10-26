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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChoiceRoom = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpTTThuePhong = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.grpTTChuThue = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDKhachThue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.grpTTKhachThue = new System.Windows.Forms.GroupBox();
            this.dgvTraPhong = new System.Windows.Forms.DataGridView();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpTraPhong = new System.Windows.Forms.GroupBox();
            this.grpTTThuePhong.SuspendLayout();
            this.grpTTChuThue.SuspendLayout();
            this.grpTTKhachThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraPhong)).BeginInit();
            this.grpTraPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(657, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbChoiceRoom
            // 
            this.cmbChoiceRoom.FormattingEnabled = true;
            this.cmbChoiceRoom.Location = new System.Drawing.Point(92, 20);
            this.cmbChoiceRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChoiceRoom.Name = "cmbChoiceRoom";
            this.cmbChoiceRoom.Size = new System.Drawing.Size(379, 27);
            this.cmbChoiceRoom.TabIndex = 3;
            this.cmbChoiceRoom.SelectedIndexChanged += new System.EventHandler(this.cmbChoiceRoom_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(709, 20);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(454, 29);
            this.txtNote.TabIndex = 5;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // grpTTThuePhong
            // 
            this.grpTTThuePhong.Controls.Add(this.dateNgayTra);
            this.grpTTThuePhong.Controls.Add(this.txtIDPhong);
            this.grpTTThuePhong.Controls.Add(this.label4);
            this.grpTTThuePhong.Controls.Add(this.label2);
            this.grpTTThuePhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTThuePhong.ForeColor = System.Drawing.Color.Black;
            this.grpTTThuePhong.Location = new System.Drawing.Point(13, 58);
            this.grpTTThuePhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTThuePhong.Name = "grpTTThuePhong";
            this.grpTTThuePhong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTThuePhong.Size = new System.Drawing.Size(478, 206);
            this.grpTTThuePhong.TabIndex = 6;
            this.grpTTThuePhong.TabStop = false;
            this.grpTTThuePhong.Text = "THÔNG TIN PHÒNG";
            this.grpTTThuePhong.Enter += new System.EventHandler(this.grpTTThuePhong_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Enabled = false;
            this.txtIDPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhong.Location = new System.Drawing.Point(126, 71);
            this.txtIDPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(312, 26);
            this.txtIDPhong.TabIndex = 3;
            this.txtIDPhong.TextChanged += new System.EventHandler(this.txtIDPhong_TextChanged);
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayTra.Location = new System.Drawing.Point(126, 125);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(186, 24);
            this.dateNgayTra.TabIndex = 4;
            // 
            // grpTTChuThue
            // 
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
            this.grpTTChuThue.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTChuThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTChuThue.Location = new System.Drawing.Point(515, 58);
            this.grpTTChuThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTChuThue.Name = "grpTTChuThue";
            this.grpTTChuThue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTChuThue.Size = new System.Drawing.Size(648, 236);
            this.grpTTChuThue.TabIndex = 7;
            this.grpTTChuThue.TabStop = false;
            this.grpTTChuThue.Text = "THÔNG TIN CHỦ THUÊ";
            this.grpTTChuThue.Enter += new System.EventHandler(this.grpTTChuThue_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách thuê";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên người thuê";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(104, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "CMND";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nghề nghiệp ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtIDKhachThue
            // 
            this.txtIDKhachThue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDKhachThue.Location = new System.Drawing.Point(194, 32);
            this.txtIDKhachThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDKhachThue.Name = "txtIDKhachThue";
            this.txtIDKhachThue.Size = new System.Drawing.Size(338, 27);
            this.txtIDKhachThue.TabIndex = 7;
            this.txtIDKhachThue.TextChanged += new System.EventHandler(this.txtIDKhachThue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "SDT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNguoiThue.Location = new System.Drawing.Point(194, 70);
            this.txtTenNguoiThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(338, 27);
            this.txtTenNguoiThue.TabIndex = 8;
            this.txtTenNguoiThue.TextChanged += new System.EventHandler(this.txtTenNguoiThue_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(194, 109);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(338, 27);
            this.txtCMND.TabIndex = 11;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgheNghiep.Location = new System.Drawing.Point(194, 150);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(338, 27);
            this.txtNgheNghiep.TabIndex = 12;
            this.txtNgheNghiep.TextChanged += new System.EventHandler(this.txtNgheNghiep_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(194, 191);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(338, 27);
            this.txtSDT.TabIndex = 13;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // grpTTKhachThue
            // 
            this.grpTTKhachThue.Controls.Add(this.dgvTraPhong);
            this.grpTTKhachThue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKhachThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTKhachThue.Location = new System.Drawing.Point(6, 321);
            this.grpTTKhachThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTKhachThue.Name = "grpTTKhachThue";
            this.grpTTKhachThue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTKhachThue.Size = new System.Drawing.Size(1160, 157);
            this.grpTTKhachThue.TabIndex = 8;
            this.grpTTKhachThue.TabStop = false;
            this.grpTTKhachThue.Text = "THÔNG TIN KHÁCH THUÊ";
            this.grpTTKhachThue.Enter += new System.EventHandler(this.grpTTKhachThue_Enter);
            // 
            // dgvTraPhong
            // 
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
            this.dgvTraPhong.Location = new System.Drawing.Point(3, 15);
            this.dgvTraPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTraPhong.Name = "dgvTraPhong";
            this.dgvTraPhong.RowHeadersWidth = 51;
            this.dgvTraPhong.RowTemplate.Height = 24;
            this.dgvTraPhong.Size = new System.Drawing.Size(1154, 140);
            this.dgvTraPhong.TabIndex = 0;
            this.dgvTraPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhThu_CellContentClick);
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quê quán";
            this.Column1.Name = "Column1";
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.HeaderText = "Nghề nghiệp";
            this.NgheNghiep.MinimumWidth = 6;
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CCCD";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // MaKT
            // 
            this.MaKT.HeaderText = "Mã  khách hàng";
            this.MaKT.MinimumWidth = 6;
            this.MaKT.Name = "MaKT";
            this.MaKT.Width = 125;
            // 
            // MaKV
            // 
            this.MaKV.HeaderText = "Mã phòng thuê";
            this.MaKV.MinimumWidth = 6;
            this.MaKV.Name = "MaKV";
            this.MaKV.Width = 125;
            // 
            // MaPT
            // 
            this.MaPT.HeaderText = "Mã Phiếu Thuê";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            this.MaPT.Width = 125;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(13, 280);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(114, 37);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // grpTraPhong
            // 
            this.grpTraPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTraPhong.AutoSize = true;
            this.grpTraPhong.Controls.Add(this.btnXacNhan);
            this.grpTraPhong.Controls.Add(this.grpTTKhachThue);
            this.grpTraPhong.Controls.Add(this.grpTTChuThue);
            this.grpTraPhong.Controls.Add(this.grpTTThuePhong);
            this.grpTraPhong.Controls.Add(this.txtNote);
            this.grpTraPhong.Controls.Add(this.cmbChoiceRoom);
            this.grpTraPhong.Controls.Add(this.label3);
            this.grpTraPhong.Controls.Add(this.label1);
            this.grpTraPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTraPhong.Location = new System.Drawing.Point(0, -1);
            this.grpTraPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTraPhong.Name = "grpTraPhong";
            this.grpTraPhong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTraPhong.Size = new System.Drawing.Size(1208, 502);
            this.grpTraPhong.TabIndex = 0;
            this.grpTraPhong.TabStop = false;
            this.grpTraPhong.Text = "TRẢ PHÒNG";
            this.grpTraPhong.Enter += new System.EventHandler(this.grpTraPhong_Enter);
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.grpTraPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraPhong";
            this.Size = new System.Drawing.Size(1210, 504);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChoiceRoom;
        private System.Windows.Forms.TextBox txtNote;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox grpTraPhong;
    }
}