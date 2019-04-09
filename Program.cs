using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            Console.WriteLine("if you want to start the quiz type 1 or press any key to skip");
            ans = (Console.ReadLine());
            if (ans == "1")
            {
                try
                {
                    int score = 0;
                    int count = 0;

                    // Question 1
                    Console.WriteLine("Which of the following is largest unit of storage?");
                    Console.WriteLine("1) Gigabyte");
                    Console.WriteLine("2) Terabyte");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p1 = int.Parse(Console.ReadLine());
                    if (p1 != 0)
                    {
                        if (p1 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 2
                    Console.WriteLine("Which level language is Assembly language?");
                    Console.WriteLine("1)  Low-level programming language");
                    Console.WriteLine("2) High-level programming language");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p2 = int.Parse(Console.ReadLine());
                    if (p2 != 0)
                    {
                        if (p2 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 3
                    Console.WriteLine("Documents, Movies and images etc are stored at file server");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2) no ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p3 = int.Parse(Console.ReadLine());
                    if (p3 != 0)
                    {
                        if (p3 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 4
                    Console.WriteLine("Semiconductor is used in RAM");
                    Console.WriteLine("1)  yes ");
                    Console.WriteLine("2) no ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p4 = int.Parse(Console.ReadLine());
                    if (p4 != 0)
                    {
                        if (p4 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 5/
                    Console.WriteLine("who was the founder of Bluetooth");
                    Console.WriteLine("1) Steve jobs ");
                    Console.WriteLine("2) Ericsson ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p5 = int.Parse(Console.ReadLine());
                    if (p5 != 0)
                    {
                        if (p5 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 6/
                    Console.WriteLine("What is LINUX?");
                    Console.WriteLine("1) OPERATING SYSTEM ");
                    Console.WriteLine("2) SYSTEM PROGRAM ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p6 = int.Parse(Console.ReadLine());
                    if (p6 != 0)
                    {
                        if (p6 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 7/
                    Console.WriteLine("PARAM 8000 is the name of first super computer of india?");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2) no ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p7 = int.Parse(Console.ReadLine());
                    if (p7 != 0)
                    {
                        if (p7 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 8/
                    Console.WriteLine("USB flash drive is which type of storage device?");
                    Console.WriteLine("1) primary ");
                    Console.WriteLine("2) secondary ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p8 = int.Parse(Console.ReadLine());
                    if (p8 != 0)
                    {
                        if (p8 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 9/
                    Console.WriteLine("MPG is an file extention of which type of files?");
                    Console.WriteLine("1) video ");
                    Console.WriteLine("2) audio ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p9 = int.Parse(Console.ReadLine());
                    if (p9 != 0)
                    {
                        if (p9 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    // Question 10/
                    Console.WriteLine("1MEGABYTE is equals to ?");
                    Console.WriteLine("1) 1024 bytes");
                    Console.WriteLine("2) 1024 kilo bytes ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p10 = int.Parse(Console.ReadLine());
                    if (p10 != 0)
                    {
                        if (p10 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 11/
                    Console.WriteLine("RAM is located in external drive");
                    Console.WriteLine("1) yes ");
                    Console.WriteLine("2) no ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p11 = int.Parse(Console.ReadLine());
                    if (p11 != 0)
                    {
                        if (p11 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 12/
                    Console.WriteLine("Mini computers are used in railways or banking sector?");
                    Console.WriteLine("1)  yes ");
                    Console.WriteLine("2) no ");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p12 = int.Parse(Console.ReadLine());
                    if (p12 != 0)
                    {
                        if (p12 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 13/
                    Console.WriteLine("who is the father of modern computer science");
                    Console.WriteLine("1) Alan Turing ");
                    Console.WriteLine("2) Larry Page");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p13 = int.Parse(Console.ReadLine());
                    if (p13 != 0)
                    {
                        if (p13 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 14/
                    Console.WriteLine("you can use tab key to ?");
                    Console.WriteLine("1)  Move a cursor across the screen");
                    Console.WriteLine("2) Indent paragraph");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p14 = int.Parse(Console.ReadLine());
                    if (p14 != 0)
                    {
                        if (p14 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 15/
                    Console.WriteLine("which type of switching is used in Internet?");
                    Console.WriteLine("1) Telex");
                    Console.WriteLine("2) packet");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p15 = int.Parse(Console.ReadLine());
                    if (p15 != 0)
                    {
                        if (p15 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 16/
                    Console.WriteLine("101101 is an example of binary number?");
                    Console.WriteLine("1)  yes");
                    Console.WriteLine("2) no");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p16 = int.Parse(Console.ReadLine());
                    if (p16 != 0)
                    {
                        if (p16 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 17/
                    Console.WriteLine("what is the full form of LAN?");
                    Console.WriteLine("1)  Local Area Network");
                    Console.WriteLine("2) Light Area Network");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p17 = int.Parse(Console.ReadLine());
                    if (p17 != 0)
                    {
                        if (p17 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 18/
                    Console.WriteLine("The word Pentium is related to Hard disk");
                    Console.WriteLine("1)  yes");
                    Console.WriteLine("2) no");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p18 = int.Parse(Console.ReadLine());
                    if (p18 != 0)
                    {
                        if (p18 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 19/
                    Console.WriteLine("SPAM is the example of real security and privacy risks?");
                    Console.WriteLine("1)  yes ");
                    Console.WriteLine("2) no");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p19 = int.Parse(Console.ReadLine());
                    if (p19 != 0)
                    {
                        if (p19 == 2)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();
                    // Question 20/
                    Console.WriteLine("IP adress 4 is in which format?");
                    Console.WriteLine("1) 32 bit");
                    Console.WriteLine("2) 16 bit");
                    Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                    int p20 = int.Parse(Console.ReadLine());
                    if (p20 != 0)
                    {
                        if (p20 == 1)
                        {
                            score += 100;
                            count += 1;
                        }
                        else
                        {
                            count += 1;
                        }
                    }

                    Console.Clear();

                    Console.WriteLine("Your score is  " + score);
                    Console.WriteLine("Total attempt quiz   " + count);
                    Console.WriteLine("Thanks for coming!!!");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            else
            {
                Console.WriteLine(" thanks for coming");
            }



        }
    }
}
