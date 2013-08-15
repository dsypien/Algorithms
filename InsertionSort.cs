using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Algorithms.Sort
{
    public static class InsertionSort
    {
        public static List<int> Sort (List<int> list)
        {
            for (int i = 1; i < list.Count ; i++)
            {
                int key = list[i];

                for (int j = i -1 ; j >= 0 && key < list[j]  ; j--)
                {
                    int temp = list[j];
                    list[j] = key;
                    list[j + 1] = temp;
                }
            }

            return list;
        }
    }
}
