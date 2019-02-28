using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            int w = 1;
            int sum = 1;

            Console.WriteLine(q);
            Console.WriteLine(w);

            for (int i = 0; i < 10; i++)
            {
                sum = q + w;
                q = w;
                w = sum;
                Console.WriteLine(sum);
            }

            

        }
        
    }
}

