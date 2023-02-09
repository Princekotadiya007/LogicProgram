using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the Number");
            int reverse = 0;
            int num = Convert.ToInt32(Console.ReadLine());  

            while (num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }

            Console.WriteLine("The reversed number is: " + reverse);
        }
    }
}
