using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionOpenTK.Modelos
{
    public class Escenario
    {
        [DataMember]
        private Dictionary<string, Objeto> objetos;
        [DataMember]
        private Punto centro;

        public Escenario(Dictionary<string, Objeto> objetos, Punto centro)
        {
            this.objetos = objetos;
            this.centro = centro;
            foreach (var objeto in objetos)
            {
                objeto.Value.Centro = centro;
            }
        }

        public Dictionary<string, Objeto> Objetos { get => objetos; set => objetos = value; }

        public Punto Centro { get => centro; set => centro = value; }

        public void dibujar()
        {
            foreach (var objeto in objetos)
            {
                objeto.Value.dibujar();
            }
        }
    }
}
