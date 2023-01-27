// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Aritmetik Operatörler

int a = 10;
int b = 20;
float val;

val = a + b;
val = a - b;
val = a * b;
val = (float)a/(float)b ;
val = a % b;
val = a++;
val = ++a;
val = a--;
val = --a;

Console.WriteLine("Value :"+val);

// Atama Operatörleri

int x=5, y=10, z=15;

x += 5;
x -= 10;
x *= 5;
x /= 5;
x %= 5;

val = (float)Math.Pow(x,y);
val = (float)Math.Sqrt(z);
val = Math.Abs(-10);
val = (float)Math.Round(10.4);
val = (float)Math.Round(10.6);

Console.WriteLine($"x : {x}, y : {y}, z: {z}");

// Karşılaştırma Operatörleri

int m=5, n=5, o=6, p=3;

var result = (m==n);
result = (o==p);

string username = "mehmetakif";
string password = "123456";

result = (username == "mhmters");
result = (password == "12345");

result = (m!=n);
result = (m>n);
result = (m<n);
result = (m>=n);
result = (m<=n);
string result1 = (m==n)?"m=n":"m!=n";

Console.WriteLine("Result : "+result);
Console.WriteLine("Result1 : "+result1);

// Mantıksal Operatörler

int k = 5;
var sonuc = (k>5) && (k<10);

var sonuc1 = (k>5) || (k<10);

var sonuc2 = !(sonuc1);

Console.WriteLine(sonuc);
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
