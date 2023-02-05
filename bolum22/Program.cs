namespace bolum22;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

class Product{
    public int ProductId { get; set; }  
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var product = GetAllProducts();

        foreach (var item in product)
        {
            Console.WriteLine($"name : {item.Name} price : {item.Price}");
        }
    }

    static List<Product> GetAllProducts(){

        List<Product> product = null;

        using(var baglan = GetConnection()){
            try{
                baglan.Open();

                string sql = "select * from products";

                MySqlCommand komut = new MySqlCommand(sql, baglan);

                MySqlDataReader reader = komut.ExecuteReader();

                product = new List<Product>();

                while(reader.Read()){
                    product.Add(new Product{
                        ProductId = int.Parse(reader["id"].ToString()),
                        Name = reader["product_name"].ToString(),
                        Price = double.Parse(reader["list_price"]?.ToString())
                    });
                }

                reader.Close();
            }

            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            finally{
                baglan.Close();
            }
        }

        return product;
    }

    static MySqlConnection GetConnection(){
        string connection = @"server=localhost; port=3306; database=northwind; user=root; password=mysql123;";
        return new MySqlConnection(connection);
    }
    
}
