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
    public partial class BanQuanLy : Form
    {
        public BanQuanLy()
        {
            InitializeComponent();
        }



        //Hàm xử lý sự kiện click cho nút thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        //Hàm xử lý sự kiện click cho nút quản lý nhân viên
        private void QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien form = new QuanLyNhanVien();     //Tạo mới Form quản lý nhân viên
            form.ShowDialog();      //Trả về form Quản Lý Nhân Viên
            
        }

        //Hàm xử lý sự kiện click cho nút quản lý thông tin khách hàng
        private void QLTTKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThongTinKhachHang form = new QuanLyThongTinKhachHang();
            form.ShowDialog();      //Trả về form Quản Lý Thông Tin Khách Hàng
        }

        //Hàm xử lý sự kiện click cho nút 
        private void BaoCaoThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoThongKe form = new BaoCaoThongKe();
            form.ShowDialog();      //Trả về form Báo Cáo Thông Kê
        }

        private void BanQuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}
