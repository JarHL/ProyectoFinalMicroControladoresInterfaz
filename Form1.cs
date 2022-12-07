using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace InterfazSerialV2
{
    public partial class ventana : Form
    {
        private string strBufferIn;
        private string strBufferOut;

        private delegate void DelegadoAcceso(string accion);
        public ventana()
        {
            InitializeComponent();
            //this.mssgManual.SetToolTip(this.ModoManual, "mantega vigilado el equipo mientras esta habilitado este modo");
        }

        private void accesoForm(string accion)  //carga los datos en el buffer de entrada
        {
            strBufferIn= accion;
            //se encuentran los datos ingresador por puertoSerie
            DatosRecibidos.Text= strBufferIn;
        }

        private void accesoInterrupcion(string accion)
        {
            //se creara un variable del delegado que permita accesar al form
            DelegadoAcceso varDelegadoAcceso;
            varDelegadoAcceso = new DelegadoAcceso(accesoForm);
            object[] arg = { accion };
            base.Invoke(varDelegadoAcceso, arg);
        }
        //inicio del programa

        private void Form1_Load(object sender, EventArgs e)
        {
            //añadir imagen
            TermoImage.Image = Image.FromFile("F:\\Users\\Jared\\Documents\\programacion\\VisualStudioAplicaciones\\interfazSerial\\InterfazSerialV2\\iconos\\Medicina-432.gif");
            TermoImage.SizeMode = PictureBoxSizeMode.StretchImage;
            TermoImage.Visible= false;
            //NOTA: intentar agregar esto en una funcion para no repetir
            //NOTA: usar el valor booleano como variable de la funcion para optimizar code:1
            //hace invisible al inicio
            ModoManual.Visible = false;
            panelBotones.Visible = false;

            ModoAuto.Visible = false;
            IniciarCalent.Visible = false;
            ProgramarTemp.Visible = false;

            //deshabilita los botones
            ModoManual.Enabled= false;
            panelBotones.Enabled= false;

            ModoAuto.Enabled = false;
            IniciarCalent.Enabled = false;
            ProgramarTemp.Enabled = false;
            //fin de la deshabilitacion

            //inicializa las variables 
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;

        }

        private void ModoAuto_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("*");
            //deshabilita el modo manual
            panelBotones.Enabled = false;
            //habilita botones modo auto
            IniciarCalent.Enabled = true;
            ProgramarTemp.Enabled = true;
            PuertoSerie.WriteLine("*");
            PuertoSerie.WriteLine("B");

            //asigna colores botones en rojo
            button3.BackColor = Color.OrangeRed;
            button2.BackColor = Color.OrangeRed;
            button1.BackColor = Color.OrangeRed;

            TermoImage.Visible = false;
        }

        private void ModoManual_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("C");
            TermoImage.Visible = false;
            //habilita botones modo manual
            MessageBox.Show("mantega vigilado el equipo mientras esta habilitado este modo");
            panelBotones.Enabled = true;

            //deshabilita botones modo auto
            IniciarCalent.Enabled = false;
            ProgramarTemp.Enabled = false;
            PuertoSerie.WriteLine("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conectar_Click(object sender, EventArgs e)
        {

            try
            {
                if (BtnConectar.Text == "conectar")
                {
                    //inicamos el puerto serie
                    PuertoSerie.BaudRate = 9600;
                    PuertoSerie.DataBits = 8;
                    PuertoSerie.Parity = Parity.None;
                    PuertoSerie.StopBits = StopBits.One;
                    PuertoSerie.Handshake = Handshake.None;
                    PuertoSerie.PortName = ListaPuertos.Text;

                    try
                    {
                        //coencta el puerto serie
                        PuertoSerie.Open();
                        BtnConectar.Text = "desconectar";
                        BtnConectar.BackColor= Color.Firebrick;
                        BtnConectar.ForeColor = Color.White;
                        

                        //habilitar botones code:1
                        //EncenderSist.Visible = true;
                        ModoManual.Visible = true;
                        panelBotones.Visible = true;

                        ModoAuto.Visible = true;
                        IniciarCalent.Visible = true;
                        ProgramarTemp.Visible = true;

                        ModoAuto.Enabled= true;
                        ModoManual.Enabled= true;
                        //fin de la habilitacion

                        //code:2
                        BtnPuertos.Visible = false;
                        ListaPuertos.Visible = false;
                        LabelInstruccion.Visible = false;
                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message.ToString());    //muestra el error en una ventana
                    }
                }
                else if (BtnConectar.Text == "desconectar")
                {
                    //desconecta el puerto serie
                    PuertoSerie.Close();
                    BtnConectar.Text = "conectar";
                    //cambio color boton
                    BtnConectar.BackColor = Color.LimeGreen;
                    BtnConectar.ForeColor = Color.Black;
                    //deshabilitar botones code:1
                    //hace invisible al inicio
                    ModoManual.Visible = false;
                    panelBotones.Visible= false;

                    ModoAuto.Visible = false;
                    IniciarCalent.Visible = false;
                    ProgramarTemp.Visible = false;

                    //deshabilita los botones
                    ModoManual.Enabled = false;
                    panelBotones.Enabled= false;

                    ModoAuto.Enabled = false;
                    IniciarCalent.Enabled = false;
                    ProgramarTemp.Enabled = false;
                    //fin de la deshabilitacion
                    TermoImage.Visible = false;

                    //code:2
                    BtnPuertos.Visible = true;
                    ListaPuertos.Visible = true;
                    LabelInstruccion.Visible = true;

                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());    //muestra el error en una ventana


            }
        }

        private void Puertos_Click(object sender, EventArgs e)
        {
            string[] puertosDisponibles = SerialPort.GetPortNames();

            ListaPuertos.Items.Clear();

            foreach (string puerto_simple in puertosDisponibles) 
            {
                ListaPuertos.Items.Add(puerto_simple);
            }

            if (ListaPuertos.Items.Count > 0)
            {
                ListaPuertos.SelectedIndex= 0;
                MessageBox.Show("seleccioanr el puerto de trabajo");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("nigun puerto detectado");
                ListaPuertos.Items.Clear();
                ListaPuertos.Text = "                       ";
                //declara las variables
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;
            }


        }

        private void IniciarCalent_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("A");
            TermoImage.Visible = true;
            PuertoSerie.WriteLine("A");
        }

        private void DatosRecibidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramarTemp_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("B");
            TermoImage.Visible = false;
            PuertoSerie.WriteLine("B");
        }

        private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            accesoInterrupcion(PuertoSerie.ReadLine());
            /*string DataIn = PuertoSerie.ReadLine();
            MessageBox.Show(DataIn);
            DatosRecibidos.Text = DataIn; */ //genera excepcion no controlada
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //PuertoSerie.WriteLine("F");
        }

        private void radioBtnRele_CheckedChanged(object sender, EventArgs e)
        {
            //PuertoSerie.WriteLine("D");
        }

        private void radioBtnLED_CheckedChanged(object sender, EventArgs e)
        {
            //PuertoSerie.WriteLine("E");
        }

        private void radioBtnRele_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("D");
        }

        private void radioBtnLED_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("E");
        }

        private void radioBtnBuzzer_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("F");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("D");
            if (button1.BackColor == Color.OrangeRed)
            {
                button1.BackColor = Color.LimeGreen;
            }
            else
            {
                button1.BackColor = Color.OrangeRed;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("E");
            if (button2.BackColor == Color.OrangeRed)
            {
                button2.BackColor = Color.LimeGreen;
            }
            else
            {
                button2.BackColor = Color.OrangeRed;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PuertoSerie.WriteLine("F");
            if (button3.BackColor == Color.OrangeRed)
            {
                button3.BackColor = Color.LimeGreen;
            }
            else
            {
                button3.BackColor = Color.OrangeRed;
            }
        }

        private void TermoImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
