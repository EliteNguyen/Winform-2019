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
using System.Text;

namespace Quản_Lý
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        //Sự kiện click của BTThoát
        private void BTThoat_Click(object sender, EventArgs e)
        {
            Close();    //Đóng form hiện tại
            FormQuanLy form = new FormQuanLy();     //Tạo mới form Quản Lý
            form.Show();       //Trở về form Quản Lý
        }

        //Sự kiện click BTThem
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

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into NhaCungCap values('" + TBMaNhaCungCap.Text + "', '" + TBTenNhaCungCap.Text + "')";
            cmd.ExecuteNonQuery();
            cnn.Close();
            display_data();

            //Thông báo
            MessageBox.Show("Record inserted successfully !");            
        }

        //Hàm hiển thị
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
            cmd.CommandText = "select * from NhaCungCap";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVNhaCungCap.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }

        //Form load
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            display_data() ;
        }

        //Sự kiện click BTXoa
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
            cmd.CommandText = "delete from NhaCungCap where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();
            display_data();

            //Thông báo
            MessageBox.Show("Record deleted successfully !");
        }

        //Sự kiện click của BTSua
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
            cmd.CommandText = "update NhaCungCap set TenNCC = '" + TBTenNhaCungCap.Text + "', MaNCC = '" + TBMaMoiNhaCungCap.Text + "' where MaNCC = '" + TBMaNhaCungCap.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();
            display_data();

            //Thông báo
            MessageBox.Show("Record updated successfully !");
        }

        //Sự kiện click của BTTimKiem
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
            cmd.CommandText = "select * from NhaCungCap where MaNCC = '" + TBMaNhaCungCap.Text + "'";
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
