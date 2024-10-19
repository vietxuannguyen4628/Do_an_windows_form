namespace Do_An_WindowsForm.chuc_nang
{
    partial class Trả_Phòng
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChoiceRoom = new System.Windows.Forms.ComboBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpTTThuePhong = new System.Windows.Forms.GroupBox();
            this.grpTTChuThue = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDKhachThue = new System.Windows.Forms.TextBox();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.txtSLToiDa = new System.Windows.Forms.TextBox();
            this.txtSLNguoiHienTai = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.grpTTKhachThue = new System.Windows.Forms.GroupBox();
            this.dgvTTKhachThue = new System.Windows.Forms.DataGridView();
            this.MaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpTraPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            this.grpTTThuePhong.SuspendLayout();
            this.grpTTChuThue.SuspendLayout();
            this.grpTTKhachThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKhachThue)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTraPhong
            // 
            this.grpTraPhong.Controls.Add(this.btnXacNhan);
            this.grpTraPhong.Controls.Add(this.grpTTKhachThue);
            this.grpTraPhong.Controls.Add(this.grpTTChuThue);
            this.grpTraPhong.Controls.Add(this.grpTTThuePhong);
            this.grpTraPhong.Controls.Add(this.txtNote);
            this.grpTraPhong.Controls.Add(this.dateEdit1);
            this.grpTraPhong.Controls.Add(this.cmbChoiceRoom);
            this.grpTraPhong.Controls.Add(this.label3);
            this.grpTraPhong.Controls.Add(this.label2);
            this.grpTraPhong.Controls.Add(this.label1);
            this.grpTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTraPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTraPhong.Location = new System.Drawing.Point(0, 0);
            this.grpTraPhong.Name = "grpTraPhong";
            this.grpTraPhong.Size = new System.Drawing.Size(942, 505);
            this.grpTraPhong.TabIndex = 0;
            this.grpTraPhong.TabStop = false;
            this.grpTraPhong.Text = "TRẢ PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(333, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(609, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            // 
            // cmbChoiceRoom
            // 
            this.cmbChoiceRoom.FormattingEnabled = true;
            this.cmbChoiceRoom.Location = new System.Drawing.Point(107, 24);
            this.cmbChoiceRoom.Name = "cmbChoiceRoom";
            this.cmbChoiceRoom.Size = new System.Drawing.Size(192, 32);
            this.cmbChoiceRoom.TabIndex = 3;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(399, 31);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(165, 22);
            this.dateEdit1.TabIndex = 4;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(669, 31);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(221, 25);
            this.txtNote.TabIndex = 5;
            // 
            // grpTTThuePhong
            // 
            this.grpTTThuePhong.Controls.Add(this.txtTenPhong);
            this.grpTTThuePhong.Controls.Add(this.txtIDPhong);
            this.grpTTThuePhong.Controls.Add(this.label5);
            this.grpTTThuePhong.Controls.Add(this.label4);
            this.grpTTThuePhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTThuePhong.ForeColor = System.Drawing.Color.Black;
            this.grpTTThuePhong.Location = new System.Drawing.Point(15, 72);
            this.grpTTThuePhong.Name = "grpTTThuePhong";
            this.grpTTThuePhong.Size = new System.Drawing.Size(370, 128);
            this.grpTTThuePhong.TabIndex = 6;
            this.grpTTThuePhong.TabStop = false;
            this.grpTTThuePhong.Text = "THÔNG TIN THUÊ PHÒNG";
            // 
            // grpTTChuThue
            // 
            this.grpTTChuThue.Controls.Add(this.txtNoiSinh);
            this.grpTTChuThue.Controls.Add(this.txtNgheNghiep);
            this.grpTTChuThue.Controls.Add(this.txtCMND);
            this.grpTTChuThue.Controls.Add(this.txtSLNguoiHienTai);
            this.grpTTChuThue.Controls.Add(this.txtSLToiDa);
            this.grpTTChuThue.Controls.Add(this.txtTenNguoiThue);
            this.grpTTChuThue.Controls.Add(this.txtIDKhachThue);
            this.grpTTChuThue.Controls.Add(this.label12);
            this.grpTTChuThue.Controls.Add(this.label11);
            this.grpTTChuThue.Controls.Add(this.label10);
            this.grpTTChuThue.Controls.Add(this.label9);
            this.grpTTChuThue.Controls.Add(this.label8);
            this.grpTTChuThue.Controls.Add(this.label7);
            this.grpTTChuThue.Controls.Add(this.label6);
            this.grpTTChuThue.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTChuThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTChuThue.Location = new System.Drawing.Point(444, 72);
            this.grpTTChuThue.Name = "grpTTChuThue";
            this.grpTTChuThue.Size = new System.Drawing.Size(422, 263);
            this.grpTTChuThue.TabIndex = 7;
            this.grpTTChuThue.TabStop = false;
            this.grpTTChuThue.Text = "THÔNG TIN CHỦ THUÊ";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phòng";
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Location = new System.Drawing.Point(85, 35);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Size = new System.Drawing.Size(254, 28);
            this.txtIDPhong.TabIndex = 2;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(85, 78);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(254, 28);
            this.txtTenPhong.TabIndex = 3;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số lượng tối đa:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng người hiện tại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "CMND:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nghề nghiệp: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nơi sinh:";
            // 
            // txtIDKhachThue
            // 
            this.txtIDKhachThue.Location = new System.Drawing.Point(168, 18);
            this.txtIDKhachThue.Name = "txtIDKhachThue";
            this.txtIDKhachThue.Size = new System.Drawing.Size(248, 28);
            this.txtIDKhachThue.TabIndex = 7;
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Location = new System.Drawing.Point(168, 52);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(248, 28);
            this.txtTenNguoiThue.TabIndex = 8;
            // 
            // txtSLToiDa
            // 
            this.txtSLToiDa.Location = new System.Drawing.Point(168, 86);
            this.txtSLToiDa.Name = "txtSLToiDa";
            this.txtSLToiDa.Size = new System.Drawing.Size(248, 28);
            this.txtSLToiDa.TabIndex = 9;
            // 
            // txtSLNguoiHienTai
            // 
            this.txtSLNguoiHienTai.Location = new System.Drawing.Point(168, 120);
            this.txtSLNguoiHienTai.Name = "txtSLNguoiHienTai";
            this.txtSLNguoiHienTai.Size = new System.Drawing.Size(248, 28);
            this.txtSLNguoiHienTai.TabIndex = 10;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(168, 155);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(248, 28);
            this.txtCMND.TabIndex = 11;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(168, 189);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(248, 28);
            this.txtNgheNghiep.TabIndex = 12;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(168, 224);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(248, 28);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // grpTTKhachThue
            // 
            this.grpTTKhachThue.Controls.Add(this.dgvTTKhachThue);
            this.grpTTKhachThue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKhachThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTKhachThue.Location = new System.Drawing.Point(6, 323);
            this.grpTTKhachThue.Name = "grpTTKhachThue";
            this.grpTTKhachThue.Size = new System.Drawing.Size(943, 136);
            this.grpTTKhachThue.TabIndex = 8;
            this.grpTTKhachThue.TabStop = false;
            this.grpTTKhachThue.Text = "THÔNG TIN KHÁCH THUÊ";
            // 
            // dgvTTKhachThue
            // 
            this.dgvTTKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKhachThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPT,
            this.MaKV,
            this.TenPhong,
            this.TrangThaiThue,
            this.MaKT,
            this.HoTen,
            this.CMND,
            this.GioiTinh,
            this.NgheNghiep,
            this.SDT});
            this.dgvTTKhachThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTKhachThue.Location = new System.Drawing.Point(3, 19);
            this.dgvTTKhachThue.Name = "dgvTTKhachThue";
            this.dgvTTKhachThue.RowHeadersWidth = 51;
            this.dgvTTKhachThue.RowTemplate.Height = 24;
            this.dgvTTKhachThue.Size = new System.Drawing.Size(937, 114);
            this.dgvTTKhachThue.TabIndex = 0;
            // 
            // MaPT
            // 
            this.MaPT.HeaderText = "MaPT";
            this.MaPT.MinimumWidth = 6;
            this.MaPT.Name = "MaPT";
            this.MaPT.Width = 125;
            // 
            // MaKV
            // 
            this.MaKV.HeaderText = "MaKV";
            this.MaKV.MinimumWidth = 6;
            this.MaKV.Name = "MaKV";
            this.MaKV.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "TenPhong";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 125;
            // 
            // TrangThaiThue
            // 
            this.TrangThaiThue.HeaderText = "TrangThaiThue";
            this.TrangThaiThue.MinimumWidth = 6;
            this.TrangThaiThue.Name = "TrangThaiThue";
            this.TrangThaiThue.Width = 125;
            // 
            // MaKT
            // 
            this.MaKT.HeaderText = "MaKT";
            this.MaKT.MinimumWidth = 6;
            this.MaKT.Name = "MaKT";
            this.MaKT.Width = 125;
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
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(15, 256);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 44);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // Trả_Phòng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 505);
            this.Controls.Add(this.grpTraPhong);
            this.Name = "Trả_Phòng";
            this.Text = "Trả_Phòng";
            this.grpTraPhong.ResumeLayout(false);
            this.grpTraPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.grpTTThuePhong.ResumeLayout(false);
            this.grpTTThuePhong.PerformLayout();
            this.grpTTChuThue.ResumeLayout(false);
            this.grpTTChuThue.PerformLayout();
            this.grpTTKhachThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKhachThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTraPhong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbChoiceRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.GroupBox grpTTChuThue;
        private System.Windows.Forms.GroupBox grpTTThuePhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtIDPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSLNguoiHienTai;
        private System.Windows.Forms.TextBox txtSLToiDa;
        private System.Windows.Forms.TextBox txtTenNguoiThue;
        private System.Windows.Forms.TextBox txtIDKhachThue;
        private System.Windows.Forms.GroupBox grpTTKhachThue;
        private System.Windows.Forms.DataGridView dgvTTKhachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPT;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Button btnXacNhan;
    }
}