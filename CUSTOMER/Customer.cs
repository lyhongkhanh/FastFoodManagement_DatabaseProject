using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.CUSTOMER
{
    class Customer
    {
        MY_DB mydb = new MY_DB();
        //public bool insertCustomer(int id, string name, string phone,  string address)
        //{
        //    //SqlCommand command = new SqlCommand("Add_Employee", mydb.getConnection);
        //    //command.CommandType = CommandType.StoredProcedure;
        //    //command.Parameters.Add("ID", SqlDbType.NVarChar).Value = id;
        //    //command.Parameters.Add("@Cus_Name", SqlDbType.NVarChar).Value = name;
        //    //command.Parameters.Add("@Cus_Phone_Number", SqlDbType.VarChar).Value = phone;
        //    //command.Parameters.Add("@Cus_Address", SqlDbType.VarChar).Value = address;

        //    //mydb.openConnection();
        //    //if ((command.ExecuteNonQuery() == 1))
        //    //{
        //    //    mydb.closeConnection();
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    mydb.closeConnection();
        //    //    return false;

        //    //}
        //}
        public bool checkCusID(int ID)
        {
            SqlCommand cmd = new SqlCommand("Select * From Customer Where Cus_ID=@id", mydb.getConnection);
            cmd.Parameters.AddWithValue("@id", ID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool editCus(int Id, string name, string phone,  string address)
        {
            SqlCommand command = new SqlCommand("Update Customer set Cus_ID= @id, Cus_Name=@name, Cus_Phone_Number=@phone,  Cus_Address=@address where Cus_ID=@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
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
        public bool RemoveCus(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from Customer where Cus_ID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            if ((cmd.ExecuteNonQuery() == 1))
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
        public DataTable getCustomer(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllCustomer()
        {
            SqlCommand cmd = new SqlCommand("select * from Customer", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
