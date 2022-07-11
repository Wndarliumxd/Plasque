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

    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            botonRestaurar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
