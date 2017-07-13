using System;

namespace CS6_2_1
{
    class A
    {
        public int i;
        public A(int j)
        {
            i = j;
        }
    }
    class B : A
    {
        public B(int j) : base(j)     //修改位置
        {
            i = j;
        }
    }
    class T
    {
        public static void Main()
        {
            B b = new B(10);
            Console.WriteLine("B's i= " + b.i);
        }
    }
}

