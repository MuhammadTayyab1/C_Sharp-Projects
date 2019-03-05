using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication283
{
    class BankAccount
    {
        private int accnum;
        private float accbal;
        static float annualinterest = 0.03f;

        public void  enterAccountData(out int an,out float bal)
        {
            an = 0;  bal = 0;
            for (; ; )
            {
                Console.WriteLine("Enter account number");
                int acno = int.Parse(Console.ReadLine());

                if (acno < 0 || acno < 1000)
                {
                    continue;
                }
                else
                {
                    accnum = acno;
                    break;
                }
            }
            for (; ; )
            {
                Console.WriteLine("Enter account Balance");
                int tbal = int.Parse(Console.ReadLine());
                if (tbal < 0)
                {
                    continue;
                }
                else
                {
                    accbal = tbal;
                    break;
                }
            }
        }
        public void computeInterest(int y)
        {
            Console.WriteLine("         Annual interest report\n");
            float endbal=accbal;

            for (int i = 1; i <= y; i++)
            {
                float interst = endbal * annualinterest * i;
                float hold = accbal + interst;
                endbal = hold;
                Console.WriteLine("Ending balance in year "+i+" Rs : " + hold);
            }
        }

        public void show()
        {
            Console.WriteLine("             Bank limited       ");
            Console.WriteLine("      Account number  : "+accnum);
            Console.WriteLine("      Opening balance : "+accbal);
            Console.WriteLine(" =========================================");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter account number not less then 1000 and negative balance not allow interest rate is 3 % annual fix");
            
            int accno;
            float balacc;

            BankAccount obj = new BankAccount();
            obj.enterAccountData(out accno,out balacc);
            Console.WriteLine("enter years");
            int year = int.Parse(Console.ReadLine());
            obj.show();
            obj.computeInterest(year);
            
        }
    }
}
