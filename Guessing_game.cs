using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication288
{
    class guessinggame
    {
        int op;
        int res;

        public guessinggame()
        {
            op = 0;
            Random r = new Random();
            res = r.Next(1, 100);
            Console.WriteLine("Guess number is : "+res);
        }
        public void set(out int a)
        {
           
            
           // infinite loop
            for (; ; )
            {
                Console.WriteLine("enter number");
                a = int.Parse(Console.ReadLine());

                op = a;
                if (op == res)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else if (op > res)
                {
                    Console.WriteLine("To high");
                    continue;
                }
                else if (op < res)
                {
                    Console.WriteLine("to low");
                    continue;
                }
                else
                {
                    Console.WriteLine("wrong input");
                    continue;
                }
            }


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            guessinggame obj = new guessinggame();
            obj.set(out num);
        }
    }
}
