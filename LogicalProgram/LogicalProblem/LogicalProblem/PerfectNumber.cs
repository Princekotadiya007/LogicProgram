using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PerfectNumber
    {
        public void perfect()
        {
            int number;
            Console.WriteLine("enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number / 2; i++) //6/3=2 
            {
                if (number % i == 0)
                {
                    sum += i;
                }
                if (sum == number)
                {
                    Console.WriteLine("ture");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
