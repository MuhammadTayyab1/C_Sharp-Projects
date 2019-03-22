using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication122
{
    class Program
    {
        static void Main(string[] args)
        {
            int life1 = 100;
            int life2 = 100;

            do
            {
                Random r = new Random();
                int num = r.Next(1, 10);
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(_____               )(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()--=                 ()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                    life1 += 4;
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(__                  )(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()--=  .  . . .       ()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();

                    life1 += 4;
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(__                  )(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()--=  .  .       .   ()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                }


                Random r1 = new Random();
                int num1 = r.Next(1, 10);
                for (int i = 0; i < num1; i++)
                {
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(                ____)(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()                 =--()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();

                    life2 += 4;
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(                  __)(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()       .    .  . =--()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();

                    life2 += 4;
                    Console.WriteLine("_____________________________________ ");
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("  Player1 {0}            player2 {1}  ", life1, life2);
                    Console.WriteLine("|                                    |");
                    Console.WriteLine("|     __                    __       |");
                    Console.WriteLine("|    |..|                  |@@|      | ");
                    Console.WriteLine("|     )(                  __)(       |");
                    Console.WriteLine("|     ||                    ||       |");
                    Console.WriteLine("|     ()  .    .      .  =--()       |");
                    Console.WriteLine("|     /\\                    /\\       |");
                    Console.WriteLine("|____________________________________|");

                    Console.ReadLine();
                    Console.Clear();
                }
            } while (life1 != 0 || life2 != 0);
        }
    }
}
