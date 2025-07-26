namespace ED2;
using System;
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"{Nombre} ({Edad} años)";
    }
}

class Program
{
    static void QuickSort(Persona[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(Persona[] array, int left, int right)
    {
        Persona pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (string.Compare(array[j].Nombre, pivot.Nombre, StringComparison.OrdinalIgnoreCase) <= 0)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(Persona[] array, int a, int b)
    {
        Persona temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void Main()
    {
        Persona[] personas = {
            new Persona { Nombre = "Carlos", Edad = 30 },
            new Persona { Nombre = "Ana", Edad = 25 },
            new Persona { Nombre = "Luis", Edad = 28 },
            new Persona { Nombre = "Beatriz", Edad = 35 }
        };

        Console.WriteLine("Lista original:");
        foreach (var p in personas)
            Console.WriteLine(p);

        QuickSort(personas, 0, personas.Length - 1);

        Console.WriteLine("\nLista ordenada por nombre:");
        foreach (var p in personas)
            Console.WriteLine(p);
    }
}
