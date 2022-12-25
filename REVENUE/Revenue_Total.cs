using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.REVENUE
{
    public partial class Revenue_Total : Form
    {
        public Revenue_Total()
        {
            InitializeComponent();
        }

        private void Revenue_Total_Load(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            dataGridView1.DataSource = bill.getRevenue();
            txtTotal.Text = bill.Calculate_Total().Rows[0].ItemArray[0].ToString();
        }
    }
}
