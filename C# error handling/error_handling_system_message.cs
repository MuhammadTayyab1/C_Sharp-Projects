using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorhandling
{

    class Program
    {
        static void Main(string[] args)
        {
            // Checking process 
            // try to divide by zero
            // enter string format in integers
            // enter out of limit values like 8888888888888888888888888888888

            try
            {
                Console.WriteLine("Value 1");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Value 2");
                int b = int.Parse(Console.ReadLine());

                int sum = a / b;

                Console.WriteLine(sum);
            }
            catch(Exception ex)
            {
                // This is system generated error message
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Finally statement is always run either it contain error or not
                Console.WriteLine("Thanks for visit");
            }


        }
    }
}
