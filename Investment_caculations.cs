using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class investment
    {
        float initialval;
        float currentval;
        float profit;
        float percentprofit;

        public investment(float ini, float curr)
        {
            initialval = ini;
            currentval = curr;

            profit = currentval - initialval;
            percentprofit = profit / currentval * 100;
        }
        public void display1()
        {
            Console.WriteLine("initial val = " + initialval);
            Console.WriteLine("Current val = " + currentval);
            Console.WriteLine("Profit      = " + profit);
            Console.WriteLine("Percent profit = " + percentprofit + "%");
        }
    }
    class house : investment
    {
        string streetaddress;
        float sqfeet;


        public house(string stadd, float sqf, float ini, float curr)
            : base(ini, curr)
        {
            streetaddress = stadd;
            sqfeet = sqf;
        }
        public void display2()
        {
            display1();
            Console.WriteLine("Street address = " + streetaddress);
            Console.WriteLine("Sq feet        = " + sqfeet);
        }
    }
    class HouseThatIsAnInvestment : house
    {
        public HouseThatIsAnInvestment(string stadd, float sqf, float ini, float curr) : base(stadd, sqf, ini, curr) { }
        public void display3()
        {
            display2();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            HouseThatIsAnInvestment obj = new HouseThatIsAnInvestment("Karachi korangi", 190, 2000000, 2200000);
            obj.display3();
        }
    }
}


