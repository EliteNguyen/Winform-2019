namespace Ban_Quản_Lý
{
    partial class LapBaoCao
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
            this.DTGVDSKHDV = new System.Windows.Forms.DataGridView();
            this.SXBC = new System.Windows.Forms.Button();
            this.Huy = new System.Windows.Forms.Button();
            this.CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDSKHDV)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVDSKHDV
            // 
            this.DTGVDSKHDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVDSKHDV.Location = new System.Drawing.Point(22, 23);
            this.DTGVDSKHDV.Name = "DTGVDSKHDV";
            this.DTGVDSKHDV.Size = new System.Drawing.Size(637, 241);
            this.DTGVDSKHDV.TabIndex = 0;
            // 
            // SXBC
            // 
            this.SXBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SXBC.Location = new System.Drawing.Point(22, 292);
            this.SXBC.Name = "SXBC";
            this.SXBC.Size = new System.Drawing.Size(176, 35);
            this.SXBC.TabIndex = 1;
            this.SXBC.Text = "Sắp Xếp Báo Cáo ";
            this.SXBC.UseVisualStyleBackColor = true;
            this.SXBC.Click += new System.EventHandler(this.SXBC_Click);
            // 
            // Huy
            // 
            this.Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huy.Location = new System.Drawing.Point(516, 292);
            this.Huy.Name = "Huy";
            this.Huy.Size = new System.Drawing.Size(143, 35);
            this.Huy.TabIndex = 2;
            this.Huy.Text = "Hủy";
            this.Huy.UseVisualStyleBackColor = true;
            this.Huy.Click += new System.EventHandler(this.Huy_Click);
            // 
            // CapNhat
            // 
            this.CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapNhat.Location = new System.Drawing.Point(274, 292);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.Size = new System.Drawing.Size(149, 35);
            this.CapNhat.TabIndex = 3;
            this.CapNhat.Text = "Cập nhật";
            this.CapNhat.UseVisualStyleBackColor = true;
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 339);
            this.Controls.Add(this.CapNhat);
            this.Controls.Add(this.Huy);
            this.Controls.Add(this.SXBC);
            this.Controls.Add(this.DTGVDSKHDV);
            this.Name = "LapBaoCao";
            this.Text = "Lập Báo Cáo ";
            this.Load += new System.EventHandler(this.LapBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDSKHDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVDSKHDV;
        private System.Windows.Forms.Button SXBC;
        private System.Windows.Forms.Button Huy;
        private System.Windows.Forms.Button CapNhat;
    }
}