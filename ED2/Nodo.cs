namespace ED2;
using System.Collections.Generic;

public class Nodo
{
    public Persona Datos { get; set; }
    public List<Arista> Adyacentes { get; set; }

    public Nodo(Persona datos)
    {
        Datos = datos;
        Adyacentes = new List<Arista>();
    }
}
