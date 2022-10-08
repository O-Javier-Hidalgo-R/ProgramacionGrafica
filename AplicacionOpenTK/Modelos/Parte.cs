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
        private Dictionary<string, Punto> puntos;

        [DataMember]
        private Color4 color;

        [DataMember]
        private Punto centro;

        public Parte()
        {
            
        }

        public Parte(Dictionary<string, Punto> puntos, Color4 color, Punto centro)
        {
            this.Puntos1 = puntos;
            this.Color = color;
            this.Centro = centro;
        }

        public Dictionary<string, Punto> Puntos { get => Puntos1; set => Puntos1 = value; }
        public Dictionary<string, Punto> Puntos1 { get => puntos; set => puntos = value; }
        public Color4 Color { get => color; set => color = value; }
        public Punto Centro { get => centro; set => centro = value; }

        //QUE ES EL TEXTURE TYPE
        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            Bozquejo(primitiveType);
        }
        private void Bozquejo(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.R, Color.G, Color.B);
            foreach (Punto p in Puntos.Values)
            {
                GL.Vertex3(Centro.X + p.X, Centro.Y + p.Y, Centro.Z + p.Z);
            }
            GL.End();
        }
    }
}
