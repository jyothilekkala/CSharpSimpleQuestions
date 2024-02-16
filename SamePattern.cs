using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class SamePattern
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", a);
                Console.WriteLine("{0}{0}{0}{0}", a);
            }
            Console.ReadLine();
        }
    }
}
