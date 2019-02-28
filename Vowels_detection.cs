using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            string hold = Console.ReadLine().ToUpper();

            if ((int)hold[0] >= 48 && (int)hold[0] <= 57)
            {
                Console.WriteLine("please not enter a number");
            }
            else
            {
                switch (hold)
                {
                    case "A":
                        Console.WriteLine("vowel");
                        break;
                    case "E":
                        Console.WriteLine("vowel");
                        break;
                    case "I":
                        Console.WriteLine("vowel");
                        break;
                    case "O":
                        Console.WriteLine("vowel");
                        break;
                    case "U":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("not vowel");
                        break;
                }
            }
            


        }
    }
}
