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
            this.ModoManual = new System.Windows.Forms.Button();
            this.mssgManual = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.BtnPuertos = new System.Windows.Forms.Button();
            this.ListaPuertos = new System.Windows.Forms.ComboBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.LabelInstruccion = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAuto = new System.Windows.Forms.Panel();
            this.panelManual = new System.Windows.Forms.Panel();
            this.TermoImage = new System.Windows.Forms.PictureBox();
            this.panelBotones.SuspendLayout();
            this.PanelAuto.SuspendLayout();
            this.panelManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TermoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosRecibidos
            // 
            this.DatosRecibidos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatosRecibidos.Location = new System.Drawing.Point(44, 31);
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
            this.ModoAuto.AutoSize = true;
            this.ModoAuto.BackColor = System.Drawing.Color.MidnightBlue;
            this.ModoAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModoAuto.ForeColor = System.Drawing.Color.White;
            this.ModoAuto.Location = new System.Drawing.Point(46, 15);
            this.ModoAuto.Name = "ModoAuto";
            this.ModoAuto.Size = new System.Drawing.Size(123, 35);
            this.ModoAuto.TabIndex = 1;
            this.ModoAuto.Text = "Modo Auto";
            this.ModoAuto.UseVisualStyleBackColor = false;
            this.ModoAuto.Click += new System.EventHandler(this.ModoAuto_Click);
            // 
            // IniciarCalent
            // 
            this.IniciarCalent.BackColor = System.Drawing.Color.LimeGreen;
            this.IniciarCalent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarCalent.Location = new System.Drawing.Point(133, 76);
            this.IniciarCalent.Name = "IniciarCalent";
            this.IniciarCalent.Size = new System.Drawing.Size(95, 33);
            this.IniciarCalent.TabIndex = 2;
            this.IniciarCalent.Text = "iniciar";
            this.IniciarCalent.UseVisualStyleBackColor = false;
            this.IniciarCalent.Click += new System.EventHandler(this.IniciarCalent_Click);
            // 
            // ProgramarTemp
            // 
            this.ProgramarTemp.BackColor = System.Drawing.Color.Tomato;
            this.ProgramarTemp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramarTemp.Location = new System.Drawing.Point(0, 76);
            this.ProgramarTemp.Name = "ProgramarTemp";
            this.ProgramarTemp.Size = new System.Drawing.Size(95, 33);
            this.ProgramarTemp.TabIndex = 3;
            this.ProgramarTemp.Text = "ajustar C°";
            this.ProgramarTemp.UseVisualStyleBackColor = false;
            this.ProgramarTemp.Click += new System.EventHandler(this.ProgramarTemp_Click);
            // 
            // ModoManual
            // 
            this.ModoManual.BackColor = System.Drawing.Color.Firebrick;
            this.ModoManual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModoManual.ForeColor = System.Drawing.Color.White;
            this.ModoManual.Location = new System.Drawing.Point(53, 15);
            this.ModoManual.Name = "ModoManual";
            this.ModoManual.Size = new System.Drawing.Size(123, 35);
            this.ModoManual.TabIndex = 5;
            this.ModoManual.Text = "Modo manual";
            this.ModoManual.UseVisualStyleBackColor = false;
            this.ModoManual.Click += new System.EventHandler(this.ModoManual_Click);
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
            this.BtnPuertos.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnPuertos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPuertos.Location = new System.Drawing.Point(331, 153);
            this.BtnPuertos.Name = "BtnPuertos";
            this.BtnPuertos.Size = new System.Drawing.Size(127, 34);
            this.BtnPuertos.TabIndex = 13;
            this.BtnPuertos.Text = "Buscar Puertos";
            this.BtnPuertos.UseVisualStyleBackColor = false;
            this.BtnPuertos.Click += new System.EventHandler(this.Puertos_Click);
            // 
            // ListaPuertos
            // 
            this.ListaPuertos.FormattingEnabled = true;
            this.ListaPuertos.Location = new System.Drawing.Point(331, 203);
            this.ListaPuertos.Name = "ListaPuertos";
            this.ListaPuertos.Size = new System.Drawing.Size(121, 21);
            this.ListaPuertos.TabIndex = 14;
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnConectar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.ForeColor = System.Drawing.Color.Black;
            this.BtnConectar.Location = new System.Drawing.Point(331, 286);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(134, 49);
            this.BtnConectar.TabIndex = 15;
            this.BtnConectar.Text = "conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // LabelInstruccion
            // 
            this.LabelInstruccion.AutoSize = true;
            this.LabelInstruccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstruccion.Location = new System.Drawing.Point(255, 117);
            this.LabelInstruccion.Name = "LabelInstruccion";
            this.LabelInstruccion.Size = new System.Drawing.Size(281, 22);
            this.LabelInstruccion.TabIndex = 16;
            this.LabelInstruccion.Text = "Elija el puerto al cual conectarse";
            this.LabelInstruccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.button3);
            this.panelBotones.Controls.Add(this.button2);
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.label4);
            this.panelBotones.Controls.Add(this.label3);
            this.panelBotones.Controls.Add(this.label2);
            this.panelBotones.Location = new System.Drawing.Point(3, 88);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 149);
            this.panelBotones.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 39);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 39);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Buzzer";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "LED";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "relevador";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // PanelAuto
            // 
            this.PanelAuto.BackColor = System.Drawing.Color.PowderBlue;
            this.PanelAuto.Controls.Add(this.ProgramarTemp);
            this.PanelAuto.Controls.Add(this.IniciarCalent);
            this.PanelAuto.Controls.Add(this.ModoAuto);
            this.PanelAuto.Location = new System.Drawing.Point(36, 78);
            this.PanelAuto.Name = "PanelAuto";
            this.PanelAuto.Size = new System.Drawing.Size(231, 237);
            this.PanelAuto.TabIndex = 21;
            // 
            // panelManual
            // 
            this.panelManual.BackColor = System.Drawing.Color.PowderBlue;
            this.panelManual.Controls.Add(this.panelBotones);
            this.panelManual.Controls.Add(this.ModoManual);
            this.panelManual.Location = new System.Drawing.Point(534, 78);
            this.panelManual.Name = "panelManual";
            this.panelManual.Size = new System.Drawing.Size(223, 237);
            this.panelManual.TabIndex = 22;
            // 
            // TermoImage
            // 
            this.TermoImage.Location = new System.Drawing.Point(331, 114);
            this.TermoImage.Name = "TermoImage";
            this.TermoImage.Size = new System.Drawing.Size(148, 166);
            this.TermoImage.TabIndex = 23;
            this.TermoImage.TabStop = false;
            this.TermoImage.Click += new System.EventHandler(this.TermoImage_Click);
            // 
            // ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TermoImage);
            this.Controls.Add(this.panelManual);
            this.Controls.Add(this.LabelInstruccion);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.ListaPuertos);
            this.Controls.Add(this.BtnPuertos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosRecibidos);
            this.Controls.Add(this.PanelAuto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventana";
            this.Text = "control calentador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.PanelAuto.ResumeLayout(false);
            this.PanelAuto.PerformLayout();
            this.panelManual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TermoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatosRecibidos;
        private System.Windows.Forms.Button ModoAuto;
        private System.Windows.Forms.Button IniciarCalent;
        private System.Windows.Forms.Button ProgramarTemp;
        private System.Windows.Forms.Button ModoManual;
        private System.Windows.Forms.ToolTip mssgManual;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Button BtnPuertos;
        private System.Windows.Forms.ComboBox ListaPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label LabelInstruccion;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelAuto;
        private System.Windows.Forms.Panel panelManual;
        private System.Windows.Forms.PictureBox TermoImage;
    }
}

