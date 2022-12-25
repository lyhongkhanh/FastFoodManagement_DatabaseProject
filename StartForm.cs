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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label_Login_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProfileForm frm = new AddProfileForm();
            frm.Show(this);
        }
    }
}
