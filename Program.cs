using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Text");
            string text = Console.ReadLine();

            int len = text.Length;

            string [] data= new string [len];


            for (int i = 0; i < text.Length; i++)
            {
                data[i] = Convert.ToString(text[i]);
            }
            string inc = "";
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(inc+"* "+data[i]);
                inc += "*";
            }
        }
    }
}
