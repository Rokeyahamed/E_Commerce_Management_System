using DBECommerce_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBECommerce_Project.Operation
{
    public class OUser
    {
        SqlConnection connection = new SqlConnection(@"Data Source=RASHED;Initial Catalog=ECommerce;Integrated Security=True");
        public EUser login(EUser user)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("select * from loginDatabase where username='" + user.Username + "'", connection);
            SqlDataReader sqlData = command.ExecuteReader();
            EUser userData = new EUser();
            try
            {
                if (sqlData.Read())
                {
                    userData.Username = sqlData[0].ToString();
                    userData.Password = sqlData[1].ToString();
                    userData.FirstName = sqlData[2].ToString();
                    userData.LastName = sqlData[3].ToString();
                    userData.DOB = sqlData[4].ToString();
                    userData.AccountType = sqlData[5].ToString();

                    return userData;

                }
                else
                {
                    Console.WriteLine("No Record");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            userData.Username = "INVALID";
            return userData;

        }
        public int signup(EUser user)
        {
            connection.Open();
            int result;
            SqlCommand command = new SqlCommand("insert into loginDatabase(username,password,FirstName,LastName,DateOfBirth,accountType) values('" + user.Username + "','" + user.Password + "','" + user.FirstName + "','" + user.LastName + "','" + user.DOB + "','" + user.AccountType + "')", connection);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                result = -1;
            }
            connection.Close();
            return result;
        }

        public SqlDataReader searchUser(String username)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from loginDatabase where username='"+ username+"'", connection);
            SqlDataReader sqlData = command.ExecuteReader();
            EUser user = new EUser();
            try
            {
                if (sqlData.Read())
                {
                    user.Username = sqlData[0].ToString();
                    user.Password = sqlData[1].ToString();
                    user.FirstName = sqlData[2].ToString();
                    user.LastName = sqlData[3].ToString();
                    user.DOB = sqlData[4].ToString();

                }
                else
                {
                    Console.WriteLine("No Record");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            

            connection.Close();
            return sqlData;
        }
        public int updatePass(EUser user)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update loginDatabase set loginDatabase.password='" + user.Password + "' where loginDatabase.username='" + user.Username + "'", connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;
        }
        public int deleteUser(EUser user)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from loginDatabase where loginDatabase.username='" + user.Username + "'", connection);
            int number = command.ExecuteNonQuery();
            connection.Close();
            return number;
        }

        public SqlDataAdapter ShowLog()
        {
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from loginDatabase", connection);
            connection.Close();
            return sqlData;
        }
    }
}
