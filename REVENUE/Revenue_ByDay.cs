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
    public partial class Revenue_ByDay : Form
    {
        public Revenue_ByDay()
        {
            InitializeComponent();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bool run = false;
            if (bill.checkDate(date.Value) == true)
            {
                dataGridView1.DataSource = bill.getRevenuebyDay(date.Value);
                txtRevenue.Text = bill.Caculate_Revenue_Day(date.Value).Rows[0].ItemArray[0].ToString();

            }
            else MessageBox.Show("KHONG TIM THAY NGAY!");
        }
    }
}
