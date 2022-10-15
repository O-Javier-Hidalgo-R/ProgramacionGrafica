using AplicacionOpenTK.Interfaces;
using AplicacionOpenTK.Modelos;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK
{
    [DataContract]
    public class Parte: ITransformable
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
            this.Puntos = puntos;
            this.Color = color;
            this.Centro = centro;
        }


        public Color4 Color { get => color; set => color = value; }
        public Punto Centro { get => centro; set => centro = value; }
        public Dictionary<string, Punto> Puntos { get => puntos; set => puntos = value; }

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

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ)
        {
            foreach (Punto punto in Puntos.Values)
            {
                punto.trasladar(enX, enY, enZ);
            }
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            foreach (Punto punto in Puntos.Values)
            {
                punto.rotar(angX, angY, angZ);
            }
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            foreach (Punto punto in Puntos.Values)
            {
                punto.escalar(enX, enY, enZ);
            }
        }
    }
}
