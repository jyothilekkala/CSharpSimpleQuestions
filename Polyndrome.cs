using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class Polyndrome
    {
        static void Main()
        {
            int num = 12121;
            int rem = 0;
            int temp = num;
            double sum = 0;

            while(temp > 0)
            {
                rem = temp % 10;
                sum = sum*10 + rem;
                temp = temp / 10;
            }
            if(sum == num)
            {
                Console.WriteLine("Palindrome");
            }
            Console.ReadKey();
        }
    }
}
