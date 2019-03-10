using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication289
{
    class num
    {
        int a;
        public num()
        {
            a = 0;
        }
        public num(int n)
        {
            a = n;
        }
        public void show(int x,int y)
        {
            Random r = new Random();

            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    int w = r.Next(x, y);
                    Console.WriteLine(w);
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
                
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random numbers");
            int many = int.Parse(Console.ReadLine());

            Console.Write("From : ");
            int from = int.Parse(Console.ReadLine());

            Console.Write("To : ");
            int to = int.Parse(Console.ReadLine());

            num obj = new num(many);
            obj.show(from,to);

            

        }
    }
}