namespace ED2;
using System;

class Programa
{
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo();

        grafo.AgregarArista("A", "B", 4);
        grafo.AgregarArista("A", "C", 2);
        grafo.AgregarArista("B", "C", 5);
        grafo.AgregarArista("B", "D", 10);
        grafo.AgregarArista("C", "E", 3);
        grafo.AgregarArista("E", "D", 4);
        grafo.AgregarArista("D", "F", 11);

        grafo.MostrarGrafo();

        Console.WriteLine();
        grafo.BFS("A");

        Console.WriteLine();
        grafo.DFS("A");

        Console.WriteLine();
        grafo.Dijkstra("A");
    }
}

/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/