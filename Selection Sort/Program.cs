using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorter<double> sort = new Sorter<double>();
            double[] doubleArray = { 16.8, 1.2, 17.3, 12.5, -7.2, 45.7, 1.3, 88.9, 1.2, 10.2, -5.8, 47.3, 101.9, 1.2 };
            sort.SelectionSort(doubleArray);
            sort.Print(doubleArray);

            Console.WriteLine();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
