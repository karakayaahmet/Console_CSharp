namespace bolum14;
using System.Collections;
class Program
{
    static void Main(string[] args){
        ArrayList arrayList = new ArrayList();
        arrayList.Add(10);
        arrayList.Add("10");
        arrayList.Add("abc");
        arrayList.Add(10.5);

        ArrayList arrayList1 = new ArrayList{10, "10", "abc", 10.5};

        arrayList.Insert(1,29);

        arrayList.InsertRange(1, arrayList1);

        arrayList.Remove(10);

        arrayList.RemoveAt(2);

        arrayList.RemoveRange(2,2);

        arrayList.Contains(10);

        foreach (var item in arrayList1)
        {
            Console.WriteLine(item);
        }

        ArrayList arrayList2 = new ArrayList(){1,25,6,36,45,34,72};

        foreach (var item in arrayList2)
        {
            Console.WriteLine(item);            
        }
        
        Console.WriteLine("************");

        arrayList2.Sort();

        foreach (var item in arrayList2)
        {
            Console.WriteLine(item);
        }
    }

}
