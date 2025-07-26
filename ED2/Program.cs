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
    private int Hashfunction(int key)
    {
        return key % size;
    }

    public void Insert(int key, string _value)
    {
        int index = Hashfunction(key);
        table[index].Add(new KeyValuePair<int, string>(key, _value));
    }
    public string Search(int key)
    {
        int index = Hashfunction(key);
        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }
        return null;
    }
    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Index {i}: ");
            foreach (var pair in table[i])
            {
                Console.Write($"[{pair.Key}, {pair.Value}] ");
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
        ht.Insert(0, "patata");
        ht.Insert(1, "One");
        ht.Insert(2, "Two");
        ht.Insert(9, "Twelve");

        ht.Display();
    }
}

/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/