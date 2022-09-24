using OpenTK.Graphics;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AplicacionOpenTK.Modelos
{
    [DataContract]
    public class Objeto
    {
        [DataMember]
        public Dictionary<string, Parte> partes;
        public Objeto()
        {

        }
        public Objeto(Punto<float>centro, float ancho, float alto, float profundo)
        {
            partes = new Dictionary<string, Parte>();

            //pared proa
            Dictionary<string, Punto<float>> puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            partes.Add("p-proa", new Parte(puntos, Color4.Red));

            //pared popa
            puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            partes.Add("p-popa", new Parte(puntos, Color4.Red));

            //pared estribor
            puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            partes.Add("p-estribor", new Parte(puntos, Color4.Red));

            //pared babor
            puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            partes.Add("p-babor", new Parte(puntos, Color4.Red));

            //pared cielo
            puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X + (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X - (ancho / 2), centro.Y + (alto / 2), centro.Z + (profundo / 2)));
            partes.Add("p-cielo", new Parte(puntos, Color4.Red));

            //pared awa
            puntos = new Dictionary<string, Punto<float>>();
            puntos.Add("P0", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P1", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z - (profundo / 2)));
            puntos.Add("P2", new Punto<float>(centro.X + (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            puntos.Add("P3", new Punto<float>(centro.X - (ancho / 2), centro.Y - (alto / 2), centro.Z + (profundo / 2)));
            partes.Add("p-awa", new Parte(puntos, Color4.Red));

        }

        internal void Dibujar()
        {
            foreach (Parte parte in partes.Values)
            {
                parte.Dibujar();
            }
        }
    }
}
