using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_race_game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("                                  Car racing game            ");
            Console.WriteLine("\n");
            Console.WriteLine("                   Try to save your car from another cars on road");
            Console.WriteLine("\n");
            Console.WriteLine("                                    Controls                     ");
            Console.WriteLine("                              press enter for drive ");
            Console.WriteLine("                              press R for Right move");
            Console.WriteLine("                              press L for left move");
            Console.WriteLine("\n");
            Console.WriteLine("                            Enjoy...................");
            Console.WriteLine("\n");
            Console.WriteLine("                             press enter to continue");
            Console.ReadLine();
            Console.Clear();
            int score = 0;
            int life = 13;
            for (int i = 1; i < 12; i++)
            {
                life--;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                  your score is  " + score);
                Console.WriteLine("                     game life left  " + life);
                Console.WriteLine("             press enter to continue.....................");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |           __          |       ");
                Console.WriteLine("                     |          |**|         |       ");
                Console.WriteLine("                     |          |__|         |       ");
                Console.WriteLine("                     |                       |       ");

                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |          __           |       ");
                Console.WriteLine("                     |         |@@|          |       ");
                Console.WriteLine("                     |         |@@|          |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |    __                 |       ");
                Console.WriteLine("                     |   |@@|                |       ");
                Console.WriteLine("                     |   |@@|                |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |           __          |       ");
                Console.WriteLine("                     |          |**|         |       ");
                Console.WriteLine("                     |          |__|         |       ");
                Console.WriteLine("                     |                       |       ");

                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |          __           |       ");
                Console.WriteLine("                     |         |@@|          |       ");
                Console.WriteLine("                     |         |@@|          |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |    __                 |       ");
                Console.WriteLine("                     |   |@@|                |       ");
                Console.WriteLine("                     |   |@@|                |       ");
                Console.WriteLine("                     |                       |       ");
                Console.WriteLine("                     |           __          |       ");
                Console.WriteLine("                     |          |**|         |       ");
                Console.WriteLine("                     |          |__|         |       ");
                Console.WriteLine("                     |                       |       ");

                string turn = Console.ReadLine();
                Console.Clear();

                if (turn == "l")
                {
                    score += 100;
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                 __    |       ");
                    Console.WriteLine("                     |                |**|   |       ");
                    Console.WriteLine("                     |          __    |__|   |       ");
                    Console.WriteLine("                     |         |@@|          |       ");



                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                 __    |       ");
                    Console.WriteLine("                     |                |@@|   |       ");
                    Console.WriteLine("                     |                |@@|   |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |    __                 |       ");
                    Console.WriteLine("                     |   |@@|                |       ");
                    Console.WriteLine("                     |   |@@|                |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                 __    |       ");
                    Console.WriteLine("                     |                |**|   |       ");
                    Console.WriteLine("                     |                |__|   |       ");
                    Console.WriteLine("                     |                       |       ");


                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                 __    |       ");
                    Console.WriteLine("                     |                |@@|   |       ");
                    Console.WriteLine("                     |                |@@|   |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                 __    |       ");
                    Console.WriteLine("                     |                |**|   |       ");
                    Console.WriteLine("                     |                |__|   |       ");
                    Console.WriteLine("                     |                       |       ");

                    string turn1 = Console.ReadLine();
                    Console.Clear();
                    if (turn1 == "r")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        score += 300;
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |           __          |       ");
                        Console.WriteLine("                     |          |**|         |       ");
                        Console.WriteLine("                     |          |__|   __    |       ");
                        Console.WriteLine("                     |                |@@|   |       ");

                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |           __          |       ");
                        Console.WriteLine("                     |          |**|         |       ");
                        Console.WriteLine("                     |          |__|         |       ");
                        Console.WriteLine("                     |                       |       ");

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                       |       ");
                        Console.WriteLine("                     |                __     |       ");
                        Console.WriteLine("                     |               |@@|    |       ");
                        Console.WriteLine("                     |               |@@| /  |       ");
                        Console.WriteLine("                     |                |**|   |       ");
                        Console.WriteLine("                     |                |__|   |       ");
                        Console.WriteLine("                     |                    \\  |      ");
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("           Opp's cars are destroyed you lost         ");

                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |          __           |       ");
                    Console.WriteLine("                     |         |@@|          |       ");
                    Console.WriteLine("                     |         |@@| /        |       ");
                    Console.WriteLine("                     |          |**|         |       ");
                    Console.WriteLine("                     |    __    |__|         |       ");
                    Console.WriteLine("                     |   |@@|       \\        |       ");
                    Console.WriteLine("                     |   |@@|                |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("                     |                       |       ");
                    Console.WriteLine("\n");
                    Console.WriteLine("           Opp's cars are destroyed you lost         ");


                }
            }






        }
    }
}
