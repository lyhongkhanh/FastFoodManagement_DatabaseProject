using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.REVENUE;
using FastFood.CUSTOMER;

namespace FastFood
{
    public partial class MainAddminForm : Form
    {
        public MainAddminForm()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelMenuSubMenu.Visible = false;
            panelStaffSubMenu.Visible = false;
            panelCustomerSubMenu.Visible = false;
            panelRevenueSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMenuSubMenu.Visible == true) panelMenuSubMenu.Visible = false;
            if (panelStaffSubMenu.Visible == true) panelStaffSubMenu.Visible = false;
            if (panelCustomerSubMenu.Visible == true) panelCustomerSubMenu.Visible = false;
            if (panelRevenueSubMenu.Visible == true) panelRevenueSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        private void addDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void removeDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveDishForm frm = new RemoveDishForm();
            frm.Show(this);
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuList frm = new MenuList();
            frm.Show(this);
        }

        private void updateDishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDishForm frm = new EditDishForm();
            frm.Show(this);
        }

        private void changeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffForm frm = new AddStaffForm();
            frm.Show(this);
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffListForm frm = new StaffListForm();
            frm.Show(this);
        }

        private void removeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveUpdateStaffForm frm = new RemoveUpdateStaffForm();
            frm.Show(this);
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Cus frm = new List_Cus();
            frm.Show(this);
        }

        private void totalRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenue_Total frm = new Revenue_Total();
            frm.Show(this);
        }

        private void revenueByDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenue_ByDay rev = new Revenue_ByDay();
            rev.Show(this);
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Update_Cus frm = new Remove_Update_Cus();
            frm.Show(this);
        }

        private void menuToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuSubMenu);
        }

        private void btnAdd_dish_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddDishForm());
            hideSubMenu();
        }

        private void btnRemove_Dish_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RemoveDishForm());
            hideSubMenu();

        }

        private void btnUpdate_Dish_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new EditDishForm());
            hideSubMenu();
        }

        private void btnList_dish_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MenuList());
            hideSubMenu();

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaffSubMenu);

        }

        private void btnAdd_Staff_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new AddStaffForm());

            hideSubMenu();

        }

        private void btnRemoveEdit_Staff_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RemoveUpdateStaffForm());

            hideSubMenu();

        }

        private void btnList_staff_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new StaffListForm());

            hideSubMenu();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomerSubMenu);

        }

        private void btnRemoveEdit_Cus_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Remove_Update_Cus());
            hideSubMenu();

        }

        private void btnList_Cus_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new List_Cus());
            hideSubMenu();

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRevenueSubMenu);
        }

        private void btnTotal_Rev_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Revenue_Total());

            hideSubMenu();

        }

        private void btnByDay_Rev_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Revenue_ByDay());

            hideSubMenu();

        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
