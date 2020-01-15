using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Lab0201 : Form
    {
        public Lab0201()
        {
            InitializeComponent();
        }

        //Hàm sự kiện click cho nút cộng
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 + number2;
                txtAnswer.Text = result.ToString();
            }
            catch(Exception ex) //Exception: lỗi chung
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        //Hàm sự kiện click cho nút trừ
        private void Eliminate_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 - number2;
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex) //Exception: lỗi chung
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        //Hàm xử lý sự kiện click cho nút nhân
        private void Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 * number2;
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex) //Exception: lỗi chung
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        //Hàm xử lý sự kiện click cho nút chia
        private void Division_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(txtNumber1.Text);
                float number2 = float.Parse(txtNumber2.Text);
                float result = number1 / number2;
                txtAnswer.Text = result.ToString();
            }
            catch (Exception ex) //Exception: lỗi chung
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }
    }
}
