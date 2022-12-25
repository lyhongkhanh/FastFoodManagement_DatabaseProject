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
    public partial class StaffListForm : Form
    {
        public StaffListForm()
        {
            InitializeComponent();
        }
        STAFF staff = new STAFF();
        private void StaffListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staff.getAllStaff();
            dataGridView1.Columns[0].HeaderText = "Staff ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Phone Number";
            dataGridView1.Columns[3].HeaderText = "Salary";
            dataGridView1.Columns[3].HeaderText = "Type";
        }
    }
}
