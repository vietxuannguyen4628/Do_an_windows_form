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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNGUOITHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHONG,
            this.TENNGUOITHUE,
            this.NGAYTHU,
            this.TIENDV,
            this.TIENPHONG,
            this.THANHTIEN});
            this.dataGridView1.Location = new System.Drawing.Point(139, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
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
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DoanhThu";
            this.Size = new System.Drawing.Size(1061, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNGUOITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
