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
    public partial class RemoveDishForm : Form
    {
        public RemoveDishForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            try
            {
                int id = Convert.ToInt32(TextBoxDishID.Text);
                if ((MessageBox.Show("Are you sure want to delete this dish", "Remove Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (menu.RemoveDish(id))
                    {
                        MessageBox.Show("Dish Deleted", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dish Not Deleted", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter valid numeric ID", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

