using AgriLogic.Modelo_De_Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InventarioApp
{
    public partial class form2 : Form
    {
        private List<Inventario> inventarios; // Lista de inventarios

        public form2()
        {
            InitializeComponent();
            inventarios = new List<Inventario>(); // Inicializar lista de inventarios
            btnAgregar.Click += new EventHandler(btnAgregar_Click); // Asociar el evento Click del botón Agregar
            btnBuscar.Click += new EventHandler(btnBuscar_Click); // Asociar el evento Click del botón Buscar
            btnGuardar.Click += new EventHandler(btnGuardar_Click_1); // Asociar el evento Click del botón Guardar
            btnCargar.Click += new EventHandler(btnCargar_Click_1); // Asociar el evento Click del botón Cargar
            ConfigurarDataGridView(); // Configurar DataGridView
        }

        private void ConfigurarDataGridView()
        {
            // Configurar columnas del DataGridView
            dgvInventario.ColumnCount = 5;
            dgvInventario.Columns[0].Name = "Inventario ID";
            dgvInventario.Columns[1].Name = "Nombre Insumo";
            dgvInventario.Columns[2].Name = "Cantidad Disponible";
            dgvInventario.Columns[3].Name = "Unidad de Medida";
            dgvInventario.Columns[4].Name = "Fecha Último Reabastecimiento";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int inventarioID = int.Parse(txtInventarioID.Text);
                Inventario inventario = inventarios.Find(i => i.InventarioID == inventarioID);

                if (inventario == null)
                {
                    inventario = new Inventario
                    {
                        InventarioID = inventarioID,
                        NombreInsumo = txtNombreInsumo.Text,
                        CantidadDisponible = int.Parse(txtCantidad.Text),
                        UnidadMedida = txtUnidad.Text,
                        FechaUltimoReabastecimiento = dtpReabastecimiento.Value
                    };

                    inventarios.Add(inventario); // Agregar nuevo inventario
                }
                else
                {
                    inventario.NombreInsumo = txtNombreInsumo.Text;
                    inventario.CantidadDisponible = int.Parse(txtCantidad.Text);
                    inventario.UnidadMedida = txtUnidad.Text;
                    inventario.FechaUltimoReabastecimiento = dtpReabastecimiento.Value;
                }

                MostrarDatos(); // Actualizar DataGridView
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores válidos en todos los campos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatos()
        {
            dgvInventario.Rows.Clear(); // Limpiar el DataGridView antes de agregar datos

            foreach (var inventario in inventarios)
            {
                dgvInventario.Rows.Add(
                    inventario.InventarioID,
                    inventario.NombreInsumo,
                    inventario.CantidadDisponible,
                    inventario.UnidadMedida,
                    inventario.FechaUltimoReabastecimiento.ToShortDateString()
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscarID;
            if (int.TryParse(txtBuscarID.Text, out buscarID))
            {
                var resultado = inventarios.Find(i => i.InventarioID == buscarID);
                if (resultado != null)
                {
                    MessageBox.Show($"Encontrado: {resultado.NombreInsumo}, Cantidad: {resultado.CantidadDisponible}, Unidad: {resultado.UnidadMedida}, Fecha Reabastecimiento: {resultado.FechaUltimoReabastecimiento.ToShortDateString()}", "Resultado de la Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún elemento con el ID especificado.", "Resultado de la Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            string filePath = "inventario.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    inventarios.Clear(); // Limpiar la lista de inventarios antes de cargar

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] inventarioData = line.Split(',');

                            Inventario inventario = new Inventario
                            {
                                InventarioID = int.Parse(inventarioData[0]),
                                NombreInsumo = inventarioData[1],
                                CantidadDisponible = int.Parse(inventarioData[2]),
                                UnidadMedida = inventarioData[3],
                                FechaUltimoReabastecimiento = DateTime.Parse(inventarioData[4])
                            };

                            inventarios.Add(inventario);
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string filePath = "inventario.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Inventario inventario in inventarios)
                    {
                        string inventarioData = $"{inventario.InventarioID},{inventario.NombreInsumo},{inventario.CantidadDisponible},{inventario.UnidadMedida},{inventario.FechaUltimoReabastecimiento}";
                        writer.WriteLine(inventarioData);
                    }
                }

                MessageBox.Show("Datos guardados exitosamente.", "Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
