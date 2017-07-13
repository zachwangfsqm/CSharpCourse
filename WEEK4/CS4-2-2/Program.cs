using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_2_2
{
    class Program
    {
        public static int num = 1;
        public static int[] luoshu = new int[9] { 0, 0, 0, 0, 5, 0, 0, 0, 0 };
        static void judge()
        {
            int i, count = 0;
            for (i = 0; i < 9; i++)
            {
                if (luoshu[i] > 0) count++;
                else break;
            }
            for (i = 1; i <= 9; i++)
            {
                int id = Array.IndexOf(luoshu, i);
                if (id != -1) count++;
                else break;
            }
            if (count == 18)
            {
                Console.WriteLine("第{0}组洛书排列如下：", num);
                for (i = 0; i < 9; i = i + 3)
                {
                    Console.WriteLine("{0}  {1}  {2}", luoshu[i], luoshu[i + 1], luoshu[i + 2]);
                }
                Console.WriteLine();
                num++;
            }
        }
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i < 10; i++)
            {
                if (i != 5)
                {
                    for (j = 1; j < 10; j++)
                    {
                        if (j != i)
                        {
                            luoshu[0] = i;
                            luoshu[1] = j;
                            luoshu[2] = 15 - i - j;
                            luoshu[4] = 5;
                            luoshu[6] = i + j - 5;
                            luoshu[7] = 10 - j;
                            luoshu[8] = 10 - i;
                            luoshu[3] = 20 - 2 * i - j;
                            luoshu[5] = 2 * i + j - 10;
                            judge();
                        }
                    }
                }
            }
        }
    }
}
