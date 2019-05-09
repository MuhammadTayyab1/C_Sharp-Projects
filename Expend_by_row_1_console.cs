using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication297
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[9]{1,2,3,4,5,6,7,8,9};
            int cout = 0;
            

            Console.WriteLine("    " + a[0] + "    " + a[1] + "    " + a[2]);
            Console.WriteLine("");
            Console.WriteLine("    " + a[3] + "    " + a[4] + "    " + a[5]);
            Console.WriteLine("");
            Console.WriteLine("    " + a[6] + "    " + a[7] + "    " + a[8]);
            


            for (int i = 0; i < 9; i++)
            {
                
                cout++;
                Console.WriteLine("Enter value at " + cout);
                int a1 = int.Parse(Console.ReadLine());
                Console.Clear();
                a[i] = a1;

                Console.WriteLine("    " + a[0] + "    " + a[1] + "    " + a[2]);
                Console.WriteLine("");
                Console.WriteLine("    " + a[3] + "    " + a[4] + "    " + a[5]);
                Console.WriteLine("");
                Console.WriteLine("    " + a[6] + "    " + a[7] + "    " + a[8]);

            }

            int sum = a[0] * ((a[7] * a[5]) - (a[4] * a[8])) - a[1] * ((a[6] * a[5]) - (a[3] * a[8])) + a[2] * ((a[6] * a[4]) - (a[3] * a[7]));
            Console.Clear();
            Console.WriteLine("Expend by row 1 ");
            Console.WriteLine("Answer is  "+sum);

            

        }
    }
}
