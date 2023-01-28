namespace bolum12;
class Program
{
    static void Main(string[] args)
    {
        var std1 = new Student("Mehmet", 299);
        var std2 = new Student("Akif", 123);
        var std3 = new Student("Ersoy", 345);

        std1.DisplaySchoolDetails();
        std1.DisplayStudentDetails();
        std2.DisplayStudentDetails();
        std3.DisplayStudentDetails();

        Console.WriteLine("******************************************");

        string str = "şimdi hüzün dolu eski bir dans müziği çalıyordu.";
        Console.WriteLine("ifade : "+str);

        Console.WriteLine("*******************************************");

        var result = HelperMethods.karakterDuzelt(str);
        Console.WriteLine("Düzeltilmiş hali : "+result);
    }
}

class Student{
    public string Name { get; set; }
    public int StudentNumber { get; set; }

    public Student(string Name, int StudentNumber){
        this.Name = Name;
        this.StudentNumber = StudentNumber;
    }

    public static string School = "My School";

    public static string Address = "My School Address";

    public void DisplayStudentDetails(){
        Console.WriteLine($"Öğrenci adı : {this.Name}, Öğrenci Numarası : {this.StudentNumber}");
    }

    public void DisplaySchoolDetails(){
        Console.WriteLine($"Okulun Adı : {School}, Okulun Adresi : {Address}");
    }
}

static class HelperMethods{
    public static string karakterDuzelt(string str){
        return str.Replace(" ","-").Replace("ö","o").Replace("ü","u").Replace("ı","i").Replace("ç","c").Replace("ş","s").Replace("ğ","g");
    }
}