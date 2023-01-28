namespace bolum9;

class Person{
    public string Name { get; set; }
    public int Year { get; set; }

    public string Intro(){
        return $"Kişi Adı : {this.Name}, yaşı : {2023-this.Year}";
    }

    public int CalculateAge(){
        return DateTime.Now.Year - this.Year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person{Name = "Mehmet", Year = 1985};
        var p2 = new Person{Name = "Akif", Year = 1993};
        var p3 = new Person{Name = "Ersoy", Year = 2000};

        var str1 = p1.Intro();
        var str2 = p2.Intro();
        var str3 = p3.Intro();

        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);
        Console.WriteLine(p1.CalculateAge());
        Console.WriteLine(p2.CalculateAge());
        Console.WriteLine(p3.CalculateAge());
    }
}
