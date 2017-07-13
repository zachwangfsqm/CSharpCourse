using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DAY_Click(object sender, EventArgs e)
        {
            int Year, Month, Day;
            Year = Int32.Parse(textBox1.Text);
            Month = Int32.Parse(textBox2.Text);
            Day = Int32.Parse(textBox3.Text);
            DateTime t = new DateTime(Year, Month, Day);
            string weekstr = t.DayOfWeek.ToString();
            switch (weekstr)
            {
                case "Monday": weekstr = "星期一"; break;
                case "Tuesday": weekstr = "星期二"; break;
                case "Wednesday": weekstr = "星期三"; break;
                case "Thursday": weekstr = "星期四"; break;
                case "Friday": weekstr = "星期五"; break;
                case "Saturday": weekstr = "星期六"; break;
                case "Sunday": weekstr = "星期日"; break;
            }
            textBox4.Text = (weekstr);
        }
    }
}
