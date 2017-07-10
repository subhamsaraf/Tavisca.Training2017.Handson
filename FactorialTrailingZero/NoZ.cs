using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZero
{
    public class NoZ
    {
        public void NumberOfZero(double number)
        {
            int c = 0;
            while(number%10==0)
            {
                c++;
                number /= 10;
            }
            Console.WriteLine("The number of Zero's = " + c);
            Console.ReadKey(true);
        }

    }
}
