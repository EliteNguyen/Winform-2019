using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FastFoodDonald
{
    public partial class FormQuanLyThucAn : Form
    {
        public FormQuanLyThucAn()
        {
            InitializeComponent();
        }

        private void FormQuanLyThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFastFood1DataSet2.ThucAn' table. You can move, or remove it, as needed.
            this.thucAnTableAdapter.Fill(this.databaseFastFood1DataSet2.ThucAn);
            // TODO: This line of code loads data into the 'databaseFastFood1DataSet1.Nha_Cung_Cap' table. You can move, or remove it, as needed.
            this.nha_Cung_CapTableAdapter.Fill(this.databaseFastFood1DataSet1.Nha_Cung_Cap);
            // TODO: This line of code loads data into the 'databaseFastFood1DataSet.MaLoaiThucAn' table. You can move, or remove it, as needed.
            this.maLoaiThucAnTableAdapter.Fill(this.databaseFastFood1DataSet.MaLoaiThucAn);

        }




        //1. Xử lý tab Loại thức ăn

        //Click vào mục thêm
        private void OptionThem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();
            //MessageBox.Show("Connection Open!");

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into MaLoaiThucAn values('" + TBSoThuTu.Text + "', '" + TBMaLoaiThucAn.Text + "', '" + TBTenLoaiThucAn.Text + "')";
            cmd.ExecuteNonQuery();
            cnn.Close();


            //Hiển thị dòng được thêm vào bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record Inserted successfully!");
        }

        //Hàm hiển thị data vào bảng
        public void display_data()
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MaLoaiThucAn";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click vào option xóa
        private void OptionXoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from MaLoaiThucAn where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng bị xóa khỏi bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record deleted successfully!");
        }

        private void OptionSua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update MaLoaiThucAn set STT = '" + TBSoThuTu.Text + "' , TenLTA = '" + TBTenLoaiThucAn.Text + "', MaLTA = '" + TBMaMoiLoaiThucAn.Text + "' where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được thêm vào bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record updated successfully!");
        }

        //Click vào option tìm kiếm
        private void OptionTimKiem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from MaLoaiThucAn where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click vào option trở về
        private void OptionTroVe_Click(object sender, EventArgs e)
        {
            display_data();
        }






        //2. Xử lý tab Nhà cung cấp

        //Click option thêm
        private void Option1Them_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Nha Cung Cap] values('" + TB1SoThuTu.Text + "', '" + TBMaNhaCungCap.Text + "', '" + TBTenNhaCungCap.Text + "')";
            cmd.ExecuteNonQuery();
            cnn.Close();
            display_data1();

            //Thông báo
            MessageBox.Show("Record inserted successfully !");
        }

        //Hàm hiển thị data của bảng
        public void display_data1()
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Nha Cung Cap]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVNhaCungCap.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click option xóa
        private void Option1Xoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Nha Cung Cap] where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Làm mất dòng bị xóa khỏi bảng 
            display_data1();

            //Thông báo
            MessageBox.Show("Record deleted successfully !");
        }

        //Click option sửa
        private void Option1Sua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Nha Cung Cap] set STT = '" + TB1SoThuTu.Text + "', TenNCC = '" + TBTenNhaCungCap.Text + "', MaNCC = '" + TBMaMoiNhaCungCap.Text + "' where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được sửa trên bảng
            display_data1();

            //Thông báo
            MessageBox.Show("Record updated successfully !");           
        }

        //Click option tìm kiếm 
        private void Option1TimKiem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Nha Cung Cap] where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVNhaCungCap.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click option trở vè
        private void Option1TroVe_Click(object sender, EventArgs e)
        {
            display_data1();
        }





        //3. Xử lý tab thức ăn
        
        //Click option thêm
        private void Option2Them_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);


            //Mở kết nối
            cnn.Open();

            //MessageBox.Show("Connection open !");

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ThucAn values('" + TB2SoThuTu.Text + "', '" + TBMaThucAn.Text + "', '" + TBTenThucAn.Text + "', '" + TBGia.Text + "', '" + TB1MaLoaiThucAn.Text + "', '" + TBMaGiamGia.Text + "', '" + TBSoLuong.Text + "')";
            cmd.ExecuteNonQuery();
            cnn.Close();

            display_data2();

            //Thông báo
            MessageBox.Show("Record inserted successfully !");
        }

        //Hàm hiển thị dữ liệu từ bảng Thức ăn
        public void display_data2()
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ThucAn";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click option xóa
        private void Option2Xoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ThucAn where MaTA = '" + TBMaThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Làm mất dòng bị xóa khỏi bảng
            display_data2();

            //Thông báo
            MessageBox.Show("Record deleted successfully !");
        }

        //Click option sửa
        private void Option2Sua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ThucAn set STT = '" + TB2SoThuTu.Text + "', MaTA = '" + TBMaMoiThucAn.Text + "', TenTA = '" + TBTenThucAn.Text + "', Gia = '" + TBGia.Text + "', MaLTA = '" + TB1MaLoaiThucAn.Text + "', MaGG = '" + TBMaGiamGia.Text + "', SL = '" + TBSoLuong.Text + "' where MaTA = '" + TBMaThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được sửa trên bảng 
            display_data2();

            //Thông báo
            MessageBox.Show("Record updated successfully !");
        }

        //Click option tìm kiếm
        private void Option2TimKiem_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = databaseFastFood1; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ThucAn where MaTA = '" + TBMaThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click option trở về
        private void Option2TroVe_Click(object sender, EventArgs e)
        {
            display_data2();
        }
    }
}
