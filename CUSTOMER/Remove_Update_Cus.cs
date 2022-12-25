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

namespace FastFood.CUSTOMER
{
    public partial class Remove_Update_Cus : Form
    {
        public Remove_Update_Cus()
        {
            InitializeComponent();
        }
        Customer cus = new Customer();

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("Select * from Customer where Cus_ID= " + id);
            DataTable table = cus.getCustomer(command);
            if (table.Rows.Count > 0)
            {
                TextBoxName.Text = table.Rows[0]["Cus_Name"].ToString();
                TextBoxPhone.Text = table.Rows[0]["Cus_Phone_Number"].ToString();
                TextBoxAddress.Text = table.Rows[0]["Cus_Address"].ToString();
                
            }
            else
            {
                MessageBox.Show("not found", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(TextBoxID.Text);
            string name = TextBoxName.Text;
            string phone = TextBoxPhone.Text;
            string address = TextBoxAddress.Text;

            if (verif())
            {
                if (cus.editCus(id, name, phone, address))
                {
                    MessageBox.Show("Edited!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((TextBoxID.Text.Trim() == "") || (TextBoxName.Text.Trim() == "")
                   || (TextBoxAddress.Text.Trim() == "")
                   || (TextBoxPhone.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this Custo?", "Delete customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cus.RemoveCus(int.Parse(TextBoxID.Text)))
                    {
                        MessageBox.Show("Removed");
                    }
                    else
                    {
                        MessageBox.Show("Not be deleted", "Delete customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
