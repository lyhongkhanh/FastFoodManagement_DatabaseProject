using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }
        SHOPPING sh = new SHOPPING();
        MY_DB mydb = new MY_DB();
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select max(Bill_ID) from Bill");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];

            int Bill_ID = Convert.ToInt32(dr[0].ToString());
            DateTime d = dateTimePicker1.Value;
            String addr = textBox1.Text;
      
            if (d < DateTime.Today)
            {
                MessageBox.Show("Delivery Date must be from today!");
            }
            else if (d > DateTime.Today.AddDays(3))
            {
                MessageBox.Show("Delivery Date must be in three days from today!");
            }
            else
            {
                sh.Delivery(Bill_ID, addr,d);
                MessageBox.Show("Successful");
                FinishForm frm = new FinishForm();
                frm.Show(this);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
