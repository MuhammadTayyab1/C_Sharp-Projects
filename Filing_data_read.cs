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
            FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            

            for (int i = 0; i < fs.Length; i++)
            {
                Console.Write((char)fs.ReadByte());
            }


        }
    }
}
