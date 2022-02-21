using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        //Método que cerrará la aplicación entera cuando se cierre este form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventana01 ventana = new Ventana01();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventana02 ventana = new Ventana02();
            ventana.Show();
        }
    }
}
