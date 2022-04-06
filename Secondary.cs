using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQLcrud
{
    class Secondary
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-J3PUE9B;database=DcodeTech;integrated security=SSPI");

        public void insert()
        {
            try
            {
                Console.WriteLine("Enter productName");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter productDescription");
                string productDesc = Console.ReadLine();
                Console.WriteLine("Enter productValue");
                string productAmt = Console.ReadLine();

                string sql = "insert into Products(ProductName, ProductDescription, ProductValue) values ('" + productName + "', '" + productDesc + "', '" + productAmt + "')";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int status = cmd.ExecuteNonQuery();

                if (status > 0)
                {
                    Console.WriteLine("Successfully inserted");
                }
                else
                {
                    Console.WriteLine("Failed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void update()
        {
            try
            {
                Console.WriteLine("Enter old product name:");
                string oldName = Console.ReadLine();
                Console.WriteLine("Enter productName");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter productDescription");
                string productDesc = Console.ReadLine();
                Console.WriteLine("Enter productValue");
                string productAmt = Console.ReadLine();

                string sql = "update Products set ProductName='"+ productName +"', ProductDescription='"+ productDesc +"', ProductValue='"+ productAmt +"' where ProductName= '"+ oldName +"'";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int status = cmd.ExecuteNonQuery();

                if (status > 0)
                {
                    Console.WriteLine("Successfully updated");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void delete()
        {
            try
            {
                Console.WriteLine("Enter old product name:");
                string productName = Console.ReadLine();

                string sql = "delete from Products where ProductName='"+ productName +"'";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int status = cmd.ExecuteNonQuery();

                if (status > 0)
                {
                    Console.WriteLine("Successfully updated");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void select()
        {
            string sql = "select * from Products";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ID"] + " | " + sdr["ProductName"] + " | " + sdr["ProductDescription"] + " | " + sdr["ProductValue"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }  
            finally
            {
                con.Close();
            }

        }
    }
}
