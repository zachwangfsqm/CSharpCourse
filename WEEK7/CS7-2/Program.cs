/*
实验2：接口的实现
实验内容和要求：
    本实验通过两个接口来定义 MP3或者MP4播放器的功能，熟悉接口的设计，
    显式接口成员的实现，但是因为课程内容和实验规模的限制，
    方法中只能用文字来象征性地表明它们的功能。

    设计接口：
IRecordable，其中包含两个方法：
    void receive（string s）表示接受了文件 s；
    bool checked（string f）表示检查了文件 f的格式，返回布尔量，
    表示是不是可接受的格式；
    void save（string t）表示存储了文件s。
IPlayable，其中包含两个方法：
    void find（string u）表示找到了文件u；
    bool checked（string f）表示检查了文件 f的格式，返回布尔量，
    表示是不是可接受的格式；
    void play(string v)表示播放文件v。
设计类 MP3，它继承接口 IRecordable和 IPlayable，
其中方法 checked 要显式接口成员来实现，
IRecordable.checked 方法是用来检查输入文件的格式，
因为除了可播放的文件以外，其他可存储的文件都是合法的；
IPlayable.checked 方法检查文件是否可播放的多媒体文件。
编制完整的可演示结果的程序。 

    实验报告：
1）小结接口的实现、显式接口成员实现的要点；
2）小结调用显式接口成员的方式；
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS7_2
{
    interface IRecordable
    {
        void receive(string s);
        bool check(string f);
        void save(string t);
    }
    interface IPlayable
    {
        void find(string u);
        void play(string v);
        bool check(string f);
    }
    class MP3 : IRecordable, IPlayable
    {
        string[] mp3;
        int n;
        public MP3()
        {
            n = 0;
            mp3 = new string[3];
        }
        public void receive(string s)
        {
            Console.WriteLine("播放器接受了文件{0}.", s);
        }
        public bool check(string f)
        {
            f.Trim();
            if (f.EndsWith(".mp3") || f.EndsWith(".wmv") || f.EndsWith(".mp4"))
            { return true; }
            else { return false; }
        }
        public void find(string u)
        {
            bool f = false;
            for (int i = 0; i < n; i++)
                if (mp3[i] == u)
                {
                    Console.WriteLine("找到了{0}.", u);
                    f = true;
                }
            if (!f) Console.WriteLine("未找到{0}.", u);

        }
        public void save(string t)
        {
            if (n == mp3.Length) Console.WriteLine("已超过最大存储量，无法存储.");
            else
            {
                mp3[n++] = t;
                Console.WriteLine("已存储{0}", t);
            }
        }
        public void play(string v)
        {
            if (check(v)) Console.WriteLine("{0}文件符合播放要求，现在开始播放.", v);
            else Console.WriteLine("{0}文件不符合播放要求.", v);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MP3 m = new MP3();
            m.receive("01.mp3");//接受01.mp3文件
            if (m.check("01.mp3")) m.save("01.mp3");//检查文件格式，若符合，则存储
            m.receive("02.wmv");//接受02.wmv文件
            if (m.check("02.wmv")) m.save("02.wmv");//检查文件格式，若符合，则存储
            m.receive("03.mp4");//接受03.mp4文件
            if (m.check("03.mp4")) m.save("03.mp4");//检查文件格式，若符合，则存储
            m.receive("04.mp3");//接受04.mp3文件
            if (m.check("04.mp3")) m.save("04.mp3");//检查文件格式，若符合，则存储,已超过最大容量，所以未存储
            m.receive("05.mp5");//接受05.mp5文件
            if (m.check("05.mp5")) m.save("05.mp5");//检查文件格式，若符合，则存储，该例不符合
            Console.WriteLine();
            m.find("01.mp3");//找到
            m.find("04.mp3");//未找到
            m.find("05.mp5");//未找到
            m.play("05.mp5");//播放失败
            m.play("02.wmv");//播放成功
        }
    }
}
