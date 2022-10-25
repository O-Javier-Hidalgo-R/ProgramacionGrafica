using System;
using AplicacionOpenTK.Interfaz_Grafica;

namespace AplicacionOpenTK
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FGame form = new FGame();
            form.Show();

            Game game = new Game(1280, 720);
            form.Game = game;
            game.Run(80);
        }
    }
}
