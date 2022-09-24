using OpenTK.Graphics.OpenGL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionOpenTK
{
    public class ObjetoOld
    {
        private Hashtable partes;
        private Punto<float> centro;

        public Objeto(Hashtable partes, Punto<float> centro)
        {
            this.Partes = partes;
            this.Centro = centro;
        }

        public Hashtable Partes { get => partes; set => partes = value; }
        public Punto<float> Centro { get => centro; set => centro = value; }

        public void dibujar()
        {
            foreach (Parte p in Partes.Values)
            {
                p.Dibujar();
            }
        }
    }
}
