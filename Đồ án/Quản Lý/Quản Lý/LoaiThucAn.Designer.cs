namespace Quản_Lý
{
    partial class FormLoaiThucAn
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
            this.components = new System.ComponentModel.Container();
            this.BTThoat = new System.Windows.Forms.Button();
            this.loaiThucAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUAHANGTHUCANNHANHDataSet = new Quản_Lý.CUAHANGTHUCANNHANHDataSet();
            this.BTThem = new System.Windows.Forms.Button();
            this.BTSua = new System.Windows.Forms.Button();
            this.loaiThucAnTableAdapter = new Quản_Lý.CUAHANGTHUCANNHANHDataSetTableAdapters.LoaiThucAnTableAdapter();
            this.LBMaLoaiThucAn = new System.Windows.Forms.Label();
            this.TBMaLoaiThucAn = new System.Windows.Forms.TextBox();
            this.LBTenLoaiThucAn = new System.Windows.Forms.Label();
            this.TBTenLoaiThucAn = new System.Windows.Forms.TextBox();
            this.DTGVLoaiThucAn = new System.Windows.Forms.DataGridView();
            this.BTTimKiem = new System.Windows.Forms.Button();
            this.LBMaMoiLoaiThucAn = new System.Windows.Forms.Label();
            this.TBMaMoiLoaiThucAn = new System.Windows.Forms.TextBox();
            this.BTXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLoaiThucAn)).BeginInit();
            this.SuspendLayout();
            // 
            // BTThoat
            // 
            this.BTThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThoat.Location = new System.Drawing.Point(585, 498);
            this.BTThoat.Name = "BTThoat";
            this.BTThoat.Size = new System.Drawing.Size(75, 33);
            this.BTThoat.TabIndex = 0;
            this.BTThoat.Text = "Thoát";
            this.BTThoat.UseVisualStyleBackColor = true;
            this.BTThoat.Click += new System.EventHandler(this.BTThoat_Click);
            // 
            // loaiThucAnBindingSource
            // 
            this.loaiThucAnBindingSource.DataMember = "LoaiThucAn";
            this.loaiThucAnBindingSource.DataSource = this.cUAHANGTHUCANNHANHDataSet;
            // 
            // cUAHANGTHUCANNHANHDataSet
            // 
            this.cUAHANGTHUCANNHANHDataSet.DataSetName = "CUAHANGTHUCANNHANHDataSet";
            this.cUAHANGTHUCANNHANHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTThem
            // 
            this.BTThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThem.Location = new System.Drawing.Point(187, 498);
            this.BTThem.Name = "BTThem";
            this.BTThem.Size = new System.Drawing.Size(75, 33);
            this.BTThem.TabIndex = 3;
            this.BTThem.Text = "Thêm";
            this.BTThem.UseVisualStyleBackColor = true;
            this.BTThem.Click += new System.EventHandler(this.BTThem_Click);
            // 
            // BTSua
            // 
            this.BTSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSua.Location = new System.Drawing.Point(447, 498);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(75, 33);
            this.BTSua.TabIndex = 5;
            this.BTSua.Text = "Sửa";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // loaiThucAnTableAdapter
            // 
            this.loaiThucAnTableAdapter.ClearBeforeFill = true;
            // 
            // LBMaLoaiThucAn
            // 
            this.LBMaLoaiThucAn.AutoSize = true;
            this.LBMaLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaLoaiThucAn.Location = new System.Drawing.Point(61, 24);
            this.LBMaLoaiThucAn.Name = "LBMaLoaiThucAn";
            this.LBMaLoaiThucAn.Size = new System.Drawing.Size(136, 20);
            this.LBMaLoaiThucAn.TabIndex = 6;
            this.LBMaLoaiThucAn.Text = "Mã loại thức ăn:";
            // 
            // TBMaLoaiThucAn
            // 
            this.TBMaLoaiThucAn.Location = new System.Drawing.Point(255, 26);
            this.TBMaLoaiThucAn.Name = "TBMaLoaiThucAn";
            this.TBMaLoaiThucAn.Size = new System.Drawing.Size(466, 20);
            this.TBMaLoaiThucAn.TabIndex = 7;
            // 
            // LBTenLoaiThucAn
            // 
            this.LBTenLoaiThucAn.AutoSize = true;
            this.LBTenLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenLoaiThucAn.Location = new System.Drawing.Point(55, 72);
            this.LBTenLoaiThucAn.Name = "LBTenLoaiThucAn";
            this.LBTenLoaiThucAn.Size = new System.Drawing.Size(142, 20);
            this.LBTenLoaiThucAn.TabIndex = 8;
            this.LBTenLoaiThucAn.Text = "Tên loại thức ăn:";
            // 
            // TBTenLoaiThucAn
            // 
            this.TBTenLoaiThucAn.Location = new System.Drawing.Point(255, 72);
            this.TBTenLoaiThucAn.Name = "TBTenLoaiThucAn";
            this.TBTenLoaiThucAn.Size = new System.Drawing.Size(466, 20);
            this.TBTenLoaiThucAn.TabIndex = 9;
            // 
            // DTGVLoaiThucAn
            // 
            this.DTGVLoaiThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVLoaiThucAn.Location = new System.Drawing.Point(26, 182);
            this.DTGVLoaiThucAn.Name = "DTGVLoaiThucAn";
            this.DTGVLoaiThucAn.Size = new System.Drawing.Size(695, 284);
            this.DTGVLoaiThucAn.TabIndex = 10;
            // 
            // BTTimKiem
            // 
            this.BTTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTimKiem.Location = new System.Drawing.Point(26, 499);
            this.BTTimKiem.Name = "BTTimKiem";
            this.BTTimKiem.Size = new System.Drawing.Size(117, 32);
            this.BTTimKiem.TabIndex = 12;
            this.BTTimKiem.Text = "Tìm kiếm";
            this.BTTimKiem.UseVisualStyleBackColor = true;
            this.BTTimKiem.Click += new System.EventHandler(this.BTTimKiem_Click);
            // 
            // LBMaMoiLoaiThucAn
            // 
            this.LBMaMoiLoaiThucAn.AutoSize = true;
            this.LBMaMoiLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaMoiLoaiThucAn.Location = new System.Drawing.Point(28, 125);
            this.LBMaMoiLoaiThucAn.Name = "LBMaMoiLoaiThucAn";
            this.LBMaMoiLoaiThucAn.Size = new System.Drawing.Size(169, 20);
            this.LBMaMoiLoaiThucAn.TabIndex = 13;
            this.LBMaMoiLoaiThucAn.Text = "Mã mới loại thức ăn:";
            // 
            // TBMaMoiLoaiThucAn
            // 
            this.TBMaMoiLoaiThucAn.Location = new System.Drawing.Point(255, 125);
            this.TBMaMoiLoaiThucAn.Name = "TBMaMoiLoaiThucAn";
            this.TBMaMoiLoaiThucAn.Size = new System.Drawing.Size(466, 20);
            this.TBMaMoiLoaiThucAn.TabIndex = 14;
            // 
            // BTXoa
            // 
            this.BTXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXoa.Location = new System.Drawing.Point(310, 498);
            this.BTXoa.Name = "BTXoa";
            this.BTXoa.Size = new System.Drawing.Size(75, 33);
            this.BTXoa.TabIndex = 4;
            this.BTXoa.Text = "Xóa";
            this.BTXoa.UseVisualStyleBackColor = true;
            this.BTXoa.Click += new System.EventHandler(this.BTXoa_Click);
            // 
            // FormLoaiThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 568);
            this.Controls.Add(this.TBMaMoiLoaiThucAn);
            this.Controls.Add(this.LBMaMoiLoaiThucAn);
            this.Controls.Add(this.BTTimKiem);
            this.Controls.Add(this.DTGVLoaiThucAn);
            this.Controls.Add(this.TBTenLoaiThucAn);
            this.Controls.Add(this.LBTenLoaiThucAn);
            this.Controls.Add(this.TBMaLoaiThucAn);
            this.Controls.Add(this.LBMaLoaiThucAn);
            this.Controls.Add(this.BTSua);
            this.Controls.Add(this.BTXoa);
            this.Controls.Add(this.BTThem);
            this.Controls.Add(this.BTThoat);
            this.Name = "FormLoaiThucAn";
            this.Text = "LoaiThucAn";
            this.Load += new System.EventHandler(this.FormLoaiThucAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLoaiThucAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTThoat;
        private System.Windows.Forms.Button BTThem;
        private System.Windows.Forms.Button BTSua;
        private CUAHANGTHUCANNHANHDataSet cUAHANGTHUCANNHANHDataSet;
        private System.Windows.Forms.BindingSource loaiThucAnBindingSource;
        private CUAHANGTHUCANNHANHDataSetTableAdapters.LoaiThucAnTableAdapter loaiThucAnTableAdapter;
        private System.Windows.Forms.Label LBMaLoaiThucAn;
        private System.Windows.Forms.TextBox TBMaLoaiThucAn;
        private System.Windows.Forms.Label LBTenLoaiThucAn;
        private System.Windows.Forms.TextBox TBTenLoaiThucAn;
        private System.Windows.Forms.DataGridView DTGVLoaiThucAn;
        private System.Windows.Forms.Button BTTimKiem;
        private System.Windows.Forms.Label LBMaMoiLoaiThucAn;
        private System.Windows.Forms.TextBox TBMaMoiLoaiThucAn;
        private System.Windows.Forms.Button BTXoa;
    }
}