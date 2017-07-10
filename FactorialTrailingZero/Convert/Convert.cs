using System;
using Factorial;

namespace ConvertToDecimal
{
    public class Con
    {
        public void BaseToDecimal(double value, int b)
        {
            Fact obj = new Fact();
            double dec = 0;
            int x = (int)value;
            int i = 0;
            while(x>0)
            {
                double temp = x % 10;
                double d = Math.Pow(b, i);
                double temp1 = d * temp;
                dec = dec + temp1;
                x = x / 10;
                i++;
            }
            obj.Facto(dec, b);
        }
      
    }
}
