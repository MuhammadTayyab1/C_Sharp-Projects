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

            Console.WriteLine("enter text or name");
            string data = Console.ReadLine();

            for (int i = 0; i < data.Length; i++)
            {
                int a = (int)data[i];
                Console.WriteLine((char)a);
            }

        }
    }
}
