namespace ED2;
using System;

class Programa
{
    static void Main(string[] args)
    {
        // Crear nodos
        Nodo raiz = new Nodo("A");
        Nodo b = new Nodo("B");
        Nodo c = new Nodo("C");
        Nodo d = new Nodo("D");
        Nodo e = new Nodo("E");
        Nodo f = new Nodo("F");

        // Construir el árbol
        raiz.AgregarHijo(b);
        raiz.AgregarHijo(c);
        b.AgregarHijo(d);
        b.AgregarHijo(e);
        c.AgregarHijo(f);

        // Imprimir estructura del árbol
        Console.WriteLine("Estructura del árbol:");
        raiz.Imprimir();

        Console.WriteLine("Recorrido Preorden:");
        raiz.RecorridoPreorden();

        Console.WriteLine("\nRecorrido Postorden:");
        raiz.RecorridoPostorden();

        Console.WriteLine("\nRecorrido por Niveles:");
        raiz.RecorridoPorNiveles();

        
        // Crear árbol binario
        NodoBinario raizNB = new NodoBinario("B");
        raizNB.Izquierdo = new NodoBinario("A");
        raizNB.Derecho = new NodoBinario("C");

        Console.WriteLine("Recorrido Inorden:");
        raizNB.RecorridoInorden();// Salida esperada: A B C


    }
}
/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/