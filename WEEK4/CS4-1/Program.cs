using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4_1
{
    class Program
    {
        public static char[] AllNode = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        public static char FirstNode;
        public static char[] FinalNode = new char[6];
        public static char[][] Node2 = new char[4][]
        {
            new char[] { 'A', 'B', 'E', 'G','\0' },
            new char[] { 'A', 'B', 'F', 'G','\0' },
            new char[] { 'A', 'C', 'D', 'E', 'G' },
            new char[] { 'A', 'C', 'D', 'F', 'G' }
        };
        public static char[][] path = new char[4][]
        {
            new char[] { 'A', 'B', 'E', 'G' },
            new char[] { 'A', 'B', 'F', 'G' },
            new char[] { 'A', 'C', 'D', 'E', 'G' },
            new char[] { 'A', 'C', 'D', 'F', 'G' }
        };
        public static int[][] length = new int[4][]
        {
            new int[] { 6, 6, 11 },
            new int[] { 6, 3, 4 },
            new int[] { 7, 2, 10, 11 },
            new int[] { 7, 2, 3, 4 }
        };
        static void final() //计算终结结点数组
        {
            int id1, id2, id3 = -1;
            id1 = Array.IndexOf(AllNode, FirstNode);
            Array.Copy(AllNode, id1 + 1, FinalNode, 0, 6 - id1);
            for (int i = 0; i < 6 - id1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    id2 = Array.IndexOf(path[j], FirstNode);
                    id3 = Array.IndexOf(path[j], FinalNode[i]);
                    if (id2 != -1 && id3 != -1)
                    {
                        id3 = -2;
                        break;
                    }
                }
                if (id3 != -2) FinalNode[i] = FirstNode;
            }
        }
        static void calc(char node1)  //通过初始结点和终结结点得到对应的最短路径并输出结果
        {
            int i, j, k, lengthmin, id1, id2;
            int[] length1 = new int[4] { 100, 100, 100, 100 };
            for (i = 0; i < 4; i++)
            {
                id1 = Array.IndexOf(path[i], FirstNode);
                id2 = Array.IndexOf(path[i], node1);
                if (id1 != -1 && id2 != -1)
                {
                    Node2[i][0] = FirstNode;
                    length1[i] = 0;
                    for (j = id1 + 1; j <= id2; j++)
                    {
                        Node2[i][j - id1] = path[i][j];
                        length1[i] += length[i][j - 1];
                    }
                }
            }
            lengthmin = length1[0];
            j = 0;
            for (i = 1; i < 4; i++)
            {
                if (lengthmin > length1[i])
                {
                    lengthmin = length1[i];
                    j = i;
                }
            }
            Console.Write("The optimal path from {0} to {1} is ", FirstNode, node1);
            Console.Write(FirstNode);
            for (k = 0; k < 5 && Node2[j][k] != node1; k++)
            {
                if (Node2[j][k] != FirstNode)
                    Console.Write(Node2[j][k]);
            }
            Console.WriteLine(node1);
            Console.WriteLine("The length of this path is {0}", lengthmin);
        }
        static void Main(string[] args)
        {
            int i, id1 = -1;
            Console.Write("Please input the first node: ");
            while (id1 == -1)
            {
                FirstNode = Convert.ToChar(Console.ReadLine());
                id1 = Array.IndexOf(AllNode, FirstNode);
                if (id1 == -1)
                    Console.Write("This node is not exist,please input again: ");
                else
                    break;
            }
            for (i = 0; i > 6 - id1; i++)
            {
                FinalNode[i] = FirstNode;
            }
            final();
            Console.Write("The reachable nodes: ");
            for (i = 0; i < 6; i++)
            {
                if (FinalNode[i] != FirstNode && FinalNode[i] != '\0')
                    Console.Write(FinalNode[i]);
            }
            Console.WriteLine();
            for (i = 0; i < 6; i++)
            {
                if (FinalNode[i] != FirstNode && FinalNode[i] != '\0')
                    calc(FinalNode[i]);
            }
        }
    }
}
