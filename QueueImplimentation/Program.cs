using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueLibrary;
namespace QueueImplimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            while (true)
            {
                Console.WriteLine("Enter a choice for operation. \n \t 1.) Enqueue \n \t 2.)Dequeue.   ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter the Value that we need to insert");
                    int value = Convert.ToInt32(Console.ReadLine());
                    queue.Enqueue(value);
                }
                else if (choice == 2)
                {
                    obj.Dequeue();
                }
                else
                {
                    Console.WriteLine("Invalid Choice Please ENTER THE CORRECT choice \n \n");
                }
            }

        }
    }

}
