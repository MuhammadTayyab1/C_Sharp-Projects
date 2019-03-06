using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication283
{
    class date
    {
        int day;
        int month;
        int year;

        string mon;

        public date()
        {
            day = 1;
            month = 1;
            year = 2001;
        }
        public date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;

            String[] check = new String[13] { "", "January", "Febuary", "March", "Aprail", "May", "June", "jully", "August", "September", "October", "November", "December" };
            for (int i = 1; i <= check.Length; i++)
            {
                if (month == i)
                {
                    mon = check[i];
                }
            }
        }
        public void show()
        {
            Console.WriteLine(day + "/" + month + "/" + year);
            Console.WriteLine(mon + " " + day + ", " + year);
            Console.WriteLine(day + " " + mon + " " + year);
            Console.WriteLine(year + "-" + day + "-" + mon);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day");
            int da = int.Parse(Console.ReadLine());

            Console.WriteLine("Month");
            int mon = int.Parse(Console.ReadLine());

            Console.WriteLine("Year");
            int ye = int.Parse(Console.ReadLine());

            Console.Clear();

            date obj = new date(da, mon, ye);
            obj.show();

        }
    }
}