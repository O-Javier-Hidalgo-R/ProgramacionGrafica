using Newtonsoft.Json;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Game juego = new Game(800, 400, "Hello Triangle");
            juego.Run(60);
        }
    }
}
