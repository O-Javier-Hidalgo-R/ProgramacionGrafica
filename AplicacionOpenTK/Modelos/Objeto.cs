using AplicacionOpenTK.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    [DataContract]
    public class Objeto:ITransformable
    {
        [DataMember]
        private Dictionary<string, Parte> partes;
        [DataMember]
        private Punto centro;

        public Dictionary<string, Parte> Partes
        {
            get
            {
                return partes;
            }

            set
            {
                partes = value;
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
                foreach (var face in Partes) face.Value.Centro = Centro;
            }
        }

        public Objeto()
        {
        }

        public void SetCenter(Punto newCenter)
        {
            Centro = newCenter;
            foreach (var face in Partes)
                face.Value.Centro = Centro;
        }

        public Objeto(Dictionary<string, Parte> partes, Punto centro)
        {
            this.Partes = partes;
            this.Centro = centro;
        }

        public void dibujar(int tipoDeDibujo)
        {
            foreach (var parte in Partes)
            {
                parte.Value.Dibujar(tipoDeDibujo);
            }
        }

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ) {

            foreach (var parte in Partes)
            {
                parte.Value.trasladar(enX, enY, enZ);
            }
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            foreach (var parte in Partes)
            {
                parte.Value.rotar(angX, angY, angZ);
            }
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            foreach (var parte in Partes)
            {
                parte.Value.escalar(enX, enY, enZ);
            }
        }

        internal void escalarPar(float enX, float enY, float enZ)
        {
            foreach (var parte in Partes)
            {
                parte.Value.escalarPar(enX, enY, enZ);
            }
        }
    }
}
