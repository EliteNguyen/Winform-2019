namespace Ban_Quản_Lý
{
    partial class QuanLyNhanVien
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
            this.ChonChucNang = new System.Windows.Forms.Label();
            this.LKDSTTNV = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChonChucNang
            // 
            this.ChonChucNang.AutoSize = true;
            this.ChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonChucNang.Location = new System.Drawing.Point(294, 36);
            this.ChonChucNang.Name = "ChonChucNang";
            this.ChonChucNang.Size = new System.Drawing.Size(144, 20);
            this.ChonChucNang.TabIndex = 0;
            this.ChonChucNang.Text = "Chọn Chức Năng";
            this.ChonChucNang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LKDSTTNV
            // 
            this.LKDSTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKDSTTNV.Location = new System.Drawing.Point(21, 125);
            this.LKDSTTNV.Name = "LKDSTTNV";
            this.LKDSTTNV.Size = new System.Drawing.Size(279, 58);
            this.LKDSTTNV.TabIndex = 1;
            this.LKDSTTNV.Text = "Liệt Kê Danh Sách Thông Tin Nhân Viên";
            this.LKDSTTNV.UseVisualStyleBackColor = true;
            this.LKDSTTNV.Click += new System.EventHandler(this.LKDSTTNV_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(418, 125);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(279, 58);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 334);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.LKDSTTNV);
            this.Controls.Add(this.ChonChucNang);
            this.Name = "QuanLyNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChonChucNang;
        private System.Windows.Forms.Button LKDSTTNV;
        private System.Windows.Forms.Button Thoat;
    }
}