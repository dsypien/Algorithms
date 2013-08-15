using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.Sort;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedList = GetUnsortedList();

            var insertionSortResult = InsertionSort.Sort(unsortedList);
            var mergeSortResult = MergeSort.Sort(unsortedList);
            var quickSortResult = QuickSort.Sort(unsortedList);
            Console.WriteLine("blah");
        }

        static private List<int> GetUnsortedList(int length = 10)
        {
            List<int> list = new List<int>();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(0,250));
            }

            return list;
        }
    }
}
