// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] isimler = {"Mehmet", "Akif", "Ersoy", "Çınar", "Tuna"};
int[] numaralar = {5,4,2,3,1};
isimler.SetValue("Ali", 0);
Console.WriteLine(isimler.GetValue(0));

Console.WriteLine(Array.IndexOf(isimler, "Ersoy"));
Console.WriteLine(isimler.Length);
Array.Sort(isimler);
Array.Sort(numaralar);
Console.WriteLine(isimler.GetValue(0));
Console.WriteLine(numaralar.GetValue(0));

Array.Reverse(isimler);
Console.WriteLine(isimler.GetValue(4));

Array.Reverse(numaralar);
Console.WriteLine(numaralar.GetValue(numaralar.Length-1));

Array.Clear(isimler, 0, 2);
Array.Clear(numaralar, 0, 2);

Console.WriteLine(isimler[^1]);

foreach(var isim in isimler){
    Console.WriteLine(isim);
}

foreach(var num in numaralar){
    Console.WriteLine(num);
}

var result = isimler[1..4];

foreach(var i in result){
    Console.WriteLine(i);
}

var result2 = numaralar[1..];

foreach(var i in result2){
    Console.WriteLine(i);
}

var result3 = isimler[..3];

foreach(var i in result3){
    Console.WriteLine(i);
}

string msg = "hello there";
Console.WriteLine(msg[0..5]);