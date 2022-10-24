﻿using AplicacionOpenTK.Interfaz_Grafica;
using AplicacionOpenTK.Modelos;
using AplicacionOpenTK.Utiles;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;

namespace AplicacionOpenTK
{
    /// <summary>
    /// Clase que controla la ventana grafica heredada de gameWindow.
    /// </summary>
    public class Game : GameWindow
    {
        private Escenario Escenario1;
        Escenario Escenario2;
        private Objeto objeto;
        FGame form;

        /// <summary>
        /// Constructor de la clase predeterminado, con la resolucion como parametro de entrada.
        /// </summary>
        /// <param name="width">Ancho de la resolucion.</param>
        /// <param name="height">Altura de la resolucion.</param>
        public Game(int width, int height) : base(width, height)
        {
            Escenario1 = new Serializador<Escenario>().CargarJson("../../../AplicacionOpenTK/Figuras3D/Escenario.json");
            Escenario2 = new Serializador<Escenario>().CargarJson("../../../AplicacionOpenTK/Figuras3D/Escenario2.json");

            form = new FGame();
            form.obtenerEscenario(Escenario1);
            form.Show();
        }

        /// <summary>
        /// Se llama después de que se haya establecido un contexto OpenGL, pero antes de ingresar al bucle principal
        /// </summary>
        /// <param name="e">Parametro para eventos.</param>
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.8f, 0.8f, 0.8f, 0.8f);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1, 1, -1, 1, -1, 1);
            GL.Rotate(15, 1, -1, 0);
            GL.MatrixMode(MatrixMode.Modelview);

            base.OnLoad(e);
        }

        //

        /// <summary>
        /// Llamada donde los frames son renderizados.
        /// Contiene información necesaria para la representación de cuadros.
        /// </summary>
        /// <param name="e">parametro para eventos.</param
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);

            Escenario1.dibujar(2);

            form.Escenario = Escenario1;

            SwapBuffers();
            base.OnRenderFrame(e);
        }

        /// <summary>
        /// Se llama cuando se cambia el tamaño de esta ventana.
        /// </summary>
        /// <param name="e">Parametro de evento.</param>
        protected override void OnResize(EventArgs e)
        {   
            GL.Viewport(0, 0, Width, Height);
            
            base.OnResize(e);
        }

        /// <summary>
        /// Llamado después de que se llamara a GameWindow.
        /// Exit, pero antes de destruir el contexto de OpenGL.
        /// </summary>
        /// <param name="e">Parametro de evento.</param>
        protected override void OnUnload(EventArgs e)
        {   
            base.OnUnload(e);
        }

        /// <summary>
        /// Llamado cuando se actualiza el frame.
        /// </summary>
        /// <param name="e">Parametro de evento.</param>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
    }
}