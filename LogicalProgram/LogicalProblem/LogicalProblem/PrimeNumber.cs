using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter a number to check if it is prime: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine(n + " is not a prime number.");
                return;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime number.");
                    return;
                }
            }

            Console.WriteLine(n + " is a prime number.");
        }
    }
}
