using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// helo
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // using the generic class with a double array
            Sorter<double> sort1 = new Sorter<double>();
            double[] doubleArray = { 16.8, 1.2, 17.3, 12.5, 45.7, 88.9, 13.9, 1.2, 10.2, 47.3, 101.9, 1.2 };
            sort1.BubbleSorter(doubleArray);
            sort1.Print(doubleArray);

            Console.WriteLine();

            // using the generic class with an int array
            Sorter<int> sort2 = new Sorter<int>();
            int[] intArray = { 45, 7, 23, 9, 8, 16, 74, 105, 89, -2, 1, 33 };
            sort2.BubbleSorter(intArray);
            sort2.Print(intArray);

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 
            
            
