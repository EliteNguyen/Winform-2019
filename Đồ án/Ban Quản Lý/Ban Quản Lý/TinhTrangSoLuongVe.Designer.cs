namespace Ban_Quản_Lý
{
    partial class TinhTrangSoLuongVe
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
            this.Xem = new System.Windows.Forms.Label();
            this.SoLuongVeCon = new System.Windows.Forms.Button();
            this.SoLuongVeDaBan = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.DTGVTTV = new System.Windows.Forms.DataGridView();
            this.NTN = new System.Windows.Forms.Label();
            this.TBNTN = new System.Windows.Forms.TextBox();
            this.TheLoai = new System.Windows.Forms.Label();
            this.TBTheLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVTTV)).BeginInit();
            this.SuspendLayout();
            // 
            // Xem
            // 
            this.Xem.AutoSize = true;
            this.Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Xem.Location = new System.Drawing.Point(310, 40);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(58, 25);
            this.Xem.TabIndex = 0;
            this.Xem.Text = "Xem";
            this.Xem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SoLuongVeCon
            // 
            this.SoLuongVeCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongVeCon.Location = new System.Drawing.Point(42, 449);
            this.SoLuongVeCon.Name = "SoLuongVeCon";
            this.SoLuongVeCon.Size = new System.Drawing.Size(217, 51);
            this.SoLuongVeCon.TabIndex = 1;
            this.SoLuongVeCon.Text = "Số Lượng Vé Còn";
            this.SoLuongVeCon.UseVisualStyleBackColor = true;
            // 
            // SoLuongVeDaBan
            // 
            this.SoLuongVeDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongVeDaBan.Location = new System.Drawing.Point(421, 449);
            this.SoLuongVeDaBan.Name = "SoLuongVeDaBan";
            this.SoLuongVeDaBan.Size = new System.Drawing.Size(217, 51);
            this.SoLuongVeDaBan.TabIndex = 2;
            this.SoLuongVeDaBan.Text = "Số Lượng Vé Đã Bán";
            this.SoLuongVeDaBan.UseVisualStyleBackColor = true;
            // 
            // Thoat
            // 
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(293, 530);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 51);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DTGVTTV
            // 
            this.DTGVTTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVTTV.Location = new System.Drawing.Point(42, 248);
            this.DTGVTTV.Name = "DTGVTTV";
            this.DTGVTTV.Size = new System.Drawing.Size(596, 146);
            this.DTGVTTV.TabIndex = 4;
            // 
            // NTN
            // 
            this.NTN.AutoSize = true;
            this.NTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTN.Location = new System.Drawing.Point(39, 95);
            this.NTN.Name = "NTN";
            this.NTN.Size = new System.Drawing.Size(150, 20);
            this.NTN.TabIndex = 5;
            this.NTN.Text = "Ngày/Tháng/Năm:";
            // 
            // TBNTN
            // 
            this.TBNTN.Location = new System.Drawing.Point(220, 95);
            this.TBNTN.Name = "TBNTN";
            this.TBNTN.Size = new System.Drawing.Size(418, 20);
            this.TBNTN.TabIndex = 6;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSize = true;
            this.TheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoai.Location = new System.Drawing.Point(112, 148);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(77, 20);
            this.TheLoai.TabIndex = 7;
            this.TheLoai.Text = "Thể loại:";
            // 
            // TBTheLoai
            // 
            this.TBTheLoai.Location = new System.Drawing.Point(220, 147);
            this.TBTheLoai.Name = "TBTheLoai";
            this.TBTheLoai.Size = new System.Drawing.Size(418, 20);
            this.TBTheLoai.TabIndex = 8;
            // 
            // TinhTrangSoLuongVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 616);
            this.Controls.Add(this.TBTheLoai);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.TBNTN);
            this.Controls.Add(this.NTN);
            this.Controls.Add(this.DTGVTTV);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.SoLuongVeDaBan);
            this.Controls.Add(this.SoLuongVeCon);
            this.Controls.Add(this.Xem);
            this.Name = "TinhTrangSoLuongVe";
            this.Text = "Tình Trạng Số Lượng Vé";
            this.Load += new System.EventHandler(this.TinhTrangSoLuongVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVTTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xem;
        private System.Windows.Forms.Button SoLuongVeCon;
        private System.Windows.Forms.Button SoLuongVeDaBan;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView DTGVTTV;
        private System.Windows.Forms.Label NTN;
        private System.Windows.Forms.TextBox TBNTN;
        private System.Windows.Forms.Label TheLoai;
        private System.Windows.Forms.TextBox TBTheLoai;
    }
}