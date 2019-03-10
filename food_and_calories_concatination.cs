using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication289
{
    class meal
    {
        string name;
        int calorie;

        public meal()
        {
            name = "Pizza";
            calorie = 800;
        }
        public meal(string n,int c)
        {
            name = n;
            calorie += c;
        }
        public static meal operator +(meal p1,meal p2)
        {
            meal p = new meal();
            p.name = Convert.ToString(p1.name + "  " + p2.name);
            p.calorie = p1.calorie + p2.calorie;
            return p;
        }
        public void show()
        {
            Console.WriteLine("your food items");
            Console.WriteLine(name);
            Console.WriteLine("contain calories");
            Console.WriteLine(calorie);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            meal breakfast = new meal("beef burger", 998);
            meal lunch = new meal("chicken roll", 1200);
            

            meal obj2 = breakfast + lunch;
            obj2.show();
            
        }
    }
}