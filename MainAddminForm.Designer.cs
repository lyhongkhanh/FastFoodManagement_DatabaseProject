namespace FastFood
{
    partial class MainAddminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSIdeMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelMenuSubMenu = new System.Windows.Forms.Panel();
            this.btnAdd_dish = new System.Windows.Forms.Button();
            this.btnRemove_Dish = new System.Windows.Forms.Button();
            this.btnUpdate_Dish = new System.Windows.Forms.Button();
            this.btnList_dish = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelStaffSubMenu = new System.Windows.Forms.Panel();
            this.btnList_staff = new System.Windows.Forms.Button();
            this.btnRemoveEdit_Staff = new System.Windows.Forms.Button();
            this.btnAdd_Staff = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.panelCustomerSubMenu = new System.Windows.Forms.Panel();
            this.btnList_Cus = new System.Windows.Forms.Button();
            this.btnRemoveEdit_Cus = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.panelRevenueSubMenu = new System.Windows.Forms.Panel();
            this.btnByDay_Rev = new System.Windows.Forms.Button();
            this.btnTotal_Rev = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSIdeMenu.SuspendLayout();
            this.panelMenuSubMenu.SuspendLayout();
            this.panelStaffSubMenu.SuspendLayout();
            this.panelCustomerSubMenu.SuspendLayout();
            this.panelRevenueSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSIdeMenu
            // 
            this.panelSIdeMenu.AutoScroll = true;
            this.panelSIdeMenu.BackColor = System.Drawing.Color.Tomato;
            this.panelSIdeMenu.Controls.Add(this.panelRevenueSubMenu);
            this.panelSIdeMenu.Controls.Add(this.btnRevenue);
            this.panelSIdeMenu.Controls.Add(this.panelCustomerSubMenu);
            this.panelSIdeMenu.Controls.Add(this.btnCustomer);
            this.panelSIdeMenu.Controls.Add(this.panelStaffSubMenu);
            this.panelSIdeMenu.Controls.Add(this.btnStaff);
            this.panelSIdeMenu.Controls.Add(this.panelMenuSubMenu);
            this.panelSIdeMenu.Controls.Add(this.btnMenu);
            this.panelSIdeMenu.Controls.Add(this.panelLogo);
            this.panelSIdeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSIdeMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSIdeMenu.ForeColor = System.Drawing.Color.LightSalmon;
            this.panelSIdeMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSIdeMenu.Name = "panelSIdeMenu";
            this.panelSIdeMenu.Size = new System.Drawing.Size(324, 953);
            this.panelSIdeMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(324, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(324, 90);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelMenuSubMenu
            // 
            this.panelMenuSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenuSubMenu.Controls.Add(this.btnList_dish);
            this.panelMenuSubMenu.Controls.Add(this.btnUpdate_Dish);
            this.panelMenuSubMenu.Controls.Add(this.btnRemove_Dish);
            this.panelMenuSubMenu.Controls.Add(this.btnAdd_dish);
            this.panelMenuSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuSubMenu.Location = new System.Drawing.Point(0, 190);
            this.panelMenuSubMenu.Name = "panelMenuSubMenu";
            this.panelMenuSubMenu.Size = new System.Drawing.Size(324, 165);
            this.panelMenuSubMenu.TabIndex = 3;
            // 
            // btnAdd_dish
            // 
            this.btnAdd_dish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd_dish.FlatAppearance.BorderSize = 0;
            this.btnAdd_dish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_dish.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_dish.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd_dish.Location = new System.Drawing.Point(0, 0);
            this.btnAdd_dish.Name = "btnAdd_dish";
            this.btnAdd_dish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdd_dish.Size = new System.Drawing.Size(324, 40);
            this.btnAdd_dish.TabIndex = 0;
            this.btnAdd_dish.Text = "Add Dish";
            this.btnAdd_dish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_dish.UseVisualStyleBackColor = true;
            this.btnAdd_dish.Click += new System.EventHandler(this.btnAdd_dish_Click);
            // 
            // btnRemove_Dish
            // 
            this.btnRemove_Dish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove_Dish.FlatAppearance.BorderSize = 0;
            this.btnRemove_Dish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove_Dish.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove_Dish.ForeColor = System.Drawing.Color.LightGray;
            this.btnRemove_Dish.Location = new System.Drawing.Point(0, 40);
            this.btnRemove_Dish.Name = "btnRemove_Dish";
            this.btnRemove_Dish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRemove_Dish.Size = new System.Drawing.Size(324, 40);
            this.btnRemove_Dish.TabIndex = 1;
            this.btnRemove_Dish.Text = "Remove Dish";
            this.btnRemove_Dish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove_Dish.UseVisualStyleBackColor = true;
            this.btnRemove_Dish.Click += new System.EventHandler(this.btnRemove_Dish_Click);
            // 
            // btnUpdate_Dish
            // 
            this.btnUpdate_Dish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate_Dish.FlatAppearance.BorderSize = 0;
            this.btnUpdate_Dish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_Dish.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Dish.ForeColor = System.Drawing.Color.LightGray;
            this.btnUpdate_Dish.Location = new System.Drawing.Point(0, 80);
            this.btnUpdate_Dish.Name = "btnUpdate_Dish";
            this.btnUpdate_Dish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUpdate_Dish.Size = new System.Drawing.Size(324, 40);
            this.btnUpdate_Dish.TabIndex = 2;
            this.btnUpdate_Dish.Text = "Update Dish";
            this.btnUpdate_Dish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_Dish.UseVisualStyleBackColor = true;
            this.btnUpdate_Dish.Click += new System.EventHandler(this.btnUpdate_Dish_Click);
            // 
            // btnList_dish
            // 
            this.btnList_dish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList_dish.FlatAppearance.BorderSize = 0;
            this.btnList_dish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_dish.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList_dish.ForeColor = System.Drawing.Color.LightGray;
            this.btnList_dish.Location = new System.Drawing.Point(0, 120);
            this.btnList_dish.Name = "btnList_dish";
            this.btnList_dish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnList_dish.Size = new System.Drawing.Size(324, 40);
            this.btnList_dish.TabIndex = 3;
            this.btnList_dish.Text = "List of dishes";
            this.btnList_dish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList_dish.UseVisualStyleBackColor = true;
            this.btnList_dish.Click += new System.EventHandler(this.btnList_dish_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Location = new System.Drawing.Point(0, 355);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(324, 90);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panelStaffSubMenu
            // 
            this.panelStaffSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStaffSubMenu.Controls.Add(this.btnList_staff);
            this.panelStaffSubMenu.Controls.Add(this.btnRemoveEdit_Staff);
            this.panelStaffSubMenu.Controls.Add(this.btnAdd_Staff);
            this.panelStaffSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffSubMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelStaffSubMenu.Location = new System.Drawing.Point(0, 445);
            this.panelStaffSubMenu.Name = "panelStaffSubMenu";
            this.panelStaffSubMenu.Size = new System.Drawing.Size(324, 129);
            this.panelStaffSubMenu.TabIndex = 5;
            // 
            // btnList_staff
            // 
            this.btnList_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList_staff.FlatAppearance.BorderSize = 0;
            this.btnList_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_staff.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList_staff.ForeColor = System.Drawing.Color.LightGray;
            this.btnList_staff.Location = new System.Drawing.Point(0, 80);
            this.btnList_staff.Name = "btnList_staff";
            this.btnList_staff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnList_staff.Size = new System.Drawing.Size(324, 40);
            this.btnList_staff.TabIndex = 2;
            this.btnList_staff.Text = "List of Staffs";
            this.btnList_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList_staff.UseVisualStyleBackColor = true;
            this.btnList_staff.Click += new System.EventHandler(this.btnList_staff_Click);
            // 
            // btnRemoveEdit_Staff
            // 
            this.btnRemoveEdit_Staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveEdit_Staff.FlatAppearance.BorderSize = 0;
            this.btnRemoveEdit_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEdit_Staff.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEdit_Staff.ForeColor = System.Drawing.Color.LightGray;
            this.btnRemoveEdit_Staff.Location = new System.Drawing.Point(0, 40);
            this.btnRemoveEdit_Staff.Name = "btnRemoveEdit_Staff";
            this.btnRemoveEdit_Staff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRemoveEdit_Staff.Size = new System.Drawing.Size(324, 40);
            this.btnRemoveEdit_Staff.TabIndex = 1;
            this.btnRemoveEdit_Staff.Text = "Remove/Edit Staff";
            this.btnRemoveEdit_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEdit_Staff.UseVisualStyleBackColor = true;
            this.btnRemoveEdit_Staff.Click += new System.EventHandler(this.btnRemoveEdit_Staff_Click);
            // 
            // btnAdd_Staff
            // 
            this.btnAdd_Staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd_Staff.FlatAppearance.BorderSize = 0;
            this.btnAdd_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Staff.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Staff.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdd_Staff.Location = new System.Drawing.Point(0, 0);
            this.btnAdd_Staff.Name = "btnAdd_Staff";
            this.btnAdd_Staff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdd_Staff.Size = new System.Drawing.Size(324, 40);
            this.btnAdd_Staff.TabIndex = 0;
            this.btnAdd_Staff.Text = "Add Staff";
            this.btnAdd_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd_Staff.UseVisualStyleBackColor = true;
            this.btnAdd_Staff.Click += new System.EventHandler(this.btnAdd_Staff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(0, 574);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(324, 90);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panelCustomerSubMenu
            // 
            this.panelCustomerSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCustomerSubMenu.Controls.Add(this.btnList_Cus);
            this.panelCustomerSubMenu.Controls.Add(this.btnRemoveEdit_Cus);
            this.panelCustomerSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerSubMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomerSubMenu.Location = new System.Drawing.Point(0, 664);
            this.panelCustomerSubMenu.Name = "panelCustomerSubMenu";
            this.panelCustomerSubMenu.Size = new System.Drawing.Size(324, 85);
            this.panelCustomerSubMenu.TabIndex = 7;
            // 
            // btnList_Cus
            // 
            this.btnList_Cus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList_Cus.FlatAppearance.BorderSize = 0;
            this.btnList_Cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList_Cus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList_Cus.ForeColor = System.Drawing.Color.LightGray;
            this.btnList_Cus.Location = new System.Drawing.Point(0, 40);
            this.btnList_Cus.Name = "btnList_Cus";
            this.btnList_Cus.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnList_Cus.Size = new System.Drawing.Size(324, 40);
            this.btnList_Cus.TabIndex = 1;
            this.btnList_Cus.Text = "List of Customers";
            this.btnList_Cus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList_Cus.UseVisualStyleBackColor = true;
            this.btnList_Cus.Click += new System.EventHandler(this.btnList_Cus_Click);
            // 
            // btnRemoveEdit_Cus
            // 
            this.btnRemoveEdit_Cus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveEdit_Cus.FlatAppearance.BorderSize = 0;
            this.btnRemoveEdit_Cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEdit_Cus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEdit_Cus.ForeColor = System.Drawing.Color.LightGray;
            this.btnRemoveEdit_Cus.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveEdit_Cus.Name = "btnRemoveEdit_Cus";
            this.btnRemoveEdit_Cus.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRemoveEdit_Cus.Size = new System.Drawing.Size(324, 40);
            this.btnRemoveEdit_Cus.TabIndex = 0;
            this.btnRemoveEdit_Cus.Text = "Remove/Edit Customer";
            this.btnRemoveEdit_Cus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEdit_Cus.UseVisualStyleBackColor = true;
            this.btnRemoveEdit_Cus.Click += new System.EventHandler(this.btnRemoveEdit_Cus_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.Black;
            this.btnRevenue.Location = new System.Drawing.Point(0, 749);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRevenue.Size = new System.Drawing.Size(324, 90);
            this.btnRevenue.TabIndex = 8;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // panelRevenueSubMenu
            // 
            this.panelRevenueSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRevenueSubMenu.Controls.Add(this.btnByDay_Rev);
            this.panelRevenueSubMenu.Controls.Add(this.btnTotal_Rev);
            this.panelRevenueSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRevenueSubMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRevenueSubMenu.Location = new System.Drawing.Point(0, 839);
            this.panelRevenueSubMenu.Name = "panelRevenueSubMenu";
            this.panelRevenueSubMenu.Size = new System.Drawing.Size(324, 85);
            this.panelRevenueSubMenu.TabIndex = 9;
            // 
            // btnByDay_Rev
            // 
            this.btnByDay_Rev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnByDay_Rev.FlatAppearance.BorderSize = 0;
            this.btnByDay_Rev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByDay_Rev.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByDay_Rev.ForeColor = System.Drawing.Color.LightGray;
            this.btnByDay_Rev.Location = new System.Drawing.Point(0, 40);
            this.btnByDay_Rev.Name = "btnByDay_Rev";
            this.btnByDay_Rev.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnByDay_Rev.Size = new System.Drawing.Size(324, 40);
            this.btnByDay_Rev.TabIndex = 1;
            this.btnByDay_Rev.Text = "Revenue By Day";
            this.btnByDay_Rev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByDay_Rev.UseVisualStyleBackColor = true;
            this.btnByDay_Rev.Click += new System.EventHandler(this.btnByDay_Rev_Click);
            // 
            // btnTotal_Rev
            // 
            this.btnTotal_Rev.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotal_Rev.FlatAppearance.BorderSize = 0;
            this.btnTotal_Rev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal_Rev.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal_Rev.ForeColor = System.Drawing.Color.LightGray;
            this.btnTotal_Rev.Location = new System.Drawing.Point(0, 0);
            this.btnTotal_Rev.Name = "btnTotal_Rev";
            this.btnTotal_Rev.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTotal_Rev.Size = new System.Drawing.Size(324, 40);
            this.btnTotal_Rev.TabIndex = 0;
            this.btnTotal_Rev.Text = "Total Revenue";
            this.btnTotal_Rev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal_Rev.UseVisualStyleBackColor = true;
            this.btnTotal_Rev.Click += new System.EventHandler(this.btnTotal_Rev_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChildForm.Location = new System.Drawing.Point(324, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1600, 953);
            this.panelChildForm.TabIndex = 1;
            // 
            // MainAddminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSIdeMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainAddminForm";
            this.Text = "MainForm";
            this.panelSIdeMenu.ResumeLayout(false);
            this.panelMenuSubMenu.ResumeLayout(false);
            this.panelStaffSubMenu.ResumeLayout(false);
            this.panelCustomerSubMenu.ResumeLayout(false);
            this.panelRevenueSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSIdeMenu;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panelMenuSubMenu;
        private System.Windows.Forms.Button btnList_dish;
        private System.Windows.Forms.Button btnUpdate_Dish;
        private System.Windows.Forms.Button btnRemove_Dish;
        private System.Windows.Forms.Button btnAdd_dish;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelRevenueSubMenu;
        private System.Windows.Forms.Button btnByDay_Rev;
        private System.Windows.Forms.Button btnTotal_Rev;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel panelCustomerSubMenu;
        private System.Windows.Forms.Button btnList_Cus;
        private System.Windows.Forms.Button btnRemoveEdit_Cus;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel panelStaffSubMenu;
        private System.Windows.Forms.Button btnList_staff;
        private System.Windows.Forms.Button btnRemoveEdit_Staff;
        private System.Windows.Forms.Button btnAdd_Staff;
        private System.Windows.Forms.Panel panelChildForm;
    }
}