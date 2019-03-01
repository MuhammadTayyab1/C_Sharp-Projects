using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication280
{
    class Program
    {
        static void Main(string[] args)
        {

            

            RNGCryptoServiceProvider saltCellar1 = new RNGCryptoServiceProvider();
            byte[] salt1 = new byte[24];
            saltCellar1.GetBytes(salt1);
            Console.WriteLine("ENTER any number");
            String enter = Console.ReadLine();

            Rfc2898DeriveBytes hashTool1 = new Rfc2898DeriveBytes(enter, salt1);
            hashTool1.IterationCount = 1000;
            byte[] hash1 = hashTool1.GetBytes(24);
            string get = "";
            for (int i = 0; i < 24; i++)
            {
                get += hash1[i];
            }
            Console.WriteLine(get);

            
           
           
        }
    }
}
