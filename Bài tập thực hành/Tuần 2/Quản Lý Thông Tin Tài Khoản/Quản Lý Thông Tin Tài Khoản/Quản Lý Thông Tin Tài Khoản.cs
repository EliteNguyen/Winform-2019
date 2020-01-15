using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thông_Tin_Tài_Khoản
{
    public partial class QuanLyThongTinTaiKhoan : Form
    {
        public QuanLyThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        //Sự kiện click của nút thêm
        private void Them_Click(object sender, EventArgs e)
        {
            Them.Text = "Hủy";      //Chuyển text cho button
        }

        //Sự kiện click của nút thoát
        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Sự kiện click cho nút lưu
        private void Luu_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem (TBSoTaiKhoan.Text);
            item.SubItems.Add(TBTenKhachHang.Text);
            item.SubItems.Add(TBDiaChiKhachHang.Text);
            item.SubItems.Add(TBSoTienTrongTaiKhoan.Text);
            LVQuanLyThongTinTaiKhoan.Items.Add(item);            
        }

        //Tạo list view
        private void QuanLyThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LVQuanLyThongTinTaiKhoan.View = View.Details;
            LVQuanLyThongTinTaiKhoan.GridLines = true;
            LVQuanLyThongTinTaiKhoan.FullRowSelect = true;

            //Thêm tiêu đề cho cột
            
            LVQuanLyThongTinTaiKhoan.Columns.Add("Mã tài khoản", 100);
            LVQuanLyThongTinTaiKhoan.Columns.Add("Tên khách hàng", 100);
            LVQuanLyThongTinTaiKhoan.Columns.Add("Địa chỉ", 100);
            LVQuanLyThongTinTaiKhoan.Columns.Add("Số tiền", 100);
        }

        //Hàm xóa
        private void delete()
        {
            if(MessageBox.Show("Xóa hàng đó hông dạ???? Xóa rồi là đừng có khóc á nhaaaa !", "Xóa nha ????? !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                LVQuanLyThongTinTaiKhoan.Items.RemoveAt(LVQuanLyThongTinTaiKhoan.SelectedIndices[0]);

                //clear
                TBSoTaiKhoan.Text = "";
                TBTenKhachHang.Text = "";
                TBDiaChiKhachHang.Text = "";
                TBSoTienTrongTaiKhoan.Text = "";
            }
        }

        //Sự kiện click cho nút xóa
        private void Xoa_Click(object sender, EventArgs e)
        {
            delete();   //Gọi hàm delete
        }
    }
}
