using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> keyValuePairs = new MyDictionary<int,string>();
            keyValuePairs.Add(1, "MyDictionary");
            foreach (var pair in keyValuePairs)
                Console.WriteLine($"{pair.Key} , {pair.Value}");
        }
    }
}
