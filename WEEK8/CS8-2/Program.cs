using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8_2
{
    class Program
    {
        public class Rain
        {
            private int rain_amount, time;
            public Rain() { }
            public Rain(int time)
            {
                this.time = time;
                rain_amount = time / 10 + 3;
            }
            public void say_amount()
            {
                Console.WriteLine("雨量为： " + rain_amount);
            }
            public void say_time()
            {
                Console.WriteLine("已经下雨{0}分钟了！", time);
            }
        }
        public class detail_rain
        {
            public delegate void Raining();
            public event Raining RainEvent;
            public void startRain()
            {
                if (RainEvent != null)
                {
                    RainEvent();
                }
            }
        }
        static void Main(string[] args)
        {
            Rain rain = new Rain(30);
            detail_rain dt_rain = new detail_rain();
            dt_rain.RainEvent += rain.say_amount;
            dt_rain.RainEvent += rain.say_time;
            dt_rain.startRain();
        }
    }
}
