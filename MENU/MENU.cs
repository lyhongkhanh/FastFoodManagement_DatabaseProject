using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class MENU
    {
        MY_DB mydb = new MY_DB();
        public bool insertDish(int Id, string Name, double price, int Status)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Menu (Dish_ID, Dish_Name, Price, Dish_Status)" +
                "VALUES (@id, @name, @price, @status)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@status", SqlDbType.Int).Value = Status;

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

        public bool EditDish(int ID, string Name, double price, int Status)
        {
            SqlCommand command = new SqlCommand("Update Menu set Dish_Name=@name, price=@price, Dish_Status=@status where Dish_ID=@id ", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
            command.Parameters.Add("@status", SqlDbType.Int).Value = Status;

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
        public bool RemoveDish(int id)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Delete from Menu where Dish_ID=@id", mydb.getConnection);
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
        public bool checkDishName(string Name, int ID = 0)
        {
            SqlCommand cmd = new SqlCommand("Select * From Menu Where Dish_Name=@Name and Dish_ID<>@id", mydb.getConnection);
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public DataTable getAllDish()
        {
            SqlCommand cmd = new SqlCommand("select * from Menu", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getDishByID(int DishID)
        {
            SqlCommand cmd = new SqlCommand("Select * from Menu where Dish_ID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = DishID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
