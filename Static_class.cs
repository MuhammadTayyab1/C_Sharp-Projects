using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication287
{
    static class my
    {
        // Static text only have static variables
        static int a = 10;
        static int b = 87;

        // Static class cannot have instance constructor
        // static class have static constructor and call only one time during excecute
        static my()
        {
            a = 90;
            Console.WriteLine("Constructor call ");
            Console.WriteLine(a);
        }

        // Static have not constructor overloading
        // static my(int p) { Console.WriteLine(a);}


        // Static have no destructor
        // ~my() {   }


        // Static class have only static functions and methods
        public static void add(int q, int w)
        {
            a = q;
            b = w;
        }
        
        public static void show()
        {
            Console.WriteLine("Sum : " + (a + b));
        }

    }

    // static class have no inheritence
    //  static class B:my {    }
    class Program
    {
        static void Main(string[] args)
        {
            // static class have no object
            // constructor call only one timeduring excecute

            my.add(1, 2);
            my.show();

            my.add(2, 2);
            my.show();

            my.add(87, 87);
            my.show();

            my.add(91, 91);
            my.show();
        }
    }
}
