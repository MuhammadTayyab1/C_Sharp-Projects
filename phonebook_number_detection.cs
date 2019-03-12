using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication291
{
    class phonebook
    {
        string cellnum;
        string length;
        string cost;

        static int count = 0;

        public static string[] data = new string[10] { "", "", "", "", "", "", "", "", "", ""};
        public phonebook()
        {
            cellnum = "";
            length = "";
            cost = "";
        }
        public phonebook(string c,string l,string co)
        {
            cellnum = c;
            length = l;
            cost = co;
            
            for (int i = 0; i < 10; i++)
            {
                if (data[i] == cellnum)
                {
                    Console.Clear();
                    Console.WriteLine("Not allow call on same number");
                    break;
                }
                else
                {
                    data[count] = cellnum;
                    break;
                }
            }            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            phonebook[] obj = new phonebook[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Cell number");
                string number = Console.ReadLine();

                Console.WriteLine("Enter call time");
                string calltime = Console.ReadLine();

                Console.WriteLine("Enter Call charges per minutes");
                string charges = Console.ReadLine();

                obj[i] = new phonebook(number,calltime,charges);
            }

            


        }


    }
}
