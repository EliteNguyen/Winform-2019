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
    public partial class BaoCaoThongKe : Form
    {
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        //Hàm xử lý sự kiện click cho nút Thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
            BanQuanLy form = new BanQuanLy();
            form.Show();
        }

        //Hàm xử lý sự kiện click cho nút tình trạng số lượng vé
        private void TinhTrangSoLuongVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TinhTrangSoLuongVe form = new TinhTrangSoLuongVe();
            form.ShowDialog();      //Trả về form Tình Trạng số lượng vé
        }

        //Hàm xử lý sự kiện click cho nút tình trạng phim
        private void TinhTrangPhim_Click(object sender, EventArgs e)
        {
            this.Hide();
            TinhTrangPhim form = new TinhTrangPhim();
            form.ShowDialog();      //Trả về form Tình Trạng Phim
        }
    }
}
