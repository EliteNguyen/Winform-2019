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
    public partial class SapXepDeLapBaoCao : Form
    {
        public SapXepDeLapBaoCao()
        {
            InitializeComponent();
        }

        //Bảng danh sách khách hàng sau khi sắp xếp theo thông tin dưới đây
        private void SapXepDeLapBaoCao_Load(object sender, EventArgs e)
        {
            //Tạo đối tượng data table
            DataTable dt = new DataTable();

            //Thêm cột vào data table

            dt.Columns.Add("Tên phim đã đặt", System.Type.GetType("System.String"));
            dt.Columns.Add("Số vé đã đặt", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Ngày đặt vé", System.Type.GetType("System.String"));
            dt.Columns.Add("Họ tên", System.Type.GetType("System.String"));
            dt.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dt.Columns.Add("Email", System.Type.GetType("System.String"));

            //Thêm mục vào bảng
            dt.Rows.Add(new object[] {"Batman v Superman", 2, "2/3/2019", "Nguyễn Văn A", "67 Bình Thạnh", "chimto@gmail.com" });
            dt.Rows.Add(new object[] { "Annabelle", 3, "4/7/2019", "Nguyễn Văn B", "103/4A CMT8 Q10", "chimnho@gmail.com"});

            //Tạo 1 data grid view sử dụng data table làm nguồn dữ liệu
            DTGVSXDLBC.DataSource = dt;

        }

       

        //Sự kiện click cho nút xác nhận
        private void XacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công bảng báo cáo");
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();    //Đóng form này
            LapBaoCao form = new LapBaoCao();   //Tạo mới form Lập Báo Cáo
            form.Show();    //Trả về form trên
        }
    }
}
