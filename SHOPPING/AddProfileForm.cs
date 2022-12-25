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
    public partial class AddProfileForm : Form
    {
        public AddProfileForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
       int cusid; 
        public bool insert_Customer()
        {
            SqlCommand command = new SqlCommand("INSERT INTO Customer (Cus_ID, Cus_Name, Cus_Phone_Number, Cus_Address)" +
                "VALUES (@id, @n,  @phn, @adrs)", mydb.getConnection);
            SqlCommand cmd = new SqlCommand("Select max(Cus_ID) from Customer");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow dr = table.Rows[0];
            cusid = Convert.ToInt32(dr[0].ToString())+1;
            command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(dr[0].ToString()) + 1;
            command.Parameters.Add("@n", SqlDbType.VarChar).Value = textBoxName.Text;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = textBoxPhone.Text;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = textBoxAdress.Text;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;

            }
        }
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (verif()==true)
            {
                if (insert_Customer() == true)
                {
                    MessageBox.Show("Your id is: "+cusid, "Add Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShoppingForm frm = new ShoppingForm();
                    frm.Show(this);
                }           
                else
                {
                    MessageBox.Show("Error", "Add Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }
        bool verif()
        {
            if ((textBoxName.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "")
                   || (textBoxAdress.Text.Trim() == ""))
             
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
