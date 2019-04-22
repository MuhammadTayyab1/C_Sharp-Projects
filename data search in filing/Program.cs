using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication316
{
    
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            

            int[] data = new int[20];
            int count=0;
            string temp = "";

            for (int i = 0; i < fs.Length; i++)
            {
                
                string ch = Convert.ToString((char)fs.ReadByte());
                if (ch != " ")
                {
                    temp += ch;
                    
                }
                else
                {
                    
                    data[count] = Convert.ToInt32(temp);
                    count++;
                    temp = "";
                    
                }
            }

            int min = 10000000;
            int max = -1000000;


            for (int i = 0; i < data.Length; i++)
            {
                if(data[i] < min)
                {
                    min = data[i];
                }
                if(data[i] > max)
                {
                    max = data[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
               

        }
    }
}
