using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication133
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 and 2 for shoot");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
            int score = 0;
            
            for (int i = 0; i < 10; i++)
            {


                Console.Clear();
                Console.WriteLine(" _________________________________________________________________________");
                Console.WriteLine("|         Score  " + score + "                                                         ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|           _                                                             |");
                Console.WriteLine("|          |_|                                                            |");
                Console.WriteLine("|          ||--=                                                          |");
                Console.WriteLine("|          /\\                                                             |");
                Console.WriteLine("|_________________________________________________________________________|");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine(" _________________________________________________________________________");
                Console.WriteLine("|         Score  " + score + "                                                         ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                  _                                      |");
                Console.WriteLine("|                                 |_|                                     |");
                Console.WriteLine("|                                 ||--=                                   |");
                Console.WriteLine("|                                 /\\                                      |");
                Console.WriteLine("|_________________________________________________________________________|");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine(" _________________________________________________________________________");
                Console.WriteLine("|         Score  " + score + "                                                         ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                  _                                      |");
                Console.WriteLine("|                                 |_|                            @        |");
                Console.WriteLine("|                                 ||--=                         ||        |");
                Console.WriteLine("|                                 /\\                            /\\        |");
                Console.WriteLine("|_________________________________________________________________________|");



                string a = Console.ReadLine();
                Console.Clear();
                if (a == "1")
                {
                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                            @        |");
                    Console.WriteLine("|                                 ||--=   .    .     .     .    ||        |");
                    Console.WriteLine("|                                 /\\                            /\\        |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                    score += 100;
                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                              +100       |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                            @        |");
                    Console.WriteLine("|                                 ||--=        .                ||        |");
                    Console.WriteLine("|                                 /\\                           /\\         |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (a == "2")
                {
                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                            @        |");
                    Console.WriteLine("|                                 ||--=   o    o     o     o    ||        |");
                    Console.WriteLine("|                                 /\\                            /\\        |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                    score += 200;
                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                              +200       |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                            @        |");
                    Console.WriteLine("|                                 ||--=        o                ||        |");
                    Console.WriteLine("|                                 /\\                           /\\         |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();


                }
                else
                {
                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                 @                   |");
                    Console.WriteLine("|                                 ||--=              ||                   |");
                    Console.WriteLine("|                                 /\\                 /\\                   |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(" _________________________________________________________________________");
                    Console.WriteLine("|         Score  " + score + "                                                         ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                You lost                                 |");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|                                  _                                      |");
                    Console.WriteLine("|                                 |_|                 @                   |");
                    Console.WriteLine("|                                 ||--=  .   .   . =-||                   |");
                    Console.WriteLine("|                                 /\\                 /\\                   |");
                    Console.WriteLine("|_________________________________________________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                }
            }



        }
    }
}
