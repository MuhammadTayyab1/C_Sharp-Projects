using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication291
{
    class pop
    {
        double population;
        double br;
        double dr;

        public pop(double p,double b,double d)
        {
            population = p;
            br = b;
            dr = d;
        }

        public double getbirthraate()
        {
            double getbirth = br / population;
            return getbirth;
        }
        public double getdeath()
        {
            double getdeath = dr / population;
            return getdeath;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pop obj = new pop(100000, 8000, 5000);
            double h1 = obj.getbirthraate();
            double h2 = obj.getdeath();


            Console.WriteLine("birth   :  "+h1);
            Console.WriteLine("death   :  "+h2);
           
        }
    }
}
