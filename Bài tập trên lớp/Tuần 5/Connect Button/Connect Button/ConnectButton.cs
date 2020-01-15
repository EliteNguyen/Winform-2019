using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;            //Thư viện để kết nối vs DB

namespace Connect_Button
{
    public partial class ConnectButton : Form
    {
        public ConnectButton()
        {
            InitializeComponent();
        }

        //Sự kiện click của nút Connect
        private void Connect_Click(object sender, EventArgs e)
        {
            //Khai báo biến
            string connectionString;
            SqlConnection cnn;

            //Set connection String
            connectionString = @"Data Source = DESKTOP-8M2NJ75; Initial Catalog = Demodb; User ID = sa; Password = 1900100biet";

            //Chỉ định kết nối (Assign Connection)
            cnn = new SqlConnection(connectionString);

            //Mở kết nối (Open Connection)
            cnn.Open();
            //MessageBox.Show("Connection open!");  //Xuất thông báo thành công

            //cnn.Close();    //Đóng kết nối (Close connection)





            /* //TRUY CẬP DỮ LIỆU VỚI SQLDATAREADER

            //Khai báo biến
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            //Lệnh SQL
            sql = "Select TutorialID, TutorialName from demotb";

            //Câu lệnh 
            command = new SqlCommand(sql, cnn);

            //Khai báo trình đọc dữ liệu
            dataReader = command.ExecuteReader();

            //Lấy data từ bảng
            while(dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            //Xuất data 
            MessageBox.Show(Output);

            //Đóng hết các object
            dataReader.Close();
            command.Dispose();
            cnn.Close(); */






            /* //INSERT TRONG DB

            //Khai báo biến
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Viết lệnh insert 
            sql = "Insert into demotb (TutorialID, TutorialName) values(3, '" + "VB.Net" + "')";

            //Câu lệnh
            command = new SqlCommand(sql, cnn);

            //Liên kết lệnh Insert
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            //Đóng hết các đối tượng
            command.Dispose();
            cnn.Close(); */






            /* //UPDATE TRONG SQL

            //Khai báo biến
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Viết lệnh update 
            sql = "Update demotb set TutorialName='"+"VB.Net Complete"+"' where TutorialID=3";

            //Câu lệnh
            command = new SqlCommand(sql, cnn);

            //Liên kết lệnh Update
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            //Đóng hết các đối tượng
            command.Dispose();
            cnn.Close(); */





            /* //DELETE TRONG DB

            //Khai báo biến
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            //Viết lệnh Delete
            sql = "Delete demotb where TutorialID = 3";

            //Lệnh SQL
            command = new SqlCommand(sql, cnn);

            //Liên kết lệnh delete
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            //Đóng hết các đối tượng
            command.Dispose();
            cnn.Close(); */











        }

        private void ConnectButton_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demodbDataSet.demotb' table. You can move, or remove it, as needed.
            this.demotbTableAdapter.Fill(this.demodbDataSet.demotb);

        }
    }
}
