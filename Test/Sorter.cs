using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// hello world
namespace MaxMin
{
    class Sorter<T> where T : IComparable<T>
    {
        public T FindMax(T[] array)
        {
            T max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i].CompareTo(max)) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public T FindMin(T[] array)
        {
            T min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i].CompareTo(min)) < 0)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
