using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class MenuList : Form
    {
        public MenuList()
        {
            InitializeComponent();
        }
        MENU menu = new MENU();
        private void MenuList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = menu.getAllDish();
            dataGridView1.Columns[0].HeaderText = "Dish ID";
            dataGridView1.Columns[1].HeaderText = "Dish Name";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Dish Status";
        }
    }
}
