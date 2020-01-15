using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        //Sự kiện click BTLoaiThucAn
        private void BTLoaiThucAn_Click(object sender, EventArgs e)
        {
            this.Hide();    //Ẩn form hiện tại
            FormLoaiThucAn form = new FormLoaiThucAn();
            form.ShowDialog();  //Trả về form Loại Thức Ăn
        }

        //Sự kiện click BTThucAn
        private void BTThucAn_Click(object sender, EventArgs e)
        {
            this.Hide();    //Ẩn form hiện tại
            FormThucAn form = new FormThucAn();     //Tạo mới form Thức Ăn
            form.ShowDialog();      //Trả về form Thức Ăn
        }

        //Sự kiện click BTNhaCungCap
        private void BTNhaCungCap_Click(object sender, EventArgs e)
        {
            this.Hide();    //Ẩn form hiện tại
            FormNhaCungCap form = new FormNhaCungCap();     //Tạo mới form Nhà Cung Cấp
            form.ShowDialog();  //Trả về form Nhà Cung Cấp
        }
    }
}
