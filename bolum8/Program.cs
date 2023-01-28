namespace bolum8;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad_Soyad = "Akif";
        ogrenci.Ogrenci_No = 199;
        ogrenci.Sube = "10A";

        Console.WriteLine($"Öğrenci Ad Soyad : {ogrenci.Ad_Soyad}, Öğrenci No : {ogrenci.Ogrenci_No}, Öğrenci Şube : {ogrenci.Sube}");

        Ogrenci ogr1 = new Ogrenci(){
            Ad_Soyad = "Ersoy",
            Ogrenci_No = 100,
            Sube = "11B"
        };

        Console.WriteLine($"Öğrenci Ad Soyad : {ogr1.Ad_Soyad}, Öğrenci No : {ogr1.Ogrenci_No}, Öğrenci Şube : {ogr1.Sube}");

        Ogrenci ogr2 = new Ogrenci(){
            Ad_Soyad = "Mehmet",
            Ogrenci_No = 200,
            Sube = "12A"
        };

        Console.WriteLine($"Öğrenci Ad Soyad : {ogr2.Ad_Soyad}, Öğrenci No : {ogr2.Ogrenci_No}, Öğrenci Şube : {ogr2.Sube}");

        Ogrenci[] ogrenciler = new Ogrenci[3];
        ogrenciler[0] = ogr1;
        ogrenciler[1] = ogr2;
        ogrenciler[2] = ogrenci;

        for (int i = 0;  i < ogrenciler.Length;  i++)
        {
            Console.WriteLine($"Öğrenci Ad Soyad : {ogrenciler[i].Ad_Soyad}, Öğrenci No : {ogrenciler[i].Ogrenci_No}, Öğrenci Şube : {ogrenciler[i].Sube}");
        }
    }
}

class Ogrenci{
    public int Ogrenci_No { get; set; }
    public string Ad_Soyad { get; set; }
    public string Sube { get; set; }

}
