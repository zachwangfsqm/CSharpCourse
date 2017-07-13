using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            float f = 1.0f;
            if (a == b) Console.WriteLine(true);
            else Console.WriteLine(false);
            Console.WriteLine(Object.Equals(a, b));
            if (a == f) Console.WriteLine(true);
            else Console.WriteLine(false);
            Console.WriteLine(Object.Equals(a, f));
            object t1 = new object();
            object t2 = new object();
            if (t1 == t2) Console.WriteLine(true);
            else Console.WriteLine(false);
            Console.WriteLine(t1);
            Console.WriteLine(t1);
            Console.WriteLine(Object.Equals(t1, t2));
        }
    }
}
