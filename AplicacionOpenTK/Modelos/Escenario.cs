using AplicacionOpenTK.Interfaces;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    public class Escenario: ITransformable
    {
        [DataMember]
        private Dictionary<string, Objeto> objetos;
        [DataMember]
        private Punto centro;

        public Escenario(Dictionary<string, Objeto> objetos, Punto centro)
        {
            this.objetos = objetos;
            this.centro = centro;
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

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ)
        {
            foreach (var objeto in objetos)
            {
                objeto.Value.trasladar(enX, enY, enZ);
            }
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            foreach (var objeto in objetos)
            {
                objeto.Value.rotar(angX, angY, angZ);
            }
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            foreach (var objeto in objetos)
            {
                objeto.Value.escalar(enX, enY, enZ);
            }
        }
    }
}
