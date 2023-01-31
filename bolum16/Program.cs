namespace bolum16;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> plakalar = new Dictionary<int, string>();

        plakalar.Add(23, "Elazığ");
        plakalar.Add(06, "Ankara");
        plakalar.Add(34, "İstanbul");
        plakalar.Add(35, "İzmir");

        foreach (var item in plakalar)
        {
            Console.WriteLine($"Plaka {item.Key} {item.Value}");
        }

        for (int i = 0; i < plakalar.Count; i++)
        {
            Console.WriteLine($"Plaka {plakalar.Keys.ElementAt(i)} {plakalar.Values.ElementAt(i)}");
        }

        Console.WriteLine("*****************************");

        Console.WriteLine(plakalar.ContainsKey(34));
    }
}
