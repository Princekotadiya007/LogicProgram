using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Fibonacci
    {
        public void fibonacciSeries()
        {
            Console.WriteLine("Enter the number of terms in the series: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1, next;

            Console.WriteLine("The first {0} terms of the Fibonacci series are: ", n);

            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine(next);
            }

            Console.ReadLine();
        }
    }
}
