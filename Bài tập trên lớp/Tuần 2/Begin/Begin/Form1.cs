using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Begin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Sự kiện Form load
        {
            label1.Text = "Dinh";
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            textBox1.Text = "Elite";
            
            textBox1.Width = 250;
            textBox1.Height = 50;

            textBox1.BackColor = Color.Blue;
            textBox1.ForeColor = Color.White;
          

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("You press enter key");
            }

            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("You press Caps Lock Key");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("You press enter key");
            }

            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("You press Caps Lock Key");
            }
        }

        private void click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Click here!";
          
        }
    }
}
