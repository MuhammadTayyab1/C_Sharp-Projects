using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication289
{
    class data
    {
        public static int a;
        public data(int get)
        {
            a += get;
        }
        public void show()
        {
            Console.WriteLine("                 Total  "+a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of enteries");
            int num= int.Parse(Console.ReadLine());


            data[] obj = new data[num];


            for (int i = 0; i < obj.GetLength(0); i++)
            {
                Console.WriteLine("Enter value");
                int val = int.Parse(Console.ReadLine());

                obj[i] = new data(val);
                obj[i].show();
            }
            Console.WriteLine("=============================================================================");
            Console.WriteLine("Result value is : ");
            obj[0].show();
            Console.WriteLine("=============================================================================");

        }
    }
}