using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ListBox1.SelectedItem.ToString());
            string value = "";

            foreach(Object obj in listBox1.SelectedItems) //Muốn show hết thì listBox1.Items
            {
                value += obj.ToString() + "\n";
            }
            MessageBox.Show(value);

            
        }
    }
}
