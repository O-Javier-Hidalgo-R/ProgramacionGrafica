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
        private Punto<float> centro;

        //PUEDE QUE ESTE MAL Y QUE NECESITE SOBRECARGA DE OPERADOR "+"
        public Escenario(Dictionary<string, Objeto> objetos, Punto<float> centro)
        {
            this.objetos = objetos;
            this.centro = centro;
            foreach (var objeto in objetos)
            {
                objeto.Value.Centro = centro;
            }
        }

        public Dictionary<string, Objeto> Objetos { get => objetos; set => objetos = value; }

        public Punto<float> Centro { get => centro; set => centro = value; }

        public void dibujar()
        {
            foreach (var objeto in objetos)
            {
                objeto.Value.dibujar();
            }
        }
    }
}
