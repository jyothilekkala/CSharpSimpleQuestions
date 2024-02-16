using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    internal class SecondLargestNumber
    {
        static void Main()
        {
            int[] ar = { 9, 22, 19, 1, 2, 3, 4, 5, 6 };
            int max1 = ar[0];
            int max2 = ar[0];
            
            for (int i = 0; i < ar.Length; i++)
            {
                if(ar[i] > max1)
                {
                    max2 = max1;
                    max1 = ar[i];                   
                }
                else if (ar[i] > max2)
                {
                    max2 = ar[i];
                }
            }
            Console.WriteLine(max2);
            Console.ReadKey();
        }
    }
}
