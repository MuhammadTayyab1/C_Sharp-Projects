using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication315
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int j = 1; j <= 3; j++)
            {

                Console.WriteLine("enter your data");
                string save = Console.ReadLine();

                int[] a = new int[save.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = (int)save[i];
                }

                Console.WriteLine("for encript press 1 , deccipt press 2 , for both press 3 ");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {

                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i]++;
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write((char)a[i]);
                    }
                    Console.ReadLine();
                }
                else if (op == 2)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i]--;
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write((char)a[i]);
                    }
                    Console.ReadLine();
                }
                else if (op == 3)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i]++;
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write((char)a[i]);
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i]--;
                    }
                    Console.WriteLine("\n\n");

                    for (int i = 0; i < a.Length; i++)
                    {
                        a[i]--;
                    }

                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write((char)a[i]);
                    }
                    Console.ReadLine();
                }
            }
            

        }
    }
}
