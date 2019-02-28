using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            string revrse = " ";
            string name = "zubair";
            int ind = name.Length - 1;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revrse += name[ind];
                ind--;

            }

            Console.WriteLine(revrse);



        }
    }
}

