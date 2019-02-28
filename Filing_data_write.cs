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

            string yourdata = "This is your data file";

            for (int i = 0; i < yourdata.Length; i++)
            {
                fs.WriteByte((byte)yourdata[i]);
            }


        }
    }
}
