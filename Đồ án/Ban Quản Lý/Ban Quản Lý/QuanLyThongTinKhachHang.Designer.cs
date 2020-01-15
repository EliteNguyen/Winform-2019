namespace Ban_Quản_Lý
{
    partial class QuanLyThongTinKhachHang
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
            this.LapBaoCao = new System.Windows.Forms.Button();
            this.QCLCP = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChonChucNang
            // 
            this.ChonChucNang.AutoSize = true;
            this.ChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonChucNang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChonChucNang.Location = new System.Drawing.Point(273, 43);
            this.ChonChucNang.Name = "ChonChucNang";
            this.ChonChucNang.Size = new System.Drawing.Size(144, 20);
            this.ChonChucNang.TabIndex = 0;
            this.ChonChucNang.Text = "Chọn Chức Năng";
            this.ChonChucNang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LapBaoCao
            // 
            this.LapBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapBaoCao.Location = new System.Drawing.Point(30, 112);
            this.LapBaoCao.Name = "LapBaoCao";
            this.LapBaoCao.Size = new System.Drawing.Size(145, 51);
            this.LapBaoCao.TabIndex = 1;
            this.LapBaoCao.Text = "Lập Báo Cáo";
            this.LapBaoCao.UseVisualStyleBackColor = true;
            this.LapBaoCao.Click += new System.EventHandler(this.LapBaoCao_Click);
            // 
            // QCLCP
            // 
            this.QCLCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QCLCP.Location = new System.Drawing.Point(509, 112);
            this.QCLCP.Name = "QCLCP";
            this.QCLCP.Size = new System.Drawing.Size(241, 51);
            this.QCLCP.TabIndex = 3;
            this.QCLCP.Text = "Quảng Cáo Lịch Chiếu Phim";
            this.QCLCP.UseVisualStyleBackColor = true;
            this.QCLCP.Click += new System.EventHandler(this.QCLCP_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(252, 207);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(179, 47);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QuanLyThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 330);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.QCLCP);
            this.Controls.Add(this.LapBaoCao);
            this.Controls.Add(this.ChonChucNang);
            this.Name = "QuanLyThongTinKhachHang";
            this.Text = "Quản Lý Thông Tin Khách Hàng";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChonChucNang;
        private System.Windows.Forms.Button LapBaoCao;
        private System.Windows.Forms.Button QCLCP;
        private System.Windows.Forms.Button Thoat;
    }
}