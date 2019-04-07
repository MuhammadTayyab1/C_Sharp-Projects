using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int score = 0;
                int count = 0;

                // Question 1
                Console.WriteLine("Capital of pakistan is");
                Console.WriteLine("1) Karachi ");
                Console.WriteLine("2) Islamabad");
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
                Console.WriteLine("CPU stands for");
                Console.WriteLine("1) Central processing unit ");
                Console.WriteLine("2) Control panel unit");
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
                Console.WriteLine("What is computer");
                Console.WriteLine("1) electronic machine ");
                Console.WriteLine("2) heat engine");
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
                Console.WriteLine("IOT stands for");
                Console.WriteLine("1) Inter operating technology ");
                Console.WriteLine("2) Internet of things");
                Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                int p4 = int.Parse(Console.ReadLine());

                if (p4 != 0)
                {
                    if (p4 == 2)
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
                Console.WriteLine("Standard limit SAR value of mobile is");
                Console.WriteLine("1) 1.5 - 2.0 ");
                Console.WriteLine("2) 3.0 - 4.0");
                Console.WriteLine("\nEnter option 1 or 2 for skip press 0");
                int p5 = int.Parse(Console.ReadLine());

                if (p5 != 0)
                {
                    if (p5 == 1)
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}
