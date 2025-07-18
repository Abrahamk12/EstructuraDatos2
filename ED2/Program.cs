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
                // Crear personas con cantidad fija
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
                // Crear personas con cantidad dinámica
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
                    }
                }
                break;
        }

        // Crear relaciones aleatorias entre las personas
        CrearRelacionesAleatorias(grafo);

        // Mostrar nodos y conexiones
        foreach (var nodo in grafo.ObtenerTodosLosNodos())
        {
            Console.WriteLine($"\nPersona: {nodo.Datos.Nombre}, Edad: {nodo.Datos.Edad}");
            foreach (var arista in nodo.Adyacentes)
            {
                Console.WriteLine($"  -> Conectado a: {arista.Destino.Datos.Nombre}, Peso: {arista.Peso}");
            }
        }
    }

    static void CrearRelacionesAleatorias(Grafo grafo)
    {
        Random rand = new Random();
        var nodos = new List<Nodo>(grafo.ObtenerTodosLosNodos());

        for (int i = 0; i < nodos.Count; i++)
        {
            int relaciones = rand.Next(1, nodos.Count); // Número aleatorio de conexiones
            HashSet<string> conectados = new HashSet<string>();

            for (int j = 0; j < relaciones; j++)
            {
                int indiceAleatorio = rand.Next(nodos.Count);

                if (indiceAleatorio != i && !conectados.Contains(nodos[indiceAleatorio].Datos.Id))
                {
                    int peso = rand.Next(1, 11); // Peso entre 1 y 10
                    grafo.AgregarArista(nodos[i].Datos.Id, nodos[indiceAleatorio].Datos.Id, peso);
                    conectados.Add(nodos[indiceAleatorio].Datos.Id);
                }
            }
        }
    }
}