using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            MessageBox.Show(a);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "";
            for(int i = 0; i < comboBox2.Items.Count; i++)
            {
                value += comboBox2.GetItemText(comboBox2.Items[i]) + "\n";
                
            }
            MessageBox.Show(value);
        }
    }
}
