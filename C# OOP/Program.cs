using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication310
{
    class human
    {
        string firstname;
        string lastname;

        public human(string fn, string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public void dis()
        {
            Console.WriteLine("First Name     : "+firstname);
            Console.WriteLine("Last Name      : "+lastname);
        }

    }
    class student : human
    {
        string mark;

        public student(string ma, string fn, string ln)
            : base(fn, ln)
        {
            mark = ma;
        }
        public void display()
        {
            dis();
            Console.WriteLine(mark);
        }
    }
    class worker : human
    {
        int wages;
        int hourwork;
        int calcu;

        public worker(int wa, int hou, string fn, string ln)
            : base(fn, ln)
        {
            wages = wa;
            hourwork = hou;
            calcu = wages / (30 * hou);
        }
        public void display()
        {
            dis();
            Console.WriteLine("Monthly Wage   : " + wages);
            Console.WriteLine("Hours/day work : " + hourwork);
            Console.WriteLine("per hour wage  : " + calcu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            worker obj = new worker(30000, 8, "ali", "raza");
            obj.display();

        }

    }
}
