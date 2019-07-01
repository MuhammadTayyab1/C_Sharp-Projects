using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication302
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter length of password");
                int len = int.Parse(Console.ReadLine());
            

            string save = "";
            Random r = new Random();

            for (int i = 0; i < len; i++)
            {
                int a = r.Next(20, 100);
                save += (char)a;
            }
            
            Console.WriteLine("Your password is :  "+save);
            Console.WriteLine("Enter file name in which you want store");
            string name = Console.ReadLine();

            FileStream fs = new FileStream(name + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < save.Length; i++)
            {
                fs.WriteByte((byte)save[i]);
            }
            Console.WriteLine("Save sucessfully");


        }
    }
}
