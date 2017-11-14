using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter<int> sort = new Sorter<int>();
            int[] numbers = { 105, 6, 24, 78, 0, -5, 12, 3 };

            sort.InsertionSorter(numbers);
            sort.Print(numbers);
            Console.WriteLine();

            Sorter<double> sort2 = new Sorter<double>();
            double[] numbers2 = { -6.5, 2.9, 102.36, 45.3, 0.2, 29.3, 78.1 };

            sort2.InsertionSorter(numbers2);
            sort2.Print(numbers2);

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
