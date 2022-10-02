namespace AplicacionOpenTK
{
    class Program
    {
        static void Main(string[] args)
        {
            var escenario = new Game(1280, 720, "escenario");
            escenario.Run(80);
        }
    }
}
