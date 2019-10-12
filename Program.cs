using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // CMT Softwares Solution
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr =new int[2, 2, 2];
            int count = -1;
            Console.WriteLine("                                                 ___________");
            Console.WriteLine("                                                 ___     ___     _");
            Console.WriteLine("S.No     A         B         C        D        ((A+B) X (C+D)) X A");
            Console.WriteLine("_______________________________________________________________");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            int a1 = i + j;
                            if (a1 == 0)
                            {
                                a1 = 1;
                            }
                            else if (a1 > 0)
                            {
                                a1 = 0;
                            }

                            int a2 = j + k;
                            if(a2==0)
                            {
                                a2 = 1;
                            }
                            else if(a2>0)
                            {
                                a2 = 0;
                            }

                            int eq = a1 * a2;
                            if(i==0)
                            {
                                eq = eq * 1;
                            }
                            else if(i>0)
                            {
                                eq = eq * 0;
                            }



                            if (eq == 0)
                            {
                                eq = 1;
                                count++;
                                string space = " ";
                                if (count < 10)
                                {
                                    Console.WriteLine(count + "    " + space + "  " + i + "         " + j + "         " + k + "        " + l + "              " + eq);
                                }
                                else if (count >= 10)
                                {
                                    Console.WriteLine(count + "      " + i + "         " + j + "         " + k + "        " + l + "              " + eq);
                                }
                            }
                            else if(eq>0)
                            {
                                eq = 0;

                                count++;
                                string space = " ";
                                if (count < 10)
                                {
                                    Console.WriteLine(count + "    " + space + "  " + i + "         " + j + "         " + k + "        " + l + "              " + eq);
                                }
                                else if (count >= 10)
                                {
                                    Console.WriteLine(count + "      " + i + "         " + j + "         " + k + "        " + l + "              " + eq);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
