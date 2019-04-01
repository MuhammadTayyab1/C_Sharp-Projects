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
            try
            {
                Console.WriteLine("value 1");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("value 2");
                int b = int.Parse(Console.ReadLine());

                int sum = a / b;

                Console.WriteLine(sum);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Zero sa divide nahi karo");
                Console.WriteLine("not try divide by zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("Sahi format ma data likho");
                Console.WriteLine("enter data in correct format");
            }
            catch(OverflowException)
            {
                Console.WriteLine("limit sa zayada data nahi enter karo");
                Console.WriteLine("enter data within limit");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("other error try again");
            }
            finally
            {
                Console.WriteLine("thanks for try this");
            }


        }
    }
}
