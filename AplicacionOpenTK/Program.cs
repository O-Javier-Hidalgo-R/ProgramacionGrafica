namespace AplicacionOpenTK
{
    class Program
    {
        static void Main(string[] args)
        {
            var escenario = new Escenario(800, 800, "escenario");
            escenario.Run(80);
        }
    }
}
