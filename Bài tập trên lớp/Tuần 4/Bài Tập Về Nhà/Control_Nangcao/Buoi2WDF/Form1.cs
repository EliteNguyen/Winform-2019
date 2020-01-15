using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2WDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 5;
            textBox2.Text = numericUpDown1.Value.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "NumericUpDown";
            DataTable dataTable = new DataTable("People");
            dataTable.Columns.Add("First Name", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Last Name", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Occupation", System.Type.GetType("System.String"));
            dataTable.Columns.Add("Salary", System.Type.GetType("System.Int32"));
            //Add items to the table;
            dataTable.Rows.Add(new object[] { "Rad", "Stephens", "Nerds", 10000 });
            dataTable.Rows.Add(new object[] { "Sergio", "Aragones", "Cartoonist", 20000 });
            dataTable.Rows.Add(new object[] { "Terry", "Practer", "Author", 40000 });
            dataGridView1.DataSource = dataTable;
            //
            ListViewItem itm;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //them tieu de cho cot
            listView1.Columns.Add("Ten san pham", 100);
            listView1.Columns.Add("Gia", 70);
            listView1.Columns.Add("So luong", 70);
            //them item vao listview
            string[] arr = new string[4];
            arr[0] = "San pham 01";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
            //them item thu 2
            arr[0] = "San pham 02";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
            
            
           
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            string value ="";
            for(int i=0;i<comboBox1.Items.Count;++i)
            {
                value += comboBox1.GetItemText(comboBox1.Items[i]) + "\n";
            }
            MessageBox.Show(value);       
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string value = "";
            foreach(Object obj in listBox1.Items)
            {
                value += obj.ToString() + "\n"; 
            }
            MessageBox.Show(value);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string productName = null;
            string price = null;
            string quanity = null;
            if (listView1.SelectedItems.Count>0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quanity = listView1.SelectedItems[0].SubItems[2].Text;
                MessageBox.Show(productName + "," + price + "," + quanity);
            }
            else
            {
                MessageBox.Show("Hay chon 1 san pham");
            }
        }
    }
}
