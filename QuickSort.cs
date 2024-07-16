using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 4, 2 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Mang sau khi sap xep: " + string.Join(", ", arr));
            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = arr[(left + right) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);
        }
    }
}
