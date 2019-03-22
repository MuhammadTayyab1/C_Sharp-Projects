using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication108
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "";
            int p1 = 0;
            int p2 = 0;
            int p = 0;
            do
            {
                string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                int choise;
                Console.WriteLine("player 1 press X and player 2 press 0");
                Console.WriteLine("sample board ");
                Console.WriteLine("\n");

                Console.WriteLine("     1      |      2      |       3");
                Console.WriteLine("     4      |      5      |       6");
                Console.WriteLine("     7      |      8      |       9");

                Console.WriteLine("\n");


                Console.WriteLine("player 1 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "X";
                Console.Clear();



                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");





                Console.WriteLine("player 2 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "0";
                Console.Clear();



                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 1 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "X";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");




                Console.WriteLine("player 2 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "0";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 1 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "X";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 2 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "0";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 1 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "X";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 2 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "0";
                Console.Clear();


                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");



                Console.WriteLine("player 1 chooise");
                choise = int.Parse(Console.ReadLine());
                pos[choise] = "X";

                Console.Clear();

                Console.WriteLine("      Developed by Muhammad Tayyab");
                Console.WriteLine("  Copy Right 2018 All Rights Reserved.");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[1], pos[2], pos[3]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[4], pos[5], pos[6]);
                Console.WriteLine("\n");
                Console.WriteLine("          {0}    |      {1}    |   {2}    ", pos[7], pos[8], pos[9]);
                Console.WriteLine("\n");

                if (pos[1] == "X" || pos[2] == "X" || pos[3] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[4] == "X" || pos[5] == "X" || pos[6] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[7] == "X" || pos[8] == "X" || pos[9] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[1] == "X" || pos[4] == "X" || pos[7] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[2] == "X" || pos[5] == "X" || pos[8] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[3] == "X" || pos[6] == "X" || pos[9] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[1] == "X" || pos[5] == "X" || pos[9] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }
                else if (pos[3] == "X" || pos[5] == "X" || pos[7] == "X")
                {
                    Console.WriteLine("player 1 is winner");
                    ++p1;
                }








                else if (pos[1] == "0" || pos[2] == "0" || pos[3] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[4] == "0" || pos[5] == "0" || pos[6] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[7] == "0" || pos[8] == "0" || pos[9] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[1] == "0" || pos[4] == "0" || pos[7] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[2] == "0" || pos[5] == "0" || pos[8] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[3] == "0" || pos[6] == "0" || pos[9] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[1] == "0" || pos[5] == "0" || pos[9] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else if (pos[3] == "0" || pos[5] == "0" || pos[7] == "0")
                {
                    Console.WriteLine("player 2 is winner");
                    ++p2;
                }
                else
                {
                    Console.WriteLine("math is Draw ");
                    ++p;
                }

                Console.WriteLine("press 1 for continue 2 for exit");
                loop = Console.ReadLine();
                Console.Clear();

            } while (loop == "1");


            Console.WriteLine("\n");
            Console.WriteLine("Overall game summery");
            Console.WriteLine("\n");
            Console.WriteLine(" player 1 wins {0} games ", p1);
            Console.WriteLine(" player 2 wins {0} games ", p2);
            Console.WriteLine(" Draw games {0} ", p);

        }
    }
}
