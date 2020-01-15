using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Make the Data Table object
            DataTable dt = new DataTable("People");

            //Add columns to the Database
            dt.Columns.Add("First name");

        }
    }
}
