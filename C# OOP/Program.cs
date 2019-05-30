using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication310
{
    class book
    {
        public string title;
        public string author;
        public string publisher;
        public string releasedate;
        public string ISBN;
        public void display()
        {
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(publisher);
            Console.WriteLine(releasedate);
            Console.WriteLine(ISBN);
            Console.WriteLine("=======================");
        }
    }
    
    class liberay : book
    {
        string libname;
        public static List<book> b = new List<book>();
        public liberay(string libn)
        {
            libname = libn;
        }
        public void addbook(string t, string a, string p, string r, string i)
        {
            b.Add(new book { title = t, author = a, publisher = p, releasedate = r, ISBN = i });
        }
        public void remove(string ib)
        {
            var target = b.Find((x) => x.ISBN == ib);

            if (target != null)
                b.Remove(target);
        }
        public void search(string autho)
        {
            var ser = b.Find((x) => x.author == autho);

            if (ser != null)
                ser.display();
        }
        public void show()
        {
            Console.WriteLine(libname);
            for (int i = 0; i < b.Count; i++)
            {
                b[i].display();

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            liberay obj = new liberay("Karachi Central liberary\n\n");

            obj.addbook("csharp", "robert", "stack", "2018", "1234");
            obj.addbook("java", "john", "stack", "2019", "1000");
            obj.addbook("C++", "mickel", "stack", "2015", "5550");
            obj.addbook("rust", "tom", "stack", "2013", "9087");
            obj.addbook("Linux", "ben", "stack", "2015", "8790");

            obj.show();

            // Search by author name
            Console.WriteLine("\n\nSearch");
            Console.WriteLine("*****************************************\n\n\n\n");

            obj.search("john");

            // remove by ISBN number

            Console.WriteLine("\n\nRemove data and display remaining");
            Console.WriteLine("*****************************************\n\n\n\n");
            obj.remove("5550");
            obj.remove("1000");
            obj.show();


        }

    }
}
