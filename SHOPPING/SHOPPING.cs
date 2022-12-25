using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class SHOPPING
    {
        MY_DB mydb = new MY_DB();

       
        public bool add_Bill(int bid, int cusid, double total_price )
        {
            SqlCommand command = new SqlCommand("insert into Bill(Bill_ID, Total_Price, Sold_Date, Cus_ID)"+ "VALUES (@id, @total,  @date, @cusid)", mydb.getConnection);
           
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = bid;
            command.Parameters.Add("@total", SqlDbType.NVarChar).Value = total_price;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@cusid", SqlDbType.Int).Value = cusid;

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
        public bool update_Bill(double a, int bid)
        {
            SqlCommand command = new SqlCommand("update Bill set Total_Price = @total where Bill_ID = @bid", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.NVarChar).Value = bid;
            command.Parameters.Add("@total", SqlDbType.NVarChar).Value = a;

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
        public bool deleteBillDetail(int BillID, int DishID)
        {
            SqlCommand cmd = new SqlCommand("delete from Bill_Detail where Bill_ID = @bid and Dish_id=@did", mydb.getConnection);
            cmd.Parameters.Add("@bid", SqlDbType.Int).Value = BillID;
            cmd.Parameters.Add("@did", SqlDbType.Int).Value = DishID;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Total_Price(int bid)
        {
            SqlCommand cmd = new SqlCommand("select sum(Price) from Bill_Detail where Bill_ID=@bid group by Bill_ID", mydb.getConnection);
            cmd.Parameters.Add("@bid", SqlDbType.Int).Value =bid ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToDouble(table.Rows[0].ItemArray[0]);
        }
        public bool addDishIntoCart(int bid, int did, int num, double price, int cusid)
        {
            SqlCommand command = new SqlCommand("insert into Bill_Detail(Bill_ID, Dish_ID, Dish_Num, Price)" + "VALUES (@bid, @did,  @num, @price)", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.Int).Value =bid;
            command.Parameters.Add("@did", SqlDbType.Int).Value = did;
            command.Parameters.Add("@num", SqlDbType.Int).Value = num; 
            command.Parameters.Add("@price", SqlDbType.Float).Value = price;
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
        
        public bool Delivery (int bid, string addr, DateTime date)
        {
            SqlCommand command = new SqlCommand("insert into Delivery(Bill_ID, Cus_Address, Delivery_Date)" + "VALUES (@bid, @addr,  @date)", mydb.getConnection);
            command.Parameters.Add("@bid", SqlDbType.Int).Value = bid;
            command.Parameters.Add("@addr", SqlDbType.NVarChar).Value = addr;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
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
    }
}
