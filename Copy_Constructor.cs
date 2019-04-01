using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copycontrustor
{

    class data
    {
        string name;
        int id;

        // original construstor
        public data(string n,int i)
        {
            name = n;
            id = i;
        }

        // copy construstor 
        public data(data a)
        {
            name = a.name;
            id = a.id;
        }
        public void show()
        {
            Console.WriteLine("Name   : "+name);
            Console.WriteLine("Id     : "+id);
            Console.WriteLine("--------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // original
            data obj = new data("ali", 1234);
            obj.show();

            // copy 
            data copy = new data(obj);
            copy.show();

        }
    }
}
