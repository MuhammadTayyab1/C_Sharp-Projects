using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication289
{
    class odd
    {
        int num;
        public odd()
        {
            num = 0;
        }
        public odd(int n)
        {
            if (n % 2 != 0)
            {
                num = n;
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public static odd operator ++(odd p)
        {
            for (; ; )
            {
                p.num++;
                if (p.num % 2 != 0)
                {
                    return p;
                }
                else
                {
                    continue;
                }
            }
        }

        public static odd operator --(odd p)
        {
            for (; ; )
            {
                p.num--;
                if (p.num % 2 != 0)
                {
                    return p;
                }
                else
                {
                    continue;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("Next odd numbers is  : "+num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a odd number");
            int nu = int.Parse(Console.ReadLine());

            Console.WriteLine("++   or   -- ");
            string op = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Your input is  :  "+nu);

            odd obj = new odd(nu);

            if (op == "++")
            {
                obj++;
            }
            else if(op=="--")
            {
                obj--;
            }
            obj.show();
            
            
        }
    }
}