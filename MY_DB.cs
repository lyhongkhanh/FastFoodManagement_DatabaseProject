using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class MY_DB
    {
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=FASTFOOD_RESTAURANT_SYSTEM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection("Data Source=VANH;Initial Catalog=FASTFOOD_RESTAURANT_SYSTEM;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        public void openConnection()
        {
            if ((con.State==System.Data.ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if ((con.State==System.Data.ConnectionState.Open))
            {
                con.Close();
            }
         }
    }
}
