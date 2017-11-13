using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Sorter<T> where T : IComparable<T> 
    {
        public void BubbleSorter(T[] array)  
        {
            // variable used during swap
            T temp; 

            // for loop to control number of passes through array
            for (int i = 0; i < array.Length - 1; i++)
            {
                // for loop to control comparison between adjacent elements
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    // compare adjacent numbers, swap if the first one is greater than the second one
                    if ((array[j].CompareTo(array[j + 1]) > 0)) 
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // method to print the sorted array
        public void Print(T[] array)
        {
            Console.WriteLine("The sorted array is: ");
            foreach (T number in array)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine();
        }
    }
}
