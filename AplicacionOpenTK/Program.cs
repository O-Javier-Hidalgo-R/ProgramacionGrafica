using System;
using AplicacionOpenTK.Interfaz_Grafica;

namespace AplicacionOpenTK
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(1280, 720);
            game.Run(80);
        }
    }
}
