using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MyList
{
    internal static class ClassForExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.ToArray();
        }
    }
}
