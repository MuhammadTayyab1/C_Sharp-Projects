using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication280
{
    class Program
    {
        static void Main(string[] args)
        {


            // Let suppose w like song number 2 from each Cd

            int[,] cd = new int[50, 20];
            int op = 0;

            

            for (int i = 0; i < cd.GetLength(0); i++)
            {
                
                for (int j = 0; j < cd.GetLength(1); j++)
                {
                    cd[i,j] = j;
                }
            }


            Console.WriteLine("w  /  h");
            string data = Console.ReadLine();

            if (data=="w")
            {
                op = 1;
            }
            else if(data=="h")
            {
                op = 2;
            }


            if (op == 1)
            {
                for (int i = 0; i < cd.GetLength(0); i++)
                {
                    for (int j = 0; j < cd.GetLength(1); j++)
                    {
                        if(cd[i,j]==2)
                        {
                            Console.Clear();
                            Console.WriteLine("w in car");
                            break;
                            
                        }
                    }
                }
            }
            else if (op==2)
            {
                for (int i = 0; i < cd.GetLength(0); i++)
                {
                    for (int j = 0; j < cd.GetLength(1); j++)
                    {
                        if (cd[i, j] != 2)
                        {
                            Console.Clear();
                            Console.WriteLine("h in car");
                            break;

                        }
                    }
                }
            }
            


            

            
            

            
           
           
        }
    }
}
