using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class CouponNumber
    {
        public void Coupon()
        {
            var numbers = "0123456789ABCDEFGHIJKMNOPQRST";
            var array = new char[6];
            var random = new Random();
            for (int i = 0; i < array.length; i++)
            {
                array[i] = numbers[random.Next(numbers.length)];
            }
            var finalString = new String(array);
            Console.WriteLine("The distinct coupon number is: " + finalString);
            Console.ReadLine();
        }
    }
}
