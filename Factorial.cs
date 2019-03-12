using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication291
{
    class factorial
    {
        int num = 1;
        public factorial(int n)
        {
            
            for (int i = 1; i <= n ; i++)
            {
                num  *= i;
            }
            Console.WriteLine("Factorial of "+n+" is  =  "+num );
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());


            factorial obj = new factorial(num);
        }


    }
}
