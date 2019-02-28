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
            Random r = new Random();

            int[] store = new int[10000];

            for (int i = 0; i < store.Length; i++)
            {
                store[i] = r.Next(1, 100);
            }

            Console.WriteLine("enter any number from 1 to 99");
            int check = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < store.Length; i++)
            {
                if(store[i]==check)
                {
                    Console.WriteLine(check+" is store in array number  store["+i+"]");
                }
            }


        }
    }
}
