namespace bolum17;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("1. Sayı : ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayı : ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = sayi1 / sayi2;

            Console.WriteLine($"{sayi1} / {sayi2} = {sonuc}");

        }
        catch (Exception ex)
        {
            Console.WriteLine("Bir hata oluştu.");
            Console.WriteLine(ex.Message);
        } 

        finally{
            Console.WriteLine("Finally bloğu çalıştı.");
        }      
    }
}
