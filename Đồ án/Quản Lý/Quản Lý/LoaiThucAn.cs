using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;     //Thư viện để kết nối vs DB
using System.Text;

namespace Quản_Lý
{
    public partial class FormLoaiThucAn : Form
    {
        
        public FormLoaiThucAn()
        {
            InitializeComponent();
        }

       //Sự kiện click BTThoat
        private void BTThoat_Click(object sender, EventArgs e)
        {
            Close();    //Đóng form hiện tại
            FormQuanLy form = new FormQuanLy();
            form.Show();    //Trở về form Quản Lý
        }

        //Sự kiện click nút thêm
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
            cmd.CommandText = "insert into LoaiThucAn values('" + TBMaLoaiThucAn.Text + "', '" + TBTenLoaiThucAn.Text +"')";
            cmd.ExecuteNonQuery();
            cnn.Close();
            

            //Hiển thị dòng được thêm vào bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record Inserted successfully!"); 
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
            cmd.CommandText = "select * from LoaiThucAn";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }


        //Sự kiện form load
        private void FormLoaiThucAn_Load(object sender, EventArgs e)
        {
            display_data();
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
            cmd.CommandText = "delete from LoaiThucAn where MaLTA = '"+ TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Hiển thị dòng bị xóa khỏi bảng
            display_data();

            //Thông báo
            MessageBox.Show("Record deleted successfully!");
        }

        //Sự kiện click DBSua
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
            cmd.CommandText = "select * from LoaiThucAn where MaLTA = '" + TBMaLoaiThucAn.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DTGVLoaiThucAn.DataSource = dt;

            //Đóng kết nối
            cnn.Close();
        }
    }
}
