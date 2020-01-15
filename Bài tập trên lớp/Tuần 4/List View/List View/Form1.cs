using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_View
{
    public partial class Form1 : Form
    {
        
        private void button1_Click(object sender, EventArgs e)
        {
            String productName = null;
            String price = null;
            String quantity = null;

            if(listView1.SelectedItems.Count >0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quantity = listView1.SelectedItems[0].SubItems[2].Text;

                MessageBox.Show(productName + "," + price + "," + quantity);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Thêm tiêu đề cho cột
            listView1.Columns.Add("Tên sản phẩm", 100);
            listView1.Columns.Add("Giá", 70);
            listView1.Columns.Add("Số lượng", 70);

            //Thêm Item vào listview
            String[] arr = new string[4];
            ListViewItem itm;

            //Thêm Item đầu tiên
            arr[0] = "Sản phẩm 1";
            arr[1] = "100";
            arr[2] = "10";

            //Thêm Item thứ 2
            arr[0] = "Sản phẩm 2";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }
    }
}
