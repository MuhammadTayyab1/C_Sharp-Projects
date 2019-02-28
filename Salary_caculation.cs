using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myprogram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter salary");
            float salary = float.Parse(Console.ReadLine());
            float tax;
            float rent;
            float expences;
            float savings;

            if (salary < 15000)
            {
                tax = salary * 0.08f;
                rent = salary * 0.19f;
                expences = salary * 0.40f;
                savings = (salary) - (tax + rent + expences);
            }
            else if(salary > 15000 && salary <=35000)
            {
                tax = salary * 0.10f;
                rent = salary * 0.20f;
                expences = salary * 0.45f;
                savings = (salary) - (tax + rent + expences);
            }
            else if (salary > 35000 && salary <= 50000)
            {
                tax = salary * 0.14f;
                rent = salary * 0.20f;
                expences = salary * 0.45f;
                savings = (salary) - (tax + rent + expences);
            }
            else if (salary > 50000 && salary <= 100000)
            {
                tax = salary * 0.18f;
                rent = salary * 0.20f;
                expences = salary * 0.47f;
                savings = (salary) - (tax + rent + expences);
            }
            else
            {
                tax = salary * 0.20f;
                rent = salary * 0.25f;
                expences = salary * 0.47f;
                savings = (salary) - (tax + rent + expences);
            }
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Total Salary  Rs = "+salary);
            Console.WriteLine("Tax           Rs = "+tax);
            Console.WriteLine("Rent          Rs = "+rent);
            Console.WriteLine("Expences      Rs = "+expences);
            Console.WriteLine("Savings       Rs = "+savings);
            Console.WriteLine("========================================");
        }
    }
}
