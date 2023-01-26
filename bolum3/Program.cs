// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string msg = " Hello there. My name is Akif Ersoy ";
Console.WriteLine(msg.Length);
Console.WriteLine(msg.ToLower());
Console.WriteLine(msg.ToUpper());
Console.WriteLine(msg.Trim());
Console.WriteLine(msg.TrimEnd());
Console.WriteLine(msg.TrimStart());
Console.WriteLine(msg.Split()[1]);
Console.WriteLine(msg[3]);
Console.WriteLine(msg.StartsWith("Hello"));
Console.WriteLine(msg.EndsWith("Hello"));
Console.WriteLine(msg.Contains("There"));
Console.WriteLine(msg.IndexOf("name"));
Console.WriteLine(msg.IndexOf('M'));
Console.WriteLine(msg.Substring(5));
Console.WriteLine(msg.Substring(5, 10));

int index = msg.IndexOf("My");
Console.WriteLine(msg.Substring(index));

Console.WriteLine(msg.Replace(" ","-"));
Console.WriteLine(msg.Replace(" ", "-").Replace(".", "").Replace("@", "").ToLower());
Console.WriteLine(msg.Insert(0,"..."));
Console.WriteLine(msg.Insert(msg.Length, "..."));
Console.WriteLine(msg.Remove(5,10));


