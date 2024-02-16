using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    public class NumberPattern
    {
        static void Main()
        {
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            string s = "jyothi";
            string s1 = "";

            for (int i = s.Length-1; i>=0; i--)
            {
                s1 = s1 + s[i];
            }
            Console.WriteLine(s1);
            Console.ReadKey();

            int n1 = 12321;
            int rem = 0;
            int temp = n1;
            int sum = 0;
            for (int i = 0; temp > 0; i++)
            {
                rem = temp % 10;
                temp = temp / 10;
                sum = sum * 10 + rem;
            }
            if(sum == n1)
            {
                Console.WriteLine("Same");
            }
            Console.ReadKey();
        }
    }
}
