using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePractice
{
    public class TableMultiplication
    {
        static void Main()
        {
            int a = 5;
            int i = 1;
            while(i <= 10){
                Console.WriteLine(a + "*" + i +": " + a*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
