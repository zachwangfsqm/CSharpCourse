using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 1;
            string[][] strJaggedArray = new string[2][];
            string[] strArray = new string[49];
            strJaggedArray[0] = new string[7];
            strJaggedArray[1] = new string[7];
            Console.WriteLine("Input seven words:");
            for (i = 0; i < 7; i++)
                strJaggedArray[0][i] = Console.ReadLine();
            Console.WriteLine("Input next seven words:");
            for (i = 0; i < 7; i++)
                strJaggedArray[1][i] = Console.ReadLine();
            Console.WriteLine();
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    strArray[i * 7 + j] = strJaggedArray[0][i] + "&" + strJaggedArray[1][j];
                    Console.Write(strArray[i * 7 + j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (string s in strArray)
            {
                if (count % 7 == 1)
                    Console.WriteLine();
                Console.Write(s + "  ");
                count++;
            }
            Console.WriteLine();
        }
    }
}
