using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.REVENUE
{
    class Bill
    {
        MY_DB mydb = new MY_DB();
        public bool checkDate(DateTime date)
        {
            SqlCommand cmd = new SqlCommand("Select * from Bill where Sold_Date=@date", mydb.getConnection);
            cmd.Parameters.AddWithValue("@date", date);
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
        public DataTable getRevenuebyDay(DateTime date)
        {
            SqlCommand cmd = new SqlCommand("Select * from Bill where Sold_Date=@date", mydb.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getRevenue()
        {
            SqlCommand cmd = new SqlCommand("Select * from Bill", mydb.getConnection);
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable Calculate_Total()
        {
            SqlCommand cmd = new SqlCommand("SELECT  SUM(Total_Price) as Total FROM Bill", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable Caculate_Revenue_Day(DateTime date)
        {
            SqlCommand command = new SqlCommand("Calculate_DateRevenue", mydb.getConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Sold_Date", SqlDbType.Date).Value = date;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
