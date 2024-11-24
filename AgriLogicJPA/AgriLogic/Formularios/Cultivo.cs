using AgriLogic.Modelo_De_Clases;
using System;
using System.Collections.Generic;
using System.IO;
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
            btnGuardar.Click += new EventHandler(btnGuardar_Click); // Asociar el evento Click del botón Guardar
            btnCargar.Click += new EventHandler(btnCargar_Click); // Asociar el evento Click del botón Cargar
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

            // Verificar si el cultivo ya existe en la lista
            int index = cultivos.FindIndex(c => c.CultivoID == cultivo.CultivoID);
            if (index != -1)
            {
                cultivos[index] = cultivo; // Actualizar el cultivo existente
            }
            else
            {
                cultivos.Add(cultivo); // Agregar nuevo cultivo
            }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string filePath = "cultivos.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Cultivo cultivo in cultivos)
                    {
                        string cultivoData = $"{cultivo.CultivoID},{cultivo.TipoCultivo},{cultivo.RequisitosCultivo},{cultivo.FechaSiembra},{cultivo.FechaCosecha}";
                        writer.WriteLine(cultivoData);
                    }
                }

                MessageBox.Show("Datos guardados exitosamente.", "Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string filePath = "cultivos.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    cultivos.Clear();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] cultivoData = line.Split(',');

                            Cultivo cultivo = new Cultivo
                            {
                                CultivoID = int.Parse(cultivoData[0]),
                                TipoCultivo = cultivoData[1],
                                RequisitosCultivo = cultivoData[2],
                                FechaSiembra = DateTime.Parse(cultivoData[3]),
                                FechaCosecha = DateTime.Parse(cultivoData[4])
                            };

                            cultivos.Add(cultivo);
                        }
                    }

                    MostrarDatos();
                    MessageBox.Show("Datos cargados exitosamente.", "Cargar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de datos.", "Cargar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
