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
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            STAFF staff = new STAFF();
            int id = Convert.ToInt32(TextBoxID.Text);
            float salary = float.Parse(TextBoxSalary.Text);
            string name = TextBoxName.Text;
            string phone = TextBoxPhone.Text;
            string type = "employee";
            if (staff.checkStaffID(id) == true)
            {
                if (RadioButton_Manager.Checked)
                {
                    type = "manager";
                }
                
                else if (verif())
                {
                    if (staff.insertStaff(id, name, phone, salary, type))
                    {
                        MessageBox.Show("New staff added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (staff.checkStaffID(id) == false)
            {
                MessageBox.Show("Staff ID is duplicated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
