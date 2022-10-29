namespace AplicacionOpenTK.Interfaz_Grafica
{
    partial class FGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.barraTraslacionX = new System.Windows.Forms.TrackBar();
            this.etiquetaTraslacionX = new System.Windows.Forms.Label();
            this.etiquetaTraslacionY = new System.Windows.Forms.Label();
            this.barraTraslacionY = new System.Windows.Forms.TrackBar();
            this.etiquetaTraslacionZ = new System.Windows.Forms.Label();
            this.barraTraslacionZ = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barraRotacionZ = new System.Windows.Forms.TrackBar();
            this.barraRotacionY = new System.Windows.Forms.TrackBar();
            this.barraRotacionX = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.barraEscalacionZ = new System.Windows.Forms.TrackBar();
            this.barraEscalacionY = new System.Windows.Forms.TrackBar();
            this.barraEscalacionX = new System.Windows.Forms.TrackBar();
            this.etiquetaRotacionZ = new System.Windows.Forms.Label();
            this.etiquetaRotacionY = new System.Windows.Forms.Label();
            this.etiquetaRotacionX = new System.Windows.Forms.Label();
            this.etiquetaTransformacionZ = new System.Windows.Forms.Label();
            this.etiquetaTransformacionY = new System.Windows.Forms.Label();
            this.etiquetaTransformacionX = new System.Windows.Forms.Label();
            this.etiquetaPerspectivaEnZ = new System.Windows.Forms.Label();
            this.etiquetaPerspectivaEnY = new System.Windows.Forms.Label();
            this.etiquetaPerspectivaEnX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barPerspectivaZ = new System.Windows.Forms.TrackBar();
            this.barPerspectivaY = new System.Windows.Forms.TrackBar();
            this.barPerspectivaX = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numero1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDesacelerar = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaX)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // barraTraslacionX
            // 
            this.barraTraslacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionX.Location = new System.Drawing.Point(5, 88);
            this.barraTraslacionX.Maximum = 50;
            this.barraTraslacionX.Minimum = -50;
            this.barraTraslacionX.Name = "barraTraslacionX";
            this.barraTraslacionX.Size = new System.Drawing.Size(445, 45);
            this.barraTraslacionX.TabIndex = 5;
            this.barraTraslacionX.Scroll += new System.EventHandler(this.barraTraslacionX_Scroll);
            // 
            // etiquetaTraslacionX
            // 
            this.etiquetaTraslacionX.AutoSize = true;
            this.etiquetaTraslacionX.Location = new System.Drawing.Point(453, 90);
            this.etiquetaTraslacionX.Name = "etiquetaTraslacionX";
            this.etiquetaTraslacionX.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTraslacionX.TabIndex = 6;
            this.etiquetaTraslacionX.Text = "En X: 0";
            // 
            // etiquetaTraslacionY
            // 
            this.etiquetaTraslacionY.AutoSize = true;
            this.etiquetaTraslacionY.Location = new System.Drawing.Point(453, 132);
            this.etiquetaTraslacionY.Name = "etiquetaTraslacionY";
            this.etiquetaTraslacionY.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTraslacionY.TabIndex = 8;
            this.etiquetaTraslacionY.Text = "En Y: 0";
            // 
            // barraTraslacionY
            // 
            this.barraTraslacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionY.Location = new System.Drawing.Point(5, 130);
            this.barraTraslacionY.Maximum = 50;
            this.barraTraslacionY.Minimum = -50;
            this.barraTraslacionY.Name = "barraTraslacionY";
            this.barraTraslacionY.Size = new System.Drawing.Size(445, 45);
            this.barraTraslacionY.TabIndex = 7;
            this.barraTraslacionY.Scroll += new System.EventHandler(this.barraTraslacionY_Scroll);
            // 
            // etiquetaTraslacionZ
            // 
            this.etiquetaTraslacionZ.AutoSize = true;
            this.etiquetaTraslacionZ.Location = new System.Drawing.Point(453, 173);
            this.etiquetaTraslacionZ.Name = "etiquetaTraslacionZ";
            this.etiquetaTraslacionZ.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTraslacionZ.TabIndex = 10;
            this.etiquetaTraslacionZ.Text = "En Z: 0";
            // 
            // barraTraslacionZ
            // 
            this.barraTraslacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionZ.Location = new System.Drawing.Point(5, 171);
            this.barraTraslacionZ.Maximum = 50;
            this.barraTraslacionZ.Minimum = -50;
            this.barraTraslacionZ.Name = "barraTraslacionZ";
            this.barraTraslacionZ.Size = new System.Drawing.Size(445, 45);
            this.barraTraslacionZ.TabIndex = 9;
            this.barraTraslacionZ.Scroll += new System.EventHandler(this.barraTraslacionZ_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TRANSFORMACIÓN DE TRASLACIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "TRANSFORMACIÓN DE ROTACIÓN";
            // 
            // barraRotacionZ
            // 
            this.barraRotacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionZ.Location = new System.Drawing.Point(5, 318);
            this.barraRotacionZ.Maximum = 360;
            this.barraRotacionZ.Name = "barraRotacionZ";
            this.barraRotacionZ.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionZ.TabIndex = 16;
            this.barraRotacionZ.Scroll += new System.EventHandler(this.barraRotacionZ_Scroll);
            // 
            // barraRotacionY
            // 
            this.barraRotacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionY.Location = new System.Drawing.Point(5, 277);
            this.barraRotacionY.Maximum = 360;
            this.barraRotacionY.Name = "barraRotacionY";
            this.barraRotacionY.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionY.TabIndex = 14;
            this.barraRotacionY.Scroll += new System.EventHandler(this.barraRotacionY_Scroll);
            // 
            // barraRotacionX
            // 
            this.barraRotacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionX.Location = new System.Drawing.Point(5, 235);
            this.barraRotacionX.Maximum = 360;
            this.barraRotacionX.Name = "barraRotacionX";
            this.barraRotacionX.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionX.TabIndex = 12;
            this.barraRotacionX.Scroll += new System.EventHandler(this.barraRotacionX_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "TRANSFORMACIÓN DE ESCALACIÓN";
            // 
            // barraEscalacionZ
            // 
            this.barraEscalacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraEscalacionZ.Location = new System.Drawing.Point(5, 465);
            this.barraEscalacionZ.Maximum = 50;
            this.barraEscalacionZ.Minimum = -50;
            this.barraEscalacionZ.Name = "barraEscalacionZ";
            this.barraEscalacionZ.Size = new System.Drawing.Size(445, 45);
            this.barraEscalacionZ.TabIndex = 23;
            this.barraEscalacionZ.Scroll += new System.EventHandler(this.barraEscalacionZ_Scroll);
            // 
            // barraEscalacionY
            // 
            this.barraEscalacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraEscalacionY.Location = new System.Drawing.Point(5, 424);
            this.barraEscalacionY.Maximum = 50;
            this.barraEscalacionY.Minimum = -50;
            this.barraEscalacionY.Name = "barraEscalacionY";
            this.barraEscalacionY.Size = new System.Drawing.Size(445, 45);
            this.barraEscalacionY.TabIndex = 21;
            this.barraEscalacionY.Scroll += new System.EventHandler(this.barraEscalacionY_Scroll);
            // 
            // barraEscalacionX
            // 
            this.barraEscalacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraEscalacionX.Location = new System.Drawing.Point(5, 382);
            this.barraEscalacionX.Maximum = 50;
            this.barraEscalacionX.Minimum = -50;
            this.barraEscalacionX.Name = "barraEscalacionX";
            this.barraEscalacionX.Size = new System.Drawing.Size(445, 45);
            this.barraEscalacionX.TabIndex = 19;
            this.barraEscalacionX.Scroll += new System.EventHandler(this.barraEscalacionX_Scroll);
            // 
            // etiquetaRotacionZ
            // 
            this.etiquetaRotacionZ.AutoSize = true;
            this.etiquetaRotacionZ.Location = new System.Drawing.Point(453, 320);
            this.etiquetaRotacionZ.Name = "etiquetaRotacionZ";
            this.etiquetaRotacionZ.Size = new System.Drawing.Size(46, 13);
            this.etiquetaRotacionZ.TabIndex = 28;
            this.etiquetaRotacionZ.Text = "En Z: 0º";
            // 
            // etiquetaRotacionY
            // 
            this.etiquetaRotacionY.AutoSize = true;
            this.etiquetaRotacionY.Location = new System.Drawing.Point(453, 279);
            this.etiquetaRotacionY.Name = "etiquetaRotacionY";
            this.etiquetaRotacionY.Size = new System.Drawing.Size(46, 13);
            this.etiquetaRotacionY.TabIndex = 27;
            this.etiquetaRotacionY.Text = "En Y: 0º";
            // 
            // etiquetaRotacionX
            // 
            this.etiquetaRotacionX.AutoSize = true;
            this.etiquetaRotacionX.Location = new System.Drawing.Point(453, 237);
            this.etiquetaRotacionX.Name = "etiquetaRotacionX";
            this.etiquetaRotacionX.Size = new System.Drawing.Size(46, 13);
            this.etiquetaRotacionX.TabIndex = 26;
            this.etiquetaRotacionX.Text = "En X: 0º";
            // 
            // etiquetaTransformacionZ
            // 
            this.etiquetaTransformacionZ.AutoSize = true;
            this.etiquetaTransformacionZ.Location = new System.Drawing.Point(453, 468);
            this.etiquetaTransformacionZ.Name = "etiquetaTransformacionZ";
            this.etiquetaTransformacionZ.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTransformacionZ.TabIndex = 31;
            this.etiquetaTransformacionZ.Text = "En Z: 0";
            // 
            // etiquetaTransformacionY
            // 
            this.etiquetaTransformacionY.AutoSize = true;
            this.etiquetaTransformacionY.Location = new System.Drawing.Point(453, 427);
            this.etiquetaTransformacionY.Name = "etiquetaTransformacionY";
            this.etiquetaTransformacionY.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTransformacionY.TabIndex = 30;
            this.etiquetaTransformacionY.Text = "En Y: 0";
            // 
            // etiquetaTransformacionX
            // 
            this.etiquetaTransformacionX.AutoSize = true;
            this.etiquetaTransformacionX.Location = new System.Drawing.Point(453, 385);
            this.etiquetaTransformacionX.Name = "etiquetaTransformacionX";
            this.etiquetaTransformacionX.Size = new System.Drawing.Size(42, 13);
            this.etiquetaTransformacionX.TabIndex = 29;
            this.etiquetaTransformacionX.Text = "En X: 0";
            // 
            // etiquetaPerspectivaEnZ
            // 
            this.etiquetaPerspectivaEnZ.AutoSize = true;
            this.etiquetaPerspectivaEnZ.Location = new System.Drawing.Point(450, 614);
            this.etiquetaPerspectivaEnZ.Name = "etiquetaPerspectivaEnZ";
            this.etiquetaPerspectivaEnZ.Size = new System.Drawing.Size(46, 13);
            this.etiquetaPerspectivaEnZ.TabIndex = 39;
            this.etiquetaPerspectivaEnZ.Text = "En Z: 0º";
            // 
            // etiquetaPerspectivaEnY
            // 
            this.etiquetaPerspectivaEnY.AutoSize = true;
            this.etiquetaPerspectivaEnY.Location = new System.Drawing.Point(450, 573);
            this.etiquetaPerspectivaEnY.Name = "etiquetaPerspectivaEnY";
            this.etiquetaPerspectivaEnY.Size = new System.Drawing.Size(46, 13);
            this.etiquetaPerspectivaEnY.TabIndex = 38;
            this.etiquetaPerspectivaEnY.Text = "En Y: 0º";
            // 
            // etiquetaPerspectivaEnX
            // 
            this.etiquetaPerspectivaEnX.AutoSize = true;
            this.etiquetaPerspectivaEnX.Location = new System.Drawing.Point(450, 531);
            this.etiquetaPerspectivaEnX.Name = "etiquetaPerspectivaEnX";
            this.etiquetaPerspectivaEnX.Size = new System.Drawing.Size(46, 13);
            this.etiquetaPerspectivaEnX.TabIndex = 37;
            this.etiquetaPerspectivaEnX.Text = "En X: 0º";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "PSEUDO-PERSPECTIVA";
            // 
            // barPerspectivaZ
            // 
            this.barPerspectivaZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barPerspectivaZ.Location = new System.Drawing.Point(2, 612);
            this.barPerspectivaZ.Maximum = 360;
            this.barPerspectivaZ.Name = "barPerspectivaZ";
            this.barPerspectivaZ.Size = new System.Drawing.Size(445, 45);
            this.barPerspectivaZ.TabIndex = 35;
            this.barPerspectivaZ.Scroll += new System.EventHandler(this.barPerspectivaZ_Scroll);
            // 
            // barPerspectivaY
            // 
            this.barPerspectivaY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barPerspectivaY.Location = new System.Drawing.Point(2, 571);
            this.barPerspectivaY.Maximum = 360;
            this.barPerspectivaY.Name = "barPerspectivaY";
            this.barPerspectivaY.Size = new System.Drawing.Size(445, 45);
            this.barPerspectivaY.TabIndex = 34;
            this.barPerspectivaY.Scroll += new System.EventHandler(this.barPerspectivaY_Scroll);
            // 
            // barPerspectivaX
            // 
            this.barPerspectivaX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barPerspectivaX.Location = new System.Drawing.Point(2, 529);
            this.barPerspectivaX.Maximum = 360;
            this.barPerspectivaX.Name = "barPerspectivaX";
            this.barPerspectivaX.Size = new System.Drawing.Size(445, 45);
            this.barPerspectivaX.TabIndex = 33;
            this.barPerspectivaX.Scroll += new System.EventHandler(this.barPerspectivaX_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.animacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // animacionesToolStripMenuItem
            // 
            this.animacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numero1ToolStripMenuItem});
            this.animacionesToolStripMenuItem.Name = "animacionesToolStripMenuItem";
            this.animacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.animacionesToolStripMenuItem.Text = "Animaciones";
            // 
            // numero1ToolStripMenuItem
            // 
            this.numero1ToolStripMenuItem.Name = "numero1ToolStripMenuItem";
            this.numero1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.numero1ToolStripMenuItem.Text = "Numero1";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(370, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 51);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(431, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 51);
            this.button3.TabIndex = 44;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDesacelerar
            // 
            this.buttonDesacelerar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDesacelerar.Image")));
            this.buttonDesacelerar.Location = new System.Drawing.Point(309, 31);
            this.buttonDesacelerar.Name = "buttonDesacelerar";
            this.buttonDesacelerar.Size = new System.Drawing.Size(55, 51);
            this.buttonDesacelerar.TabIndex = 43;
            this.buttonDesacelerar.UseVisualStyleBackColor = true;
            this.buttonDesacelerar.Click += new System.EventHandler(this.buttonDesacelerar_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.buttonPlay.Image = global::AplicacionOpenTK.Properties.Resources.Play;
            this.buttonPlay.Location = new System.Drawing.Point(248, 31);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(55, 51);
            this.buttonPlay.TabIndex = 42;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JSON (*-json)|*.json";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Gray;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 24);
            this.comboBox2.TabIndex = 46;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos JSON (*-json)|*.json";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "Borrar objeto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Borrar Escenario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(511, 680);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDesacelerar);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.etiquetaPerspectivaEnZ);
            this.Controls.Add(this.etiquetaPerspectivaEnY);
            this.Controls.Add(this.etiquetaPerspectivaEnX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.barPerspectivaZ);
            this.Controls.Add(this.barPerspectivaY);
            this.Controls.Add(this.barPerspectivaX);
            this.Controls.Add(this.etiquetaTransformacionZ);
            this.Controls.Add(this.etiquetaTransformacionY);
            this.Controls.Add(this.etiquetaTransformacionX);
            this.Controls.Add(this.etiquetaRotacionZ);
            this.Controls.Add(this.etiquetaRotacionY);
            this.Controls.Add(this.etiquetaRotacionX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.barraEscalacionZ);
            this.Controls.Add(this.barraEscalacionY);
            this.Controls.Add(this.barraEscalacionX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.barraRotacionZ);
            this.Controls.Add(this.barraRotacionY);
            this.Controls.Add(this.barraRotacionX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etiquetaTraslacionZ);
            this.Controls.Add(this.barraTraslacionZ);
            this.Controls.Add(this.etiquetaTraslacionY);
            this.Controls.Add(this.barraTraslacionY);
            this.Controls.Add(this.etiquetaTraslacionX);
            this.Controls.Add(this.barraTraslacionX);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FGame";
            this.Text = "FGame";
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPerspectivaX)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar barraTraslacionX;
        private System.Windows.Forms.Label etiquetaTraslacionX;
        private System.Windows.Forms.Label etiquetaTraslacionY;
        private System.Windows.Forms.TrackBar barraTraslacionY;
        private System.Windows.Forms.Label etiquetaTraslacionZ;
        private System.Windows.Forms.TrackBar barraTraslacionZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar barraRotacionZ;
        private System.Windows.Forms.TrackBar barraRotacionY;
        private System.Windows.Forms.TrackBar barraRotacionX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar barraEscalacionZ;
        private System.Windows.Forms.TrackBar barraEscalacionY;
        private System.Windows.Forms.TrackBar barraEscalacionX;
        private System.Windows.Forms.Label etiquetaRotacionZ;
        private System.Windows.Forms.Label etiquetaRotacionY;
        private System.Windows.Forms.Label etiquetaRotacionX;
        private System.Windows.Forms.Label etiquetaTransformacionZ;
        private System.Windows.Forms.Label etiquetaTransformacionY;
        private System.Windows.Forms.Label etiquetaTransformacionX;
        private System.Windows.Forms.Label etiquetaPerspectivaEnZ;
        private System.Windows.Forms.Label etiquetaPerspectivaEnY;
        private System.Windows.Forms.Label etiquetaPerspectivaEnX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar barPerspectivaZ;
        private System.Windows.Forms.TrackBar barPerspectivaY;
        private System.Windows.Forms.TrackBar barPerspectivaX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numero1ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDesacelerar;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}