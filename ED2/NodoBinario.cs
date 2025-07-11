namespace ED2
{
    public class NodoBinario
    {
        public string Valor;
        public NodoBinario Izquierdo;
        public NodoBinario Derecho;

        public NodoBinario(string valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }

        public void RecorridoInorden()
        {
            if (Izquierdo != null)
                Izquierdo.RecorridoInorden();

            Console.WriteLine(Valor);

            if (Derecho != null)
                Derecho.RecorridoInorden();
        }
    }
}