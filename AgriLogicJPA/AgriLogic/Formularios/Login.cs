using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AgriLogic.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
           if (txtusuario.Text == "Julio Cesar" && txtcontraseña.Text == "23021490")
            {
                new lobby().Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos Volver a Intentar");
                txtcontraseña.Clear();
                txtusuario.Clear(); 
            }

        }
    }
}
