using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Fibonacci, \n2 PerfactNumber");
            Console.WriteLine("choose the option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.fibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.perfect();
                    break;
                default:
                    Console.WriteLine("choose the option");
                    break;
            }
        }
    }
}
