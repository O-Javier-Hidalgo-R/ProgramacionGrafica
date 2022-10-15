using OpenTK.Graphics;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    [DataContract]
    public class Objeto
    {
        [DataMember]
        private Dictionary<string, Parte> partes;
        [DataMember]
        private Punto centro;

        public Dictionary<string, Parte> Partes { get => partes; set => partes = value; }
        public Punto Centro { get => centro; set => centro = value; }

        public Objeto()
        {
        }

        public Objeto(Dictionary<string, Parte> partes, Punto centro)
        {
            this.Partes = partes;
            this.Centro = centro;
            foreach (var parte in partes)
            {
                parte.Value.Centro = centro;
            }
        }

        public void dibujar()
        {
            foreach (var parte in partes)
            {
                parte.Value.Dibujar();
            }
        }

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ) {

            foreach (var parte in partes)
            {
                parte.Value.trasladar(enX, enY, enZ);
            }
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            foreach (var parte in partes)
            {
                parte.Value.rotar(angX, angY, angZ);
            }
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            foreach (var parte in partes)
            {
                parte.Value.escalar(enX, enY, enZ);
            }
        }
    }
}
