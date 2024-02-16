using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class IndividualCalculation
    {
        static void Main()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int f = (a + b) * c;
            int z = a*b + b*c;

            Console.WriteLine(f);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
