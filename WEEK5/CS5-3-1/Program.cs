using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5_3_1
{
    public struct Trial
    {
        public int x;
        public string y;
        //public Trial() { }    //每个struct均已有一个将对象初始化为零的默认构造函数，因此，可以为结构创建的构造函数必须带有一个或多个参数。
        public Trial(int p1,string p2)
        { x = p1; y = p2; }
    }
    class MainCls
    {
        static void Main(string[] args)
        {
            Trial myTrial = new Trial();
            Trial yourTrial = new Trial(10, "Oh, I see.");
            Trial hisTrial;
            hisTrial.x = 88;
            hisTrial.y = "";
            Console.WriteLine("x = {0}, y = {1}", myTrial.x, yourTrial.y);
            Console.WriteLine(hisTrial.x + "\t" + hisTrial.y);
        }
    }
}
