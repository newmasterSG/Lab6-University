using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    internal class MyClass<T>
    {
        public static T FactoryMethod<T>() where T : new()
        {
            var type = new T();
            return type;
        }


    }
}
