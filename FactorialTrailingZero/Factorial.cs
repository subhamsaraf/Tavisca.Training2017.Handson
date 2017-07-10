using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZero
{
    public class Fact
    {
        DeC obj = new DeC();
        public void Facto(double number, int b)
        {
            DeC obj = new DeC();
            double factorial=1;
            int d = (int)number;
            for(int i=1;i<=d;i++)
            {
                factorial = factorial * i;
            }
            obj.De(factorial, b);

             
        }
    }
}
