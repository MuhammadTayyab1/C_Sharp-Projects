using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_afternoon_evening_shift_changing
{
    class student
    {
        string name;
        int id;
        clasification type;
        public student(string n, int i, string t)
        {
            name = n;
            id = i;
            if (t == "morning")
            {
                type = new morning(t);
            }
            else if (t == "afternoon")
            {
                type = new afternoon(t);
            }
            else
            {
                type = new evening(t);
            }
        }
        public void show()
        {
            Console.WriteLine("Name  : " + name);
            Console.WriteLine("Id    : " + id);
            type.display();
        }
        public void changeshift(string get)
        {
            if (get == "morning")
            {
                type = new morning("morning");
            }
            else if (get == "afternoon")
            {
                type = new afternoon("afternoon");
            }
            else
            {
                type = new evening("evening");
            }
        }
    }
    class clasification
    {
        protected int fee;
        protected int creadithours;
        public string shift;
        public clasification(string s)
        {
            shift = s;
        }
        public void display()
        {
            Console.WriteLine("Fee     : " + fee);
            Console.WriteLine("Creadit hours : " + creadithours);
            Console.WriteLine("Shift   : " + shift);
        }
    }
    class morning : clasification
    {
        public morning(string s)
            : base(s)
        {
            fee = 15000;
            creadithours = 140;
        }
    }
    class afternoon : clasification
    {
        public afternoon(string s)
            : base(s)
        {
            fee = 17000;
            creadithours = 130;
        }
    }
    class evening : clasification
    {
        public evening(string s)
            : base(s)
        {
            fee = 20000;
            creadithours = 120;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student("Ali", 1234, "morning");
            obj.show();

            Console.WriteLine("====================");

            obj.changeshift("afternoon");
            obj.show();

            Console.WriteLine("====================");

            obj.changeshift("afternoon");
            obj.show();

            Console.WriteLine("====================");

            obj.changeshift("morning");
            obj.show();

            Console.WriteLine("====================");

            obj.changeshift("evening");
            obj.show();
        }
    }
}
