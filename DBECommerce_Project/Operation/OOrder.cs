using DBECommerce_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Operation
{
    public class OOrder
    {

        SqlConnection connection = new SqlConnection(@"Data Source=RASHED;Initial Catalog=ECommerce;Integrated Security=True");
        public int addOrder(EOrder order)
        {
            connection.Open();
            int result;
            SqlCommand command = new SqlCommand("insert into orderList(orderID,orderSeller,orderCustomer,productName,productPrice) values('" + order.OrderID + "','" + order.OrderSeller + "','" + order.OrderCustomer + "','" + order.ProductName + "','" + order.ProductPrice + "')", connection);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = -1;
            }
            connection.Close();
            return result;
        }

        public SqlDataAdapter viewOrder(EUser user)
        {
            SqlDataAdapter sqlData;
            connection.Open();
            if (user.AccountType == "Seller")
                sqlData = new SqlDataAdapter("select * from orderList where orderSeller='" + user.Username + "'", connection);
            else
                sqlData = new SqlDataAdapter("select 8 from orderList where orderCustomer='" + user.Username + "'",connection);
            connection.Close();
            return sqlData;
        }
    }
}
