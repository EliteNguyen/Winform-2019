namespace ThucAnNhanh
{
    partial class FormQuanLyThucAn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPLoaiThucAn = new System.Windows.Forms.TabPage();
            this.TPNhaCungCap = new System.Windows.Forms.TabPage();
            this.TPThucAn = new System.Windows.Forms.TabPage();
            this.LBMaLoaiThucAn = new System.Windows.Forms.Label();
            this.TBMaLoaiThucAn = new System.Windows.Forms.TextBox();
            this.LBTenLoaiThucAn = new System.Windows.Forms.Label();
            this.LBMaMoiLoaiThucAn = new System.Windows.Forms.Label();
            this.TBTenLoaiThucAn = new System.Windows.Forms.TextBox();
            this.TBMaMoiLoaiThucAn = new System.Windows.Forms.TextBox();
            this.DTGVLoaiThucAn = new System.Windows.Forms.DataGridView();
            this.BTTimKiem = new System.Windows.Forms.Button();
            this.BTThem = new System.Windows.Forms.Button();
            this.BTXoa = new System.Windows.Forms.Button();
            this.BTSua = new System.Windows.Forms.Button();
            this.cUAHANGTHUCANNHANHDataSet = new ThucAnNhanh.CUAHANGTHUCANNHANHDataSet();
            this.loaiThucAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiThucAnTableAdapter = new ThucAnNhanh.CUAHANGTHUCANNHANHDataSetTableAdapters.LoaiThucAnTableAdapter();
            this.maLTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTTroVe = new System.Windows.Forms.Button();
            this.LBMaNhaCungCap = new System.Windows.Forms.Label();
            this.TBMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.LBTenNhaCungCap = new System.Windows.Forms.Label();
            this.TBTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.LBMaMoiNhaCungCap = new System.Windows.Forms.Label();
            this.TBMaMoiNhaCungCap = new System.Windows.Forms.TextBox();
            this.DTGVNhaCungCap = new System.Windows.Forms.DataGridView();
            this.BT1TimKiem = new System.Windows.Forms.Button();
            this.BT1Them = new System.Windows.Forms.Button();
            this.BT1Xoa = new System.Windows.Forms.Button();
            this.BT4Sua = new System.Windows.Forms.Button();
            this.BT5TroVe = new System.Windows.Forms.Button();
            this.cUAHANGTHUCANNHANHDataSet1 = new ThucAnNhanh.CUAHANGTHUCANNHANHDataSet1();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCungCapTableAdapter = new ThucAnNhanh.CUAHANGTHUCANNHANHDataSet1TableAdapters.NhaCungCapTableAdapter();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TPLoaiThucAn.SuspendLayout();
            this.TPNhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLoaiThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPLoaiThucAn);
            this.tabControl1.Controls.Add(this.TPNhaCungCap);
            this.tabControl1.Controls.Add(this.TPThucAn);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // TPLoaiThucAn
            // 
            this.TPLoaiThucAn.Controls.Add(this.BTTroVe);
            this.TPLoaiThucAn.Controls.Add(this.BTSua);
            this.TPLoaiThucAn.Controls.Add(this.BTXoa);
            this.TPLoaiThucAn.Controls.Add(this.BTThem);
            this.TPLoaiThucAn.Controls.Add(this.BTTimKiem);
            this.TPLoaiThucAn.Controls.Add(this.DTGVLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.TBMaMoiLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.TBTenLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.LBMaMoiLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.LBTenLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.TBMaLoaiThucAn);
            this.TPLoaiThucAn.Controls.Add(this.LBMaLoaiThucAn);
            this.TPLoaiThucAn.Location = new System.Drawing.Point(4, 22);
            this.TPLoaiThucAn.Name = "TPLoaiThucAn";
            this.TPLoaiThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoaiThucAn.Size = new System.Drawing.Size(680, 547);
            this.TPLoaiThucAn.TabIndex = 0;
            this.TPLoaiThucAn.Text = "Loại thức ăn";
            this.TPLoaiThucAn.UseVisualStyleBackColor = true;
            // 
            // TPNhaCungCap
            // 
            this.TPNhaCungCap.Controls.Add(this.BT5TroVe);
            this.TPNhaCungCap.Controls.Add(this.BT4Sua);
            this.TPNhaCungCap.Controls.Add(this.BT1Xoa);
            this.TPNhaCungCap.Controls.Add(this.BT1Them);
            this.TPNhaCungCap.Controls.Add(this.BT1TimKiem);
            this.TPNhaCungCap.Controls.Add(this.DTGVNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.TBMaMoiNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.LBMaMoiNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.TBTenNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.LBTenNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.TBMaNhaCungCap);
            this.TPNhaCungCap.Controls.Add(this.LBMaNhaCungCap);
            this.TPNhaCungCap.Location = new System.Drawing.Point(4, 22);
            this.TPNhaCungCap.Name = "TPNhaCungCap";
            this.TPNhaCungCap.Padding = new System.Windows.Forms.Padding(3);
            this.TPNhaCungCap.Size = new System.Drawing.Size(680, 547);
            this.TPNhaCungCap.TabIndex = 1;
            this.TPNhaCungCap.Text = "Nhà cung cấp";
            this.TPNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // TPThucAn
            // 
            this.TPThucAn.Location = new System.Drawing.Point(4, 22);
            this.TPThucAn.Name = "TPThucAn";
            this.TPThucAn.Size = new System.Drawing.Size(680, 317);
            this.TPThucAn.TabIndex = 2;
            this.TPThucAn.Text = "Thức ăn";
            this.TPThucAn.UseVisualStyleBackColor = true;
            // 
            // LBMaLoaiThucAn
            // 
            this.LBMaLoaiThucAn.AutoSize = true;
            this.LBMaLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaLoaiThucAn.Location = new System.Drawing.Point(52, 18);
            this.LBMaLoaiThucAn.Name = "LBMaLoaiThucAn";
            this.LBMaLoaiThucAn.Size = new System.Drawing.Size(136, 20);
            this.LBMaLoaiThucAn.TabIndex = 7;
            this.LBMaLoaiThucAn.Text = "Mã loại thức ăn:";
            // 
            // TBMaLoaiThucAn
            // 
            this.TBMaLoaiThucAn.Location = new System.Drawing.Point(221, 20);
            this.TBMaLoaiThucAn.Name = "TBMaLoaiThucAn";
            this.TBMaLoaiThucAn.Size = new System.Drawing.Size(401, 20);
            this.TBMaLoaiThucAn.TabIndex = 8;
            // 
            // LBTenLoaiThucAn
            // 
            this.LBTenLoaiThucAn.AutoSize = true;
            this.LBTenLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenLoaiThucAn.Location = new System.Drawing.Point(46, 57);
            this.LBTenLoaiThucAn.Name = "LBTenLoaiThucAn";
            this.LBTenLoaiThucAn.Size = new System.Drawing.Size(142, 20);
            this.LBTenLoaiThucAn.TabIndex = 9;
            this.LBTenLoaiThucAn.Text = "Tên loại thức ăn:";
            // 
            // LBMaMoiLoaiThucAn
            // 
            this.LBMaMoiLoaiThucAn.AutoSize = true;
            this.LBMaMoiLoaiThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaMoiLoaiThucAn.Location = new System.Drawing.Point(19, 96);
            this.LBMaMoiLoaiThucAn.Name = "LBMaMoiLoaiThucAn";
            this.LBMaMoiLoaiThucAn.Size = new System.Drawing.Size(169, 20);
            this.LBMaMoiLoaiThucAn.TabIndex = 14;
            this.LBMaMoiLoaiThucAn.Text = "Mã mới loại thức ăn:";
            // 
            // TBTenLoaiThucAn
            // 
            this.TBTenLoaiThucAn.Location = new System.Drawing.Point(221, 59);
            this.TBTenLoaiThucAn.Name = "TBTenLoaiThucAn";
            this.TBTenLoaiThucAn.Size = new System.Drawing.Size(401, 20);
            this.TBTenLoaiThucAn.TabIndex = 15;
            // 
            // TBMaMoiLoaiThucAn
            // 
            this.TBMaMoiLoaiThucAn.Location = new System.Drawing.Point(221, 96);
            this.TBMaMoiLoaiThucAn.Name = "TBMaMoiLoaiThucAn";
            this.TBMaMoiLoaiThucAn.Size = new System.Drawing.Size(401, 20);
            this.TBMaMoiLoaiThucAn.TabIndex = 16;
            // 
            // DTGVLoaiThucAn
            // 
            this.DTGVLoaiThucAn.AutoGenerateColumns = false;
            this.DTGVLoaiThucAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVLoaiThucAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLTADataGridViewTextBoxColumn,
            this.tenLTADataGridViewTextBoxColumn});
            this.DTGVLoaiThucAn.DataSource = this.loaiThucAnBindingSource;
            this.DTGVLoaiThucAn.Location = new System.Drawing.Point(23, 163);
            this.DTGVLoaiThucAn.Name = "DTGVLoaiThucAn";
            this.DTGVLoaiThucAn.Size = new System.Drawing.Size(599, 264);
            this.DTGVLoaiThucAn.TabIndex = 17;
            // 
            // BTTimKiem
            // 
            this.BTTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTimKiem.Location = new System.Drawing.Point(23, 458);
            this.BTTimKiem.Name = "BTTimKiem";
            this.BTTimKiem.Size = new System.Drawing.Size(117, 32);
            this.BTTimKiem.TabIndex = 18;
            this.BTTimKiem.Text = "Tìm kiếm";
            this.BTTimKiem.UseVisualStyleBackColor = true;
            this.BTTimKiem.Click += new System.EventHandler(this.BTTimKiem_Click);
            // 
            // BTThem
            // 
            this.BTThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTThem.Location = new System.Drawing.Point(175, 458);
            this.BTThem.Name = "BTThem";
            this.BTThem.Size = new System.Drawing.Size(75, 33);
            this.BTThem.TabIndex = 19;
            this.BTThem.Text = "Thêm";
            this.BTThem.UseVisualStyleBackColor = true;
            this.BTThem.Click += new System.EventHandler(this.BTThem_Click);
            // 
            // BTXoa
            // 
            this.BTXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTXoa.Location = new System.Drawing.Point(287, 458);
            this.BTXoa.Name = "BTXoa";
            this.BTXoa.Size = new System.Drawing.Size(75, 33);
            this.BTXoa.TabIndex = 20;
            this.BTXoa.Text = "Xóa";
            this.BTXoa.UseVisualStyleBackColor = true;
            this.BTXoa.Click += new System.EventHandler(this.BTXoa_Click);
            // 
            // BTSua
            // 
            this.BTSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSua.Location = new System.Drawing.Point(394, 457);
            this.BTSua.Name = "BTSua";
            this.BTSua.Size = new System.Drawing.Size(75, 33);
            this.BTSua.TabIndex = 21;
            this.BTSua.Text = "Sửa";
            this.BTSua.UseVisualStyleBackColor = true;
            this.BTSua.Click += new System.EventHandler(this.BTSua_Click);
            // 
            // cUAHANGTHUCANNHANHDataSet
            // 
            this.cUAHANGTHUCANNHANHDataSet.DataSetName = "CUAHANGTHUCANNHANHDataSet";
            this.cUAHANGTHUCANNHANHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiThucAnBindingSource
            // 
            this.loaiThucAnBindingSource.DataMember = "LoaiThucAn";
            this.loaiThucAnBindingSource.DataSource = this.cUAHANGTHUCANNHANHDataSet;
            // 
            // loaiThucAnTableAdapter
            // 
            this.loaiThucAnTableAdapter.ClearBeforeFill = true;
            // 
            // maLTADataGridViewTextBoxColumn
            // 
            this.maLTADataGridViewTextBoxColumn.DataPropertyName = "MaLTA";
            this.maLTADataGridViewTextBoxColumn.HeaderText = "MaLTA";
            this.maLTADataGridViewTextBoxColumn.Name = "maLTADataGridViewTextBoxColumn";
            // 
            // tenLTADataGridViewTextBoxColumn
            // 
            this.tenLTADataGridViewTextBoxColumn.DataPropertyName = "TenLTA";
            this.tenLTADataGridViewTextBoxColumn.HeaderText = "TenLTA";
            this.tenLTADataGridViewTextBoxColumn.Name = "tenLTADataGridViewTextBoxColumn";
            // 
            // BTTroVe
            // 
            this.BTTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTroVe.Location = new System.Drawing.Point(522, 460);
            this.BTTroVe.Name = "BTTroVe";
            this.BTTroVe.Size = new System.Drawing.Size(100, 31);
            this.BTTroVe.TabIndex = 22;
            this.BTTroVe.Text = "Trở về";
            this.BTTroVe.UseVisualStyleBackColor = true;
            this.BTTroVe.Click += new System.EventHandler(this.BTTroVe_Click);
            // 
            // LBMaNhaCungCap
            // 
            this.LBMaNhaCungCap.AutoSize = true;
            this.LBMaNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaNhaCungCap.Location = new System.Drawing.Point(85, 47);
            this.LBMaNhaCungCap.Name = "LBMaNhaCungCap";
            this.LBMaNhaCungCap.Size = new System.Drawing.Size(151, 20);
            this.LBMaNhaCungCap.TabIndex = 2;
            this.LBMaNhaCungCap.Text = "Mã nhà cung cấp:";
            // 
            // TBMaNhaCungCap
            // 
            this.TBMaNhaCungCap.Location = new System.Drawing.Point(260, 47);
            this.TBMaNhaCungCap.Name = "TBMaNhaCungCap";
            this.TBMaNhaCungCap.Size = new System.Drawing.Size(372, 20);
            this.TBMaNhaCungCap.TabIndex = 3;
            // 
            // LBTenNhaCungCap
            // 
            this.LBTenNhaCungCap.AutoSize = true;
            this.LBTenNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTenNhaCungCap.Location = new System.Drawing.Point(79, 93);
            this.LBTenNhaCungCap.Name = "LBTenNhaCungCap";
            this.LBTenNhaCungCap.Size = new System.Drawing.Size(157, 20);
            this.LBTenNhaCungCap.TabIndex = 4;
            this.LBTenNhaCungCap.Text = "Tên nhà cung cấp:";
            // 
            // TBTenNhaCungCap
            // 
            this.TBTenNhaCungCap.Location = new System.Drawing.Point(260, 93);
            this.TBTenNhaCungCap.Name = "TBTenNhaCungCap";
            this.TBTenNhaCungCap.Size = new System.Drawing.Size(372, 20);
            this.TBTenNhaCungCap.TabIndex = 5;
            // 
            // LBMaMoiNhaCungCap
            // 
            this.LBMaMoiNhaCungCap.AutoSize = true;
            this.LBMaMoiNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMaMoiNhaCungCap.Location = new System.Drawing.Point(18, 138);
            this.LBMaMoiNhaCungCap.Name = "LBMaMoiNhaCungCap";
            this.LBMaMoiNhaCungCap.Size = new System.Drawing.Size(218, 20);
            this.LBMaMoiNhaCungCap.TabIndex = 10;
            this.LBMaMoiNhaCungCap.Text = "Mã mới của nhà cung cấp:";
            // 
            // TBMaMoiNhaCungCap
            // 
            this.TBMaMoiNhaCungCap.Location = new System.Drawing.Point(260, 138);
            this.TBMaMoiNhaCungCap.Name = "TBMaMoiNhaCungCap";
            this.TBMaMoiNhaCungCap.Size = new System.Drawing.Size(372, 20);
            this.TBMaMoiNhaCungCap.TabIndex = 11;
            // 
            // DTGVNhaCungCap
            // 
            this.DTGVNhaCungCap.AutoGenerateColumns = false;
            this.DTGVNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNCCDataGridViewTextBoxColumn,
            this.tenNCCDataGridViewTextBoxColumn});
            this.DTGVNhaCungCap.DataSource = this.nhaCungCapBindingSource;
            this.DTGVNhaCungCap.Location = new System.Drawing.Point(22, 195);
            this.DTGVNhaCungCap.Name = "DTGVNhaCungCap";
            this.DTGVNhaCungCap.Size = new System.Drawing.Size(610, 228);
            this.DTGVNhaCungCap.TabIndex = 12;
            // 
            // BT1TimKiem
            // 
            this.BT1TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT1TimKiem.Location = new System.Drawing.Point(22, 442);
            this.BT1TimKiem.Name = "BT1TimKiem";
            this.BT1TimKiem.Size = new System.Drawing.Size(105, 33);
            this.BT1TimKiem.TabIndex = 13;
            this.BT1TimKiem.Text = "Tìm kiếm";
            this.BT1TimKiem.UseVisualStyleBackColor = true;
            // 
            // BT1Them
            // 
            this.BT1Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT1Them.Location = new System.Drawing.Point(176, 443);
            this.BT1Them.Name = "BT1Them";
            this.BT1Them.Size = new System.Drawing.Size(75, 33);
            this.BT1Them.TabIndex = 14;
            this.BT1Them.Text = "Thêm";
            this.BT1Them.UseVisualStyleBackColor = true;
            // 
            // BT1Xoa
            // 
            this.BT1Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT1Xoa.Location = new System.Drawing.Point(297, 444);
            this.BT1Xoa.Name = "BT1Xoa";
            this.BT1Xoa.Size = new System.Drawing.Size(75, 33);
            this.BT1Xoa.TabIndex = 15;
            this.BT1Xoa.Text = "Xóa";
            this.BT1Xoa.UseVisualStyleBackColor = true;
            // 
            // BT4Sua
            // 
            this.BT4Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT4Sua.Location = new System.Drawing.Point(422, 442);
            this.BT4Sua.Name = "BT4Sua";
            this.BT4Sua.Size = new System.Drawing.Size(75, 33);
            this.BT4Sua.TabIndex = 16;
            this.BT4Sua.Text = "Sửa";
            this.BT4Sua.UseVisualStyleBackColor = true;
            // 
            // BT5TroVe
            // 
            this.BT5TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT5TroVe.Location = new System.Drawing.Point(532, 444);
            this.BT5TroVe.Name = "BT5TroVe";
            this.BT5TroVe.Size = new System.Drawing.Size(100, 31);
            this.BT5TroVe.TabIndex = 23;
            this.BT5TroVe.Text = "Trở về";
            this.BT5TroVe.UseVisualStyleBackColor = true;
            // 
            // cUAHANGTHUCANNHANHDataSet1
            // 
            this.cUAHANGTHUCANNHANHDataSet1.DataSetName = "CUAHANGTHUCANNHANHDataSet1";
            this.cUAHANGTHUCANNHANHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.cUAHANGTHUCANNHANHDataSet1;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "MaNCC";
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            // 
            // tenNCCDataGridViewTextBoxColumn
            // 
            this.tenNCCDataGridViewTextBoxColumn.DataPropertyName = "TenNCC";
            this.tenNCCDataGridViewTextBoxColumn.HeaderText = "TenNCC";
            this.tenNCCDataGridViewTextBoxColumn.Name = "tenNCCDataGridViewTextBoxColumn";
            // 
            // FormQuanLyThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormQuanLyThucAn";
            this.Text = "Quản lý thức ăn";
            this.Load += new System.EventHandler(this.FormQuanLyThucAn_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPLoaiThucAn.ResumeLayout(false);
            this.TPLoaiThucAn.PerformLayout();
            this.TPNhaCungCap.ResumeLayout(false);
            this.TPNhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVLoaiThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiThucAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUAHANGTHUCANNHANHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPLoaiThucAn;
        private System.Windows.Forms.Button BTSua;
        private System.Windows.Forms.Button BTXoa;
        private System.Windows.Forms.Button BTThem;
        private System.Windows.Forms.Button BTTimKiem;
        private System.Windows.Forms.DataGridView DTGVLoaiThucAn;
        private System.Windows.Forms.TextBox TBMaMoiLoaiThucAn;
        private System.Windows.Forms.TextBox TBTenLoaiThucAn;
        private System.Windows.Forms.Label LBMaMoiLoaiThucAn;
        private System.Windows.Forms.Label LBTenLoaiThucAn;
        private System.Windows.Forms.TextBox TBMaLoaiThucAn;
        private System.Windows.Forms.Label LBMaLoaiThucAn;
        private System.Windows.Forms.TabPage TPNhaCungCap;
        private System.Windows.Forms.TabPage TPThucAn;
        private CUAHANGTHUCANNHANHDataSet cUAHANGTHUCANNHANHDataSet;
        private System.Windows.Forms.BindingSource loaiThucAnBindingSource;
        private CUAHANGTHUCANNHANHDataSetTableAdapters.LoaiThucAnTableAdapter loaiThucAnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLTADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTTroVe;
        private System.Windows.Forms.Label LBMaNhaCungCap;
        private System.Windows.Forms.TextBox TBMaNhaCungCap;
        private System.Windows.Forms.Button BT4Sua;
        private System.Windows.Forms.Button BT1Xoa;
        private System.Windows.Forms.Button BT1Them;
        private System.Windows.Forms.Button BT1TimKiem;
        private System.Windows.Forms.DataGridView DTGVNhaCungCap;
        private System.Windows.Forms.TextBox TBMaMoiNhaCungCap;
        private System.Windows.Forms.Label LBMaMoiNhaCungCap;
        private System.Windows.Forms.TextBox TBTenNhaCungCap;
        private System.Windows.Forms.Label LBTenNhaCungCap;
        private System.Windows.Forms.Button BT5TroVe;
        private CUAHANGTHUCANNHANHDataSet1 cUAHANGTHUCANNHANHDataSet1;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private CUAHANGTHUCANNHANHDataSet1TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCCDataGridViewTextBoxColumn;
    }
}

