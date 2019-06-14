using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace all_in_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your mode");
            Console.WriteLine("\n");
            Console.WriteLine("press 1 for Online hotel order system");
          
            Console.WriteLine("press 2 for student mark(1 student) sheet");
            
            Console.WriteLine("press 3 for for Vowels detection");
           
            Console.WriteLine("press 4 for Online House order");

            Console.WriteLine("press 5 for marksheet style 2");
            int select=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            if (select==1)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("press 1 for tea and 2 for coffie");
                int order = Convert.ToInt32(Console.ReadLine());
                string totalorder = "";
                int price = 0;
                
                if (order == 1)
                {
                    totalorder += "tea";
                    price += 60;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("press 1 for high sugar and 2 low sugar");
                    int teasugar = Convert.ToInt32(Console.ReadLine());
                    if (teasugar == 1)
                    {
                        totalorder += " with high sugar";
                        price += 15;
                    }
                    else
                    {
                        totalorder += " with low sugar";
                        price += 12;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Want in cup or parcel ? press 1 for cup 2 for parcel");
                    int teadelivery = Convert.ToInt32(Console.ReadLine());
                    if (teadelivery == 1)
                    {
                        totalorder += " in cup  |___|>";
                        price += 7;
                    }
                    else
                    {
                        totalorder += " ** Parcel **";
                        price += 14;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("you want samoosa or biscuts press 1 for samoosa 2 for biscuits");
                    int fastfood = Convert.ToInt32(Console.ReadLine());
                    if (fastfood == 1)
                    {
                        totalorder += " with a samoosa /\\";
                        price += 20;
                    }
                    else
                    {
                        totalorder += " with some biscuts () () () () ";
                        price += 21;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You want mineral water? press 1 for yes 2 for no");
                    int water = Convert.ToInt32(Console.ReadLine());
                    if (water == 1)
                    {
                        totalorder += "with extra mineral water bottle";
                        price += 70;
                    }
                    else
                    {
                        totalorder += "";
                        price += 0;
                    }
                }
                else if (order == 2)
                {
                    totalorder += " Coffie";
                    price += 70;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("press 1 for high and 2 for low sugar");
                    int coffiesugar = Convert.ToInt32(Console.ReadLine());
                    if (coffiesugar == 1)
                    {
                        totalorder += " With high sugar";
                        price += 18;
                    }
                    else
                    {
                        totalorder += " With low sugar";
                        price += 12;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Want in cup or parcel press 1 for cup 2 for parcel");
                    int coffiedelivery = Convert.ToInt32(Console.ReadLine());
                    if (coffiedelivery == 1)
                    {
                        totalorder += " in cup  |___|>";
                        price += 7;
                    }
                    else
                    {
                        totalorder += " ** parcel **";
                        price += 14;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("you want samoosa or biscuts press 1 for samoosa 2 for biscuits");
                    int fastfood = Convert.ToInt32(Console.ReadLine());
                    if (fastfood == 1)
                    {
                        totalorder += " with a samoosa /\\";
                        price += 20;
                    }
                    else
                    {
                        totalorder += " with some biscuts () () () () ";
                        price += 21;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You want mineral water? press 1 for yes 2 for no");
                    int water = Convert.ToInt32(Console.ReadLine());
                    if (water == 1)
                    {
                        totalorder += "with extra mineral water bottle";
                        price += 70;
                    }
                    else
                    {
                        totalorder += "";
                        price += 0;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("thanks for purchasing from us");
                Console.WriteLine("\n");
                Console.WriteLine("here is your order >>> {0}", totalorder);
                Console.WriteLine("\n");
                Console.WriteLine("Price Rs = {0} only", price);
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("your order is in process loading...");
                Console.ReadLine();
                Console.WriteLine("loading... 10 % complete");
                Console.ReadLine();
                Console.WriteLine("loading... 40 % complete");
                Console.ReadLine();
                Console.WriteLine("loading... 70 % complete");
                Console.ReadLine();
                Console.WriteLine("loading... 100 % complete");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("We sucessfully collect your order Thanks");
                Console.ReadLine();




            }


            if (select==2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string div, dav, dev, dzv, dxv;
                Console.WriteLine("NOTE: please enter your mid term marks out of 40 ");
                Console.WriteLine("      And enter your final term marks out of 80");
                Console.WriteLine("\n");
                Console.WriteLine("Enter your mid term marks");
                Console.Write("Math = ");
                float m1 = float.Parse(Console.ReadLine());

                Console.Write("English = ");
                float e1 = float.Parse(Console.ReadLine());

                Console.Write("Urdu = ");
                float u1 = float.Parse(Console.ReadLine());

                Console.Write("Arts = ");
                float a1 = float.Parse(Console.ReadLine());

                Console.Write("Science = ");
                float s1 = float.Parse(Console.ReadLine());





                Console.WriteLine("Enter your final term marks");
                Console.Write("Math = ");
                float m2 = float.Parse(Console.ReadLine());



                Console.Write("English = ");
                float e2 = float.Parse(Console.ReadLine());



                Console.Write("Urdu = ");
                float u2 = float.Parse(Console.ReadLine());



                Console.Write("Arts = ");
                float a2 = float.Parse(Console.ReadLine());



                Console.Write("Science = ");
                float s2 = float.Parse(Console.ReadLine());




                float m = m1 + m2;
                float e = e1 + e2;
                float u = u1 + u2;
                float a = a1 + a2;
                float s = s1 + s2;



                float mr = 120f;
                float er = 120f;
                float ur = 120f;
                float ar = 120f;
                float sr = 120f;


                float mp = m * 100f / mr;
                float ep = e * 100f / er;
                float up = u * 100f / ur;
                float ap = a * 100f / ar;
                float sp = s * 100f / sr;

                float ms = m1 + e1 + u1 + a1 + s1;
                float fs = m2 + e2 + u2 + a2 + s2;
                float ts = m + e + u + a + s;
                float rs = mr + er + ur + ar + sr;




                if (mp >= 80)
                    div = "A";
                else
                    if (mp < 80 && mp >= 70)
                        div = "B";
                    else
                        if (mp < 70 && mp >= 60)
                            div = "C";
                        else
                            div = "Fail";





                if (ep >= 80)
                    dav = "A";
                else
                    if (ep < 80 && ep >= 70)
                        dav = "B";
                    else
                        if (ep < 70 && ep >= 60)
                            dav = "C";
                        else
                            dav = "Fail";






                if (up >= 80)
                    dev = "A";
                else
                    if (up < 80 && up >= 70)
                        dev = "B";
                    else
                        if (up < 70 && up >= 60)
                            dev = "C";
                        else
                            dev = "Fail";


                if (ap >= 80)
                    dzv = "A";
                else
                    if (ap < 80 && ap >= 70)
                        dzv = "B";
                    else
                        if (ap < 70 && ap >= 60)
                            dzv = "C";
                        else
                            dzv = "Fail";


                if (sp >= 80)
                    dxv = "A";
                else
                    if (sp < 80 && sp >= 70)
                        dxv = "B";
                    else
                        if (sp < 70 && sp >= 60)
                            dxv = "C";
                        else
                            dxv = "Fail";




                Console.ForegroundColor = ConsoleColor.Blue;



                Console.WriteLine("                                 _                                    ");
                Console.WriteLine(" ______________________________// \\\\________________________________");
                Console.WriteLine("|                              \\\\_//                                |");
                Console.WriteLine("|___________________________________________________________________|");
                Console.WriteLine("|Subject  | Mid term | Final term| A     | B     |  %     |Grade    |");
                Console.WriteLine("|__Names__|____Marks_|_____Marks_|_______|_______|________|_________|");
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("| Maths         {0}       {1}       {2}      {3}    {4} %   {5} ", m1, m2, m, mr, mp, div);
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("| English       {0}       {1}       {2}      {3}    {4} %   {5} ", e1, e2, e, er, ep, dav);
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("| Urdu          {0}       {1}       {2}      {3}    {4} %   {5} ", u1, u2, u, ur, up, dev);
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("| Arts          {0}       {1}       {2}      {3}    {4} %   {5} ", a1, a2, a, ar, ap, dzv);
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("| Science       {0}       {1}       {2}      {3}    {4} %   {5} ", s1, s2, s, sr, sp, dxv);
                Console.WriteLine("|                                                                    ");
                Console.WriteLine("|===================================================================|");
                Console.WriteLine("| total        {0}       {1}      {2}      {3}                     ", ms, fs, ts, rs);
                Console.WriteLine("|_________|__________|___________|_______|_______|________|_________|");


                Console.ReadLine();



            }

            if (select==3)
            {

                Console.WriteLine("enter an alphabet");
                char any = char.Parse(Console.ReadLine().ToLower());
                Console.ForegroundColor = ConsoleColor.Magenta;

                if (any >= 48 && any <= 57)
                {
                    Console.WriteLine("please enter an alphabet");
                }
                else
                {
                    switch (any)
                    {
                        case 'a':
                            Console.WriteLine("this is a vowel");
                            break;
                        case 'e':
                            Console.WriteLine("this is a vowel");
                            break;
                        case 'i':
                            Console.WriteLine("this is a vowel");
                            break;
                        case 'o':
                            Console.WriteLine("this is a vowel");
                            break;
                        case 'u':
                            Console.WriteLine("this is a vowel");
                            break;
                        default:
                            Console.WriteLine("this is not a vowel");
                            break;

                    }

                }



            }

            if (select==4)
            {

                int totalprice = 0;
                Console.WriteLine("hello user we are house builders please submit your order for YES type Y and for NO type N");
                Console.WriteLine("You want chimini in your dream house ?  Y/N");
                string cheminy = Console.ReadLine();

                Console.WriteLine("We have good quality roofs you want ? Y/N");
                string roof = Console.ReadLine();


                Console.WriteLine("You want window ? Y/N");
                string window = Console.ReadLine();

                Console.WriteLine("Can we decorate your gardern with grass ? Y/N");
                string grass = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;

                if (cheminy == "Y")
                {
                    totalprice += 200;
                    Console.WriteLine("                       ^^^^^ ");
                    Console.WriteLine("                      |     |");
                    Console.WriteLine("                      |     |");


                }
                if (roof == "Y")
                {

                    totalprice += 1000;
                    Console.WriteLine("     ============================");
                    Console.WriteLine("    //                        \\\\");
                    Console.WriteLine("    ==============================");
                }

                if (window == "Y")
                {
                    totalprice += 700;
                    Console.WriteLine("    |                    _____    |");
                    Console.WriteLine("    |                   |__|__|   |");


                }
                totalprice += 10000;
                Console.WriteLine("    |                             |");
                Console.WriteLine("    |                             |");
                Console.WriteLine("    |                             |");
                Console.WriteLine("    |                             |");
                Console.WriteLine("    |    ________                 |");
                Console.WriteLine("    |   |        |                |");
                Console.WriteLine("    |   |        |                |");
                Console.WriteLine("    |   | *      |                |");
                Console.WriteLine("    |   |        |                |");
                Console.WriteLine("    |___|________|________________|");

                if (grass == "Y")
                {
                    totalprice += 800;
                    Console.WriteLine("#########################################");
                    Console.WriteLine("#########################################");
                }
                Console.WriteLine("Price List According your demand");

                if (roof == "Y")
                {
                    Console.WriteLine("RS 1000 for Roof");
                }
                if (cheminy == "Y")
                {
                    Console.WriteLine("RS 200 for cheminy");

                }
                if (window == "Y")
                {
                    Console.WriteLine("RS 700 for window");

                }
                if (grass == "Y")
                {
                    Console.WriteLine("RS 800 for grass");
                }
                Console.WriteLine("RS 10000 for walls");

                Console.WriteLine("Thanks for submiting your order . here is your house structure soon we will start construction");
                Console.WriteLine("your House total price is RS {0} only", totalprice);

            }


            if (select==5)
            {
                double rl, phy, che, ca, total;
                double per;
                string nm, div;

                Console.Write("\n\n");
                Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
                Console.Write("-------------------------------------------------------------------------------");
                Console.Write("\n\n");


                Console.Write("Input the Roll Number of the student :");
                rl = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the Name of the Student :");
                nm = Console.ReadLine();

                Console.Write("Input  the marks of Physics : ");
                phy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of  Chemistry : ");
                che = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of Computer Application : ");
                ca = Convert.ToInt32(Console.ReadLine());

                total = phy + che + ca;
                per = total / 3.0;
                if (per >= 60)
                    div = "First";
                else
                    if (per < 60 && per >= 48)
                        div = "Second";
                    else
                        if (per < 48 && per >= 36)
                            div = "Pass";
                        else
                            div = "Fail";

                Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
                Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
                Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

            }

            if (select == 6)
            {


            }
            if (select ==7)
            {

            }
        }
    }
}
