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
    public partial class QuangCaoLichChieuPhim : Form
    {
        public QuangCaoLichChieuPhim()
        {
            InitializeComponent();
        }

        private void QuangCaoLichChieuPhim_Load(object sender, EventArgs e)
        {
            DanhSachEmailKhachHang.View = View.Details;
            DanhSachEmailKhachHang.GridLines = true;
            DanhSachEmailKhachHang.FullRowSelect = true;

            //Thêm tiêu đề chi cột
            DanhSachEmailKhachHang.Columns.Add("Email", 100);

            // Thêm Item vào listview
            string[] arr = new string[3];
            ListViewItem itm;

            //Thêm Item 
            arr[0] = "chimto@gmail.com";
            itm = new ListViewItem(arr);
            DanhSachEmailKhachHang.Items.Add(itm);

            arr[0] = "cubu@gmail.com";
            itm = new ListViewItem(arr);
            DanhSachEmailKhachHang.Items.Add(itm);

            arr[0] = "lamthon@gmail.com";
            itm = new ListViewItem(arr);
            DanhSachEmailKhachHang.Items.Add(itm);
        }

        //Sự kiện click cho nút thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();        //Đóng form hiện tại
            QuanLyThongTinKhachHang form = new QuanLyThongTinKhachHang();       //Tạo mới form Quản Lý Thông Tin Khách Hàng
            form.Show();                                                        //Trả về form vừa tạo
        }

        //Sự kiện click cho nút gửi lịch chiếu phim
        private void GuiLichChieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gửi thành công!");
        }
    }
}
