using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c2048;
using Tetris;

namespace Main_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c2048.Form1 f1 = new c2048.Form1();
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Tetris.Form1 f2 = new Tetris.Form1();
            f2.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
