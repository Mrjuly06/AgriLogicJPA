using AgriLogic.Modelo_De_Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgriLogic.Formularios
{
    public partial class Form1 : Form
    {
        private List<Cultivo> cultivos; // Inicializar lista de cultivos

        public Form1()
        {
            InitializeComponent();
            cultivos = new List<Cultivo>(); // Inicializar lista de cultivos
            btnAgregar.Click += new EventHandler(btnAgregar_Click); // Asociar el evento Click del botón
            ConfigurarDataGridView(); // Configurar DataGridView
        }

        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView
            dgvRegistros.ColumnCount = 5;
            dgvRegistros.Columns[0].Name = "ID";
            dgvRegistros.Columns[1].Name = "Tipo";
            dgvRegistros.Columns[2].Name = "Requisito";
            dgvRegistros.Columns[3].Name = "Fecha de Siembra";
            dgvRegistros.Columns[4].Name = "Fecha de Cosecha";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cultivo cultivo = new Cultivo();

            try
            {
                cultivo.CultivoID = int.Parse(txtId.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número entero válido en el campo ID.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la conversión falla
            }

            cultivo.TipoCultivo = txtTipo.Text;
            cultivo.RequisitosCultivo = txtRequisito.Text;
            cultivo.FechaSiembra = dtpSiembra.Value;
            cultivo.FechaCosecha = dtpCosecha.Value;

            cultivos.Add(cultivo);
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            dgvRegistros.Rows.Clear();
            foreach (var cultivo in cultivos)
            {
                dgvRegistros.Rows.Add(cultivo.CultivoID, cultivo.TipoCultivo, cultivo.RequisitosCultivo, cultivo.FechaSiembra.ToShortDateString(), cultivo.FechaCosecha.ToShortDateString());
            }
        }
    }
}
