using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sort
{
    public static class MergeSort
    {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count == 1)
                return list;

            int sizeLeft = list.Count / 2;
            int sizeRight = list.Count - sizeLeft;

            List<int> leftList = list.GetRange(0, sizeLeft);
            List<int> rightList = list.GetRange(sizeLeft, sizeRight);

            Sort(leftList);
            Sort(rightList);

            int li = 0;
            int ri = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (li >= leftList.Count)
                {
                    list[i] = rightList[ri];
                    ri++;
                    continue;
                }
                if (ri >= rightList.Count)
                {
                    list[i] = leftList[li];
                    li++;
                    continue;
                }

                if (leftList[li] < rightList[ri])
                {
                    list[i] = leftList[li];
                    li++;
                }
                else
                {
                    list[i] = rightList[ri];
                    ri++;
                }
            }
            return list;
        }
    }
}
