using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class Average
    {
        static void Main()
        {
            int a, b, c, d;
            Console.Write("Enter 1st number:");
            a = int.Parse(Console.ReadLine());
            b  = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            double avg = (a + b+c+d) / 4;
            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}
