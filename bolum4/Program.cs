// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] isimler = new string[5];
isimler[0] = "Mehmet";
isimler[1] = "Akif";
isimler[2] = "Ersoy";
isimler[3] = "Çınar";
isimler[4] = "Tuna";

Console.WriteLine(isimler[3]);

int[] numaralar = new int[5];
numaralar[0] = 101;
numaralar[1] = 102;
numaralar[2] = 103;
numaralar[3] = 104;
numaralar[4] = 105;

Console.WriteLine(numaralar[2]);

Console.WriteLine($"Öğrenci adı {isimler[3]} okul numarası {numaralar[1]} olan öğrenci.");

string[] yeni_isimler = {"Mehmet", "Akif", "Ersoy", "Çınar", "Tuna"};
int[] yeni_numaralar = {100, 101, 102, 103, 104};
