using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS4_3
{
    public partial class Form1 : Form
    {
        public static string[][] fullname = new string[4][]
        {
            new string[] { "Thomas","Sir","James","John","Alain","George","Alexander","Jocelyn" },
            new string[] { "A","I","C","J","L","W","G","B" },
            new string[] { "Alva","Issac","Clerk","James","Louis","Washington","Graham","Bell" },
            new string[] { "Edison","Newton","Maxwell","Audubon","Bombard","Carver","Bell","Burnell" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id1, id2, id3, id4;
            string firstname1, middlename1, lastname1;
            id1 = id2 = id3 = id4 = -1;
            firstname1 = textBox1.Text;
            middlename1 = textBox2.Text;
            lastname1 = textBox3.Text;
            id1 = Array.IndexOf(fullname[0], firstname1);
            id2 = Array.IndexOf(fullname[1], middlename1);
            id3 = Array.IndexOf(fullname[2], middlename1);
            id4 = Array.IndexOf(fullname[3], lastname1);
            if (firstname1 == "" && middlename1 == "" && id4 != -1) textBox4.Text = fullname[0][id4] + " " + fullname[2][id4] + " " + fullname[3][id4];
            else if (id1 != -1 && middlename1 == "" && lastname1 == "") textBox4.Text = fullname[0][id1] + " " + fullname[2][id1] + " " + fullname[3][id1];
            else if (firstname1 == "" && lastname1 == "" && id2 != -1) textBox4.Text = fullname[0][id2] + " " + fullname[2][id2] + " " + fullname[3][id2];
            else if (firstname1 == "" && lastname1 == "" && id3 != -1) textBox4.Text = fullname[0][id3] + " " + fullname[2][id3] + " " + fullname[3][id3];
            else if (firstname1 == "" && id2 != -1 && id2 == id4) textBox4.Text = fullname[0][id2] + " " + fullname[2][id2] + " " + fullname[3][id2];
            else if (firstname1 == "" && id3 != -1 && id3 == id4) textBox4.Text = fullname[0][id3] + " " + fullname[2][id3] + " " + fullname[3][id3];
            else if (middlename1 == "" && id1 != -1 && id1 == id4) textBox4.Text = fullname[0][id1] + " " + fullname[2][id1] + " " + fullname[3][id1];
            else if (lastname1 == "" && id2 != -1 && id2 == id1) textBox4.Text = fullname[0][id2] + " " + fullname[2][id2] + " " + fullname[3][id2];
            else if (lastname1 == "" && id3 != -1 && id3 == id1) textBox4.Text = fullname[0][id3] + " " + fullname[2][id3] + " " + fullname[3][id3];
            else if (id2 != -1 && id2 == id1 && id2 == id4) textBox4.Text = fullname[0][id2] + " " + fullname[2][id2] + " " + fullname[3][id2];
            else if (id3 != -1 && id3 == id1 && id3 == id4) textBox4.Text = fullname[0][id3] + " " + fullname[2][id3] + " " + fullname[3][id3];
            else textBox4.Text = "No match！";
        }
    }
}
