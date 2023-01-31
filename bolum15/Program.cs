namespace bolum15;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();

        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(30);


        List<string> isimler = new List<string>();

        isimler.Add("Mehmet");
        isimler.Add("Akif");
        isimler.Add("Ersoy");


        List<Product> urunler1 = new List<Product>(){
            new Product(){Name="Samsung S5"},
            new Product(){Name="Samsung S6"},
            new Product(){Name="Samsung S7"},
            new Product(){Name="Samsung S8"}
        };

        List<Product> urunler2 = new List<Product>(){
            new Product(){Name="Iphone 6"},
            new Product(){Name="Iphone 7"},
            new Product(){Name="Iphone 8"},
            new Product(){Name="Iphone 10"}
        };

        urunler1.AddRange(urunler2);

        foreach (var item in urunler1)
        {
            Console.WriteLine(item.Name);
        }

        int urun_sayisi = urunler1.Count;

        Console.WriteLine(urun_sayisi);
    }
}

class Product{

    public string Name { get; set; }
}
