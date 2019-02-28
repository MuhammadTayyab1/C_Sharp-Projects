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
            Console.WriteLine("how many workers");
            int w = Convert.ToInt32(Console.ReadLine());


            string[,] record = new string[w, 4];


            for (int i = 0; i < record.GetLength(0); i++)
            {
                Console.WriteLine("Enter name : ");
                record[i, 0] = "Name    : "+Console.ReadLine();

                Console.WriteLine("Enter contact number : ");
                record[i, 1] = "contact : " + Console.ReadLine();

                Console.WriteLine("Enter Email : ");
                record[i, 2] = "Email   : " + Console.ReadLine();

                Console.WriteLine("Enter Adress : ");
                record[i, 3] = "Adress  : " + Console.ReadLine();
                Console.WriteLine("");
            }
            Console.Clear();


            for (int i = 0; i < record.GetLength(0); i++)
            {
                for (int j = 0; j < record.GetLength(1); j++)
                {
                    Console.WriteLine(record[i,j]);
                }
            }


        }
    }
}
