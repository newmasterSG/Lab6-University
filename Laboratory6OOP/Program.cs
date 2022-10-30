using System;
using System.Collections.Generic;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list2 = new MyList<int>();
            list2.Add(1);
            foreach (int item in list2)
                Console.WriteLine(item);
            int[] array = ClassForExtension.GetArray(list2);
            foreach (int item in array)
                Console.WriteLine(item);
        }
    }
}
