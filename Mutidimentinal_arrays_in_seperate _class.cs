using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication294
{
    class data
    {
        public data(out string n,out string i,int l)
        {
            string[,] da = new string[l, 2];
            n = ""; i = "";

            for (int j = 0; j < da.GetLength(0); j++)
            {
                Console.WriteLine("Enter name");
                da[j,0] = Console.ReadLine();

                Console.WriteLine("Enter id of "+da[j,0]);
                da[j,1] = Console.ReadLine();
            }
            Console.Clear();
                Console.WriteLine("         Data is         \n");
                Console.WriteLine("==========================");
            for (int j = 0; j < da.GetLength(0); j++)
            {
                for (int k = 0; k < da.GetLength(1); k++)
                {
                    Console.WriteLine(da[j,k]);
                }
                Console.WriteLine("==========================");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name,id;
            Console.WriteLine("Enter length of record");
            int len = int.Parse(Console.ReadLine());
            Console.Clear();
            data obj = new data(out name, out id,len);
        }
    }
}
