namespace bolum19;
using System;
class Program
{
    static void Main(string[] args)
    {
        try{
            Console.Write("Kullanıcı adı : ");
            string username = Console.ReadLine();

            Console.Write("Şifre : ");
            string password = Console.ReadLine();

            Login(username, password);

            Console.WriteLine("Giriş Başarılı ;)");
        }

        catch(LoginException e){
            Console.WriteLine(e.Message);
        }
        
    }

    static void Login(string username, string password){
        if (username.Contains(" ")){
            throw new LoginException("Kullanıcı adı boşluk içeremez!");
        }

        if (password.Length<8){
            throw new LoginException("Şifre minimum 8 karakterden oluşmalıdır !");
        }
    }
}

class LoginException : Exception{

    public LoginException(string message):base(message){

    }
}
