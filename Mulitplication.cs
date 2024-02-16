using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class Mulitplication
    {
        static void Main()
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            d = a * b * c;

            Console.WriteLine(d);

            Console.ReadLine();
        }
      
    }
}
