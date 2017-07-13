using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b == true)
            {
                try
                {
                    Console.WriteLine("请输入一个整数：");
                    int x = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入不正确，请重新输入");
                }
                finally
                {
                    Console.WriteLine("继续输入（y/n）?");
                    string ch = Console.ReadLine();
                    if (ch == "N" || ch == "n")
                    {
                        goto leave;
                    }
                    else
                        goto here;
                    leave: b = false;
                    here:;
                }
            }
        }
    }
}
