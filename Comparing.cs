using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class Comparing
    {
        static void Main()
        {
            int a = 2;
            int b = 2;
            int c = 2;
            int count = 0;
            count =  (a== b && b == c && c == a) ? 3 : (a != b && b != c && c != a) ? 0 : 2;
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
