namespace Do_An_WindowsForm.ChucNang
{
    partial class ChonNam
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dtpChonNam = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
<<<<<<< HEAD
            this.btnCancel.Location = new System.Drawing.Point(142, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
=======
            this.btnCancel.Location = new System.Drawing.Point(129, 66);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 25);
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 12F);
<<<<<<< HEAD
            this.btnOk.Location = new System.Drawing.Point(25, 41);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 31);
=======
            this.btnOk.Location = new System.Drawing.Point(22, 66);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 25);
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtpChonNam
            // 
<<<<<<< HEAD
            this.dtpChonNam.Location = new System.Drawing.Point(25, 12);
=======
            this.dtpChonNam.Location = new System.Drawing.Point(22, 33);
            this.dtpChonNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2
            this.dtpChonNam.Name = "dtpChonNam";
            this.dtpChonNam.Size = new System.Drawing.Size(172, 21);
            this.dtpChonNam.TabIndex = 2;
            this.dtpChonNam.ValueChanged += new System.EventHandler(this.dtpChonNam_ValueChanged);
            // 
            // ChonNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(257, 97);
=======
            this.ClientSize = new System.Drawing.Size(220, 136);
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtpChonNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChonNam";
            this.Text = "Chọn năm";
            this.Load += new System.EventHandler(this.ChonNam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dtpChonNam;
    }
}