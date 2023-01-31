namespace bolum18;
using System.Linq;
class Program
{

    static void pass_check(string password){
        if(password.Length<8 || password.Length>15){
            throw new Exception("parola uzunluğu 7-15 karakter uzunluğuna sahip olmalıdır.");
        }

        if(!password.Any(char.IsDigit)){
            throw new Exception("Parola en az bir rakam içermelidir.");
        }

        if(!password.Any(char.IsLetter)){
            throw new Exception("Parola en az bir harf içermelidir.");
        }

        if(!password.Any(char.IsUpper)){
            throw new Exception("Parola en az bir büyük harf içermelidir.");
        }
            
    }
    static void Main(string[] args)
    {

        var p = new Person();

        try{

            p.Name = "yazılımcı";

            Console.WriteLine("İsim : "+ p.Name);

        }

        catch(Exception e){

            Console.WriteLine(e.Message);

        }

        try{
            Console.Write("Bir parola oluşturunuz : ");
            string parola = Console.ReadLine();

            pass_check(parola);
            Console.WriteLine("Parola başarılı bir şekilde oluşturuldu.");
        }

        catch(Exception e){

            Console.WriteLine(e.Message);

        }
    }
}

class Person{
    string _name;

    public string Name{
        get{
            return _name;
        }

        set{
            if(value.Length>10){
                throw new Exception("İsim alanı için en fazla 10 karakter girebilirsiniz.");
            }
            _name = value;
        }
    }
}
