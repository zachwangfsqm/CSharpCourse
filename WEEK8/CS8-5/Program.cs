using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8_5
{
    public class Employee
    {
        String xm, xb, number, position, title;
        int BasSalary, YearSalary, month_check;
        DateTime enter_date, csny;
        public Employee() { }
        public Employee(String number, String position, DateTime enter_date, String title, int month_check)
        {
            this.number = number;
            this.position = position;
            this.enter_date = enter_date;
            this.title = title;
            this.month_check = month_check;
        }
        public int getBasSalary(String title)
        {
            return BasSalary;
        }
        public int getYearSalary(String enter_date)
        {
            return YearSalary;
        }
    }
    public class decision_Em : Employee
    {
        int Salary, Clas, BasSalary, PerfSalary, Smoo, YearSalary;
        public decision_Em() { }

        public int getSalary()
        {
            Salary = BasSalary + PerfSalary + Smoo + YearSalary;
            return Salary;
        }
    }
    public class manager_Em
    {
        int Salary, Position_salary, MonthPerf, BasSalary, YearSalary;
        public manager_Em() { }

        public int getSalary()
        {
            Salary = Position_salary + MonthPerf + BasSalary + YearSalary;
            return Salary;
        }
    }
    public class normal_Em
    {
        int Salary, BasSalary, YearSalary, MonthPerf;
        public normal_Em() { }

        public int getSalary()
        {
            Salary = MonthPerf + BasSalary + YearSalary;
            return Salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
