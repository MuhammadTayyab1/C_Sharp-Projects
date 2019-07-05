using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_interface
{

    // C# not support multiple inhertance 
    // but C# support multiple interface
    
    interface A
    {

        // not use public with functions
        // data members not allow in interface
        // constructor not allow
        // destructor not allow
        // non abstract functions not allow
        // it's by default create abstract functions
        void p1();
    }
    
    interface B
    {
        void p2();
    }
    
    class my:B,A
    {
        public void p1()
        {
            Console.WriteLine("p1");
        }
        public void p2()
        {
            Console.WriteLine("p2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            my obj = new my();
            obj.p1();
            obj.p2();
       
        }
    }
}
