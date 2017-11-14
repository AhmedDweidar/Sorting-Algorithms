using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Sorter<T> where T : IComparable<T> 
    {
        public void InsertionSorter(T[] array)
        {
            T temp;

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && (array[j].CompareTo(array[j - 1]) < 0))
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }

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
