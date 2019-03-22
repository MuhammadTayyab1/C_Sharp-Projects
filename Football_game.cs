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
            int score = 0;
            for (int j = 0; j < 15; j++)
            {



                for (int i = 0; i < 2; i++)
                {
                    Console.Clear();

                    Console.WriteLine("          Score  " + score);
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("|             |    |              | ");
                    Console.WriteLine("|                @                |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|                         #       |");
                    Console.WriteLine("|            0           /\\       |");
                    Console.WriteLine("|            #                    |");
                    Console.WriteLine("|           /\\                    |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|_________________________________|");

                    Console.WriteLine("\n 1 for kick 2 for pass to another player");
                    string option = Console.ReadLine();
                    Console.Clear();

                    if (option == "1")
                    {
                        score += 100;
                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|     +100    |    |              | ");
                        Console.WriteLine("|    goal       0 @               |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (option == "2")
                    {
                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|             |    |              | ");
                        Console.WriteLine("|                @                |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         0       |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();

                        score += 100;
                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|     +100    |    |              | ");
                        Console.WriteLine("|    goal       0 @               |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();

                    }

                }



                for (int i = 0; i < 2; i++)
                {
                    Console.Clear();
                    Console.WriteLine("          Score  " + score);
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("|             |    |              | ");
                    Console.WriteLine("|                @                |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|                         #       |");
                    Console.WriteLine("|            0           /\\       |");
                    Console.WriteLine("|            #                    |");
                    Console.WriteLine("|           /\\                    |");
                    Console.WriteLine("|                                 |");
                    Console.WriteLine("|_________________________________|");

                    Console.WriteLine("\n 1 for kick 2 for pass to another player");
                    string option = Console.ReadLine();
                    Console.Clear();

                    if (option == "1")
                    {
                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|             |    |              | ");
                        Console.WriteLine("|    defend     @                 |");
                        Console.WriteLine("|               0                 |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (option == "2")
                    {
                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|             |    |              | ");
                        Console.WriteLine("|                @                |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         0       |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("          Score  " + score);
                        Console.WriteLine("__________________________________");
                        Console.WriteLine("|             |    |              | ");
                        Console.WriteLine("|    defend     @                 |");
                        Console.WriteLine("|               0                 |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|                         #       |");
                        Console.WriteLine("|                        /\\       |");
                        Console.WriteLine("|            #                    |");
                        Console.WriteLine("|           /\\                    |");
                        Console.WriteLine("|                                 |");
                        Console.WriteLine("|_________________________________|");

                        Console.ReadLine();
                        Console.Clear();

                    }
                }

            }



        }
    }
}
