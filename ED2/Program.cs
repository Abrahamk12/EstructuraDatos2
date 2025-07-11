namespace ED2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo();

        // Crear personas
        Persona p1 = new Persona("P001", "Ana", 30);
        Persona p2 = new Persona("P002", "Luis", 25);
        Persona p3 = new Persona("P003", "Carlos", 40);

        // Agregar nodos al grafo
        grafo.AgregarNodo(p1);
        grafo.AgregarNodo(p2);
        grafo.AgregarNodo(p3);

        // Conectar nodos
        grafo.AgregarArista("P001", "P002", 10);
        grafo.AgregarArista("P001", "P003", 5);
        grafo.AgregarArista("P002", "P003", 2);

        // Mostrar todos los nodos y sus conexiones
        foreach (var nodo in grafo.ObtenerTodosLosNodos())
        {
            Console.WriteLine($"Persona: {nodo.Datos.Nombre}, Edad: {nodo.Datos.Edad}");
            foreach (var arista in nodo.Adyacentes)
            {
                Console.WriteLine($"  -> Conectado a: {arista.Destino.Datos.Nombre}, Peso: {arista.Peso}");
            }
        }

        // Buscar un nodo específico
        Console.WriteLine("\nBuscar nodo P002:");
        var buscado = grafo.ObtenerNodo("P002");
        if (buscado != null)
        {
            Console.WriteLine($"Nombre: {buscado.Datos.Nombre}, Edad: {buscado.Datos.Edad}");
        }
    }
}

/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/