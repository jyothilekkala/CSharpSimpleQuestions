using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class StringSort
    {
        static void Main()
        {
            string s = "Jyothi123";
            var numbers = new List<char>();
            var uppers = new List<char>();
            var lowers = new List<char>();

            var charArray = s.ToCharArray();

            foreach (char c in charArray)
            {
                if (char.IsDigit(c))
                {
                    numbers.Add(c);
                }

                if (char.IsUpper(c))
                {
                    uppers.Add(c);
                }

                if (char.IsLower(c))
                {
                    lowers.Add(c);
                }
            }

            numbers.Sort();
            uppers.Sort();
            lowers.Sort();
            var sortedString = string.Join("", numbers.Concat(uppers).Concat(lowers));

            Console.WriteLine(sortedString);
            Console.ReadLine();

        }
    }
}
