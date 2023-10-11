using DBECommerce_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Operation
{
    public class OProduct
    {
        SqlConnection connection = new SqlConnection(@"Data Source=RASHED;Initial Catalog=ECommerce;Integrated Security=True");
        public int addProduct(EProduct product)
        {
            connection.Open();
            int result;
            SqlCommand command = new SqlCommand("insert into productList(productID,productSeller,productPrice,productName,productStock) values('" + product.ProductID + "','" + product.ProductSeller + "','" + product.ProductPrice + "','" + product.ProductName + "','" + product.ProductStock + "')", connection);
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

        public int editProduct(EProduct product)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update productList set productName = '" + product.ProductName + "', productPrice='" + product.ProductPrice + "', productStock= '" + product.ProductStock + "' where productList.productID='" + product.ProductID +"'", connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;
        }

        public int deleteProduct(String id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from productList where productList.productID='" + id + "'", connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;
        }

        public SqlDataAdapter getList()
        {
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from productList", connection);
            connection.Close();
            return sqlData;
        }
    }
}
