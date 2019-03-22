using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random r2 = new Random();
            int bowls = 12;


            int random2 = r2.Next(30, 50);
            int y = 30;
            int total = 0;

            for (; ; )
            {
                y = 30;

                for (int i2 = 0; i2 < 20; i2++)
                {


                    Console.WriteLine("-------------------");
                    Console.WriteLine("|      |||        |");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("|                 |");
                    }

                    Console.WriteLine("-------------------");



                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("      0    ");
                    Console.WriteLine("      |    ");
                    Console.WriteLine("     / \\   ");

                    Thread.Sleep(100);
                    y--;
                    Console.Clear();


                }


                Console.WriteLine("-------------------");
                Console.WriteLine("|      |||        |");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("|                 |");
                }

                Console.WriteLine("-----------------");



                Console.SetCursorPosition(0, y);
                Console.WriteLine("      0    ");
                Console.WriteLine("      |    ");
                Console.WriteLine("     / \\   ");

                Random r = new Random();

                int random = r.Next(1, 10);


                Console.WriteLine("Your Target is = " + random2);

                Console.WriteLine();
                Console.WriteLine("Remaining Bowls are =" + bowls--);
                Console.WriteLine("Enter your number");
                Console.WriteLine();
                int num = Convert.ToInt16(Console.ReadLine());
                if (num > 6)
                {

                    Console.WriteLine("Re Enter the value......");
                }

                else if (num == random)
                {
                    Console.WriteLine("Out");
                }
                else if (num == 6)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("|                    ");
                    Console.WriteLine("|                    ");
                    Console.WriteLine("|                    ");
                    Console.WriteLine("|                    ");
                    Console.WriteLine("|--------------------");
                    Console.WriteLine("|                    |");
                    Console.WriteLine("|                    |");
                    Console.WriteLine("|                    |");
                    Console.WriteLine("|____________________|");
                    Console.WriteLine();
                    total += num;
                    Console.WriteLine("You Hit " + num);
                    Console.WriteLine("Total Score " + total);
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER for next bowl");
                }
                else if (num == 4)
                {
                    Console.WriteLine("|                     |");
                    Console.WriteLine("|                     |");
                    Console.WriteLine("|                     |");
                    Console.WriteLine("|                     |");
                    Console.WriteLine("|---------------------|");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine("                      |");
                    Console.WriteLine();
                    total += num;
                    Console.WriteLine("You Hit " + num);
                    Console.WriteLine("Total Score " + total);
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER for next bowl");
                }
                else if (random2 <= total)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CONGRATULATION!!!!! YOU WON THE MATH WITH SCORE =" + total);
                    Console.ReadLine();
                    break;
                }
                else
                {

                    total += num;
                    Console.WriteLine("You Hit " + num);
                    Console.WriteLine("Total Score " + total);
                }
                Console.ReadLine();

            }
        }
    }
}
