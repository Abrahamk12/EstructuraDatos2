using System;
using System.Collections.Generic;

namespace ED2
{
    public class Arista
    {
        public string Destino { get; set; }
        public int Peso { get; set; }

        public Arista(string destino, int peso)
        {
            Destino = destino;
            Peso = peso;
        }
    }

    public class Grafo
    {
        private Dictionary<string, List<Arista>> adyacencias;

        public Grafo()
        {
            adyacencias = new Dictionary<string, List<Arista>>();
        }

        public void AgregarVertice(string vertice)
        {
            if (!adyacencias.ContainsKey(vertice))
                adyacencias[vertice] = new List<Arista>();
        }

        public void AgregarArista(string origen, string destino, int peso)
        {
            AgregarVertice(origen);
            AgregarVertice(destino);
            adyacencias[origen].Add(new Arista(destino, peso));
        }

        public void MostrarGrafo()
        {
            foreach (var vertice in adyacencias)
            {
                Console.Write($"{vertice.Key} -> ");
                foreach (var arista in vertice.Value)
                {
                    Console.Write($"({arista.Destino}, {arista.Peso}) ");
                }
                Console.WriteLine();
            }
        }

        public void BFS(string inicio)
        {
            var visitados = new HashSet<string>();
            var cola = new Queue<string>();
            cola.Enqueue(inicio);

            Console.WriteLine("Recorrido BFS:");
            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();
                if (!visitados.Contains(actual))
                {
                    Console.WriteLine(actual);
                    visitados.Add(actual);
                    foreach (var vecino in adyacencias[actual])
                        cola.Enqueue(vecino.Destino);
                }
            }
        }

        public void DFS(string inicio)
        {
            var visitados = new HashSet<string>();
            Console.WriteLine("Recorrido DFS:");
            DFSRecursivo(inicio, visitados);
        }

        private void DFSRecursivo(string actual, HashSet<string> visitados)
        {
            if (visitados.Contains(actual)) return;

            Console.WriteLine(actual);
            visitados.Add(actual);

            foreach (var vecino in adyacencias[actual])
                DFSRecursivo(vecino.Destino, visitados);
        }

        public void Dijkstra(string inicio)
        {
            var distancias = new Dictionary<string, int>();
            var predecesores = new Dictionary<string, string>();
            var colaPrioridad = new SortedSet<(int, string)>();

            foreach (var vertice in adyacencias.Keys)
                distancias[vertice] = int.MaxValue;

            distancias[inicio] = 0;
            colaPrioridad.Add((0, inicio));

            while (colaPrioridad.Count > 0)
            {
                var (dist, actual) = colaPrioridad.Min;
                colaPrioridad.Remove(colaPrioridad.Min);

                foreach (var arista in adyacencias[actual])
                {
                    int nuevaDist = dist + arista.Peso;
                    if (nuevaDist < distancias[arista.Destino])
                    {
                        colaPrioridad.Remove((distancias[arista.Destino], arista.Destino));
                        distancias[arista.Destino] = nuevaDist;
                        predecesores[arista.Destino] = actual;
                        colaPrioridad.Add((nuevaDist, arista.Destino));
                    }
                }
            }

            Console.WriteLine("Distancias mínimas desde " + inicio + ":");
            foreach (var kvp in distancias)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
