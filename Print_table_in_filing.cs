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
            FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            string data="";

            for (int i = 1; i <=10; i++)
            {
                data +=(num+ "   X   "+i+"   =   "+(num*i)+"  \t\n");
            }

            for (int i = 0; i < data.Length; i++)
            {
                fs.WriteByte((byte)data[i]);
            }

        }
    }
}
