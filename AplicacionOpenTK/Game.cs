using AplicacionOpenTK.Modelos;
using AplicacionOpenTK.Utiles;
using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;

namespace AplicacionOpenTK
{
    public class Game : GameWindow
    {
        Escenario escenario;

        Objeto casa;
        Objeto casa2;

        Serializador<Escenario> serializador = new Serializador<Escenario>();
        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            escenario = serializador.Deserealizar("../../../AplicacionOpenTK/json/Escenario.json");

            /*
            Dictionary<string, Objeto> objetos = new Dictionary<string, Objeto>();
            objetos.Add("casa1", casa);

            escenario = new Escenario(objetos, new Punto<float>(0, 0, 0));

            Serializador<Escenario> serializador2 = new Serializador<Escenario>();
            serializador2.Serializar("../../../AplicacionOpenTK/json/Escenario.json", escenario);
            */
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

            int orthoSize = 50;
            GL.Ortho(-orthoSize, orthoSize, -orthoSize, orthoSize, -orthoSize, orthoSize);
            GL.Rotate(30, 1, -1, 0);

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
            //GL.LoadIdentity();
            //----------------------
            //GL.Rotate(0.5, 0, 1, 0);
            //GL.Translate(-5, -10, 5);
            escenario.dibujar();
            //-----------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            //float d = 30;
            GL.Viewport(0, 0, Width, Height);
            //GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            //GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();
            base.OnResize(e);
        }
    }
}
