namespace Ban_Quản_Lý
{
    partial class SapXepDeLapBaoCao
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
            this.TenPhimDaDat = new System.Windows.Forms.Label();
            this.TBTenPhimDaDat = new System.Windows.Forms.TextBox();
            this.SoVeDaDat = new System.Windows.Forms.Label();
            this.TBSoVeDaDat = new System.Windows.Forms.TextBox();
            this.NgayDat = new System.Windows.Forms.Label();
            this.TBNgayDat = new System.Windows.Forms.TextBox();
            this.DTGVSXDLBC = new System.Windows.Forms.DataGridView();
            this.Thoat = new System.Windows.Forms.Button();
            this.XacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVSXDLBC)).BeginInit();
            this.SuspendLayout();
            // 
            // TenPhimDaDat
            // 
            this.TenPhimDaDat.AutoSize = true;
            this.TenPhimDaDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimDaDat.Location = new System.Drawing.Point(67, 39);
            this.TenPhimDaDat.Name = "TenPhimDaDat";
            this.TenPhimDaDat.Size = new System.Drawing.Size(143, 20);
            this.TenPhimDaDat.TabIndex = 0;
            this.TenPhimDaDat.Text = "Tên phim đã đặt:";
            // 
            // TBTenPhimDaDat
            // 
            this.TBTenPhimDaDat.Location = new System.Drawing.Point(245, 38);
            this.TBTenPhimDaDat.Name = "TBTenPhimDaDat";
            this.TBTenPhimDaDat.Size = new System.Drawing.Size(374, 20);
            this.TBTenPhimDaDat.TabIndex = 1;
            // 
            // SoVeDaDat
            // 
            this.SoVeDaDat.AutoSize = true;
            this.SoVeDaDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoVeDaDat.Location = new System.Drawing.Point(95, 80);
            this.SoVeDaDat.Name = "SoVeDaDat";
            this.SoVeDaDat.Size = new System.Drawing.Size(115, 20);
            this.SoVeDaDat.TabIndex = 2;
            this.SoVeDaDat.Text = "Số vé đã đặt:";
            // 
            // TBSoVeDaDat
            // 
            this.TBSoVeDaDat.Location = new System.Drawing.Point(245, 80);
            this.TBSoVeDaDat.Name = "TBSoVeDaDat";
            this.TBSoVeDaDat.Size = new System.Drawing.Size(374, 20);
            this.TBSoVeDaDat.TabIndex = 3;
            // 
            // NgayDat
            // 
            this.NgayDat.AutoSize = true;
            this.NgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDat.Location = new System.Drawing.Point(125, 126);
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Size = new System.Drawing.Size(85, 20);
            this.NgayDat.TabIndex = 4;
            this.NgayDat.Text = "Ngày đặt:";
            // 
            // TBNgayDat
            // 
            this.TBNgayDat.Location = new System.Drawing.Point(245, 126);
            this.TBNgayDat.Name = "TBNgayDat";
            this.TBNgayDat.Size = new System.Drawing.Size(374, 20);
            this.TBNgayDat.TabIndex = 5;
            // 
            // DTGVSXDLBC
            // 
            this.DTGVSXDLBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVSXDLBC.Location = new System.Drawing.Point(71, 177);
            this.DTGVSXDLBC.Name = "DTGVSXDLBC";
            this.DTGVSXDLBC.Size = new System.Drawing.Size(548, 167);
            this.DTGVSXDLBC.TabIndex = 6;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(475, 393);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(144, 47);
            this.Thoat.TabIndex = 7;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // XacNhan
            // 
            this.XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.Location = new System.Drawing.Point(71, 393);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(144, 47);
            this.XacNhan.TabIndex = 8;
            this.XacNhan.Text = "Xác nhận";
            this.XacNhan.UseVisualStyleBackColor = true;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // SapXepDeLapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 461);
            this.Controls.Add(this.XacNhan);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DTGVSXDLBC);
            this.Controls.Add(this.TBNgayDat);
            this.Controls.Add(this.NgayDat);
            this.Controls.Add(this.TBSoVeDaDat);
            this.Controls.Add(this.SoVeDaDat);
            this.Controls.Add(this.TBTenPhimDaDat);
            this.Controls.Add(this.TenPhimDaDat);
            this.Name = "SapXepDeLapBaoCao";
            this.Text = "Sắp Xếp Để Lập Báo Cáo";
            this.Load += new System.EventHandler(this.SapXepDeLapBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVSXDLBC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenPhimDaDat;
        private System.Windows.Forms.TextBox TBTenPhimDaDat;
        private System.Windows.Forms.Label SoVeDaDat;
        private System.Windows.Forms.TextBox TBSoVeDaDat;
        private System.Windows.Forms.Label NgayDat;
        private System.Windows.Forms.TextBox TBNgayDat;
        private System.Windows.Forms.DataGridView DTGVSXDLBC;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button XacNhan;
    }
}