using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Sorter<T> where T : IComparable<T> 
    {
        public void SelectionSort(T[] array)
        {
            T temp; // temp variable used during swap
            int minPosition; // index of the minimum element

            // controls passes through array
            for (int i = 0; i < array.Length - 1; i++)
            {
                minPosition = i; // set the min element at the current i position

                // loop through the array and check for smaller element
                for (int j = i + 1; j < array.Length; j++)
                {
                    // if element at j is smaller than the current min, update min
                    if ((array[j].CompareTo(array[minPosition]) < 0))
                    {
                        minPosition = j;
                    }
                }

                // swap the element at min position with i
                temp = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temp;
            }
        }

        // method to print the sorted array
        public void Print(T[] array)
        {
            Console.WriteLine("The sorted array is: ");
            foreach (T number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
