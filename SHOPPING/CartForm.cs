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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        int Bill_ID;
        private void CartForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select max(Bill_ID) from Bill");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];

            Bill_ID = Convert.ToInt32(dr[0].ToString()) ;

            SqlCommand command = new SqlCommand("select a.Dish_ID, b.Dish_Name, a.Dish_Num, a.Price from Bill_Detail a, Menu b where Bill_ID = @bid and a.Dish_ID = b.Dish_ID", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.Int).Value = Bill_ID;
            SqlDataAdapter adapter2 = new SqlDataAdapter(command);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dataGridView1.DataSource = table2;
            dataGridView1.Columns[0].HeaderText = "Dish ID";
            dataGridView1.Columns[1].HeaderText = "Dish Name";
            dataGridView1.Columns[2].HeaderText = "Number";
            dataGridView1.Columns[3].HeaderText = "Price";
            double a = sh.Total_Price(Bill_ID);
            lb_TotalPrice.Text = "TOTAL PRICE: " + Convert.ToString(a);
        }
        SHOPPING sh = new SHOPPING();
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int DishID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if ((MessageBox.Show("Are you sure want to delete this dish", "Remove Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (sh.deleteBillDetail(Bill_ID, DishID))
                    {
                        double a = sh.Total_Price(Bill_ID);
                        sh.update_Bill(a,Bill_ID);
                        lb_TotalPrice.Text = "TOTAL PRICE: "+Convert.ToString(a);
                        MessageBox.Show("Dish Deleted", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlCommand command = new SqlCommand("select a.Dish_ID, b.Dish_Name, a.Dish_Num, a.Price from Bill_Detail a, Menu b where Bill_ID = @bid and a.Dish_ID = b.Dish_ID", mydb.getConnection);
                        command.Parameters.Add("@bid", SqlDbType.Int).Value = Bill_ID;
                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        DataTable table2 = new DataTable();
                        adapter2.Fill(table2);
                        dataGridView1.DataSource = table2;
                    }
                    else
                    {
                        MessageBox.Show("Dish Not Deleted", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Choose one to remove", "Remove Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to use delivery service", "Delivery Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                DeliveryForm frm = new DeliveryForm();
                frm.Show(this);
            }
            else
            {
                FinishForm frm = new FinishForm();
                frm.Show(this);
            }
        }
    }
}
