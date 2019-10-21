using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication143
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream FA = new FileStream("a.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FB = new FileStream("b.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FC = new FileStream("c.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FD = new FileStream("d.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FE = new FileStream("e.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FF = new FileStream("f.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FG = new FileStream("g.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FH = new FileStream("h.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FI = new FileStream("i.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FJ = new FileStream("j.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            // file data carrier

            string[] A = new string[15];
            string[] B = new string[15];
            string[] C = new string[15];
            string[] D = new string[15];
            string[] E = new string[15];
            string[] F = new string[15];
            string[] G = new string[15];
            string[] H = new string[15];
            string[] I = new string[15];
            string[] J = new string[15];

            // file data read 

            for (int i = 0; i < 15; i++)
            {
                A[i] = Convert.ToString((Convert.ToChar(FA.ReadByte())));
                B[i] = Convert.ToString((Convert.ToChar(FB.ReadByte())));
                C[i] = Convert.ToString((Convert.ToChar(FC.ReadByte())));
                D[i] = Convert.ToString((Convert.ToChar(FD.ReadByte())));
                E[i] = Convert.ToString((Convert.ToChar(FE.ReadByte())));
                F[i] = Convert.ToString((Convert.ToChar(FF.ReadByte())));
                G[i] = Convert.ToString((Convert.ToChar(FG.ReadByte())));
                H[i] = Convert.ToString((Convert.ToChar(FH.ReadByte())));
                I[i] = Convert.ToString((Convert.ToChar(FI.ReadByte())));
                J[i] = Convert.ToString((Convert.ToChar(FJ.ReadByte())));
            }

            // main screen user info
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t     Welcome new user\n");
            Console.WriteLine("                   Please read instructions carefully \n\n");
            Console.WriteLine("        " + (char)26 + " you can only use panel 0 to 14 to draw your alphabet");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                           _________________");
            Console.WriteLine("                          " + "|  0  |  1  |  2  |");
            Console.WriteLine("                          |-----|-----|-----|");
            Console.WriteLine("                          " + "|  3  |  4  |  5  |");
            Console.WriteLine("                          |-----|-----|-----|");
            Console.WriteLine("                          " + "|  6  |  7  |  8  |");
            Console.WriteLine("                          |-----|-----|-----|");
            Console.WriteLine("                          " + "|  9  | 10  | 11  |");
            Console.WriteLine("                          |-----|-----|-----|");
            Console.WriteLine("                          " + "|  12 | 13  | 14  |\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        " + (char)26 + " you only can type star ( * ) or space (  ) to fill these panel");
            Console.WriteLine("              for example for draw A fill panel like this \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                          _________________");
            Console.WriteLine("                         " + "|     |  *  |     |");
            Console.WriteLine("                         |-----|-----|-----|");
            Console.WriteLine("                         " + "|  *  |     |  *  |");
            Console.WriteLine("                         |-----|-----|-----|");
            Console.WriteLine("                         " + "|  *  |  *  |  *  |");
            Console.WriteLine("                         |-----|-----|-----|");
            Console.WriteLine("                         " + "|  *  |     |  *  |");
            Console.WriteLine("                         |-----|-----|-----|");
            Console.WriteLine("                         " + "|  *  |     |  *  |\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       must confirm before process detection that all panel have");
            Console.WriteLine("                * and space at the place of 0 to 14");
            Console.WriteLine("                        Hope you will enjoy\n");
            Console.WriteLine("\t  " + (char)169 + " Copyright all rights reserved Tayyab , Najam , Fazeel\n\n");
            Console.WriteLine("                press enter to continue.....................\n\n");
            Console.ReadLine(); Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // 0 to 14 value initilizor
            int usercount = 0;
            string[] user = new string[15];

            for (int i = 0; i < 15; i++)
            {
                user[i] = "" + usercount;
                usercount++;
            }

            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}  |   {2}   |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}   |    {1}  |   {2}   |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            // user data getting in 0 to 14 boxes
            int usercount2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter * or space at position " + usercount2);
                string add = Console.ReadLine();
                if (add == "*" || add == " ")
                {
                    user[i] = add;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n \t Other keys not allow expect * and space ");
                    Console.ReadLine();
                    break;
                }

                Console.Clear();
                Console.WriteLine("             __________________________");
                Console.WriteLine("            |        |        |        |");
                Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
                Console.WriteLine("            |________|________|________|");
                Console.WriteLine("            |        |        |        |");
                Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
                Console.WriteLine("            |________|________|________|");
                Console.WriteLine("            |        |        |        |");
                Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
                Console.WriteLine("            |________|________|________|");
                Console.WriteLine("            |        |        |        |");
                Console.WriteLine("            |   {0}    |    {1}  |   {2}   |", user[9], user[10], user[11]);
                Console.WriteLine("            |________|________|________|");
                Console.WriteLine("            |        |        |        |");
                Console.WriteLine("            |   {0}   |    {1}  |   {2}   |", user[12], user[13], user[14]);
                Console.WriteLine("            |________|________|________|");

                usercount2++;
            }

            // boxes shape setting / style maintaining  

            Console.WriteLine("enter * or space at position 10");
            user[10] = Console.ReadLine(); Console.Clear();

            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}   |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}   |    {1}  |   {2}   |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            Console.WriteLine("enter * or space at position 11");
            user[11] = Console.ReadLine(); Console.Clear();

            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}   |    {1}  |   {2}   |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            Console.WriteLine("enter * or space at position 12");
            user[12] = Console.ReadLine(); Console.Clear();
            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}  |   {2}   |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            Console.WriteLine("enter * or space at position 13");
            user[13] = Console.ReadLine(); Console.Clear();

            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}   |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            Console.WriteLine("enter * or space at position 14");
            user[14] = Console.ReadLine(); Console.Clear();

            Console.WriteLine("             __________________________");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[0], user[1], user[2]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    | ", user[3], user[4], user[5]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |  ", user[6], user[7], user[8]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[9], user[10], user[11]);
            Console.WriteLine("            |________|________|________|");
            Console.WriteLine("            |        |        |        |");
            Console.WriteLine("            |   {0}    |    {1}   |   {2}    |", user[12], user[13], user[14]);
            Console.WriteLine("            |________|________|________|");

            // Apply Artifical intellegence throught K-NN
            int[] alpha = new int[10];
            for (int i = 0; i < user.Length; i++)
            {
                if (A[i] == user[i])
                {
                    alpha[0]++;
                }
                if (B[i] == user[i])
                {
                    alpha[1]++;
                }
                if (C[i] == user[i])
                {
                    alpha[2]++;
                }
                if (D[i] == user[i])
                {
                    alpha[3]++;
                }
                if (E[i] == user[i])
                {
                    alpha[4]++;
                }
                if (F[i] == user[i])
                {
                    alpha[5]++;
                }
                if (G[i] == user[i])
                {
                    alpha[6]++;
                }
                if (H[i] == user[i])
                {
                    alpha[7]++;
                }
                if (I[i] == user[i])
                {
                    alpha[8]++;
                }
                if (J[i] == user[i])
                {
                    alpha[9]++;
                }
            }

            // result checking through K-NN algo
            int max = -10000000;
            int indexno = -1;
            for (int i = 0; i < alpha.Length; i++)
            {
                if (max < alpha[i])
                {
                    max = alpha[i];
                    indexno = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tDetection sucessfully complete Your given character is \n\n\t\t\t\t" + (char)(65 + indexno) + "\n\n");
        }
    }
}