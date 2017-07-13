using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iBirthYear, iBirthMonth, iBirthDay;
            DateTime dThisMoment = DateTime.Now;
            iBirthYear = Int32.Parse(textBox1.Text);
            iBirthMonth = Int32.Parse(textBox2.Text);
            iBirthDay = Int32.Parse(textBox3.Text);
            if ((dThisMoment.Month > iBirthMonth) || ((dThisMoment.Month == iBirthMonth) && (dThisMoment.Day >= iBirthDay)))
                textBox4.Text = (dThisMoment.Year - iBirthYear).ToString();
            else
                textBox4.Text = (dThisMoment.Year - iBirthYear - 1).ToString();
        }
    }
}
