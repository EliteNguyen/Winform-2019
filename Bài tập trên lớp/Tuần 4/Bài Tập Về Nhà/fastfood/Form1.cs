using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_BAI1
{
    public partial class Form1 : Form
    {
        BanList data = new BanList();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add("FoodName");
            dataTable.Columns.Add("Quantity", typeof(int));
            gvData.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = cbTable.Text;
            Button btn = sender as Button;
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên bàn trước khi thao tác", "Chưa có bàn được chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTable.Focus();
                return;
            }
            if (cbTable.FindString(name) < 0) cbTable.Items.Add(name); 
            data[name].Add(btn.Text);
            gvData.DataSource = data[name].Data;
        }

        private void cbTable_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = cbTable.Text;
            gvData.DataSource = data[name].Data;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string name = cbTable.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên bàn trước khi thao tác", "Chưa có bàn được chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTable.Focus();
                return;
            }
            data[name] = null;
            cbTable.Items.Remove(cbTable.SelectedItem);
            cbTable.Text = "";
            gvData.DataSource = dataTable;
            if (cbTable.Items.Count > 0)
            {
                cbTable.SelectedIndex = 0;
                cbTable_SelectedValueChanged(sender, e);
            }
        }

        private void cbTable_TextChanged(object sender, EventArgs e)
        {
            string name = cbTable.Text;
           
            if (data.Find(name))
            {
                gvData.DataSource = data[name].Data;
            }
            else
            {
                gvData.DataSource = dataTable;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = cbTable.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên bàn trước khi thao tác", "Chưa có bàn được chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTable.Focus();
                return;
            }
            

            for (int i = 0; i < gvData.SelectedRows.Count; i++)
            {
                data[name].Remove(gvData.SelectedRows[i].Cells[0].Value.ToString());
            }
        }
    }
}
