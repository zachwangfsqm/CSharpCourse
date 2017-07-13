/*
实验3：程序分析及改错
以下程序语法上是否正确？如果是正确的，那么输出是什么？如果有错误，是什么错误？请改正。
*/
//using System;
//abstract class A
//{
//    int i;
//    abstract public void Print(string ){ };
//}
//class B : A
//{
//    int i; protected string s; public char ch;
//    public B(int j, string t, char d)
//    { i = j; s = t; ch = d; }
//    public new void Print(string w)
//    { Console.WriteLine(w); }
//}
//class T
//{
//    public static void Main()
//    { B b = new B(11, "Here!", 'f');    b.Print(b.ch); }
//}

using System;

namespace CS7_3
{
    abstract class A
    {
        int i;
        public void plll(int a)
        {

        }
        abstract public void Print(string w);
    }
    class B : A
    {
        int i; protected string s; public char ch;
        public B(int j, string t, char d)
        { i = j; s = t; ch = d; }
        public override void Print(string w)
        { Console.WriteLine(w); }
    }
    class T
    {
        public static void Main()
        { B b = new B(11, "Here!", 'f'); b.Print(Convert.ToString(b.ch)); }
    }
}
