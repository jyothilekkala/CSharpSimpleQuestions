using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class NoofWords
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int count = 0;
            
            string[] spl = s.Trim().Split(' ');

            Console.WriteLine(spl.GetLength(0));

            //no.of characters
            foreach (char c in s) 
            {
                if (c != ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadKey();


        }
    }
}
