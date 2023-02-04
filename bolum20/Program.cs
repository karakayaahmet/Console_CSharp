namespace bolum20;
using System;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GetMySqlConnection();
    }

    static void GetMySqlConnection()
    {

        string connectionString = @"server=localhost; port=3306; database=northwind; user=root; password=mysql123;";

        using (var connection = new MySqlConnection(connectionString)){

            try{
                connection.Open();
                Console.WriteLine("Bağlantı Sağlandı.");
            }

            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            finally{
                connection.Close();
            }
            
        }

    }
}
