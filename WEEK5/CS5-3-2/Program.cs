using System;

namespace CS5_3_2
{
    interface IIs { float Ls(); }
    interface IHs { float Ms(); }
    class IH : IIs, IHs
    { float l, m; public float Ls() { return l; } public float Ms() { return m; } }
    class MainCls
    {
        public  static void Main()
        {
            IH ih = new IH();
            Console.WriteLine(ih.Ls());
        }
    }
}
