
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a (1)string\n(2)boolean\n(3)integer\n(4)decimal");
            {
                int choice = DataTypeParser.ParseInt(Console.ReadLine());
                Console.WriteLine("Give your input");
                string inp = Console.ReadLine();
                switch (choice)
                {
                    case 1:
                        Input.Print(inp);
                        break;
                    case 2:
                        Input.Print(DataTypeParser.Parse<bool>(inp));
                        break;
                    case 3:
                        Input.Print((int)DataTypeParser.Parse(inp, DataType.Int));
                        break;
                    case 4:
                        Input.Print((decimal)DataTypeParser.Parse(inp, DataType.Decimal));
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }

    class Input
    {
        public static void Print(string inp)
        {
            Console.WriteLine(inp);
        }
        public static void Print(int inp)
        {
            Console.WriteLine(inp);
        }
        public static void Print(bool inp)
        {
            Console.WriteLine(inp);
        }
        public static void Print(decimal inp)
        {
            Console.WriteLine(inp);
        }
    }


}
