using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class OccuranceofChar
    {
        static void Main()
        {
            string s = "jyothi is a good girl";
            List<int> ilist = new List<int>();
            char c = 'i';
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    ilist.Add(i);
                    count++;
                }
            }
            Console.WriteLine($"Char {c} is present at positions: {string.Join(", ",ilist)}");
            Console.WriteLine($"Char {c} is present at: {string.Join("; ", ilist)}");
            Console.ReadKey();
        }
    }
}
