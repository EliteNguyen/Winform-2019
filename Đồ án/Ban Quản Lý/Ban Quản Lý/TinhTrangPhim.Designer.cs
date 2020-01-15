namespace Ban_Quản_Lý
{
    partial class TinhTrangPhim
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
            this.PhimDuocYeuThich = new System.Windows.Forms.Button();
            this.PKDUC = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.DGRVP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGRVP)).BeginInit();
            this.SuspendLayout();
            // 
            // ChonChucNang
            // 
            this.ChonChucNang.AutoSize = true;
            this.ChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChonChucNang.Location = new System.Drawing.Point(192, 28);
            this.ChonChucNang.Name = "ChonChucNang";
            this.ChonChucNang.Size = new System.Drawing.Size(294, 39);
            this.ChonChucNang.TabIndex = 0;
            this.ChonChucNang.Text = "Chọn Chức Năng";
            // 
            // PhimDuocYeuThich
            // 
            this.PhimDuocYeuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhimDuocYeuThich.Location = new System.Drawing.Point(31, 316);
            this.PhimDuocYeuThich.Name = "PhimDuocYeuThich";
            this.PhimDuocYeuThich.Size = new System.Drawing.Size(254, 51);
            this.PhimDuocYeuThich.TabIndex = 1;
            this.PhimDuocYeuThich.Text = "Phim Được Yêu Thích";
            this.PhimDuocYeuThich.UseVisualStyleBackColor = true;
            // 
            // PKDUC
            // 
            this.PKDUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PKDUC.Location = new System.Drawing.Point(385, 316);
            this.PKDUC.Name = "PKDUC";
            this.PKDUC.Size = new System.Drawing.Size(254, 51);
            this.PKDUC.TabIndex = 2;
            this.PKDUC.Text = "Phim Không Được Ưa Chuộng";
            this.PKDUC.UseVisualStyleBackColor = true;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(298, 399);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 42);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DGRVP
            // 
            this.DGRVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRVP.Location = new System.Drawing.Point(31, 109);
            this.DGRVP.Name = "DGRVP";
            this.DGRVP.Size = new System.Drawing.Size(608, 159);
            this.DGRVP.TabIndex = 4;
            // 
            // TinhTrangPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 487);
            this.Controls.Add(this.DGRVP);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.PKDUC);
            this.Controls.Add(this.PhimDuocYeuThich);
            this.Controls.Add(this.ChonChucNang);
            this.Name = "TinhTrangPhim";
            this.Text = "Tình Trạng Phim";
            this.Load += new System.EventHandler(this.TinhTrangPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChonChucNang;
        private System.Windows.Forms.Button PhimDuocYeuThich;
        private System.Windows.Forms.Button PKDUC;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DGRVP;
    }
}