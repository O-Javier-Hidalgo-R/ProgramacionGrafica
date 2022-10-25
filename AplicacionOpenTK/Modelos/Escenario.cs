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

        public Dictionary<string, Objeto> Objetos
        {
            get
            {
                return objetos;
            }

            set
            {
                objetos = value;
            }
        }

        public Punto Centro
        {
            get
            {
                return centro;
            }

            set
            {
                centro = value;
            }
        }

        public Escenario(Dictionary<string, Objeto> objetos, Punto centro)
        {
            this.Objetos = objetos;
            this.Centro = centro;
        }

        public Escenario()
        {

        }

        public void dibujar(int tipoDeDibujo)
        {
            foreach (var objeto in Objetos)
            {
                objeto.Value.dibujar(tipoDeDibujo);
            }
        }

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ)
        {
            foreach (var objeto in Objetos)
            {
                objeto.Value.trasladar(enX, enY, enZ);
            }
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            foreach (var objeto in Objetos)
            {
                objeto.Value.rotar(angX, angY, angZ);
            }
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            foreach (var objeto in Objetos)
            {
                objeto.Value.escalar(enX, enY, enZ);
            }
        }
    }
}
