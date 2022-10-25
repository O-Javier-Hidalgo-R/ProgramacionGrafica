using AplicacionOpenTK.Modelos;
using AplicacionOpenTK.Utiles;
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

        int contador ;

        private Dictionary<String, Escenario> escenarios;

        private Game game;

        public Game Game
        {
            get
            {
                return game;
            }

            set
            {
                game = value;
            }
        }

        public FGame()
        {
            InitializeComponent();
            //Serializador<Escenario> s = new Serializador<Escenario>();
            this.escenarios = new Dictionary<string, Escenario>();
            //this.escenarios.Add("EscenarioAnima", s.CargarJson("../../../AplicacionOpenTK/Figuras3D/EscenariVir.json"));
            contador = 0;
        }

        private void barraTraslacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionX.Text = "En X: " + barraTraslacionX.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.trasladar((barraTraslacionX.Value - valorPrevioTX) / 100f, 0, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario; 
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.trasladar((barraTraslacionX.Value - valorPrevioTX) / 100f, 0, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.trasladar((barraTraslacionX.Value - valorPrevioTX) / 100f, 0, 0);
            }

            valorPrevioTX = barraTraslacionX.Value;
        }

        private void barraTraslacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionY.Text = "En Y: " + barraTraslacionY.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.trasladar(0, (barraTraslacionY.Value - valorPrevioTY) / 100f, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.trasladar(0, (barraTraslacionY.Value - valorPrevioTY) / 100f, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.trasladar(0, (barraTraslacionY.Value - valorPrevioTY) / 100f, 0);
            }

            valorPrevioTY = barraTraslacionY.Value;
        }

        private void barraTraslacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaTraslacionZ.Text = "En Z: " + barraTraslacionZ.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.trasladar(0, 0, (barraTraslacionZ.Value - valorPrevioTZ) / 100f);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.trasladar(0, 0, (barraTraslacionZ.Value - valorPrevioTZ) / 100f);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.trasladar(0, 0, (barraTraslacionZ.Value - valorPrevioTZ) / 100f);
            }

            valorPrevioTZ = barraTraslacionZ.Value;
        }

        private void barraRotacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionX.Text = "En X: " + barraRotacionX.Value + "º";
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.rotar(barraRotacionX.Value - valorPrevioRX, 0, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.rotar(barraRotacionX.Value - valorPrevioRX, 0, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.rotar(barraRotacionX.Value - valorPrevioRX, 0, 0);
            }

            valorPrevioRX = barraRotacionX.Value;
        }

        private void barraRotacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionY.Text = "En Y: " + barraRotacionY.Value + "º";
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.rotar(0, barraRotacionY.Value - valorPrevioRY, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.rotar(0, barraRotacionY.Value - valorPrevioRY, 0);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.rotar(0, barraRotacionY.Value - valorPrevioRY, 0);
            }

            valorPrevioRY = barraRotacionY.Value;
        }

        private void barraRotacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaRotacionZ.Text = "En Z: " + barraRotacionZ.Value + "º";
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.rotar(0, 0, barraRotacionZ.Value - valorPrevioRZ);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.rotar(0, 0, barraRotacionZ.Value - valorPrevioRZ);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.rotar(0, 0, barraRotacionZ.Value - valorPrevioRZ);
            }

            valorPrevioRZ = barraRotacionZ.Value;
        }

        private void barraEscalacionX_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionX.Text = "En X: " + barraEscalacionX.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.escalar((barraEscalacionX.Value - valorPrevioEX) / 100f + 1, 1, 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.escalar((barraEscalacionX.Value - valorPrevioEX) / 100f + 1, 1, 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.escalar((barraEscalacionX.Value - valorPrevioEX) / 100f + 1, 1, 1);
            }

            valorPrevioEX = barraEscalacionX.Value;
        }

        private void barraEscalacionY_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionY.Text = "En Y: " + barraEscalacionY.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.escalar(1, (barraEscalacionY.Value - valorPrevioEY) / 100f + 1, 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.escalar(1, (barraEscalacionY.Value - valorPrevioEY) / 100f + 1, 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.escalar(1, (barraEscalacionY.Value - valorPrevioEY) / 100f + 1, 1);
            }

            valorPrevioEY = barraEscalacionY.Value;
        }

        private void barraEscalacionZ_Scroll(object sender, EventArgs e)
        {
            etiquetaTransformacionZ.Text = "En Z: " + barraEscalacionZ.Value;
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                foreach (var escenario in escenarios)
                {
                    escenario.Value.escalar(1, 1, (barraEscalacionZ.Value - valorPrevioEZ) / 100f + 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text == "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                foreach (var objeto in escenario.Objetos)
                {
                    objeto.Value.escalar(1, 1, (barraEscalacionZ.Value - valorPrevioEZ) / 100f + 1);
                }
            }
            else if (comboBox1.Text != "" & comboBox2.Text != "")
            {
                Escenario escenario;
                escenarios.TryGetValue(comboBox1.Text, out escenario);
                Objeto objeto;
                escenario.Objetos.TryGetValue(comboBox2.Text, out objeto);
                objeto.escalar(1, 1, (barraEscalacionZ.Value - valorPrevioEZ) / 100f + 1);
            }

            valorPrevioEZ = barraEscalacionZ.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void barPerspectivaX_Scroll(object sender, EventArgs e)
        {
            etiquetaPerspectivaEnX.Text = "En X: " + barPerspectivaX.Value + "º";
            game.PerX = barPerspectivaX.Value;
        }

        private void barPerspectivaY_Scroll(object sender, EventArgs e)
        {
            etiquetaPerspectivaEnY.Text = "En Y: " + barPerspectivaY.Value + "º";
            game.PerY = barPerspectivaY.Value;
        }

        private void barPerspectivaZ_Scroll(object sender, EventArgs e)
        {
            etiquetaPerspectivaEnZ.Text = "En Z: " + barPerspectivaZ.Value + "º";
            game.PerZ = barPerspectivaZ.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
               
        }

        private void animacion()
        {

            if (escenarios.Count == 0 || escenarios.First().Key != "EscenarioAnimacion")
            {
                Serializador<Escenario> s = new Serializador<Escenario>();

                string dir = "../../../../ProgramacionGrafica/AplicacionOpenTK/Figuras3D/EscenarioAnimacion1.json";

                escenarios.Add("EscenarioAnimacion", s.CargarJson(dir));

                game.Escenarios = this.escenarios;

                comboBox1.Items.Clear();
                foreach (var escenario1 in escenarios)
                {
                    comboBox1.Items.Add(escenario1.Key);
                }
                comboBox1.Items.Add("");
            }

            Objeto objeto;
            Escenario escenario = game.Escenarios.First().Value;

            escenario.Objetos.TryGetValue("Llanta1", out objeto);
            objeto.rotar(25, 0, 0);

            escenario.Objetos.TryGetValue("Llanta2", out objeto);
            objeto.rotar(25, 0, 0);

            escenario.Objetos.TryGetValue("Llanta3", out objeto);
            objeto.rotar(25, 0, 0);

            escenario.Objetos.TryGetValue("Llanta4", out objeto);
            objeto.rotar(25, 0, 0);

            escenario.trasladar(0, 0, 0.005f);

            escenario.escalar(1.005f, 1.005f, 1.005f);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animacion();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void numero1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                buttonPlay.Image = Properties.Resources.Play;
                timer1.Enabled = !timer1.Enabled;
            }
            else
            {
                buttonPlay.Image = Properties.Resources.Pausa;
                timer1.Enabled = !timer1.Enabled;
            }

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Serializador<Escenario> s = new Serializador<Escenario>();
                contador++;

                string dir = openFileDialog1.FileName;

                escenarios.Add("Escenario" + contador, s.CargarJson(dir));

                game.Escenarios = this.escenarios;

                comboBox1.Items.Clear();
                foreach (var escenario in escenarios) 
                {
                    comboBox1.Items.Add(escenario.Key);
                }
                comboBox1.Items.Add("");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.Text != "" || comboBox1.Text != null)
            {
                foreach (var objeto in escenarios[comboBox1.Text].Objetos)
                {
                    comboBox2.Items.Add(objeto.Key);
                }
            }

            comboBox2.Items.Add("");
        }

        private void buttonDesacelerar_Click(object sender, EventArgs e)
        {
            Serializador<Escenario> s = new Serializador<Escenario>();

            string dir = "../../../../ ProgramacionGrafica / AplicacionOpenTK / Figuras3D / EscenarioAnimacion1.json";

            escenarios.Clear();
            escenarios.Add("EscenarioAnimacion", s.CargarJson(dir));

            game.Escenarios = this.escenarios;

            comboBox1.Items.Clear();
            foreach (var escenario1 in escenarios)
            {
                comboBox1.Items.Add(escenario1.Key);
            }
            comboBox1.Items.Add("");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (timer1.Interval >= 30)
            {
                timer1.Interval -= 20;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Interval <= 70)
            {
                timer1.Interval += 20;
            }
        }
    }
}
