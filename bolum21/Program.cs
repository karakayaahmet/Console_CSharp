namespace bolum21;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        GetAllProducts();
    }

    static void GetAllProducts(){
        using(var connection = getMysqlConnection()){
            try{
                connection.Open();

                string sql = "select * from products";

                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while(reader.Read()){
                    Console.WriteLine($"name : {reader[3]} price : {reader[6]}");
                }

                reader.Close();

            }

            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            finally{
                connection.Close();
            }
        }
    }

    static MySqlConnection getMysqlConnection(){
        string connection = @"server=localhost; port=3306; database=northwind; user=root; password=mysql123;";
        return new MySqlConnection(connection);
    }
    
}
