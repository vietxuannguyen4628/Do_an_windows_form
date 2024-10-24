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
            this.grpTraPhong = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
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
            this.grpTTChuThue = new System.Windows.Forms.GroupBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSLNguoiHienTai = new System.Windows.Forms.TextBox();
            this.txtTenNguoiThue = new System.Windows.Forms.TextBox();
            this.txtIDKhachThue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpTTThuePhong = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbChoiceRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpTraPhong.SuspendLayout();
            this.grpTTKhachThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKhachThue)).BeginInit();
            this.grpTTChuThue.SuspendLayout();
            this.grpTTThuePhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTraPhong
            // 
            this.grpTraPhong.Controls.Add(this.btnXacNhan);
            this.grpTraPhong.Controls.Add(this.grpTTKhachThue);
            this.grpTraPhong.Controls.Add(this.grpTTChuThue);
            this.grpTraPhong.Controls.Add(this.grpTTThuePhong);
            this.grpTraPhong.Controls.Add(this.txtNote);
            this.grpTraPhong.Controls.Add(this.cmbChoiceRoom);
            this.grpTraPhong.Controls.Add(this.label3);
            this.grpTraPhong.Controls.Add(this.label1);
            this.grpTraPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTraPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTraPhong.ForeColor = System.Drawing.Color.Red;
            this.grpTraPhong.Location = new System.Drawing.Point(0, 0);
            this.grpTraPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTraPhong.Name = "grpTraPhong";
            this.grpTraPhong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTraPhong.Size = new System.Drawing.Size(1210, 497);
            this.grpTraPhong.TabIndex = 0;
            this.grpTraPhong.TabStop = false;
            this.grpTraPhong.Text = "TRẢ PHÒNG";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Lime;
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(13, 280);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(29, 27);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // grpTTKhachThue
            // 
            this.grpTTKhachThue.Controls.Add(this.dgvTTKhachThue);
            this.grpTTKhachThue.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTKhachThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTKhachThue.Location = new System.Drawing.Point(6, 321);
            this.grpTTKhachThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTKhachThue.Name = "grpTTKhachThue";
            this.grpTTKhachThue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTKhachThue.Size = new System.Drawing.Size(1176, 157);
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
            this.dgvTTKhachThue.Location = new System.Drawing.Point(3, 15);
            this.dgvTTKhachThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTTKhachThue.Name = "dgvTTKhachThue";
            this.dgvTTKhachThue.RowHeadersWidth = 51;
            this.dgvTTKhachThue.RowTemplate.Height = 24;
            this.dgvTTKhachThue.Size = new System.Drawing.Size(1170, 140);
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
            // grpTTChuThue
            // 
            this.grpTTChuThue.Controls.Add(this.txtNoiSinh);
            this.grpTTChuThue.Controls.Add(this.txtNgheNghiep);
            this.grpTTChuThue.Controls.Add(this.txtCMND);
            this.grpTTChuThue.Controls.Add(this.txtSLNguoiHienTai);
            this.grpTTChuThue.Controls.Add(this.txtTenNguoiThue);
            this.grpTTChuThue.Controls.Add(this.txtIDKhachThue);
            this.grpTTChuThue.Controls.Add(this.label12);
            this.grpTTChuThue.Controls.Add(this.label11);
            this.grpTTChuThue.Controls.Add(this.label10);
            this.grpTTChuThue.Controls.Add(this.label9);
            this.grpTTChuThue.Controls.Add(this.label7);
            this.grpTTChuThue.Controls.Add(this.label6);
            this.grpTTChuThue.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTChuThue.ForeColor = System.Drawing.Color.Black;
            this.grpTTChuThue.Location = new System.Drawing.Point(515, 58);
            this.grpTTChuThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTChuThue.Name = "grpTTChuThue";
            this.grpTTChuThue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTTChuThue.Size = new System.Drawing.Size(632, 236);
            this.grpTTChuThue.TabIndex = 7;
            this.grpTTChuThue.TabStop = false;
            this.grpTTChuThue.Text = "THÔNG TIN CHỦ THUÊ";
            this.grpTTChuThue.Enter += new System.EventHandler(this.grpTTChuThue_Enter);
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(144, 182);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(469, 24);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(144, 154);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(469, 24);
            this.txtNgheNghiep.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(144, 126);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(469, 24);
            this.txtCMND.TabIndex = 11;
            // 
            // txtSLNguoiHienTai
            // 
            this.txtSLNguoiHienTai.Location = new System.Drawing.Point(145, 98);
            this.txtSLNguoiHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSLNguoiHienTai.Name = "txtSLNguoiHienTai";
            this.txtSLNguoiHienTai.Size = new System.Drawing.Size(468, 24);
            this.txtSLNguoiHienTai.TabIndex = 10;
            // 
            // txtTenNguoiThue
            // 
            this.txtTenNguoiThue.Location = new System.Drawing.Point(144, 42);
            this.txtTenNguoiThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNguoiThue.Name = "txtTenNguoiThue";
            this.txtTenNguoiThue.Size = new System.Drawing.Size(469, 24);
            this.txtTenNguoiThue.TabIndex = 8;
            // 
            // txtIDKhachThue
            // 
            this.txtIDKhachThue.Location = new System.Drawing.Point(144, 15);
            this.txtIDKhachThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDKhachThue.Name = "txtIDKhachThue";
            this.txtIDKhachThue.Size = new System.Drawing.Size(469, 24);
            this.txtIDKhachThue.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 14);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nơi sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nghề nghiệp: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 4;
            this.label10.Text = "CMND:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng người hiện tại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên người thuê:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách thuê:";
            // 
            // grpTTThuePhong
            // 
            this.grpTTThuePhong.Controls.Add(this.txtTenPhong);
            this.grpTTThuePhong.Controls.Add(this.label5);
            this.grpTTThuePhong.Controls.Add(this.label4);
            this.grpTTThuePhong.Controls.Add(this.dateEdit1);
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
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(96, 107);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(353, 24);
            this.txtTenPhong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(96, 50);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(353, 20);
            this.dateEdit1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(709, 20);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(438, 29);
            this.txtNote.TabIndex = 5;
            // 
            // cmbChoiceRoom
            // 
            this.cmbChoiceRoom.FormattingEnabled = true;
            this.cmbChoiceRoom.Location = new System.Drawing.Point(92, 20);
            this.cmbChoiceRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChoiceRoom.Name = "cmbChoiceRoom";
            this.cmbChoiceRoom.Size = new System.Drawing.Size(379, 27);
            this.cmbChoiceRoom.TabIndex = 3;
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
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTraPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraPhong";
            this.Size = new System.Drawing.Size(1210, 497);
            this.Load += new System.EventHandler(this.TraPhong_Load);
            this.grpTraPhong.ResumeLayout(false);
            this.grpTraPhong.PerformLayout();
            this.grpTTKhachThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKhachThue)).EndInit();
            this.grpTTChuThue.ResumeLayout(false);
            this.grpTTChuThue.PerformLayout();
            this.grpTTThuePhong.ResumeLayout(false);
            this.grpTTThuePhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSLNguoiHienTai;
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