// See https://aka.ms/new-console-template for more information
// implicit casting (automatically) : smaller type to larger
// explicit casting (manually) : larger type to smaller

Console.WriteLine("1. Sayı: ");
string sayi1 = Console.ReadLine();

Console.WriteLine("2. Sayı: ");
string sayi2 = Console.ReadLine();

Console.WriteLine(sayi1 + sayi2);
Console.WriteLine($"Girilen sayıların string toplamı: {sayi1}{sayi2}");

Console.Write("Tekrar 1. Sayı: ");
int sayi3 = int.Parse(Console.ReadLine());

Console.Write("Tekrar 2. Sayı: ");
int sayi4 = int.Parse(Console.ReadLine());

int toplam = sayi3 + sayi4;

Console.Write($"Sayısal Toplam Sonucu: {toplam}");
