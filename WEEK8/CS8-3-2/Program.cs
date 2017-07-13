using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8_3_2
{
    public class MyCSException : ApplicationException
    {
        public MyCSException() { }
        public MyCSException(string messageStr) : base(messageStr) { }
        public MyCSException(string messageStr, Exception inner) : base(messageStr) { }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入五个整数：");
            int count = 0;
            int error = 0;
            int[] a = new int[5];
            string[] b = new string[10];
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    b[count] = Console.ReadLine();
                    a[i] = int.Parse(b[count]);
                    if (a[i] == 100)
                        throw new MyCSException("输入100", new OverflowException());
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入不正确，请重新输入");
                    i--;
                    error++;
                    if (error >= 5)
                    {
                        throw new ArgumentException("错误的输入次数超过限制，您被怀疑为故意捣乱，我们有权把您踢出本系统！");

                    }
                    continue;
                }
                finally
                {
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
                Console.WriteLine("第{0}个输入为：{1}", i, b[i]);
            Console.WriteLine();
            Console.WriteLine("其中不合法的输入有{0}个", count - 5);
        }
    }
}
