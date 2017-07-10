using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FactorialTrailingZero
{
    class Factoring
    {
        static void Main(string[] args)
        {
            Con obj = new Con();
            Console.WriteLine("Enter the number");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the base of the value");
            int b = Convert.ToInt16(Console.ReadLine());

            obj.BaseToDecimal(number,b);
        }
    }
}
