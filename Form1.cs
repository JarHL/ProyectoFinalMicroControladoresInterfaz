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

            //NOTA: intentar agregar esto en una funcion para no repetir
            //NOTA: usar el valor booleano como variable de la funcion para optimizar code:1
            //hace invisible al inicio
            EncenderSist.Visible = false;
            ModoManual.Visible = false;
            relevadorOn.Visible = false;
            relevadorOff.Visible = false;
            BuzzerOn.Visible = false;
            BuzzerOff.Visible = false;
            LEDOn.Visible = false;
            LEDOff.Visible = false;

            ModoAuto.Visible = false;
            IniciarCalent.Visible = false;
            ProgramarTemp.Visible = false;

            //deshabilita los botones
            ModoManual.Enabled= false;
            relevadorOn.Enabled = false;
            relevadorOff.Enabled = false;
            BuzzerOn.Enabled = false;
            BuzzerOff.Enabled = false;
            LEDOn.Enabled = false;
            LEDOff.Enabled = false;

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
            //deshabilita el modo manual
            relevadorOn.Enabled = false;
            relevadorOff.Enabled = false;
            BuzzerOn.Enabled = false;
            BuzzerOff.Enabled = false;
            LEDOn.Enabled = false;  
            LEDOff.Enabled = false;

            //habilita botones modo auto
            IniciarCalent.Enabled = true;
            ProgramarTemp.Enabled = true;

        }

        private void ModoManual_Click(object sender, EventArgs e)
        {
            //habilita botones modo manual
            MessageBox.Show("mantega vigilado el equipo mientras esta habilitado este modo");
            relevadorOn.Enabled = true;
            relevadorOff.Enabled = true;
            BuzzerOn.Enabled = true;
            BuzzerOff.Enabled = true;
            LEDOn.Enabled = true;
            LEDOff.Enabled = true;

            //deshabilita botones modo auto
            IniciarCalent.Enabled = false;
            ProgramarTemp.Enabled = false;
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

                        //habilitar botones code:1
                        //EncenderSist.Visible = true;
                        ModoManual.Visible = true;
                        relevadorOn.Visible = true;
                        relevadorOff.Visible = true;
                        BuzzerOn.Visible = true;
                        BuzzerOff.Visible = true;
                        LEDOn.Visible = true;
                        LEDOff.Visible = true;

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
                    //deshabilitar botones code:1
                    //hace invisible al inicio
                    EncenderSist.Visible = false;
                    ModoManual.Visible = false;
                    relevadorOn.Visible = false;
                    relevadorOff.Visible = false;
                    BuzzerOn.Visible = false;
                    BuzzerOff.Visible = false;
                    LEDOn.Visible = false;
                    LEDOff.Visible = false;

                    ModoAuto.Visible = false;
                    IniciarCalent.Visible = false;
                    ProgramarTemp.Visible = false;

                    //deshabilita los botones
                    ModoManual.Enabled = false;
                    relevadorOn.Enabled = false;
                    relevadorOff.Enabled = false;
                    BuzzerOn.Enabled = false;
                    BuzzerOff.Enabled = false;
                    LEDOn.Enabled = false;
                    LEDOff.Enabled = false;

                    ModoAuto.Enabled = false;
                    IniciarCalent.Enabled = false;
                    ProgramarTemp.Enabled = false;
                    //fin de la deshabilitacion

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
        }

        private void DatosRecibidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramarTemp_Click(object sender, EventArgs e)
        {
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
    }
}
