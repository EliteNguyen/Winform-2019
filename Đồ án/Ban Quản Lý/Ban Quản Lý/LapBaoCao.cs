using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ban_Quản_Lý
{
    public partial class LapBaoCao : Form
    {
        public LapBaoCao()
        {
            InitializeComponent();
        }

        //Sự kiện click của nút Hủy
        private void Huy_Click(object sender, EventArgs e)
        {
            Close();    //Đóng form này 
            QuanLyThongTinKhachHang form = new QuanLyThongTinKhachHang();       //Tạo mới form Quản Lý Thông Tin Khách Hàng
            form.Show();   //Trở về form Quản Lý Thông Tin Khách Hàng
        }


        //Danh sách khách hàng đã đặt vé
        private void LapBaoCao_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng data table
            DataTable dt = new DataTable("Customer");

            //Thêm cột vào data table
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Họ tên", System.Type.GetType("System.String"));
            dt.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên phim đã đặt", System.Type.GetType("System.String"));
            dt.Columns.Add("Số vé đã đặt", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Ngày đặt vé", System.Type.GetType("System.String"));
            dt.Columns.Add("Email", System.Type.GetType("System.String"));

            //Thêm mục vào bảng
            dt.Rows.Add(new object[] {1, "Nguyễn Văn A", "67 Bình Thạnh", "Batman v Superman", 2, "2/3/2019", "chimto@gmail.com"});
            dt.Rows.Add(new object[] {2, "Nguyễn Văn B", "103/4A CMT8 Q10", "Annabelle", 3, "4/7/2019", "chimnho@gmail.com"});

            //Tạo 1 data grid view sử dụng data table làm nguồn dữ liệu
            DTGVDSKHDV.DataSource = dt;

        }

       
        //Sự kiện click cho nút sắp xếp báo cáo
        private void SXBC_Click(object sender, EventArgs e)
        {
            this.Hide();    //Ẩn chính form này
            SapXepDeLapBaoCao form = new SapXepDeLapBaoCao();       //Tạo mới form Sắp Xếp Để Lập Báo Cáo
            form.ShowDialog();                                      //Trả về form trên
        }
    }
}
