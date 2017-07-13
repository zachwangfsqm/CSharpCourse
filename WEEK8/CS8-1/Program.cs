using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS8_1
{
    public class Animal
    {
        int age;
        String gender;
        public Animal() { }
        public Animal(int age, String gender)
        {
            this.age = age;
            this.gender = gender;
        }
        public int getAge()
        {
            return age;
        }
        public String getGender()
        {
            return gender;
        }
    }
    public class tiger : Animal
    {
        string color;
        int weight;
        public tiger() { }

        public tiger(int age, String gender, String color, int weight) : base(age, gender)
        {
            this.color = color;
            this.weight = weight;
        }
        public override string ToString()
        {
            return "Tiger:" + color + " " + weight + " " + getAge() + " " + getGender();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            cat cat = new cat();
            if (cat.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            tiger ti = obj as tiger;
            return this.color.Equals(ti.color) && this.weight.Equals(ti.weight);
        }
        public override int GetHashCode()
        {
            return weight;
        }
    }
    public class cat : Animal
    {
        string color;
        int weight;
        public cat() { }
        public cat(int age, String gender, String color, int weight)
            : base(age, gender)
        {
            this.color = color;
            this.weight = weight;
        }
        public override string ToString()
        {
            return "Cat:" + color + " " + weight + " " + getAge() + " " + getGender();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            tiger cat = null;
            if (cat.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            cat ti = obj as cat;
            return this.color.Equals(ti.color) && this.weight.Equals(ti.weight);
        }
        public override int GetHashCode()
        {
            return weight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            tiger tiger1 = new tiger(10, "boy", "yellow", 1000);
            tiger tiger2 = new tiger(9, "girl", "black", 900);
            cat cat1 = new cat(5, "boy", "white", 100);
            cat cat2 = new cat(3, "girl", "yellow", 80);
            Console.WriteLine(tiger1);
            Console.WriteLine(cat1);
            Console.WriteLine(tiger1.Equals(cat1));
            Console.WriteLine(tiger2.Equals(tiger1));
        }
    }
}
