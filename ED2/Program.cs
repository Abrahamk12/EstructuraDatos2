namespace ED2;
using System;
using System.Collections;

class Program
{
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void Main()
    {
        int[] data = { 8, 3, 1, 7, 0, 10, 2 };
        Console.WriteLine("Original array: " + string.Join(", ", data));

        QuickSort(data, 0, data.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", data));
    }
}
