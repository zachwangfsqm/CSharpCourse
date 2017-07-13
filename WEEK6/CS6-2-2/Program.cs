using System;

namespace CS6_2_2
{
    class A
    {
        int i;
        protected string s;
        public char c;
        public A(char d)
        {
            c = d;
        }
        public string this[int index]      //修改位置1
        {
            get
            {
                return s;
            }
        }
    }
    class B : A
    {
        int i;
        string s;
        public char ch;
        public B(int j, string t, char d) : base(d)    //修改位置2
        {
            i = j;
            s = t;
            ch = d;
        }
    }
    class T
    {
        public static void Main()
        {
            A a = new A('a');
            B b = new B(11, "Here!", 'f');
            Console.WriteLine(a.c + "\t" + a[0]);   //修改位置3
        }
    }
}
