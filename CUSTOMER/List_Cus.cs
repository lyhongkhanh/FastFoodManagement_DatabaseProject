using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood.CUSTOMER
{
    public partial class List_Cus : Form
    {
        Customer cus = new Customer();
        public List_Cus()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = cus.getAllCustomer();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
