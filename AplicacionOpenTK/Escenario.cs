using AplicacionOpenTK.Modelos;
using AplicacionOpenTK.Utiles;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;

namespace AplicacionOpenTK
{
    public class Escenario : GameWindow
    {
        public Objeto objeto;
        //-----------------------------------------------------------------------------------------------------------------
        public Escenario(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            Serializador<Objeto> serializador = new Serializador<Objeto>("objeto-de-prueba-numero-1");
            bool s = true;
            if (s)
            {
                Punto<float> punto = new Punto<float>(0f, 0f, 0f);
                objeto = new Objeto(punto, 20f, 20f, 20f);
                serializador.Serializar(objeto);
            }
            else
            {
                objeto = serializador.Deserealizar();
            }
           
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.Black);
            //cubo = new Cubo(new Punto(), 10, 10 ,10);
            base.OnLoad(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //-----------------------
            GL.Rotate(45, -1, -1, 0);
            GL.Translate(-5, -10, 5);
            objeto.Dibujar();
            //-----------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }
    }
}
