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
    public partial class QuanLyThongTinKhachHang : Form
    {
        public QuanLyThongTinKhachHang()
        {
            InitializeComponent();
        }

        //Hàm xử lý sự kiện click cho nút thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
            BanQuanLy form = new BanQuanLy();
            form.Show();
        }

        //Sự kiện click của nút Lập Báo Cáo
        private void LapBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();        //Ẩn form này
            LapBaoCao form = new LapBaoCao();       //Tạo mới form Lập Báo Cáo
            form.ShowDialog();                     //Hiển thị form Lập Báo Cáo
        }

        //Sự kiện click cho nút Quảng Cáo lịch chiếu phim
        private void QCLCP_Click(object sender, EventArgs e)
        {
            this.Hide();        //Ẩn form
            QuangCaoLichChieuPhim form = new QuangCaoLichChieuPhim();       //Tạo mới form Quảng Cáo Lịch Chiếu Phim
            form.ShowDialog();                                              //Trả về form trên
        }
    }
}
