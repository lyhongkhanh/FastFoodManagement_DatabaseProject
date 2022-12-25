using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class ShoppingForm : Form
    {
        public ShoppingForm()
        {
            InitializeComponent();
        }
        MENU menu = new MENU();
        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
       
        void showData(int index)
        {
        DataRow dr = menu.getAllDish().Rows[index];
        ListBoxMenu.SelectedIndex = index;
        textBoxID.Text = dr.ItemArray[0].ToString();
        textBoxName.Text = dr.ItemArray[1].ToString();
        textBoxPrice.Text = dr.ItemArray[2].ToString();
        textBoxStatus.Text = dr.ItemArray[3].ToString();
        byte[] pic = (byte[])dr.ItemArray[4];
        MemoryStream picture = new MemoryStream(pic);
        pictureBox.Image = Image.FromStream(picture);
        }
        SHOPPING sh = new SHOPPING();
        MY_DB mydb = new MY_DB();
        int check = 0;
        int Bill_ID;
        public double total_price = 1;
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select Max(Cus_id) from Customer", mydb.getConnection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            DataRow dr2 = table2.Rows[0];
            int cusid = Convert.ToInt32(dr2.ItemArray[0].ToString());
            double price = Convert.ToDouble(textBoxPrice.Text);
            int did = Convert.ToInt32(textBoxID.Text);
            int num = Convert.ToInt32(numericUpDownDishNumber.Value);
            if (num == 0)
            {
                MessageBox.Show("Number of Dish must be more than 0");
            }
            else
            {
                if (check == 0)
                {
                    SqlCommand cmd = new SqlCommand("Select max(Bill_ID) from Bill");
                    cmd.Connection = mydb.getConnection;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataRow dr = table.Rows[0];
                    Bill_ID = Convert.ToInt32(dr[0].ToString()) + 1;
                    if (sh.add_Bill(Bill_ID, cusid, total_price) == true)
                    {
                        sh.addDishIntoCart(Bill_ID, did, num, num * price, cusid);
                        double a = sh.Total_Price(Bill_ID);
                        sh.update_Bill(a, Bill_ID);
                        MessageBox.Show("Add To Your Cart!");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    check++;
                }
                else
                {

                    sh.addDishIntoCart(Bill_ID, did, num, num * price, cusid);
                    double a = sh.Total_Price(Bill_ID);
                    sh.update_Bill(a, Bill_ID);
                    MessageBox.Show("Add To Your Cart!");
                }

                pos = ListBoxMenu.SelectedIndex;
                showData(pos);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        int pos;
        void reloadListBoxData()
        {
            ListBoxMenu.DataSource = menu.getAllDish();
            ListBoxMenu.ValueMember = "Dish_ID";
            ListBoxMenu.DisplayMember = "DIsh_Name";
            ListBoxMenu.SelectedItem = null;

        }
        private void ListBoxMenu_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListBoxMenu.SelectedItem;
            pos = ListBoxMenu.SelectedIndex;
            showData(pos);
            
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            CartForm frm = new CartForm();
            frm.Show(this);
        }

        private void ListBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
