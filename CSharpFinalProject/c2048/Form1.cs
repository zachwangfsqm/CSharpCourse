using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c2048
{
    public partial class Form1 : Form
    {
        int[,] m = new int[4, 4];
        int score;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cr = e.KeyChar.ToString();
            switch (cr)
            {  
                case "w": game(0); if (score < 0) { MessageBox.Show("游戏结束"); } else { label1.Text = score.ToString(); } break;
                case "s": game(1); if (score < 0) { MessageBox.Show("游戏结束"); } else { label1.Text = score.ToString(); } break;
                case "d": game(2); if (score < 0) { MessageBox.Show("游戏结束"); } else { label1.Text = score.ToString(); } break;
                case "a": game(3); if (score < 0) { MessageBox.Show("游戏结束"); } else { label1.Text = score.ToString(); } break;
                default: return;
                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            score = 0;
            begin(score, m);
        }
        private void game(int n)
        {
            int Flag=0;
            if (n == 0)
            {
                for(int i = 0; i <= 3; i++)
                {
                    int f;
                    f = 0;
                    for (int k=0; k <= 3; k++)
                    {
                        if (m[k, i] != 0) { m[f, i] = m[k, i];  f++; }
                    }
                    for(int k = 0; k <= 3-f; k++)
                    {
                        m[3 - k, i] = 0;
                    }
                    if (m[0, i] == 0 && m[1, i] == 0 && m[2, i] == 0) { m[0, i] = m[3, i]; rand(3, i); }
                    else
                    {
                        if (m[0, i] == m[1, i])
                        {
                            m[0, i] = m[0, i] * 2; score = score +m[0, i];
                            if (m[2, i] == m[3, i]) { m[1, i] = m[2, i] * 2; score = score + m[1, i]; m[2, i] = 0; rand(3, i); }
                            else { m[1, i] = m[2, i]; m[2, i] = m[3, i]; rand(3, i); }
                        }
                        else if (m[1, i] == m[2, i])
                        {
                            m[1, i] = m[1, i] * 2; score = score + m[1, i]; m[2, i] = m[3, i]; rand(3, i);
                        }
                        else if (m[2, i] == m[3, i])
                        {
                            m[2, i] = m[2, i] * 2; score = score + m[2, i]; rand(3, i);
                        }
                        else if (m[3, i] == 0) { rand(3, i); }
                        else { Flag++; }
                    }
                }
            }
            if (n == 1)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int f;
                    f = 0;
                    for (int k = 0; k <= 3; k++)
                    {
                        if (m[3-k, i] != 0) { m[3-f, i] = m[3-k, i]; f++; }
                    }
                    for (int k = 0; k <= 3 - f; k++)
                    {
                        m[ k, i] = 0;
                    }
                    if (m[3, i] == 0 && m[1, i] == 0 && m[2, i] == 0) { m[3, i] = m[0, i]; rand(0, i); }
                    else
                    {
                        if (m[3, i] == m[2, i])
                        {
                            m[3, i] = m[3, i] * 2; score = score + m[3, i];
                            if (m[1, i] == m[0, i]) { m[2, i] = m[1, i] * 2; score = score + m[2, i]; m[1, i] = 0; rand(0, i); }
                            else { m[2, i] = m[1, i]; m[1, i] = m[0, i]; rand(0, i); }
                        }
                        else if (m[1, i] == m[2, i])
                        {
                            m[2, i] = m[2, i] * 2; score = score + m[2, i]; m[1, i] = m[0, i]; rand(0, i);
                        }
                        else if (m[1, i] == m[0, i])
                        {
                            m[1, i] = m[1, i] * 2; score = score + m[1, i]; rand(0, i);
                        }
                        else if (m[0, i] == 0) { rand(0, i); }
                        else { Flag++; }
                    }
                }
            }
            if (n == 2)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int f;
                    f = 0;
                    for (int k = 0; k <= 3; k++)
                    {
                        if (m[i, 3-k] != 0) { m[i, 3-f] = m[i, 3-k]; f++; }
                    }
                    for (int k = 0; k <= 3 - f; k++)
                    {
                        m[i, k] = 0;
                    }
                    if (m[i, 3] == 0 && m[i, 1] == 0 && m[i, 2] == 0) { m[i, 3] = m[i, 0]; rand(i, 0); }
                    else
                    {
                        if (m[i, 3] == m[i, 2])
                        {
                            m[i, 3] = m[i, 3] * 2; score = score + m[i, 3];
                            if (m[i, 1] == m[i, 0]) { m[i, 2] = m[i, 1] * 2; score = score + m[i, 2]; m[i, 1] = 0; rand(i, 0); }
                            else { m[i, 2] = m[i, 1]; m[i, 1] = m[i, 0]; rand(i, 0); }
                        }
                        else if (m[i, 1] == m[i, 2])
                        {
                            m[i, 2] = m[i, 2] * 2; score = score + m[i, 2]; m[i, 1] = m[i, 0]; rand(i, 0);
                        }
                        else if (m[i, 1] == m[i, 0])
                        {
                            m[i, 1] = m[i, 1] * 2; score = score + m[i, 1]; rand(i, 0);
                        }
                        else if (m[i, 0] == 0) { rand(i, 0); }
                        else { Flag++; }
                    }
                }
            }

            if (n == 3)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int f;
                    f = 0;
                    for (int k = 0; k <= 3; k++)
                    {
                        if (m[i, k] != 0) { m[i, f] = m[i, k]; f++; }
                    }
                    for (int k = 0; k <= 3 - f; k++)
                    {
                        m[i, 3-k] = 0;
                    }

                    if (m[i, 0] == 0 && m[i, 1] == 0 && m[i, 2] == 0) { m[i, 0] = m[i, 3]; rand(i, 3); }
                    else
                    {
                        if (m[i, 0] == m[i, 1])
                        {
                            m[i, 0] = m[i, 0] * 2; score = score + m[i, 0];
                            if (m[i, 2] == m[i, 3]) { m[i, 1] = m[i, 2] * 2; score = score + m[i, 2]; m[i, 2] = 0; rand(i, 3); }
                            else { m[i, 1] = m[i, 2]; m[i, 2] = m[i, 3]; rand(i, 3); }
                        }
                        else if (m[i, 1] == m[i, 2])
                        {
                            m[i, 1] = m[i, 1] * 2; score = score + m[i, 1]; m[i, 2] = m[i, 3]; rand(i, 3);
                        }
                        else if (m[i, 2] == m[i, 3])
                        {
                            m[i, 2] = m[i, 2] * 2; score = score + m[i, 2]; rand(i, 3);
                        }
                        else if (m[i, 3] == 0) { rand(i, 3); }
                        else { Flag++; }
                    }
                }
            }
            if (Flag == 4) {
                Flag = -1;
                score = score * Flag;
            }
            PictureBox[,] pi = new PictureBox[4, 4]{
                               {pi1,pi2,pi3,pi4},
                               {pi5,pi6,pi7,pi8},
                               {pi9,pi10,pi11,pi12},
                               {pi13,pi14,pi15,pi16}
                               };
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    setimage(pi[i, j], m[i, j]);
                }
            }
        }
        private void rand(int i,int j)
        {
            if (ran.Next(0, 7) >= 4)
            {
                if (ran.Next(0, 7) >= 4) { m[i, j] = 2; }
                else { m[i, j] = 4; }
            }
            else m[i, j] = 0;
            }
        
    
        private void begin(int s,int[,] m)//初始化
        {
            s = 0;
            PictureBox[,] pi = new PictureBox[4, 4]{
                               {pi1,pi2,pi3,pi4},
                               {pi5,pi6,pi7,pi8},
                               {pi9,pi10,pi11,pi12},
                               {pi13,pi14,pi15,pi16}
                               };

            for (int i=0; i <= 3; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    m[i,j] = 0;
                }
            }
            
            int ran_x = ran.Next(0, 3);
            int ran_y = ran.Next(0, 3);
            if (ran.Next(0, 7) >= 4)
            {
                m[ran_x, ran_y] = 2;
            }
            else
            { m[ran_x, ran_y] = 4; }
            ran_x = ran.Next(0, 3);
            ran_y = ran.Next(0, 3);
            if (ran.Next(0, 7) >= 4)
            {
                m[ran_x, ran_y] = 2;
            }
            else
            { m[ran_x, ran_y] = 4; }

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    setimage(pi[i, j], m[i, j]);
                }
            }
            label1.Text = s.ToString();
        }
        private void setimage(PictureBox p, int num)//显示刷新
        {
            switch (num)
            {
                case 0: p.Image = global::c2048.Resource1._0; break;
                case 2: p.Image = global::c2048.Resource1._2; break;
                case 4: p.Image = global::c2048.Resource1._4; break;
                case 8: p.Image = global::c2048.Resource1._8; break;
                case 16: p.Image = global::c2048.Resource1._16; break;
                case 32: p.Image = global::c2048.Resource1._32; break;
                case 64: p.Image = global::c2048.Resource1._64; break;
                case 128: p.Image = global::c2048.Resource1._128; break;
                case 256: p.Image = global::c2048.Resource1._256; break;
                case 512: p.Image = global::c2048.Resource1._512; break;
                case 1024: p.Image = global::c2048.Resource1._1024; break;
                case 2048: p.Image = global::c2048.Resource1._2048; break;
                case 4096: p.Image = global::c2048.Resource1._4096; break;
                case 8192: p.Image = global::c2048.Resource1._8192; break;
                default: break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;
            begin(score, m);
        }
    }
}
