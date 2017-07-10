using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactorialTrailingZero
{
    public class DeC
        {
        public void De(double factorial, int b)
        {
            NoZ obj = new NoZ();
            int temp;
            string rem = "";
            int f = (int)factorial;
            while (f >= 1)
            {
                temp = f / b;
                rem += (f % b).ToString();
                f = temp;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
           double d = double.Parse(bin);
            Console.WriteLine("The Factorial of Entered Number = " + d );
            Console.WriteLine(" ");
            obj.NumberOfZero(d);

        }
    }
}

