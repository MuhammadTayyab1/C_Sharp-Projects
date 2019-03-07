using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication285
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter ");
            int number = int.Parse(Console.ReadLine());

            bool flag = false;

            for (int i = 2; i < number; i++)
            {
                if (number % i ==0)
                {
                    flag = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag==false)
            {
                Console.WriteLine(number+" is a prime");
            }
            else
            {
                Console.WriteLine(number+ " is not a prime");
            }

        }
    }
}
