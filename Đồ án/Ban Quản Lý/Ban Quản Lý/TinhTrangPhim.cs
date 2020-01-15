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
    public partial class TinhTrangPhim : Form
    {
        public TinhTrangPhim()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
            BaoCaoThongKe form = new BaoCaoThongKe();
            form.Show();    //Trả về form Báo Cáo Thống Kê
        }

        //Danh sách khách hàng và phim họ xem
        private void TinhTrangPhim_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng data table
            DataTable dt = new DataTable("People and Movie they wactch");

            //Thêm cột vào data table
            dt.Columns.Add("Họ tên", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên phim", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày xem", System.Type.GetType("System.String"));
            dt.Columns.Add("Số vé đã đặt", System.Type.GetType("System.Int32"));

            //Thêm mục vào bảng
            dt.Rows.Add(new object[] {"Nguyễn Văn A", "Batman begin", "3/5/2019", 2});
            dt.Rows.Add(new object[] {"Nguyễn Văn B", "SCP", "8/2/2018", 4});
            dt.Rows.Add(new object[] {"Nguyễn Văn C", "Zombie land", "7/11/2018"}, 7);

            //Tạo 1 data grid view sử dụng data table làm nguồn dữ liệu
            DGRVP.DataSource = dt;

        }
    }
}
