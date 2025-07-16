namespace ED2;
using System;
using System.Collections;


class HashTable
{
    private int size;
    private List<KeyValuePair<int, string>>[] table;

    public HashTable(int size)
    {
        this.size = size;
        table = new List<KeyValuePair<int, string>>[size];
        for (int i = 0; i < size; i++)
        {
            table[i] = new List<KeyValuePair<int, string>>();
        }
    }

    // Función hash simple
    private int HashFunction(int key)
    {
        return key % size;
    }

    // Insertar clave-valor
    public void Insert(int key, string value)
    {
        int index = HashFunction(key);
        table[index].Add(new KeyValuePair<int, string>(key, value));
    }

    // Buscar valor por clave
    public string Search(int key)
    {
        int index = HashFunction(key);
        foreach (var pair in table[index])
        {
            if (pair.Key == key)
                return pair.Value;
        }
        return null;
    }

    // Mostrar tabla
    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Índice {i}: ");
            foreach (var pair in table[i])
            {
                Console.Write($"[{pair.Key} : {pair.Value}] ");
            }
            Console.WriteLine();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        HashTable ht = new HashTable(10);

        ht.Insert(15, "Juan");
        ht.Insert(25, "Ana");
        ht.Insert(35, "Luis");
        ht.Insert(5, "Carlos");

        ht.Display();

        Console.WriteLine("\nBuscar clave 25: " + ht.Search(25));
    }
}

/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/