namespace Quản_Lý
{
    partial class FormQuanLy
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
            this.LBChonChucNang = new System.Windows.Forms.Label();
            this.BTThucAn = new System.Windows.Forms.Button();
            this.BTLoaiThucAn = new System.Windows.Forms.Button();
            this.BTNhaCungCap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBChonChucNang
            // 
            this.LBChonChucNang.AutoSize = true;
            this.LBChonChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBChonChucNang.Location = new System.Drawing.Point(259, 31);
            this.LBChonChucNang.Name = "LBChonChucNang";
            this.LBChonChucNang.Size = new System.Drawing.Size(165, 24);
            this.LBChonChucNang.TabIndex = 0;
            this.LBChonChucNang.Text = "Chọn chức năng";
            // 
            // BTThucAn
            // 
            this.BTThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThucAn.Location = new System.Drawing.Point(287, 142);
            this.BTThucAn.Name = "BTThucAn";
            this.BTThucAn.Size = new System.Drawing.Size(106, 37);
            this.BTThucAn.TabIndex = 1;
            this.BTThucAn.Text = "Thức ăn";
            this.BTThucAn.UseVisualStyleBackColor = true;
            this.BTThucAn.Click += new System.EventHandler(this.BTThucAn_Click);
            // 
            // BTLoaiThucAn
            // 
            this.BTLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLoaiThucAn.Location = new System.Drawing.Point(26, 142);
            this.BTLoaiThucAn.Name = "BTLoaiThucAn";
            this.BTLoaiThucAn.Size = new System.Drawing.Size(161, 37);
            this.BTLoaiThucAn.TabIndex = 2;
            this.BTLoaiThucAn.Text = "Loại thức ăn";
            this.BTLoaiThucAn.UseVisualStyleBackColor = true;
            this.BTLoaiThucAn.Click += new System.EventHandler(this.BTLoaiThucAn_Click);
            // 
            // BTNhaCungCap
            // 
            this.BTNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNhaCungCap.Location = new System.Drawing.Point(499, 142);
            this.BTNhaCungCap.Name = "BTNhaCungCap";
            this.BTNhaCungCap.Size = new System.Drawing.Size(161, 37);
            this.BTNhaCungCap.TabIndex = 3;
            this.BTNhaCungCap.Text = "Nhà cung cấp";
            this.BTNhaCungCap.UseVisualStyleBackColor = true;
            this.BTNhaCungCap.Click += new System.EventHandler(this.BTNhaCungCap_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 330);
            this.Controls.Add(this.BTNhaCungCap);
            this.Controls.Add(this.BTLoaiThucAn);
            this.Controls.Add(this.BTThucAn);
            this.Controls.Add(this.LBChonChucNang);
            this.Name = "FormQuanLy";
            this.Text = "Quản lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBChonChucNang;
        private System.Windows.Forms.Button BTThucAn;
        private System.Windows.Forms.Button BTLoaiThucAn;
        private System.Windows.Forms.Button BTNhaCungCap;
    }
}

