using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS5_1
{
    class Winner
    {
        string[] programme;
        string[] name;
        string[] born;
        public Winner(int n)
        {
            programme = new string[n];
            name = new string[n];
            born = new string[n];
        }
        public string this[int ID]
        {
            set
            {
                string[] a = new string[3];
                a = value.Split(',');
                programme[ID] = a[0];
                name[ID] = a[1];
                born[2] = a[2];
            }
            get { return programme[ID] + "冠军：" + born[ID] + "选手" + name[ID]; }
        }
        public string this[string a]
        {
            get
            {
                string[] b = new string[2];
                b = a.Split(',');
                if (b[0] == "项目")
                {
                    int ID;
                    for (ID = 0; ID < programme.Length; ID++)
                        if (b[1] == programme[ID]) break;
                    return programme[ID] + "冠军：" + born[ID] + "选手" + name[ID];
                }
                else if (b[0] == "选手")
                {
                    int ID;
                    for (ID = 0; ID < name.Length; ID++)
                        if (b[1] == name[ID]) break;
                    return programme[ID] + "冠军：" + born[ID] + "选手" + name[ID];
                }
                else return "错误！";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Winner wins = new Winner(5);
            wins[0] = "男子100米,刘庆平,四川";
            wins[1] = "女子800米,王安新,北京";
            wins[2] = "男子跳高,胡颖,云南";
            wins[3] = "女子铅球,丁丰岚,辽宁";
            wins[4] = "男子10000米,李铭钧,上海";
            Console.WriteLine("{0}", wins[1]);
            Console.WriteLine("{0}", wins["项目,女子800米"]);
            Console.WriteLine("{0}", wins["选手,王安新"]);
            Console.Read();
        }
    }
}
