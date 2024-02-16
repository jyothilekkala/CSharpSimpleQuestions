using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class ArmstrongNumber
    {
        static void Main()
        {
            int num;
            double sum = 0;
            double rem = 0, temp = 0;
            num = 371;
            temp = num;
            while(num > 0)
            {
                rem = num % 10;
                sum = sum + Math.Pow(rem, 3);
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("NOT ARMSTRONG");
            }
            Console.ReadKey();
        }
    }
}
