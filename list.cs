using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication310
{
    class student
    {
        public int id;
        public string name;

        public void display()
        {
            Console.WriteLine("Id : "+id);
            Console.WriteLine("Name : "+name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<student> stdlist = new List<student>()
            {
                new student(){id= 420 , name="ali"},
                new student(){id= 9211 , name="raza"}
            };

            foreach (var item in stdlist)
            {
                item.display();
            }


        }

    }
}
