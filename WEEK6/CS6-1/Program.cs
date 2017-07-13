using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6_1
{
    public abstract class Account   //抽象类Account
    {
        private string id = "";
        private string name = "";
        private string money = "";
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Money
        {
            get { return money; }
            set { money = value; }
        }
        public abstract void ShowInfo();                //检查账户余额
        public abstract void AddMoney(int addmoney);    //向账户中加钱
        public abstract void GetMoney(int getmoney);    //从账户中取钱
        public abstract void services();                //账户可选业务
    }
    public class CheckingAccount : Account              //活期账户继承账户抽象类
    {
        public CheckingAccount(string id, string name, string money)
        {
            ID = id;
            Name = name;
            Money = money;
        }
        public void GetCheckbook()                      //订购支票簿
        {
            if (Int32.Parse(Money) < 1000) Console.WriteLine("您的账户余额不足1000元，无法订购支票簿！");
            else Console.WriteLine("您的账户余额满足条件，可以订购支票簿！");
        }
        public override void ShowInfo()                 //检查账户余额
        {
            Console.WriteLine("账户号：\t" + ID + "\n储户名：\t" + Name + "\n账户余额：\t" + Money + "元");
        }
        public override void AddMoney(int addmoney)     //往账户中加钱
        {
            if (addmoney > 0)
            {
                Money = Convert.ToString(Int32.Parse(Money) + addmoney);
                Console.WriteLine("存钱成功，现在的账户余额为{0}", Money);
            }
            else
            {
                Console.WriteLine("输入金额数错误，存钱失败");
            }
        }
        public override void GetMoney(int getmoney)     //如果账户中资金充足，可以从中取钱，但不能透支
        {
            if (Int32.Parse(Money) > getmoney)
            {
                Money = Convert.ToString(Int32.Parse(Money) - getmoney);
                Console.WriteLine("取钱成功，现在的账户余额为{0}", Money);
            }
            else Console.WriteLine("您的账户余额不足");
        }
        public override void services()                 //活期账户业务选择
        {
            int i = 1, j;
            Console.WriteLine("您当前为活期账户，请输入相应的业务号（0-4）进行业务操作：");
            Console.WriteLine("1、查询当前账户信息；");
            Console.WriteLine("2、向当前账户存钱；");
            Console.WriteLine("3、从当前账户取钱；");
            Console.WriteLine("4、查询可否订购支票簿；");
            Console.WriteLine("0、退出当前账户。");
            while (i == 1)
            {
                string[] choice = { "0", "1", "2", "3", "4" };
                j = Array.IndexOf(choice, Console.ReadLine());
                switch (j)
                {
                    case 1:
                        Console.WriteLine("您当前的账户信息如下：");
                        ShowInfo();
                        break;
                    case 2:
                        Console.Write("请输入您要存入的金额数目：");
                        AddMoney(Int32.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("请输入您要取出的金额数目：");
                        GetMoney(Int32.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        GetCheckbook();
                        break;
                    case 0:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("输入的业务号不存在，请重新输入：");
                        break;
                }
                if (j != 0) Console.Write("请选择业务操作：");
            }
        }
    }
    public class SavingsAccount : Account               //储蓄存款账户继承账户抽象类
    {
        int Year;
        public SavingsAccount(string id, string name, string money, int year)
        {
            ID = id;
            Name = name;
            Money = money;
            Year = year;
        }
        public string interest(string m, int y)          //计算利息，账户可以赚取利息，利息取决于账户的余额，余额大于 1000，年利息为6％，否则为  3％
        {
            double inter;
            if (Int32.Parse(m) > 1000) inter = 0.06;
            else inter = 0.03;
            string Moneynow = Convert.ToString(Int32.Parse(Money) * (1 + inter * (Year + y)));
            return Moneynow;
        }
        public override void ShowInfo()                 //检查账户余额
        {
            Console.WriteLine("账户号：\t" + ID + "\n储户名：\t" + Name + "\n账户本金：\t" + Money + "元\n已存款年数：\t" + Year + "年\n当前余额：\t" + interest(Money, 0) + "元");
        }
        public override void AddMoney(int addmoney)     //往账户中加钱
        {
            if (addmoney > 0)
            {
                Money = Convert.ToString(Int32.Parse(Money) + addmoney);
                Console.WriteLine("存钱成功，现在的账户余额为{0}", Money);
            }
            else
            {
                Console.WriteLine("输入金额数错误，存钱失败");
            }
        }
        public override void GetMoney(int getmoney)     //如果账户中资金充足，可以从中取钱，但不能透支
        {
            if (Int32.Parse(Money) > getmoney)
            {
                Money = Convert.ToString(Int32.Parse(Money) - getmoney);
                Console.WriteLine("取钱成功，现在的账户余额为{0}", Money);
            }
            else Console.WriteLine("您的账户余额不足");
        }
        public override void services()                 //储蓄存款账户业务选择
        {
            int i = 1, j;
            Console.WriteLine("您当前为储蓄存款账户，请输入相应的业务号（0-4）进行业务操作：");
            Console.WriteLine("1、查询当前账户信息；");
            Console.WriteLine("2、向当前账户存钱；");
            Console.WriteLine("3、从当前账户取钱；");
            Console.WriteLine("4、根据年限查询预计账户余额；");
            Console.WriteLine("0、退出当前账户。");
            while (i == 1)
            {
                string[] choose = { "0", "1", "2", "3", "4" };
                j = Array.IndexOf(choose, Console.ReadLine());
                switch (j)
                {
                    case 1:
                        Console.WriteLine("您当前的账户信息如下：");
                        ShowInfo();
                        break;
                    case 2:
                        Console.Write("请输入您要存入的金额数目：");
                        AddMoney(Int32.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("请输入您要取出的金额数目：");
                        GetMoney(Int32.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.Write("请输入您要存入的年数：");
                        int y = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("账户信息已更新，预计{0}年后，您的账户余额为{1}元！", y, interest(Money, y));            //此处报错BUG
                        break;
                    case 0:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("输入的业务号不存在，请重新输入：");
                        break;
                }
                if (j != 0) Console.Write("请选择业务操作：");
            }
        }
    }
    class Test
    {
        public static string[] ID = new string[20] { "111111", "222222", "333333", "444444", "555555", "666666", "777777", "888888", null, null, null, null, null, null, null, null, null, null, null, null };//账户号数组
        public static string[] NAME = new string[20] { "张一", "张二", "张三", "张四", "李五", "李六", "李七", "李八", null, null, null, null, null, null, null, null, null, null, null, null };//账户名数组
        public static string[] MONEY = new string[20] { "15000", "1298", "134", "1899", "20000", "10000", "20001", "4247", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };//账户初始存款
        public static int[] YEAR = new int[20] { -1, -1, -1, -1, 1, 2, 4, 8, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };//已经存款的年数，空账户或活期账户默认为-1
        public static void loadsystem()                 //账户系统登陆选择与开户
        {
            string id, name;
            int i = 1, j;
            CheckingAccount account1;
            SavingsAccount account2;
            Console.WriteLine("欢迎进入银行账户管理系统，请输入相应的业务号（0-3）进行业务操作：");
            Console.WriteLine("1、已有账户，登陆系统；");
            Console.WriteLine("2、没有账户，现在创建活期账户;");
            Console.WriteLine("3、没有账户，现在创建储蓄存款账户;");
            Console.WriteLine("0、退出系统，不进行任何操作。");
            while (i == 1)
            {
                string[] choice = { "0", "1", "2", "3" };
                j = Array.IndexOf(choice, Console.ReadLine());
                switch (j)
                {
                    case 1:
                        Console.Write("请输入您的账户号：");
                        id = Console.ReadLine();
                        Console.Write("请输入您的账户名：");
                        name = Console.ReadLine();
                        if (Array.IndexOf(ID, id) == Array.IndexOf(NAME, name) && Array.IndexOf(ID, id) > -1)
                        {
                            Console.WriteLine("尊敬的{0}，欢迎回来", name);
                            if (Int32.Parse(id) > 99999 && Int32.Parse(id) < 500000)
                            {
                                account1 = new CheckingAccount(id, name, MONEY[Array.IndexOf(ID, id)]);
                                account1.services();
                            }
                            else
                            {
                                account2 = new SavingsAccount(id, name, MONEY[Array.IndexOf(ID, id)], YEAR[Array.IndexOf(ID, id)]);
                                account2.services();
                                loadsystem();
                            }
                        }
                        else
                        {
                            Console.WriteLine("账户号与账户名不匹配，请重新输入：");
                        }
                        break;
                    case 2:
                        Console.Write("请输入您的姓名：");
                        int a = Array.IndexOf(NAME, null);
                        NAME[a] = Console.ReadLine();
                        for (int b = 100000; b <= 499999; b++)
                        {
                            if (Array.IndexOf(ID, Convert.ToString(b)) == -1)
                            {
                                ID[a] = Convert.ToString(b);
                                break;
                            }
                        }
                        Console.WriteLine("活期账户信息已存入，当前信息如下：");
                        account1 = new CheckingAccount(ID[a], NAME[a], MONEY[a]);
                        account1.ShowInfo();
                        account1.services();
                        break;
                    case 3:
                        Console.Write("请输入您的姓名：");
                        int c = Array.IndexOf(NAME, null);
                        NAME[c] = Console.ReadLine();
                        for (int d = 500000; d <= 999999; d++)
                        {
                            if (Array.IndexOf(ID, d) == -1)
                            {
                                ID[c] = Convert.ToString(d);
                                YEAR[c] = 0;
                                break;
                            }
                        }
                        Console.WriteLine("储蓄存款账户信息已存入，当前信息如下：");
                        account2 = new SavingsAccount(NAME[c], ID[c], MONEY[c], YEAR[c]);
                        account2.ShowInfo();
                        account2.services();
                        break;
                    case 0:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("输入的业务号不存在，请重新输入：");
                        break;
                }
                if (j != 0) Console.Write("请选择系统操作：");
            }
        }
        public static void Main(string[] args)
        {
            //CheckingAccount checking_account = new CheckingAccount(ID[1], NAME[1], MONEY[1]);
            //SavingsAccount savings_account = new SavingsAccount(ID[5], NAME[5], MONEY[5], YEAR[5]);
            //Account acc_checking = checking_account;
            //Account acc_savings = savings_account;
            //checking_account.services();
            //savings_account.services();
            //((CheckingAccount)acc_checking).services();
            //((SavingsAccount)acc_savings).services();
            loadsystem();
        }
    }
}
