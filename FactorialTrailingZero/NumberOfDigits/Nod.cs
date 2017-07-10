using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberOfZero;
namespace NumberOfDigits
{

    public class Nod
    {

        public void NumberOfDigits(double number)
        {
            NoZ obj = new NoZ();
            int length = 1;
            while ((number /= 10) >= 1)
            {

                length++;
            }
            obj.NumberOfZero(number, length);

        }
    }
}