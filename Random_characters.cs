/* Write a Program in which generate 87 A to Z random character except X and Y and store in an singal dimentional array create an integer variable 
   with name (store). if any array data become M and P then increment +1 in (store) varibale and finally convert the (store) varible final number 
   into char and save in txt file. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication292
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("character.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Random r = new Random();
            string[] ch = new string[87];
            int store = 0;

            for (int i = 0; i < 87; i++)
            {
                int a = r.Next(65, 91);
                if (a != 89 || a != 90)
                {
                    ch[i] = Convert.ToString((char)a);
                }
                else
                {
                    ch[i] = "";
                }
            }

            for (int i = 0; i < 87; i++)
            {
                if(ch[i]=="M" || ch[i]=="P")
                {
                    store = (int)ch[i][0];
                    store++;
                }
            }

            string save = Convert.ToString((char)store);

            fs.WriteByte((byte)save[0]);
        }
    }
}
