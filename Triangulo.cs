using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using Proyecto1;

namespace HelloTriangle
{
    public class Triangulo
    {
        public Punto centro;
        public float ancho;
        public float alto;

        public Triangulo(Punto centro, float ancho, float alto)
        {
            this.centro = centro;
            this.ancho = ancho;
            this.alto = alto;
        }   

        public void dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            vertices(primitiveType);
        }

        public void vertices(PrimitiveType primitive)
        {
            GL.Begin(primitive);
            GL.Color4(Color.Red);

            GL.Vertex3(centro.x, centro.y + (alto/2), centro.z);
            GL.Vertex3(centro.x - (ancho / 2), centro.y - (alto / 2), centro.z);
            GL.Vertex3(centro.x + (ancho / 2), centro.y - (alto / 2), centro.z);
            GL.End();
        }
    }
}
