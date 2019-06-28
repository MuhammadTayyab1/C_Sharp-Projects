using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // initilize array with length
            int[] ok = new int[100];

            // Ramdom numbers
            Random r = new Random();

            // Initilizing data in arrays
            for (int i = 0; i < ok.Length; i++)
            {
                ok[i] = r.Next(1, 100);
                Console.WriteLine("Index = "+i+"       value = "+ok[i]);
            }

            // Sorting numeric data in array
            Array.Sort(ok);
            Console.WriteLine("After sorting");

            // Display data after sorting
            foreach (var item in ok)
            {
                Console.WriteLine("Index = " + item + "       value = " + ok[item]);
            }




        }
    }
}
