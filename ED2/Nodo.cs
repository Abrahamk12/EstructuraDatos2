// ED2/Program.cs
namespace ED2
{
    public class Nodo
    {
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; }

        public Nodo(string valor)
        {
            Valor = valor;
            Hijos = new List<Nodo>();
        }

        public void AgregarHijo(Nodo hijo)
        {
            Hijos.Add(hijo);
        }

        public void Imprimir(string indentacion = "")
        {
            Console.WriteLine(indentacion + Valor);
            foreach (var hijo in Hijos)
            {
                hijo.Imprimir(indentacion + "  ");
            }
        }

        public void RecorridoPreorden()
        {
            Console.WriteLine(Valor);
            foreach (var hijo in Hijos)
            {
                hijo.RecorridoPreorden();
            }
        }
        public void RecorridoPostorden()
        {
            foreach (var hijo in Hijos)
            {
                hijo.RecorridoPostorden();
            }
            Console.WriteLine(Valor);
        }

        public void RecorridoPorNiveles()
        {
            Queue<Nodo> cola = new Queue<Nodo>();
            cola.Enqueue(this);

            while (cola.Count > 0)
            {
                Nodo actual = cola.Dequeue();
                Console.WriteLine(actual.Valor);

                foreach (var hijo in actual.Hijos)
                {
                    cola.Enqueue(hijo);
                }
            }
        }


    }
}
