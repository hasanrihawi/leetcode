using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.CrackingInterviews
{
    class MergeSortExample
    {
        static public void merge(int[] arr, int start, int middle, int end)
        {
            int i, j, k;
            int n1 = middle - start + 1;
            int n2 = end - middle;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[start + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[middle + 1 + j];
            }
            i = 0;
            j = 0;
            k = start;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                mergeSort(arr, start, middle);
                mergeSort(arr, middle + 1, end);
                merge(arr, start, middle, end);
            }
        }
        static void Main1(string[] args)
        {
            int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
            int n = arr.Length, i;
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            mergeSort(arr, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
