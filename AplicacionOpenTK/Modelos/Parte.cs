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

        public Parte()
        {
            
        }

        public Parte(Dictionary<string, Punto<float>> puntos, Color4 color)
        {
            this.puntos = puntos;
            this.color = color;
        }

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
                GL.Vertex3(p.X, p.Y, p.Z);
            }
            GL.End();
        }
    }
}
