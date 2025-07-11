namespace ED2;
public class Persona
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string id, string nombre, int edad)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
    }
}
