using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string store = "";

            Console.WriteLine("number of workers");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("number of fields for per worker");
            int fie = int.Parse(Console.ReadLine());

            string[,] data = new String[num, fie];

            string[] fields = new string[fie];

            for (int j = 0; j < fields.Length; j++)
            {
                Console.WriteLine("Enter title for field number "+j);
                fields[j] = Console.ReadLine();
            }



            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] += fields[j];
                }
            }
            Console.Clear();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    
                    Console.Write(data[i,j]+" : ");
                    data[i, j] += Console.ReadLine();

                }
                Console.WriteLine("");
            }
            Console.Clear();


            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.WriteLine(data[i,j]);
                    store += (data[i, j]);
                }
                Console.WriteLine("");
                store += "   \n\t";
            }


            Console.WriteLine("Enter file name in which you want to save data");
            string fname = Console.ReadLine();
            FileStream fs = new FileStream(fname+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < store.Length; i++)
            {
                fs.WriteByte((byte)store[i]);
            }




        }
    }
}
