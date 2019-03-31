using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloading
{
    class point
    {
        int x;
        int y;
        public point()
        {
            x = 0;
            y = 0;
        }
        public point(int a, int b)
        {
            x = a;
            y = b;
        }
        public static point operator +(point p1, point p2)
        {
            point p = new point();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;

            return p;
        }
        public void show()
        {
            Console.WriteLine("X = " + x + "        Y = " + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            point q = new point(2, 2);
            point w = new point(2, 2);

            point sum = q + w;

            sum.show();

        }
    }
}
