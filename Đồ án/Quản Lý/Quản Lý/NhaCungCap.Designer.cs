namespace Quản_Lý
{
    partial class FormNhaCungCap
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
            this.BTThoat = new System.Windows.Forms.Button();
            this.LBMaNhaCungCap = new System.Windows.Forms.Label();
            this.TBMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.LBTenNhaCungCap = new System.Windows.Forms.Label();
            this.TBTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.DTGVNhaCungCap = new System.Windows.Forms.DataGridView();
            this.BTThem = new System.Windows.Forms.Button();
            this.BTXoa = new System.Windows.Forms.Button();
            this.BTSua = new System.Windows.Forms.Button();
            this.LBMaMoiNhaCungCap = new System.Windows.Forms.Label();
            this.TBMaMoiNhaCungCap = new System.Windows.Forms.TextBox();
            this.BTTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // BTThoat
            // 
            this.BTThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThoat.Location = new System.Drawing.Point(653, 370);
            this.BTThoat.Name = "BTThoat";
            this.BTThoat.Size = new System.Drawing.Size(75, 33);
            this.BTThoat.TabIndex = 0;
            this.BTThoat.Text = "Thoát";
            this.BTThoat.UseVisualStyleBackColor = true;
            this.BTThoat.Click += new System.EventHandler(this.BTThoat_Click);
            // 
            // LBMaNhaCungCap
            // 
            this.LBMaNhaCungCap.AutoSize = true;
            this.LBMaNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaNhaCungCap.Location = new System.Drawing.Point(79, 44);
            this.LBMaNhaCungCap.Name = "LBMaNhaCungCap";
            this.LBMaNhaCungCap.Size = new System.Drawing.Size(151, 20);
            this.LBMaNhaCungCap.TabIndex = 1;
            this.LBMaNhaCungCap.Text = "Mã nhà cung cấp:";
            // 
            // TBMaNhaCungCap
            // 
            this.TBMaNhaCungCap.Location = new System.Drawing.Point(288, 44);
            this.TBMaNhaCungCap.Name = "TBMaNhaCungCap";
            this.TBMaNhaCungCap.Size = new System.Drawing.Size(440, 20);
            this.TBMaNhaCungCap.TabIndex = 2;
            // 
            // LBTenNhaCungCap
            // 
            this.LBTenNhaCungCap.AutoSize = true;
            this.LBTenNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenNhaCungCap.Location = new System.Drawing.Point(73, 97);
            this.LBTenNhaCungCap.Name = "LBTenNhaCungCap";
            this.LBTenNhaCungCap.Size = new System.Drawing.Size(157, 20);
            this.LBTenNhaCungCap.TabIndex = 3;
            this.LBTenNhaCungCap.Text = "Tên nhà cung cấp:";
            // 
            // TBTenNhaCungCap
            // 
            this.TBTenNhaCungCap.Location = new System.Drawing.Point(288, 97);
            this.TBTenNhaCungCap.Name = "TBTenNhaCungCap";
            this.TBTenNhaCungCap.Size = new System.Drawing.Size(440, 20);
            this.TBTenNhaCungCap.TabIndex = 4;
            // 
            // DTGVNhaCungCap
            // 
            this.DTGVNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVNhaCungCap.Location = new System.Drawing.Point(16, 178);
            this.DTGVNhaCungCap.Name = "DTGVNhaCungCap";
            this.DTGVNhaCungCap.Size = new System.Drawing.Size(712, 173);
            this.DTGVNhaCungCap.TabIndex = 5;
            // 
            // BTThem
            // 
            this.BTThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThem.Location = new System.Drawing.Point(182, 370);
            this.BTThem.Name = "BTThem";
            this.BTThem.Size = new System.Drawing.Size(75, 33);
            this.BTThem.TabIndex = 6;
            this.BTThem.Text = "Thêm";
            this.BTThem.UseVisualStyleBackColor = true;
            this.BTThem.Click += new System.EventHandler(this.BTThem_Click);
            // 
            // BTXoa
            // 
            this.BTXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXoa.Location = new System.Drawing.Point(343, 370);
            this.BTXoa.Name = "BTXoa";
            this.BTXoa.Size = new System.Drawing.Size(75, 33);
            this.BTXoa.TabIndex = 7;
            this.BTXoa.Text = "Xóa";
            this.BTXoa.UseVisualStyleBackColor = true;
            this.BTXoa.Click += new System.EventHandler(this.BTXoa_Click);
            // 
            // BTSua
            // 
            this.BTSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSua.Location = new System.Drawing.Point(508, 370);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(75, 33);
            this.BTSua.TabIndex = 8;
            this.BTSua.Text = "Sửa";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // LBMaMoiNhaCungCap
            // 
            this.LBMaMoiNhaCungCap.AutoSize = true;
            this.LBMaMoiNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaMoiNhaCungCap.Location = new System.Drawing.Point(12, 139);
            this.LBMaMoiNhaCungCap.Name = "LBMaMoiNhaCungCap";
            this.LBMaMoiNhaCungCap.Size = new System.Drawing.Size(218, 20);
            this.LBMaMoiNhaCungCap.TabIndex = 9;
            this.LBMaMoiNhaCungCap.Text = "Mã mới của nhà cung cấp:";
            // 
            // TBMaMoiNhaCungCap
            // 
            this.TBMaMoiNhaCungCap.Location = new System.Drawing.Point(288, 139);
            this.TBMaMoiNhaCungCap.Name = "TBMaMoiNhaCungCap";
            this.TBMaMoiNhaCungCap.Size = new System.Drawing.Size(440, 20);
            this.TBMaMoiNhaCungCap.TabIndex = 10;
            // 
            // BTTimKiem
            // 
            this.BTTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTimKiem.Location = new System.Drawing.Point(16, 370);
            this.BTTimKiem.Name = "BTTimKiem";
            this.BTTimKiem.Size = new System.Drawing.Size(105, 33);
            this.BTTimKiem.TabIndex = 11;
            this.BTTimKiem.Text = "Tìm kiếm";
            this.BTTimKiem.UseVisualStyleBackColor = true;
            this.BTTimKiem.Click += new System.EventHandler(this.BTTimKiem_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 439);
            this.Controls.Add(this.BTTimKiem);
            this.Controls.Add(this.TBMaMoiNhaCungCap);
            this.Controls.Add(this.LBMaMoiNhaCungCap);
            this.Controls.Add(this.BTSua);
            this.Controls.Add(this.BTXoa);
            this.Controls.Add(this.BTThem);
            this.Controls.Add(this.DTGVNhaCungCap);
            this.Controls.Add(this.TBTenNhaCungCap);
            this.Controls.Add(this.LBTenNhaCungCap);
            this.Controls.Add(this.TBMaNhaCungCap);
            this.Controls.Add(this.LBMaNhaCungCap);
            this.Controls.Add(this.BTThoat);
            this.Name = "FormNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTThoat;
        private System.Windows.Forms.Label LBMaNhaCungCap;
        private System.Windows.Forms.TextBox TBMaNhaCungCap;
        private System.Windows.Forms.Label LBTenNhaCungCap;
        private System.Windows.Forms.TextBox TBTenNhaCungCap;
        private System.Windows.Forms.DataGridView DTGVNhaCungCap;
        private System.Windows.Forms.Button BTThem;
        private System.Windows.Forms.Button BTXoa;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.Label LBMaMoiNhaCungCap;
        private System.Windows.Forms.TextBox TBMaMoiNhaCungCap;
        private System.Windows.Forms.Button BTTimKiem;
    }
}