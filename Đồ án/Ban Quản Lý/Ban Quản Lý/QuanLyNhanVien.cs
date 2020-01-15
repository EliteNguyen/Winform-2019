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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
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

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

        //Hàm xử lý sự kiện click cho nút liệt kê danh sách nhân viên
        private void LKDSTTNV_Click(object sender, EventArgs e)
        {
            this.Hide();                    //Ẩn form này
            DSTTNV form = new DSTTNV();     //Tạo mới form Danh Sách Thông Tin Nhân Viên
            form.ShowDialog();              //Trả về form Danh Sách Thông Tin Nhân Viên
        }
    }
}
