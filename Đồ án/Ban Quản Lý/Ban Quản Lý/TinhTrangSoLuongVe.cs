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
    public partial class TinhTrangSoLuongVe : Form
    {
        public TinhTrangSoLuongVe()
        {
            InitializeComponent();
        }

        //Hàm xử lý sự kiện click cho nút Thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
            BaoCaoThongKe form = new BaoCaoThongKe();
            form.Show();    //Trả về form Báo Cáo Thống Kê
        }

        //Danh sách số lượng vé theo tiêu chí pim
        private void TinhTrangSoLuongVe_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng data table
            DataTable dt = new DataTable("Ticket");

            //Thêm cột vào data table
            dt.Columns.Add("Ngày/Tháng/Năm", System.Type.GetType("System.String"));          
            dt.Columns.Add("Tên phim", System.Type.GetType("System.String"));
            dt.Columns.Add("Thể loại", System.Type.GetType("System.String"));
            dt.Columns.Add("Số vé đã đặt", System.Type.GetType("System.Int32"));

            //Thêm mục vào bảng
            dt.Rows.Add(new object[] {"3/11/2019", "Batman begin", "Hành động", 2});
            dt.Rows.Add(new object[] {"22/5/2019", "Fast and furios", "Hành động", 2});

            //Tạo 1 data grid view sử dụng data table làm nguồn dữ liệu
            DTGVTTV.DataSource = dt;

        }
    }
}
