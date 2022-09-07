using System.Diagnostics;
using System;

namespace cs_0907_1
{
    internal class MyClass
    {
        public MyClass()
        {
        }

        internal void print(string v)
        {
            string message = $"DBG:{v}";

            Console.WriteLine(v);
            Debug.WriteLine(message);
        }
    }
}