using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class ReverseaString
    {
        static void Main()
        {
            string s = "Jyothi";
            string rev = "";
            int l = s.Length - 1;
            for(int i = l; i>=0; i--)
            {
                rev = rev + s[i];
            }

            Console.WriteLine(rev);
            Console.ReadKey();
        }
    }
}
