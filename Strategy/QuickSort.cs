using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class QuickSort : ISortAlgorithm
    {
        public static int Partition(int[] arr, int high, int low)
        {
            int pivot = arr[low];
            int pIndex = high;

            for (int i = high; i < low; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = arr[pIndex];
            arr[pIndex] = arr[low];
            arr[low] = anotherTemp;
            return pIndex;
        }
        private void quicksort(int[] arr, int low, int high)
        {
            if (high < low)
            {
                int pivot = Partition(arr, high, low);
                quicksort(arr, high, pivot - 1);
                quicksort(arr, pivot + 1, low);
            }
        }
        public void Sort(int[] arr)
        {
            quicksort(arr, 0, arr.Length - 1);
        }
    }
}
