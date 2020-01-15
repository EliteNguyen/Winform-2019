namespace Ban_Quản_Lý
{
    partial class BaoCaoThongKe
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
            this.TinhTrangSoLuongVe = new System.Windows.Forms.Button();
            this.TinhTrangPhim = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChonChucNang
            // 
            this.ChonChucNang.AutoSize = true;
            this.ChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonChucNang.Location = new System.Drawing.Point(280, 37);
            this.ChonChucNang.Name = "ChonChucNang";
            this.ChonChucNang.Size = new System.Drawing.Size(144, 20);
            this.ChonChucNang.TabIndex = 0;
            this.ChonChucNang.Text = "Chọn Chức Năng";
            this.ChonChucNang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TinhTrangSoLuongVe
            // 
            this.TinhTrangSoLuongVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrangSoLuongVe.Location = new System.Drawing.Point(44, 103);
            this.TinhTrangSoLuongVe.Name = "TinhTrangSoLuongVe";
            this.TinhTrangSoLuongVe.Size = new System.Drawing.Size(236, 60);
            this.TinhTrangSoLuongVe.TabIndex = 1;
            this.TinhTrangSoLuongVe.Text = "Tình Trạng Số Lượng Vé";
            this.TinhTrangSoLuongVe.UseVisualStyleBackColor = true;
            this.TinhTrangSoLuongVe.Click += new System.EventHandler(this.TinhTrangSoLuongVe_Click);
            // 
            // TinhTrangPhim
            // 
            this.TinhTrangPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrangPhim.Location = new System.Drawing.Point(421, 103);
            this.TinhTrangPhim.Name = "TinhTrangPhim";
            this.TinhTrangPhim.Size = new System.Drawing.Size(236, 60);
            this.TinhTrangPhim.TabIndex = 2;
            this.TinhTrangPhim.Text = "Tình Trạng Phim";
            this.TinhTrangPhim.UseVisualStyleBackColor = true;
            this.TinhTrangPhim.Click += new System.EventHandler(this.TinhTrangPhim_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(314, 214);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(77, 59);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 330);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.TinhTrangPhim);
            this.Controls.Add(this.TinhTrangSoLuongVe);
            this.Controls.Add(this.ChonChucNang);
            this.Name = "BaoCaoThongKe";
            this.Text = "Báo Cáo Thống Kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChonChucNang;
        private System.Windows.Forms.Button TinhTrangSoLuongVe;
        private System.Windows.Forms.Button TinhTrangPhim;
        private System.Windows.Forms.Button Thoat;
    }
}