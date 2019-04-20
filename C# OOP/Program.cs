using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
   class game
   {
       static int count;
       public game(int n)
       {
           Random r = new Random();
           int ran = r.Next(1, 5);

           if(ran==n)
           {
               count++;
           }
       }
       public static void result()
       {
           if(count >= 3)
           {
               Console.WriteLine("You guess 3 or more You win ");
           }
           else
           {
               Console.WriteLine("You loss");
           }
       }
   }
    class Program
    {
        static void Main(string[] args)
        {
            game[] obj = new game[10];

            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine("Enter number or type break to stop");
                string userdata = Console.ReadLine();
                if (userdata == "break")
                {
                    break;
                }
                else
                {
                    int user = Convert.ToInt32(userdata);
                    obj[i] = new game(user);
                }
            }

            game.result();
           
        }
    }
}
