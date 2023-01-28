namespace bolum13;
class Program
{
    static void Main(string[] args)
    {
        var p = new Person("Ali","Yılmaz");
        var s = new Student("Murat", "Kara", 130);
        var t = new Teacher("Ayşe", "Aydın", "Müzik");

        p.Intro();
        s.Intro();
        t.Intro();
        
    }
}

class Person{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string Name, string Surname){
        this.Name = Name;
        this.Surname = Surname;
    }

    public virtual void Intro(){
        Console.WriteLine($"Person Ad Soyad : {this.Name} {this.Surname}");
    }
}

class Student : Person{

    public int StudentNumber { get; set; }
    public Student(string name, string surname, int StudentNumber):base(name, surname){
        this.StudentNumber = StudentNumber;
    }
    public override void Intro()
    {
        Console.WriteLine($"Öğrenci Ad Soyad Numara : {this.Name} {this.Surname} {this.StudentNumber}");
    }
}

class Teacher : Person {

    public string Branch { get; set; }

    public Teacher(string name, string surname, string Branch) : base(name, surname){
        this.Branch = Branch;
    }

    public override void Intro()
    {
        Console.WriteLine($"Öğretmen Ad Soyad Branş : {this.Name} {this.Surname} {this.Branch}");
    }
}
