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
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            int id = Convert.ToInt32(DishID.Text);
            string name = DishName.Text;
            double hrs = Convert.ToDouble(Price.Text);
            int desc = Convert.ToInt32(Status.Text);
            if (name.Trim() == "")
            {
                MessageBox.Show("Add a dish name", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (menu.checkDishName(name))
            {
                if (menu.insertDish(id, name, hrs, desc))
                {
                    MessageBox.Show("New Dish Inserted", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dish Not Inserted", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Dish Name Already Exists", "Add Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

