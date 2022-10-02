using AplicacionOpenTK.Modelos;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK
{
    [DataContract]
    public class Parte
    {
        [DataMember]
        public Dictionary<string, Punto<float>> puntos;

        [DataMember]
        public Color4 color;

        [DataMember]
        public Punto<float> centro;

        public Parte()
        {
            
        }

        public Parte(Dictionary<string, Punto<float>> puntos, Color4 color, Punto<float> centro)
        {
            this.puntos = puntos;
            this.color = color;
            this.centro = centro;
        }

        //QUE CARAJOS ES EL TEXTURE TYPE
        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            Bozquejo(primitiveType);
        }
        private void Bozquejo(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(color.R, color.G, color.B);
            foreach (Punto<float> p in puntos.Values)
            {
                GL.Vertex3(centro.X + p.X, centro.Y + p.Y, centro.Z + p.Z);
            }
            GL.End();
        }
    }
}
