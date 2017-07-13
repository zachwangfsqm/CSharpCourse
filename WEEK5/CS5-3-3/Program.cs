using System;

namespace CS5_3_3
{
    interface ICountable
    { double Compute(double i, double j); }
    struct ball : ICountable
    {
        public double Radius; public double Weight;
        const double pi = 3.14;
        public double Compute(double i, double j)
        { return pi * i * i * i / j; }
    }
    class MainCls
    {
        public static void Main()
        {
            ball bl = new ball(); bl.Radius = 16;
            Console.WriteLine(bl.Radius);
            Console.WriteLine(bl.Compute(bl.Radius, bl.Weight + 1));
        }
    }
}
