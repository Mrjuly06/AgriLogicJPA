using AgriLogic.Formularios;
using InventarioApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriLogic
{
    public partial class lobby : Form
    {
        public lobby()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormularioCultivo = new Form1();
            FormularioCultivo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormularioCalendario = new FormularioCalendario();
            FormularioCalendario.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form formInventario = new form2();
            formInventario.Show();
        }
    }
}
