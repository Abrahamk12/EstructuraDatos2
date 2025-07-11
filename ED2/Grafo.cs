namespace ED2;
using System.Collections.Generic;

public class Grafo
{
    private Dictionary<string, Nodo> nodos;

    public Grafo()
    {
        nodos = new Dictionary<string, Nodo>();
    }

    public void AgregarNodo(Persona persona)
    {
        if (!nodos.ContainsKey(persona.Id))
        {
            nodos[persona.Id] = new Nodo(persona);
        }
    }

    public void AgregarArista(string idOrigen, string idDestino, int peso)
    {
        if (nodos.ContainsKey(idOrigen) && nodos.ContainsKey(idDestino))
        {
            Nodo origen = nodos[idOrigen];
            Nodo destino = nodos[idDestino];
            origen.Adyacentes.Add(new Arista(destino, peso));
        }
    }

    public Nodo ObtenerNodo(string id)
    {
        return nodos.ContainsKey(id) ? nodos[id] : null;
    }

    public IEnumerable<Nodo> ObtenerTodosLosNodos()
    {
        return nodos.Values;
    }
}
