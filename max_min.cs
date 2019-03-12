using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class maxmin
    {
        public int max;
        public int min;
        public maxmin(out int a)
        {
            a = 0;
            

            max = -1000000000;
            min = 1000000000;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                int num = int.Parse(Console.ReadLine());
                if(num > max )
                {
                    max = num;
                }
                if(min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine("Max : " + max + "     min : " + min);
        }
       
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            maxmin obj = new maxmin(out num);

        }


    }
}
