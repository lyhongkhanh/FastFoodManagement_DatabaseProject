using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class STAFF
    {
        MY_DB mydb = new MY_DB();
        public bool insertStaff(int id, string name, string phone, float salary, string type)
        {
            SqlCommand command = new SqlCommand("Add_Employee", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("ID", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@Staff_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@Salary", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@Type", SqlDbType.VarChar).Value = type;
           
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
        public bool checkStaffID(int studentID)
        {
            SqlCommand cmd = new SqlCommand("Select * From Staff Where id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
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
        public bool editStaff(int Id, string name,string phone, float salary, string type)
        {
            SqlCommand command = new SqlCommand("Update Staff set id= @id, Staff_Name =@name, Phone_Number=@phn, salary=@sal, Type=@type where id=@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sal", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
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
        public bool RemoveStaff(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from Staff where id=@id", mydb.getConnection);
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
        public DataTable getStaff(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllStaff()
        {
            SqlCommand cmd = new SqlCommand("select * from Staff", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
