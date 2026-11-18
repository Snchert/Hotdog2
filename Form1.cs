using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_individual
{
    internal partial class Form1 : Form
    {
        // Instancia del repositorio de ventas ubicado en venta.cs
        private Venta venta = new Venta();

        // Cadena de conexión a tu base de datos 'hotdogs2' en XAMPP
        private string cadenaConexion = "Server=localhost;Database=hotdogs2;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
            CargarProductosEnComboBox();
            CargarDatosEnGrid("SELECT * FROM ingredientes");
        }

        // Evento que se ejecuta al abrir la ventana (Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Método auxiliar para llenar el DataGridView con cualquier consulta SQL
        private void CargarDatosEnGrid(string query)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvVisualizador.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar los productos automáticamente desde la base de datos
        private void CargarProductosEnComboBox()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT id, nombre, precio_venta, costo_produccion FROM productos";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // IMPORTANTE: Limpiamos la colección Items por si se quedó con elementos manuales del diseñador
                                cmbProductos.Items.Clear();
                                cmbProductos.DataSource = null;

                                // Asignamos la fuente de datos
                                cmbProductos.DataSource = dt;
                                cmbProductos.DisplayMember = "nombre"; // Esto hace que solo se vea el nombre
                                cmbProductos.ValueMember = "id";
                            }
                            else
                            {
                                MessageBox.Show("La tabla 'productos' en phpMyAdmin está vacía.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        // --- 1. BOTÓN: REGISTRAR VENTA ---
        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductos.SelectedValue == null) return;

                int productoId = Convert.ToInt32(cmbProductos.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                DataRowView rowView = (DataRowView)cmbProductos.SelectedItem;
                decimal precio = Convert.ToDecimal(rowView["precio_venta"]);
                decimal costo = Convert.ToDecimal(rowView["costo_produccion"]);

                // Ejecuta la transacción y descuenta el stock de los ingredientes automáticamente
                venta.RegistrarVentaCompleta(productoId, cantidad, precio, costo);

                MessageBox.Show("¡La venta se hizo con éxito!", "Buenarda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca la tabla para ver el stock de ingredientes actualizado
                CargarDatosEnGrid("SELECT * FROM ingredientes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 2. BOTÓN: VER INVENTARIO ---
        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            CargarDatosEnGrid("SELECT * FROM ingredientes");
        }

        // --- 3. BOTÓN: VER HISTORIAL DE VENTAS ---
        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            string queryDetalle = @"SELECT 
                                        v.id AS id_venta,
                                        v.fecha_hora,
                                        p.nombre AS producto,
                                        d.cantidad,
                                        d.precio_unitario,
                                        d.subtotal
                                    FROM ventas v
                                    INNER JOIN detalle_ventas d ON v.id = d.venta_id
                                    INNER JOIN productos p ON d.producto_id = p.id
                                    ORDER BY v.fecha_hora DESC;";
            CargarDatosEnGrid(queryDetalle);
        }

        // --- 4. BOTÓN: VER CORTE DIARIO ---
        private void btnCorteDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Corte de caja del día consultado.", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatosEnGrid("SELECT * FROM cierre_diario");
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Libre de bucles: se deja vacío para evitar recargas infinitas
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvVisualizador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

