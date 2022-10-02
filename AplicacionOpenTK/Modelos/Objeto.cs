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
        private Punto<float> centro;

        public Dictionary<string, Parte> Partes { get => partes; set => partes = value; }
        public Punto<float> Centro { get => centro; set => centro = value; }

        public Objeto()
        {
        }

        public Objeto(Dictionary<string, Parte> partes, Punto<float> centro)
        {
            this.Partes = partes;
            this.Centro = centro;
            foreach (var parte in partes)
            {
                parte.Value.centro = centro;
            }
        }

        public void dibujar()
        {
            foreach (var parte in partes)
            {
                parte.Value.Dibujar();
            }
        }
    }
}
