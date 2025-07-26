namespace ED2;
using System;

using System;

class Program
{
    static void QuickSort(string[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(string[] array, int left, int right)
    {
        string pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (string.Compare(array[j], pivot, StringComparison.OrdinalIgnoreCase) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(string[] array, int a, int b)
    {
        string temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void Main()
    {
        string[] data = { "Manzana", "pera", "Banana", "kiwi", "uva", "Durazno" };
        Console.WriteLine("Arreglo original: " + string.Join(", ", data));

        QuickSort(data, 0, data.Length - 1);

        Console.WriteLine("Arreglo ordenado: " + string.Join(", ", data));
    }
}
