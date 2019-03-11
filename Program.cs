using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication290
{
    class add
    {
        public add(int a,int b)
        {
            Console.WriteLine("Sum  :  "+(a+b));
        }
        public add(int a, int b, int c)
        {
            Console.WriteLine("Sum  :  " + (a + b + c));
        }
        public add(int a, int b, int q,int w)
        {
            Console.WriteLine("Sum  :  " + (a + b + q + w));
        }
        public add(double a=0, double b=0,double q=0,double w=0)
        {
            Console.WriteLine("Sum  :  " + (a + b + q+w));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            add obj = new add(95.89,3.99);
        }
    }
}
