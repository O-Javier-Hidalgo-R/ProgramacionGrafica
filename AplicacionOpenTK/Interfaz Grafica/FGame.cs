using AplicacionOpenTK.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionOpenTK.Interfaz_Grafica
{
    
    public partial class FGame : Form
    {
        private int valorPrevioTX;
        private int valorPrevioTY;
        private int valorPrevioTZ;
        private int valorPrevioRX;
        private int valorPrevioRY;
        private int valorPrevioRZ;
        private int valorPrevioEX;
        private int valorPrevioEY;
        private int valorPrevioEZ;

        public FGame()
        {
            InitializeComponent();
        }

        public Escenario Escenario { get; internal set; }

        internal void obtenerEscenario(Escenario escenario1)
        {
            comboBox1.Items.Add("Escenario");
            foreach (var objeto in escenario1.Objetos)
            {
                comboBox1.Items.Add(objeto.Key);
            }
        }

        private void barraTraslacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionX.Text = "En X: " + barraTraslacionX.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.trasladar((barraTraslacionX.Value - valorPrevioTX) / 100f, 0, 0);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.trasladar((barraTraslacionX.Value - valorPrevioTX) / 100f, 0, 0);
            }
            valorPrevioTX = barraTraslacionX.Value;
        }

        private void barraTraslacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionY.Text = "En Y: " + barraTraslacionY.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.trasladar(0, (barraTraslacionY.Value - valorPrevioTY) / 100f, 0);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.trasladar(0, (barraTraslacionY.Value - valorPrevioTY) / 100f, 0);
            }
            valorPrevioTY = barraTraslacionY.Value;
        }

        private void barraTraslacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionZ.Text = "En Z: " + barraTraslacionZ.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.trasladar(0, 0, (barraTraslacionZ.Value - valorPrevioTZ) / 100f);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.trasladar(0, 0, (barraTraslacionZ.Value - valorPrevioTZ) / 100f);
            }
            valorPrevioTZ = barraTraslacionZ.Value;
        }

        private void barraRotacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionX.Text = "En X: " + barraRotacionX.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.rotar(barraRotacionX.Value - valorPrevioRX, 0, 0);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.rotar(barraRotacionX.Value - valorPrevioRX, 0, 0);
            }
            valorPrevioRX = barraRotacionX.Value;
        }

        private void barraRotacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionY.Text = "En Y: " + barraRotacionY.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.rotar(0, barraRotacionY.Value - valorPrevioRY, 0);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.rotar(0, barraRotacionY.Value - valorPrevioRY, 0);
            }
            valorPrevioRY = barraRotacionY.Value;
        }

        private void barraRotacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionZ.Text = "En Z: " + barraRotacionZ.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.rotar(0, 0, barraRotacionZ.Value - valorPrevioRZ);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.rotar(0, 0, barraRotacionZ.Value - valorPrevioRZ);
            }
            valorPrevioRZ = barraRotacionZ.Value;
        }

        private void barraEscalacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionX.Text = "En X: " + barraEscalacionX.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.escalar((barraEscalacionX.Value - valorPrevioEX)/100f +1, 1, 1);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.escalar((barraEscalacionX.Value - valorPrevioEX) / 100f + 1, 1, 1);
            }
            valorPrevioEX = barraEscalacionX.Value;
        }

        private void barraEscalacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionY.Text = "En Y: " + barraEscalacionY.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.escalar(1, (barraEscalacionY.Value - valorPrevioEY) / 100f + 1, 1);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.escalar(1, (barraEscalacionY.Value - valorPrevioEY) / 100f + 1, 1);
            }
            valorPrevioEY = barraEscalacionY.Value;
        }

        private void barraEscalacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionZ.Text = "En Z: " + barraEscalacionZ.Value;
            Objeto objeto;
            Escenario.Objetos.TryGetValue(comboBox1.Text, out objeto);
            if (objeto != null)
            {
                objeto.escalar(1, 1, (barraEscalacionZ.Value - valorPrevioEZ) / 100f + 1);
            }
            else if (comboBox1.Text == "Escenario")
            {
                Escenario.escalar(1, 1, (barraEscalacionZ.Value - valorPrevioEZ) / 100f + 1);
            }
            valorPrevioEZ = barraEscalacionZ.Value;
        }
    }
}
