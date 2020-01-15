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

namespace ThucAnNhanh
{
    public partial class FormQuanLyThucAn : Form
    {
        public FormQuanLyThucAn()
        {
            InitializeComponent();
        }

        //Hiển thị data vào data grid view được kết nối với bảng Loại thức ăn
        private void FormQuanLyThucAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cUAHANGTHUCANNHANHDataSet1.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.cUAHANGTHUCANNHANHDataSet1.NhaCungCap);
            // TODO: This line of code loads data into the 'cUAHANGTHUCANNHANHDataSet.LoaiThucAn' table. You can move, or remove it, as needed.
            this.loaiThucAnTableAdapter.Fill(this.cUAHANGTHUCANNHANHDataSet.LoaiThucAn);

            
        }

        //Xử lý tab Loại thức ăn

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

            //cnn.Close();

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

        //Hàm hiển thị dữ liệu từ bảng Loại thức ăn
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

        //click nút tìm kiếm
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

        //Click nút trở về
        private void BTTroVe_Click(object sender, EventArgs e)
        {           
            display_data();
        }




        
        
        //Xử lý Tab Nhà Cung Cấp

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

        //Hàm hiển thị dữ liệu từ bảng Nhà cung cấp
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


    }


}
