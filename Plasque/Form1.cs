using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Plasque
{

    public partial class s : Form
    {
        String departamento = "";
        int[] usadas = new int[20];
        String respuesta = "";
        int correctas = 0;
        int erroneas = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public s()
        {
            InitializeComponent();
            botonRestaurar.Visible = false;
            calificarBoton.Visible = false;
            pregunta.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                peten.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "peten";
            }
            else
            {
                peten.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                altaVerapaz.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "altaVerapaz";
            }
            else
            {
                altaVerapaz.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                huehuetenango.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "huehuetenango";
            }
            else
            {
                huehuetenango.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                Quiche.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "quiche";
            }
            else
            {
                Quiche.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }
            }
        private void button5_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                izabal.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "izabal";
            }
            else
            {
                izabal.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                zacapa.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "zacapa";
            }
            else
            {
                zacapa.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                chiquimula.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "chiquimula";
            }
            else
            {
                chiquimula.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                jutiapa.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "jutiapa";
            }
            else
            {
                jutiapa.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                jalapa.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "jalapa";
            }
            else
            {
                jalapa.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                progreso.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "progreso";
            }
            else
            {
                progreso.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                guatemala.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "guatemala";
            }
            else
            {
                guatemala.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                santaRosa.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "santaRosa";
            }
            else
            {
                santaRosa.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                escuintla.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "escuintla";
            }
            else
            {
                escuintla.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                sacatepequez.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "sacatepequez";
            }
            else
            {
                sacatepequez.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                chimaltenango.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "chimaltenango";
            }
            else
            {
                chimaltenango.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                solola.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "solola";
            }
            else
            {
                solola.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                totonicapan.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "totonicapan";
            }
            else
            {
                totonicapan.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                suchitepequez.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "suchitepequez";
            }
            else
            {
                suchitepequez.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                retahuleo.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "retahuleo";
            }
            else
            {
                retahuleo.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                xela.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "xela";
            }
            else
            {
                xela.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                sanMarcos.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "sanMarcos";
            }
            else
            {
                sanMarcos.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (departamento == "")
            {
                bajaVerapaz.Image = Plasque.Properties.Resources._299087_marker_map_icon__1_;
                departamento = "bajaVerapaz";
            }
            else
            {
                bajaVerapaz.Image = Plasque.Properties.Resources._299087_marker_map_icon;
                departamento = "";
            }

        }

        private void botonSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonMax_Click(object sender, EventArgs e)
        {
            botonMax.Visible = false;
            botonRestaurar.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void botonRestaurar_Click(object sender, EventArgs e)
        {
            botonRestaurar.Visible = false;
            botonMax.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void botonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelCabeza_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 60)
            {
                tmOcultarMenu.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 20;
            }
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 200)
            {
                tmMostrarMenu.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width + 20;
            }
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 200) 
            {
                tmOcultarMenu.Enabled = true;
            } 
            else 
            {
                tmMostrarMenu.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void jugarBoton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 19; i++)
            {
                usadas[i] = 0;
            }
            pregunta.Visible = true;
            calificarBoton.Visible = true;
            jugarBoton.Visible = false;
            label1.Visible = false;
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 20);
            pregunta.Text = obtenerPregunta(ranNum).Item1;
            respuesta = obtenerPregunta(ranNum).Item2;
        }

        private Tuple<String , String> obtenerPregunta(int n)
        {
            String p = "";
            String r = "";
            switch (n)
            {
                case 1:
                    p = "¿Donde esta tikal?";
                    r = "peten";
                    break;
                case 2:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 3:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 4:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 5:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 6:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 7:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 8:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 9:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 10:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 11:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 12:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 13:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 14:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 15:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 16:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 17:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 18:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 19:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
                case 20:
                    p = "¿Donde esta tikal?";
                    r = "Peten";
                    break;
            }
            usadas[n] = 1;
            return new Tuple<String, String>(p, r);
        }

        private void calificarBoton_Click(object sender, EventArgs e)
        {
            if (respuesta == departamento)
            {
                correctas++;
                MessageBox.Show("Correcta!");
            }
            else
            {
                erroneas++;
                MessageBox.Show("Incorrecta!");
            }
            Boolean seAcabo = true;
            for (int i = 0; i < 19; i++)
            {
                if (usadas[i] != 1)
                {
                    seAcabo = false;
                }
            }
            if (seAcabo)
            {
                string message = "¡Se acabo!\n";
                string caption = "Buenas: " + correctas + "\nMalas: " + erroneas;
                MessageBox.Show(message + caption);
                calificarBoton.Visible = false;
                pregunta.Visible = false;
                label1.Visible = true;
                jugarBoton.Visible = true;
            }
            else
            {
                int nuevoNumero = -1;
                while (nuevoNumero == -1)
                {
                    Random myObject = new Random();
                    int ranNum = myObject.Next(0, 19);

                    if (usadas[ranNum] != 1)
                    {
                        nuevoNumero = ranNum;
                    }
                }

                pregunta.Text = obtenerPregunta(nuevoNumero).Item1;
                respuesta = obtenerPregunta(nuevoNumero).Item2;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
