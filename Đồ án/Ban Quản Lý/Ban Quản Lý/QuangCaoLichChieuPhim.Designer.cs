namespace Ban_Quản_Lý
{
    partial class QuangCaoLichChieuPhim
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
            this.DanhSachEmailKhachHang = new System.Windows.Forms.ListView();
            this.GuiLichChieu = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DanhSachEmailKhachHang
            // 
            this.DanhSachEmailKhachHang.HideSelection = false;
            this.DanhSachEmailKhachHang.Location = new System.Drawing.Point(54, 33);
            this.DanhSachEmailKhachHang.Name = "DanhSachEmailKhachHang";
            this.DanhSachEmailKhachHang.Size = new System.Drawing.Size(206, 220);
            this.DanhSachEmailKhachHang.TabIndex = 0;
            this.DanhSachEmailKhachHang.UseCompatibleStateImageBehavior = false;
            // 
            // GuiLichChieu
            // 
            this.GuiLichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuiLichChieu.Location = new System.Drawing.Point(350, 33);
            this.GuiLichChieu.Name = "GuiLichChieu";
            this.GuiLichChieu.Size = new System.Drawing.Size(192, 42);
            this.GuiLichChieu.TabIndex = 1;
            this.GuiLichChieu.Text = "Gửi lịch chiếu phim";
            this.GuiLichChieu.UseVisualStyleBackColor = true;
            this.GuiLichChieu.Click += new System.EventHandler(this.GuiLichChieu_Click);
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(350, 111);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(192, 42);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QuangCaoLichChieuPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 330);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.GuiLichChieu);
            this.Controls.Add(this.DanhSachEmailKhachHang);
            this.Name = "QuangCaoLichChieuPhim";
            this.Text = "Quảng Cáo Lịch Chiếu Phim";
            this.Load += new System.EventHandler(this.QuangCaoLichChieuPhim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DanhSachEmailKhachHang;
        private System.Windows.Forms.Button GuiLichChieu;
        private System.Windows.Forms.Button Thoat;
    }
}