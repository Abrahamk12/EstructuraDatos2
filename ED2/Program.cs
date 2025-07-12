namespace ED2;
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string nombre, continuar, opcion;
        int j = 0, id = 0, edad;

        Grafo grafo = new Grafo();
        Console.WriteLine("Seleccione una opción: 1 para 5 datos, 2 para n datos");
        opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                // Crear personas
                Persona[] personas = new Persona[5];
                for (int i = 0; i < personas.Length; i++)
                {
                    Console.Write("Ingrese el nombre de la persona: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad de la persona: ");
                    edad = int.Parse(Console.ReadLine());
                    personas[i] = new Persona(id.ToString(), nombre, edad);
                    grafo.AgregarNodo(personas[i]);
                    id++;
                    
                }
                break;
            case "2":
                ArrayList personasN = new ArrayList();
                while (true)
                {
                    Console.Write("Ingrese el nombre de la persona: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad de la persona: ");
                    edad = int.Parse(Console.ReadLine());
                    personasN.Add(new Persona(id.ToString(), nombre, edad));
                    grafo.AgregarNodo(personasN[j] as Persona);
                    Console.Write("¿Desea agregar otra persona? (s/n): ");
                    if (Console.ReadLine().ToLower() != "s")
                    {
                        break;
                    }
                    else
                    {
                        id++;
                        j++;
                            foreach (var nodo in grafo.ObtenerTodosLosNodos())
                            {
                                Console.WriteLine($"Persona: {nodo.Datos.Nombre}, Edad: {nodo.Datos.Edad}");
                                foreach (var arista in nodo.Adyacentes)
                                {
                                    Console.WriteLine($"  -> Conectado a: {arista.Destino.Datos.Nombre}, Peso: {arista.Peso}");
                                }
                            }
                    }
                    
                }
                break;
        }
        
        // Agregar nodos al grafo
        /*
        grafo.AgregarNodo(p1);
        grafo.AgregarNodo(p2);
        grafo.AgregarNodo(p3);
        */
        // Conectar nodos
        /*
        grafo.AgregarArista("P001", "P002", 10);
        grafo.AgregarArista("P001", "P003", 5);
        grafo.AgregarArista("P002", "P003", 2);
        */
        // Mostrar todos los nodos y sus conexiones
        foreach (var nodo in grafo.ObtenerTodosLosNodos())
        {
            Console.WriteLine($"Persona: {nodo.Datos.Nombre}, Edad: {nodo.Datos.Edad}");
            foreach (var arista in nodo.Adyacentes)
            {
                Console.WriteLine($"  -> Conectado a: {arista.Destino.Datos.Nombre}, Peso: {arista.Peso}");
            }
        }
    }
}

/*

Desde la terminal, en la carpeta del proyecto:
dotnet build - copilar
dotnet run - ejecutar

*/