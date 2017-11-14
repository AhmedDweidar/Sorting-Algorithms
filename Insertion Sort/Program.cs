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
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
