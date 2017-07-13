/*
实验1：结构的优越性和局限性
实验内容和步骤：
1）分析下面的类定义：
    class Point
    {
        public int x, y;
        public Point(int i,int j)
        {   x = i;y = j; }
    }
2）将下面的类改为结构；
3）设计一个包含15个Point类的对象的数组；设计一个包含15个Point结构的对象的数组。
4）完成整个程序，输出上述两个数组。
实验报告：
    通过本实验可以了解结构对象数组的设计技术，本实验不能直接观察到应用结构的优越性和局限性，要求根据已有的知识进行思考和小结。
1）列出结构的特点；
2）讨论结构的应用价值和局限性；
3）讨论结构对象的数组和类对象的数组之间的差别（包括在存储量、访问方式、访问速度等方面差别）。
4）如果分别用结构对象数组和类对象数组作为某方法的参数，它们之间有什么差别和优缺点。
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS7_1
{
    class Point1
    {
        public int x, y;
        public Point1(int i, int j)
        {
            x = i; y = j;
        }
    }
    public struct Point2
    {
        public int x1, y1;
        public Point2(int i, int j)
        {
            x1 = i; y1 = j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point1[] a1 = new Point1[15];
            Point2[] a2 = new Point2[15];
            Console.WriteLine("\t\tPoint类：\tPoint结构：");
            for (int i = 0; i < 15; i++)
            {
                a1[i] = new Point1(i, i + 20);
                a2[i] = new Point2(i, i + 20);
                Console.WriteLine("第{0}个数组：\t{1} , {2}\t\t{3} , {4}", i + 1, a1[i].x, a1[i].y, a2[i].x1, a2[i].y1);
            }
        }
    }
}
