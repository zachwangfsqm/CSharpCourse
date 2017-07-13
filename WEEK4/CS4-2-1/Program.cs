using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_2_1
{
    class Program
    {
        public static int count = 0;
        static void counti(int a)
        {
            int j;
            for (j = a; j % 5 == 0; j = j / 5) count++;
        }
        static void Main(string[] args)
        {
            int i;
            Console.Write("请输入一个正整数：");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++) counti(i);
            Console.WriteLine("{0}!的末尾有{1}个0。", num, count);
        }
    }
}
