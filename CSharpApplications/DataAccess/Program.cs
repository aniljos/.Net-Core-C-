using System.Data.SqlClient;

namespace DataAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //InsertProduct(1, "Lenovo ThinkPad", 10000, "Busniess Laptop");
            //InsertProduct(2, "Samsung S23", 900, "Smart Phone");
            //InsertProduct(3, "Logitech USB Mouse", 50, "Mouse");
            //InsertProduct(4, "Micosoft Surface", 11000, "Busniess Tablet");

            UpdateProductPrice(1, 12000);
        }

        static void UpdateProductPrice(int id, double price)
        {

            try
            {
                string connectionString = "Server=localhost; Database=Training; User Id=sa; Password=sa";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string cmdTxt = "update product set price=@price where id=@id";
                    using(SqlCommand cmd = new SqlCommand(cmdTxt, connection))
                    {
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            Console.WriteLine("Record Updated");
                        }
                        else
                        {
                            Console.WriteLine("Record not Updated");
                        }

                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        static void InsertProduct(int id, string productName, double price, string desc)
        {

            try
            {


                //Connect to the DB
                string connectionString = "Server=localhost; Database=Training; User Id=sa; Password=sa"; // SQL Authentication
                                                                                                          //string connectionString = "Server=localhost; Database=Training; Intergrated Security=true"; // Windows Authentication
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //Execute the insert command
                    string cmdTxt = "insert into Product (id, name, price, description) values(@id, @name, @price, @description)";
                    using (SqlCommand cmd = new SqlCommand(cmdTxt, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", productName);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@description", desc);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            Console.WriteLine("Record inserted");
                        }
                        else
                        {
                            Console.WriteLine("Record not inserted");
                        }

                    }


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }
    }
}