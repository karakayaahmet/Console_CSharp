namespace bolum10;
class Program
{
    static void Main(string[] args)
    {

      var islem = new Islem();
      Console.WriteLine(islem.Toplam(12,2,3,5));
      Console.WriteLine(islem.Toplam(342,213));
      Console.WriteLine(islem.carp(12,2,3));
    }
}

class Islem{

    public int Toplam(params int[] sayilar){
        var toplam = 0;
        foreach(var sayi in sayilar){
            toplam += sayi;
        }

        return toplam;
    }

    public int carp(params int[] numbers){
        var carpma = 1;
        foreach(var x in numbers){
            carpma *= x;
        }
        return carpma;
    }
}
