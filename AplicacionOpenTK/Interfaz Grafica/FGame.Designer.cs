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
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraTraslacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraRotacionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraEscalacionX)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // barraTraslacionX
            // 
            this.barraTraslacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionX.Location = new System.Drawing.Point(5, 65);
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
            this.etiquetaTraslacionX.Location = new System.Drawing.Point(453, 67);
            this.etiquetaTraslacionX.Name = "etiquetaTraslacionX";
            this.etiquetaTraslacionX.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTraslacionX.TabIndex = 6;
            this.etiquetaTraslacionX.Text = "En X:";
            // 
            // etiquetaTraslacionY
            // 
            this.etiquetaTraslacionY.AutoSize = true;
            this.etiquetaTraslacionY.Location = new System.Drawing.Point(453, 109);
            this.etiquetaTraslacionY.Name = "etiquetaTraslacionY";
            this.etiquetaTraslacionY.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTraslacionY.TabIndex = 8;
            this.etiquetaTraslacionY.Text = "En Y:";
            // 
            // barraTraslacionY
            // 
            this.barraTraslacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionY.Location = new System.Drawing.Point(5, 107);
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
            this.etiquetaTraslacionZ.Location = new System.Drawing.Point(453, 150);
            this.etiquetaTraslacionZ.Name = "etiquetaTraslacionZ";
            this.etiquetaTraslacionZ.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTraslacionZ.TabIndex = 10;
            this.etiquetaTraslacionZ.Text = "En Z:";
            // 
            // barraTraslacionZ
            // 
            this.barraTraslacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraTraslacionZ.Location = new System.Drawing.Point(5, 148);
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
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TRANSFORMACIÓN DE TRASLACIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "TRANSFORMACIÓN DE ROTACIÓN";
            // 
            // barraRotacionZ
            // 
            this.barraRotacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionZ.Location = new System.Drawing.Point(5, 295);
            this.barraRotacionZ.Maximum = 360;
            this.barraRotacionZ.Name = "barraRotacionZ";
            this.barraRotacionZ.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionZ.TabIndex = 16;
            this.barraRotacionZ.Scroll += new System.EventHandler(this.barraRotacionZ_Scroll);
            // 
            // barraRotacionY
            // 
            this.barraRotacionY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionY.Location = new System.Drawing.Point(5, 254);
            this.barraRotacionY.Maximum = 360;
            this.barraRotacionY.Name = "barraRotacionY";
            this.barraRotacionY.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionY.TabIndex = 14;
            this.barraRotacionY.Scroll += new System.EventHandler(this.barraRotacionY_Scroll);
            // 
            // barraRotacionX
            // 
            this.barraRotacionX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraRotacionX.Location = new System.Drawing.Point(5, 212);
            this.barraRotacionX.Maximum = 360;
            this.barraRotacionX.Name = "barraRotacionX";
            this.barraRotacionX.Size = new System.Drawing.Size(445, 45);
            this.barraRotacionX.TabIndex = 12;
            this.barraRotacionX.Scroll += new System.EventHandler(this.barraRotacionX_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "TRANSFORMACIÓN DE ESCALACIÓN";
            // 
            // barraEscalacionZ
            // 
            this.barraEscalacionZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barraEscalacionZ.Location = new System.Drawing.Point(5, 442);
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
            this.barraEscalacionY.Location = new System.Drawing.Point(5, 401);
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
            this.barraEscalacionX.Location = new System.Drawing.Point(5, 359);
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
            this.etiquetaRotacionZ.Location = new System.Drawing.Point(453, 297);
            this.etiquetaRotacionZ.Name = "etiquetaRotacionZ";
            this.etiquetaRotacionZ.Size = new System.Drawing.Size(33, 13);
            this.etiquetaRotacionZ.TabIndex = 28;
            this.etiquetaRotacionZ.Text = "En Z:";
            // 
            // etiquetaRotacionY
            // 
            this.etiquetaRotacionY.AutoSize = true;
            this.etiquetaRotacionY.Location = new System.Drawing.Point(453, 256);
            this.etiquetaRotacionY.Name = "etiquetaRotacionY";
            this.etiquetaRotacionY.Size = new System.Drawing.Size(33, 13);
            this.etiquetaRotacionY.TabIndex = 27;
            this.etiquetaRotacionY.Text = "En Y:";
            // 
            // etiquetaRotacionX
            // 
            this.etiquetaRotacionX.AutoSize = true;
            this.etiquetaRotacionX.Location = new System.Drawing.Point(453, 214);
            this.etiquetaRotacionX.Name = "etiquetaRotacionX";
            this.etiquetaRotacionX.Size = new System.Drawing.Size(33, 13);
            this.etiquetaRotacionX.TabIndex = 26;
            this.etiquetaRotacionX.Text = "En X:";
            // 
            // etiquetaTransformacionZ
            // 
            this.etiquetaTransformacionZ.AutoSize = true;
            this.etiquetaTransformacionZ.Location = new System.Drawing.Point(453, 445);
            this.etiquetaTransformacionZ.Name = "etiquetaTransformacionZ";
            this.etiquetaTransformacionZ.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTransformacionZ.TabIndex = 31;
            this.etiquetaTransformacionZ.Text = "En Z:";
            // 
            // etiquetaTransformacionY
            // 
            this.etiquetaTransformacionY.AutoSize = true;
            this.etiquetaTransformacionY.Location = new System.Drawing.Point(453, 404);
            this.etiquetaTransformacionY.Name = "etiquetaTransformacionY";
            this.etiquetaTransformacionY.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTransformacionY.TabIndex = 30;
            this.etiquetaTransformacionY.Text = "En Y:";
            // 
            // etiquetaTransformacionX
            // 
            this.etiquetaTransformacionX.AutoSize = true;
            this.etiquetaTransformacionX.Location = new System.Drawing.Point(453, 362);
            this.etiquetaTransformacionX.Name = "etiquetaTransformacionX";
            this.etiquetaTransformacionX.Size = new System.Drawing.Size(33, 13);
            this.etiquetaTransformacionX.TabIndex = 29;
            this.etiquetaTransformacionX.Text = "En X:";
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(505, 586);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}