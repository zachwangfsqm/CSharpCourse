using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrInt = { { 1, 2 }, { 3, 4 } };
            for (int j = 0; j <= 1; j++)
                for (int k = 0; k <= 1; k++)
                    Console.WriteLine("arrInt[{0},{1}]={2}", j, k, arrInt[j, k]);
            foreach (int s in arrInt)
                Console.WriteLine(s);
        }
    }
}
