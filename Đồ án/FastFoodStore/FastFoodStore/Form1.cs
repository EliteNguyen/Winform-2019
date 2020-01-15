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

namespace FastFoodStore
{
    public partial class FormQuanLyThucAn : Form
    {
        public FormQuanLyThucAn()
        {
            InitializeComponent();
        }

        private void FormQuanLyThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cUAHANGTHUCANNHANHDataSet2.ThucAn' table. You can move, or remove it, as needed.
            this.thucAnTableAdapter.Fill(this.cUAHANGTHUCANNHANHDataSet2.ThucAn);
            // TODO: This line of code loads data into the 'cUAHANGTHUCANNHANHDataSet1.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.cUAHANGTHUCANNHANHDataSet1.NhaCungCap);
            // TODO: This line of code loads data into the 'cUAHANGTHUCANNHANHDataSet.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter.Fill(this.cUAHANGTHUCANNHANHDataSet.LoaiThucAn);

        }

        //1. Xử lý Tab Loại thức ăn

        //Click nút thêm
        private void BTThem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();
            //MessageBox.Show("Connection Open!");

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into LoaiThucAn values('" + TBMaLoaiThucAn.Text + "', '" + TBTenLoaiThucAn.Text + "')";
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
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LoaiThucAn";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click nút xóa
        private void BTXoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from LoaiThucAn where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng bị xóa khỏi bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record deleted successfully!");
        }

        //Click nút sửa
        private void BTSua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update LoaiThucAn set TenLTA = '" + TBTenLoaiThucAn.Text + "', MaLTA = '" + TBMaMoiLoaiThucAn.Text + "' where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được thêm vào bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record updated successfully!");
        }

        //Click nút tìm kiếm
        private void BTTimKiem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from LoaiThucAn where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click nút trở về sau khi tìm kiếm
        private void BTTroVe_Click(object sender, EventArgs e)
        {
            display_data();
        }

        //2.Xử lý tab Nhà cung cấp

        //Click nút thêm
        private void BT1Them_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into NhaCungCap values('" + TBMaNhaCungCap.Text + "', '" + TBTenNhaCungCap.Text + "')";
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
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NhaCungCap";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVNhaCungCap.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click nút xóa
        private void BT1Xoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from NhaCungCap where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Làm mất dòng bị xóa khỏi bảng 
            display_data1();

            //Thông báo
            MessageBox.Show("Record deleted successfully !");
        }

        //Click nút sửa
        private void BT1Sua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update NhaCungCap set TenNCC = '" + TBTenNhaCungCap.Text + "', MaNCC = '" + TBMaMoiNhaCungCap.Text + "' where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được sửa trên bảng
            display_data1();

            //Thông báo
            MessageBox.Show("Record updated successfully !");
        }

        //Click nút tìm kiếm
        private void BT1TimKiem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NhaCungCap where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVNhaCungCap.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Click nút trở về sau khi tìm kiếm
        private void BT1TroVe_Click(object sender, EventArgs e)
        {
            display_data1();
        }

        
        
        
        
        
        
        //3. Xử lý tab Thức ăn

        //Click nút thêm
        private void BT2Them_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);


            //Mở kết nối
            cnn.Open();

            //MessageBox.Show("Connection open !");

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ThucAn values('" + TBMaThucAn.Text + "', '" + TB1MaLoaiThucAn.Text + "', '" + TB1MaNhaCungCap.Text + "', '" + TBTenThucAn.Text + "', '" + TBGia.Text + "')";
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
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

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

        //Click nút sửa
        private void BT2Sua_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

            //Tạo lệnh
            cnn = new SqlConnection(connectionString);

            //Mở kết nối
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ThucAn set MaTA = '" + TBMaMoiThucAn.Text + "', MaLoaiThucAn = '" + TB1MaLoaiThucAn.Text + "', MaNhaCungCap = '" + TB1MaNhaCungCap.Text + "', TenTA = '" + TBTenThucAn.Text + "', GiaTA = '" + TBGia.Text + "' where MaTA = '" + TBMaThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng được sửa trên bảng 
            display_data2();

            //Thông báo
            MessageBox.Show("Record updated successfully !");
        }

        //Click nút xóa
        private void BT2Xoa_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

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

        //Click nút tìm kiếm 
        private void BT2TimKiem_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Khai báo lệnh SQL
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = CUAHANGTHUCANNHANH; User ID = sa; Password = 1900100biet";

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

        //Click nút trở về sau khi tìm kiếm
        private void BT2TroVe_Click(object sender, EventArgs e)
        {
            display_data2();
        }
    }
}
