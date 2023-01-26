// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "fırat";
string surname = "dicle";
int age = 100;

string cumle1 = "Adı " + name + " soyadı " + surname + " olan yapının yaşı " + age + " dır.";
Console.WriteLine(cumle1);

string cumle2 = string.Format("Adı {0} soyadı {1} olan yapının yaşı {2} dır", name, surname, age);
Console.WriteLine(cumle2);

string cumle3 = $"Adı {name} soyadı {surname} olan yapının yaşı {age} dır.";
Console.WriteLine(cumle3);