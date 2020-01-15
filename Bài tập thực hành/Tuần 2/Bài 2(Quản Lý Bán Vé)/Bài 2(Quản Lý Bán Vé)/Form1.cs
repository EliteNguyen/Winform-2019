using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2_Quản_Lý_Bán_Vé_
{
    public partial class QuanLyBanVe : Form
    {
        public QuanLyBanVe()
        {
            InitializeComponent();
        }

        private void QuanLyBanVe_Load(object sender, EventArgs e)
        {
            ManAnh.ForeColor = Color.Orange;    //Chỉnh màu Màn Ảnh
            Ghe1.BackColor = Color.Blue;        //Chỉnh màu ghế 1
            Ghe2.BackColor = Color.Yellow;      //CHỉnh màu ghế 2
            Ghe7.BackColor = Color.Yellow;      //Chỉnh màu ghế 7
            Ghe9.BackColor = Color.Yellow;      //Chỉnh màu ghế 9
            Ghe11.BackColor = Color.Yellow;     //Chỉnh màu ghế 11
            Ghe12.BackColor = Color.Blue;       //Chình màu ghế 12
            Ghe13.BackColor = Color.Blue;       //Chỉnh màu ghế 13
            Ghe14.BackColor = Color.Blue;       //Chỉnh màu ghế 14

            for (int i=0;i<ViTriGhe.Controls.Count;i++)
            {
                if (ViTriGhe.Controls[i] is Button)     //Biến chứa các control con
                {
                    if (ViTriGhe.Controls[i].BackColor != Color.Blue && ViTriGhe.Controls[i].BackColor != Color.Yellow)
                    {
                        Button btn = (Button)ViTriGhe.Controls[i];
                        btn.BackColor = Color.White;
                    }
                }   
            }
        }
        
        //Điều chỉnh màu vị trí ghế 
        private void ViTriGhe_Enter(object sender, EventArgs e)
        {
            if(sender is Button)    //Sender phát sinh sự kiện cho hệ thống: nhấn cho control nào thì control đó là sender
            {
                Button btn = (Button)sender;        //Button được xem như là kiểu dữ liệu
                /* if(btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.Blue;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }
                MessageBox.Show("Bạn vừa nhấn nút " + btn.Text); */

                if(btn.BackColor == Color.White)    //Click vào ghế chưa chọn thành ghế đang chọn
                {
                    btn.BackColor = Color.Blue;
                }
                else if(btn.BackColor == Color.Blue)     //Click  lại vào ghế đang chọn chuyển về ghế chưa chọn
                    {
                        btn.BackColor = Color.White;
                    }
                    else if(btn.BackColor == Color.Yellow)
                         {
                               MessageBox.Show("Ghế đã được bán!");                    
                         }
            }


        }

        //Hàm xử lý sự kiện click cho nút chọn
        private void Chon_Click(object sender, EventArgs e)
        {
            int price = 0; //Khai báo biến giá tiền

            for(int i = 0; i < ViTriGhe.Controls.Count; i++)
            {
                if(ViTriGhe.Controls[i] is Button)
                {
                    Button btn = (Button)ViTriGhe.Controls[i];

                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;
                        btn.ForeColor = Color.Black;

                        if(btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5")
                        {
                            price = price + 5000;
                        }

                        else if (btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "10")
                        {
                            price = price + 6500;
                        }
                            
                            else if (btn.Text == "11" || btn.Text == "12" || btn.Text == "13" || btn.Text == "14" ||  btn.Text == "15")
                            {
                                price = price + 8000;
                            }
                    }
                }
                GiaTien.Text = price.ToString();        //Xuất giá tiền sau khi chọn các ghế
            }
        }

        //Hàm xử lý sự kiện click cho nút hủy bỏ
        private void HuyBo_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< ViTriGhe.Controls.Count; i++)
            {
                if(ViTriGhe.Controls[i] is Button)
                {
                    Button btn = (Button)ViTriGhe.Controls[i];

                    if(btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;                        
                    }
                }
            }
        }

        //Hàm xử lý sự kiện click cho nút kết thúc
        private void KetThuc_Click(object sender, EventArgs e)
        {
            Close();        //Thoát 
        }
    }
}
