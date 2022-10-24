using AplicacionOpenTK.Interfaces;
using AplicacionOpenTK.Modelos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

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

        public Dictionary<string, Punto> Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }

        public Color4 Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
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

        public Parte()
        {
            
        }

        public Parte(Dictionary<string, Punto> puntos, Color4 color, Punto centro)
        {
            this.Puntos = puntos;
            this.Color = color;
            this.Centro = centro;
        }

        //QUE ES EL TEXTURE TYPE
        public void Dibujar(int tipoDeDibujo)
        {
            GL.Color4(color);
            GL.Begin((PrimitiveType) tipoDeDibujo);
            foreach (var punto in Puntos)
            {
                GL.Vertex3(punto.Value.X + Centro.X, punto.Value.Y + Centro.Y, punto.Value.Z + Centro.Z);
            }
            GL.End();
            GL.Flush();
        }

        //Transformacion de traslacion 
        public void trasladar(float enX, float enY, float enZ)
        {
            Punto puntoTrasladado = new Punto(enX, enY, enZ);
            Centro = centro + puntoTrasladado;
        }

        //Transformacion de rotacion
        public void rotar(float angX, float angY, float angZ)
        {
            angX = MathHelper.DegreesToRadians(angX);
            angY = MathHelper.DegreesToRadians(angY);
            angZ = MathHelper.DegreesToRadians(angZ);

            foreach (var punto in Puntos)
            {
                punto.Value.Set(rotarEnX(punto.Value, angX));
                punto.Value.Set(rotarEnY(punto.Value, angY));
                punto.Value.Set(rotarEnZ(punto.Value, angZ));
            }
        }

        private Punto rotarEnX(Punto rotado, float angX)
        {
            Matrix3 matrixDeRotacio = Matrix3.CreateRotationX(angX);
            return rotado * matrixDeRotacio;
        }

        private Punto rotarEnY(Punto rotado, float angY)
        {
            Matrix3 matrixDeRotacio = Matrix3.CreateRotationY(angY);
            return rotado * matrixDeRotacio;
        }

        private Punto rotarEnZ(Punto rotado, float angZ)
        {
            Matrix3 matrixDeRotacio = Matrix3.CreateRotationZ(angZ);
            return rotado * matrixDeRotacio;
        }

        //Transformacion de escalacion
        public void escalar(float enX, float enY, float enZ)
        {
            Matrix3 matrixEscalada = Matrix3.CreateScale(enX, enY, enZ);

            foreach (var punto in Puntos)
            {
                punto.Value.Set(punto.Value * matrixEscalada);
            }
        }
    }
}
