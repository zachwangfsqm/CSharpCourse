using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5_2
{
    class Program
    {
        public static int[] array1 = new int[10000];
        public static int[][] array2 = new int[100][];
        public static int n, max = 0, maxlength;
        public static void Max()//计算该杨辉三角里的项目数
        {
            for (int i = 0; i < n; i++)
            {
                max += i;
            }
        }
        public static void Cal()//分别计算一维数组和交错数组
        {
            int i, j, count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    array1[count] = 1;
                    if (j != 0 && j != i) array1[count] = array1[count - i - 1] + array1[count - i];
                    if (array1[count].ToString().Length > maxlength) maxlength = array1[count].ToString().Length;
                    count++;
                }
            }
            for (i = 0; i < n; i++)
            {
                array2[i] = new int[i + 1];
                for (j = 0; j <= i; j++)
                {
                    array2[i][j] = 1;
                    if (j != 0 && j != i) array2[i][j] = array2[i - 1][j - 1] + array2[i - 1][j];
                }
            }
            if (maxlength % 2 != 0) maxlength--;
        }
        public static void ArrayOut1(int[] array)//输出一维数组
        {
            int i, j, count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j < n - i; j++)
                {
                    for (int k = 0; k < (maxlength + 2) / 2; k++)
                    {
                        Console.Write(' ');
                    }
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write(array1[count].ToString().PadLeft(maxlength + 2, ' '));
                    count++;
                }
                Console.WriteLine();
            }
        }
        public static void ArrayOut2(int[][] array)//输出交错数组
        {
            int i, j, count = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j < n - i; j++)
                {
                    for (int k = 0; k < (maxlength + 2) / 2; k++)
                    {
                        Console.Write(' ');
                    }
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write(array2[i][j].ToString().PadLeft(maxlength + 2, ' '));
                    count++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数n：");
            n = Convert.ToInt32(Console.ReadLine());
            Max();
            Cal();
            Console.WriteLine("一维数组实现结果：");
            ArrayOut1(array1);
            Console.WriteLine();
            Console.WriteLine("交错数组实现结果：");
            ArrayOut2(array2);
            Console.ReadLine();
        }
    }
}
