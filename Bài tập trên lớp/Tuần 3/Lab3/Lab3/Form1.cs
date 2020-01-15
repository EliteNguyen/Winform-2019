using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Hàm xử lý sự kiện click nút cộng
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int Tong = n + m;
            textBox3.Text = Tong.ToString();
        }

        //Hàm  xử lý sự kiện click nút trừ
        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int Tru = n - m;
            textBox3.Text = Tru.ToString();
        }

        //Hàm  xử lý sự kiện click nút nhân
        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int Nhan = n*m;
            textBox3.Text = Nhan.ToString();
        }

        //Hàm xử lý sự kiện click nút chia 
        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int Chia = n / m;
            textBox3.Text = Chia.ToString();
        }

        //Hàm xử lý sự kiện click nút xóa
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //Hàm xử lý sự kiện click nút thoát
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
