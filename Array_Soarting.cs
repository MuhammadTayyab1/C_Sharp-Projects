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

            int[] store = new int[1000];

            for (int i = 0; i < store.Length; i++)
            {
                
                store[i] = r.Next(1, 1000);
                
            }
            
            Array.Sort(store);
            
            // loop for display data
            for (int i = 0; i < store.Length; i++)
            {
                Console.WriteLine(store[i]);
            }


        }
    }
}
