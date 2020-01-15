namespace Ban_Quản_Lý
{
    partial class BanQuanLy
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
            this.QuanLyNhanVien = new System.Windows.Forms.Button();
            this.BaoCaoThongKe = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.QLTTKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChonChucNang
            // 
            this.ChonChucNang.AutoSize = true;
            this.ChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonChucNang.Location = new System.Drawing.Point(253, 41);
            this.ChonChucNang.Name = "ChonChucNang";
            this.ChonChucNang.Size = new System.Drawing.Size(165, 24);
            this.ChonChucNang.TabIndex = 0;
            this.ChonChucNang.Text = "Chọn chức năng";
            this.ChonChucNang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuanLyNhanVien
            // 
            this.QuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanLyNhanVien.Location = new System.Drawing.Point(12, 124);
            this.QuanLyNhanVien.Name = "QuanLyNhanVien";
            this.QuanLyNhanVien.Size = new System.Drawing.Size(181, 62);
            this.QuanLyNhanVien.TabIndex = 1;
            this.QuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.QuanLyNhanVien.UseVisualStyleBackColor = true;
            this.QuanLyNhanVien.Click += new System.EventHandler(this.QuanLyNhanVien_Click);
            // 
            // BaoCaoThongKe
            // 
            this.BaoCaoThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCaoThongKe.Location = new System.Drawing.Point(491, 124);
            this.BaoCaoThongKe.Name = "BaoCaoThongKe";
            this.BaoCaoThongKe.Size = new System.Drawing.Size(181, 62);
            this.BaoCaoThongKe.TabIndex = 2;
            this.BaoCaoThongKe.Text = "Báo Cáo Thống kê";
            this.BaoCaoThongKe.UseVisualStyleBackColor = true;
            this.BaoCaoThongKe.Click += new System.EventHandler(this.BaoCaoThongKe_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(248, 227);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(191, 62);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QLTTKH
            // 
            this.QLTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLTTKH.Location = new System.Drawing.Point(248, 124);
            this.QLTTKH.Name = "QLTTKH";
            this.QLTTKH.Size = new System.Drawing.Size(191, 62);
            this.QLTTKH.TabIndex = 4;
            this.QLTTKH.Text = "Quản Lý Thông Tin Khách Hàng";
            this.QLTTKH.UseVisualStyleBackColor = true;
            this.QLTTKH.Click += new System.EventHandler(this.QLTTKH_Click);
            // 
            // BanQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 324);
            this.Controls.Add(this.QLTTKH);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.BaoCaoThongKe);
            this.Controls.Add(this.QuanLyNhanVien);
            this.Controls.Add(this.ChonChucNang);
            this.Name = "BanQuanLy";
            this.Text = "Ban Quản Lý";
            this.Load += new System.EventHandler(this.BanQuanLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChonChucNang;
        private System.Windows.Forms.Button QuanLyNhanVien;
        private System.Windows.Forms.Button BaoCaoThongKe;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button QLTTKH;
    }
}

