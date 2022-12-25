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
    public partial class EditDishForm : Form
    {
        public EditDishForm()
        {
            InitializeComponent();
        }
        MENU menu = new MENU();
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string name = TextBoxDishName.Text;
            double price = Convert.ToDouble(TextBoxPrice.Text);
            int status = Convert.ToInt32(TextBoxStatus.Text);
            int id = Convert.ToInt32(TextBoxDishID.Text);
            if (!menu.checkDishName(name,id))
            {
                MessageBox.Show("This Dish Name Already Exist", "Edit Dish", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (menu.EditDish(id, name, price, status))
            {
                MessageBox.Show("Dish Updated", "Edit Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Dish Not Updated", "Edit Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxDishID.Text);
            DataTable table = menu.getDishByID(id);
            TextBoxDishName.Text =table.Rows[0].ItemArray[1].ToString();
            TextBoxPrice.Text = table.Rows[0].ItemArray[2].ToString();
            TextBoxStatus.Text = table.Rows[0].ItemArray[3].ToString();
        }
    }
}
