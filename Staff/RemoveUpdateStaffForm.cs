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
    public partial class RemoveUpdateStaffForm : Form
    {
        public RemoveUpdateStaffForm()
        {
            InitializeComponent();
        }
        STAFF staff = new STAFF();
        private void btn_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand("Select * from Staff where ID= " + id);
            DataTable table = staff.getStaff(command);
            if (table.Rows.Count > 0)
            {
                TextBoxName.Text = table.Rows[0]["Staff_Name"].ToString();
                TextBoxPhone.Text = table.Rows[0]["Phone_Number"].ToString();
                if (table.Rows[0]["Type"].ToString().Trim() == "manager")
                {
                    RadioButton_Manager.Checked = true;
                }
                else
                {
                    RadioButton_Employee.Checked = true;
                }
                
              TextBoxSalary.Text= table.Rows[0]["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("not found", "Find Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxID.Text);
            float salary = float.Parse(TextBoxSalary.Text);
            string name = TextBoxName.Text;
            string phone = TextBoxPhone.Text;
            string type = "employee";
            if (RadioButton_Manager.Checked)
            {
                type = "manager";
            }
            if (verif())
                {
                    if (staff.editStaff(id, name, phone, salary, type))
                    {
                        MessageBox.Show("Edited!", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
        bool verif()
        {
            if ((TextBoxID.Text.Trim() == "") || (TextBoxName.Text.Trim() == "")
                   || (TextBoxSalary.Text.Trim() == "")
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
                if (MessageBox.Show("Are you sure you want to delete this staff?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (staff.RemoveStaff(int.Parse(TextBoxID.Text)))
                    {
                        MessageBox.Show("Removed");
                    }
                    else
                    {
                        MessageBox.Show("Not be deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

