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

namespace Ban_Quản_Lý
{
    public partial class DSTTNV : Form
    {
        public DSTTNV()
        {
            InitializeComponent();
        }

        //Danh sách thông tin nhân viên
        private void DSTTNV_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng data table
            DataTable dt = new DataTable("People");

            //Thêm cột vào data table
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Họ tên", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày/Tháng/Năm sinh", System.Type.GetType("System.String"));
            dt.Columns.Add("Giới tính", System.Type.GetType("System.String"));
            dt.Columns.Add("Quê quán", System.Type.GetType("System.String"));
            dt.Columns.Add("Nơi ở hiện tại", System.Type.GetType("System.String"));
            dt.Columns.Add("Số CMND", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Chức vụ", System.Type.GetType("System.String"));
            dt.Columns.Add("Lương", System.Type.GetType("System.Double"));

            //Thêm mục vào bảng
            dt.Rows.Add(new object[] { "113332", "Nguyễn Văn A", "10/2/1994", "Nam", "Cần Thơ", "TP HCM", 24262727, "Nhân viên bán vé", 7000000 });
            dt.Rows.Add(new object[] { "2827222", "Nguyễn Văn B", "15/5/1992", "Nam", "Hà Nội", "TP HCM", 25262727, "Nhân viên soát vé", 4000000 });

            //Tạo 1 data grid view sử dụng data table làm nguồn dữ liệu
            DTGVDSTTNV.DataSource = dt;

            //
        }

        //Sự kiện click của nút thêm
        private void Them_Click(object sender, EventArgs e)
        {

        }

        //Sự kiện click của nút xóa
        private void Xoa_Click(object sender, EventArgs e)
        {

        }

        //Sự kiện click của nút sửa 
        private void Sua_Click(object sender, EventArgs e)
        {

        }

        //Sự kiện click của nút thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();    //Đóng form này
            QuanLyNhanVien form = new QuanLyNhanVien();     //Tạo mới form Quản Lý Nhân Viên
            form.Show();                                    //Trả về form Quản Lý Nhân Viên
        }


    }
}
