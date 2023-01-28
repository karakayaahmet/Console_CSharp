namespace bolum11;
class Program
{
    static void Main(string[] args)
    {
        var p = new Product();
        p.name = "Samsung";
        p.setprice(200);

        Console.WriteLine($"Ürün adı : {p.name}, fiyatı : {p.getprice()}");

        var p2 = new Product2();
        p2.name = "iphone";
        p2.price = -200;

        Console.WriteLine($"Ürün adı : {p2.name}, fiyatı : {p2.price}");
    }
}

class Product{
    public string name;
    private double price;

    public void setprice(double price){
        if(price<0){
            this.price = 0;
        }

        else{
            this.price = price;
        }
    }

    public double getprice(){
        return this.price;
    }
}

class Product2{
    private string _name;
    public string name{
        get{
            return this._name;
        }
        set{
            if(!string.IsNullOrEmpty(value)){
                Console.WriteLine("Name alanı boş geçilemez!");
            }
            else{
                this.name = name;
            }
        }
    }
    private double _price;

    public double price{
        get{
            return this._price;
        }
        set{
            if(value<0){
                this._price = 0;
            }

            else{
                this.price = price;
            }
        }
    }
}
