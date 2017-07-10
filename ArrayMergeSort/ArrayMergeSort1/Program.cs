using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMergeSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. of arrays ");
            int noOfArrays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no. of elements in each array");
            int noOfElements = Convert.ToInt32(Console.ReadLine());

            int s = 0;


            int[][] arr = new int[noOfArrays][];

            int[] masterArray = new int[noOfArrays * noOfElements];


            for (int i = 0; i < noOfArrays; i++)
            {
                Console.WriteLine("Enter the " + (i + 1) + "th array");
                arr[i] = new int[noOfElements];
                for (int j = 0; j < noOfElements; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    masterArray[s] = arr[i][j];
                    s++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("The Merged Array =  \n \t");


            for (int z = 0; z < (noOfArrays * noOfElements); z++)
            {
                Console.Write(masterArray[z] + "   ");

            }
        
            Console.WriteLine(" \n \n \n \n   The Sorted Array =  \n \t ");
            int len = (noOfElements * noOfArrays);
            Sorting(masterArray, 0, len - 1);


            for (int i = 0; i < s; i++)
            {
                Console.Write(masterArray[i]+" \t ");
            }
            Console.ReadKey();

        }



        public static void JoinArray(int[] array, int left, int mid, int right)
        {
            int size = array.Length;
            int[] temp = new int[size];
            int i, leftEnd, noOfElements, temPosition;
            leftEnd = (mid - 1);
            temPosition = left;
            noOfElements = (right - left + 1);


            while ((left <= leftEnd) && (mid <= right))
            {
                if (array[left] <= array[mid])
                {
                    temp[temPosition++] = array[left++];
                }
                else
                {
                    temp[temPosition++] = array[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[temPosition++] = array[left++];
            }
            while (mid <= right)
            {
                temp[temPosition++] = array[mid++];
            }
            for (i = 0; i < noOfElements; i++)
            {
                array[right] = temp[right];
                right--;
            }

        }





        public static void Sorting(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                Sorting(numbers, left, mid);
                Sorting(numbers, (mid + 1), right);
                JoinArray(numbers, left, (mid + 1), right);

            }

        }
    }

}
