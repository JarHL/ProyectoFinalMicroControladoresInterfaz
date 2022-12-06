namespace InterfazSerialV2
{
    partial class ventana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana));
            this.DatosRecibidos = new System.Windows.Forms.TextBox();
            this.ModoAuto = new System.Windows.Forms.Button();
            this.IniciarCalent = new System.Windows.Forms.Button();
            this.ProgramarTemp = new System.Windows.Forms.Button();
            this.EncenderSist = new System.Windows.Forms.Button();
            this.ModoManual = new System.Windows.Forms.Button();
            this.relevadorOn = new System.Windows.Forms.Button();
            this.BuzzerOn = new System.Windows.Forms.Button();
            this.LEDOn = new System.Windows.Forms.Button();
            this.relevadorOff = new System.Windows.Forms.Button();
            this.BuzzerOff = new System.Windows.Forms.Button();
            this.LEDOff = new System.Windows.Forms.Button();
            this.mssgManual = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.BtnPuertos = new System.Windows.Forms.Button();
            this.ListaPuertos = new System.Windows.Forms.ComboBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.LabelInstruccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatosRecibidos
            // 
            this.DatosRecibidos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatosRecibidos.Location = new System.Drawing.Point(24, 41);
            this.DatosRecibidos.Name = "DatosRecibidos";
            this.DatosRecibidos.ReadOnly = true;
            this.DatosRecibidos.Size = new System.Drawing.Size(709, 20);
            this.DatosRecibidos.TabIndex = 0;
            this.DatosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DatosRecibidos.WordWrap = false;
            this.DatosRecibidos.TextChanged += new System.EventHandler(this.DatosRecibidos_TextChanged);
            // 
            // ModoAuto
            // 
            this.ModoAuto.Location = new System.Drawing.Point(85, 102);
            this.ModoAuto.Name = "ModoAuto";
            this.ModoAuto.Size = new System.Drawing.Size(88, 23);
            this.ModoAuto.TabIndex = 1;
            this.ModoAuto.Text = "Modo Auto";
            this.ModoAuto.UseVisualStyleBackColor = true;
            this.ModoAuto.Click += new System.EventHandler(this.ModoAuto_Click);
            // 
            // IniciarCalent
            // 
            this.IniciarCalent.Location = new System.Drawing.Point(143, 154);
            this.IniciarCalent.Name = "IniciarCalent";
            this.IniciarCalent.Size = new System.Drawing.Size(75, 23);
            this.IniciarCalent.TabIndex = 2;
            this.IniciarCalent.Text = "iniciar";
            this.IniciarCalent.UseVisualStyleBackColor = true;
            this.IniciarCalent.Click += new System.EventHandler(this.IniciarCalent_Click);
            // 
            // ProgramarTemp
            // 
            this.ProgramarTemp.Location = new System.Drawing.Point(24, 154);
            this.ProgramarTemp.Name = "ProgramarTemp";
            this.ProgramarTemp.Size = new System.Drawing.Size(75, 23);
            this.ProgramarTemp.TabIndex = 3;
            this.ProgramarTemp.Text = "programar t°";
            this.ProgramarTemp.UseVisualStyleBackColor = true;
            this.ProgramarTemp.Click += new System.EventHandler(this.ProgramarTemp_Click);
            // 
            // EncenderSist
            // 
            this.EncenderSist.Location = new System.Drawing.Point(328, 79);
            this.EncenderSist.Name = "EncenderSist";
            this.EncenderSist.Size = new System.Drawing.Size(89, 23);
            this.EncenderSist.TabIndex = 4;
            this.EncenderSist.Text = "encender";
            this.EncenderSist.UseVisualStyleBackColor = true;
            // 
            // ModoManual
            // 
            this.ModoManual.Location = new System.Drawing.Point(587, 102);
            this.ModoManual.Name = "ModoManual";
            this.ModoManual.Size = new System.Drawing.Size(88, 23);
            this.ModoManual.TabIndex = 5;
            this.ModoManual.Text = "Modo manual";
            this.ModoManual.UseVisualStyleBackColor = true;
            this.ModoManual.Click += new System.EventHandler(this.ModoManual_Click);
            // 
            // relevadorOn
            // 
            this.relevadorOn.Location = new System.Drawing.Point(515, 154);
            this.relevadorOn.Name = "relevadorOn";
            this.relevadorOn.Size = new System.Drawing.Size(75, 23);
            this.relevadorOn.TabIndex = 6;
            this.relevadorOn.Text = "relevador";
            this.relevadorOn.UseVisualStyleBackColor = true;
            // 
            // BuzzerOn
            // 
            this.BuzzerOn.Location = new System.Drawing.Point(515, 206);
            this.BuzzerOn.Name = "BuzzerOn";
            this.BuzzerOn.Size = new System.Drawing.Size(75, 23);
            this.BuzzerOn.TabIndex = 7;
            this.BuzzerOn.Text = "buzzer";
            this.BuzzerOn.UseVisualStyleBackColor = true;
            // 
            // LEDOn
            // 
            this.LEDOn.Location = new System.Drawing.Point(515, 248);
            this.LEDOn.Name = "LEDOn";
            this.LEDOn.Size = new System.Drawing.Size(75, 23);
            this.LEDOn.TabIndex = 8;
            this.LEDOn.Text = "LED";
            this.LEDOn.UseVisualStyleBackColor = true;
            // 
            // relevadorOff
            // 
            this.relevadorOff.Location = new System.Drawing.Point(658, 154);
            this.relevadorOff.Name = "relevadorOff";
            this.relevadorOff.Size = new System.Drawing.Size(75, 23);
            this.relevadorOff.TabIndex = 9;
            this.relevadorOff.Text = "Apagar";
            this.relevadorOff.UseVisualStyleBackColor = true;
            // 
            // BuzzerOff
            // 
            this.BuzzerOff.Location = new System.Drawing.Point(658, 206);
            this.BuzzerOff.Name = "BuzzerOff";
            this.BuzzerOff.Size = new System.Drawing.Size(75, 23);
            this.BuzzerOff.TabIndex = 10;
            this.BuzzerOff.Text = "Apagar";
            this.BuzzerOff.UseVisualStyleBackColor = true;
            // 
            // LEDOff
            // 
            this.LEDOff.Location = new System.Drawing.Point(658, 248);
            this.LEDOff.Name = "LEDOff";
            this.LEDOff.Size = new System.Drawing.Size(75, 23);
            this.LEDOff.TabIndex = 11;
            this.LEDOff.Text = "Apagar";
            this.LEDOff.UseVisualStyleBackColor = true;
            // 
            // mssgManual
            // 
            this.mssgManual.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "equipo 6: los panafrescos 2.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // BtnPuertos
            // 
            this.BtnPuertos.Location = new System.Drawing.Point(328, 154);
            this.BtnPuertos.Name = "BtnPuertos";
            this.BtnPuertos.Size = new System.Drawing.Size(89, 23);
            this.BtnPuertos.TabIndex = 13;
            this.BtnPuertos.Text = "Buscar Puertos";
            this.BtnPuertos.UseVisualStyleBackColor = true;
            this.BtnPuertos.Click += new System.EventHandler(this.Puertos_Click);
            // 
            // ListaPuertos
            // 
            this.ListaPuertos.FormattingEnabled = true;
            this.ListaPuertos.Location = new System.Drawing.Point(307, 206);
            this.ListaPuertos.Name = "ListaPuertos";
            this.ListaPuertos.Size = new System.Drawing.Size(121, 21);
            this.ListaPuertos.TabIndex = 14;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(328, 280);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(89, 23);
            this.BtnConectar.TabIndex = 15;
            this.BtnConectar.Text = "conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // LabelInstruccion
            // 
            this.LabelInstruccion.AutoSize = true;
            this.LabelInstruccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstruccion.Location = new System.Drawing.Point(231, 120);
            this.LabelInstruccion.Name = "LabelInstruccion";
            this.LabelInstruccion.Size = new System.Drawing.Size(281, 22);
            this.LabelInstruccion.TabIndex = 16;
            this.LabelInstruccion.Text = "Elija el puerto al cual conectarse";
            this.LabelInstruccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelInstruccion);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.ListaPuertos);
            this.Controls.Add(this.BtnPuertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LEDOff);
            this.Controls.Add(this.BuzzerOff);
            this.Controls.Add(this.relevadorOff);
            this.Controls.Add(this.LEDOn);
            this.Controls.Add(this.BuzzerOn);
            this.Controls.Add(this.relevadorOn);
            this.Controls.Add(this.ModoManual);
            this.Controls.Add(this.EncenderSist);
            this.Controls.Add(this.ProgramarTemp);
            this.Controls.Add(this.IniciarCalent);
            this.Controls.Add(this.ModoAuto);
            this.Controls.Add(this.DatosRecibidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventana";
            this.Text = "control calentador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatosRecibidos;
        private System.Windows.Forms.Button ModoAuto;
        private System.Windows.Forms.Button IniciarCalent;
        private System.Windows.Forms.Button ProgramarTemp;
        private System.Windows.Forms.Button EncenderSist;
        private System.Windows.Forms.Button ModoManual;
        private System.Windows.Forms.Button relevadorOn;
        private System.Windows.Forms.Button BuzzerOn;
        private System.Windows.Forms.Button LEDOn;
        private System.Windows.Forms.Button relevadorOff;
        private System.Windows.Forms.Button BuzzerOff;
        private System.Windows.Forms.Button LEDOff;
        private System.Windows.Forms.ToolTip mssgManual;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Button BtnPuertos;
        private System.Windows.Forms.ComboBox ListaPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label LabelInstruccion;
    }
}

