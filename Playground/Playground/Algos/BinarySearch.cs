using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Algos
{
    internal class BinarySearch
    {
        public bool searchRecursive(int[] array, int value2search, int leftIdx, int rightIdx)
        {
            if (leftIdx > rightIdx) {
                return false;
            }
            else
            {
                int midIdx = (leftIdx + rightIdx) / 2;
                if (value2search == array[midIdx])
                    return true;
                else if (value2search > array[midIdx])        // x is on the right side
                    return searchRecursive(array, value2search, midIdx + 1, rightIdx);
                else                               // x is on the right side
                    return searchRecursive(array, value2search, leftIdx, midIdx - 1);
                }
        }

        public bool searchIterative(int[] array, int value2search)
        {
            int leftIdx = 0;
            int rightIdx = array.Length - 1;

            // Repeat until the pointers low and high meet each other
            while (leftIdx <= rightIdx)
            {
                int mid = leftIdx + (rightIdx - leftIdx) / 2;

                if (array[mid] == value2search)
                    return true;

                if (array[mid] < value2search)
                    leftIdx = mid + 1;

                else
                    rightIdx = mid - 1;
            }

            return false;
        }
    }
}
