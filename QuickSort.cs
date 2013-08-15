using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public static class QuickSort
    {
        static public List<int> Sort(List<int> list)
        {
            if (list.Count < 2)
                return list;

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            int pivot = list[list.Count / 2];
            list.Remove(pivot);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < pivot)
                {
                    leftList.Add(list[i]);
                }
                else
                {
                    rightList.Add(list[i]);
                }
            }

            // Concatanate
            list = Sort(leftList);
            list.Add(pivot);
            list.AddRange(Sort(rightList));

            return list;
        }
    }
}
