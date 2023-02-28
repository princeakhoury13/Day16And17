using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16And17
{
    public static class Sorting
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];

            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (int x = left; x <= right; x++)
            {
                arr[x] = temp[x];
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}


