using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class FibonocciSeries
    {
        static void Main()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 2; i <= 10; i++)
            {
               
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }

            Console.ReadKey();
        }
    }
}
