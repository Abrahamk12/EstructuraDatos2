namespace ED2;
public class Arista
{
    public Nodo Destino { get; set; }
    public int Peso { get; set; }

    public Arista(Nodo destino, int peso)
    {
        Destino = destino;
        Peso = peso;
    }
}
