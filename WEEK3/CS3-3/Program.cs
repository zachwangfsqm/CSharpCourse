using System;

namespace CS3_3
{
    public class Hanoi
    {
        static void Move(char getone, char putone)
        {
            Console.WriteLine(getone + "-->" + putone);
        }
        static void PlayHanoi(int n, char one, char two, char three)
        {
            if (n == 1) Move(one, three);
            else
            {
                PlayHanoi(n - 1, one, three, two);
                Move(one, three);
                PlayHanoi(n - 1, two, one, three);
            }
        }
        public static void Main()
        {
            int m;
            Console.WriteLine("请输入Hanoi盘的数量：");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m + "个Hanoi盘移动步骤如下：");
            PlayHanoi(m, 'A', 'B', 'C');
        }
    }
}
