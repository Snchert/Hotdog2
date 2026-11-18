using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_individual
{
    public partial class FormVentas : Form
    {
        private string cadenaConexion = "Server=localhost;Database=hotdogs2;Uid=root;Pwd=;";
        private Venta venta = new Venta();
        public FormVentas()
        {
            InitializeComponent();
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarProductosEnComboBox();
            CargarDetalleVentaTemporal();
        }
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
                                Productos_venta.DataSource = null;
                                Productos_venta.Items.Clear();
                                Productos_venta.DataSource = dt;
                                Productos_venta.DisplayMember = "nombre";
                                Productos_venta.ValueMember = "id";
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

        private void CargarDetalleVentaTemporal()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT d.id, p.nombre AS producto, d.cantidad, d.precio_unitario, d.subtotal FROM detalle_ventas d INNER JOIN productos p ON d.producto_id = p.id";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        data_ventas.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar grid de ventas: " + ex.Message);
            }
        }


        private void Productos_venta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Cantidad_venta_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonMenu_Click_1(object sender, EventArgs e)
        {
            FormMenu menuPrincipal = new FormMenu();
            menuPrincipal.Show();
            this.Close();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_venta_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (data_ventas.SelectedRows.Count > 0)
                    {
                        int detalleId = Convert.ToInt32(data_ventas.SelectedRows[0].Cells["id"].Value);
                        int nuevaCantidad = Convert.ToInt32(Cantidad_venta.Text);

                        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                        {
                            conexion.Open();
                            string query = "UPDATE detalle_ventas SET cantidad = @cantidad, subtotal = precio_unitario * @cantidad WHERE id = @id";
                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@cantidad", nuevaCantidad);
                                cmd.Parameters.AddWithValue("@id", detalleId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Cantidad actualizada correctamente.");
                        CargarDetalleVentaTemporal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }

        }

        private void agregaraVenta_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (Productos_venta.SelectedValue == null) return;

                    int productoId = Convert.ToInt32(Productos_venta.SelectedValue);
                    int cantidad = Convert.ToInt32(Productos_venta.Text);

                    DataRowView rowView = (DataRowView)Productos_venta.SelectedItem;
                    decimal precio = Convert.ToDecimal(rowView["precio_venta"]);
                    decimal costo = Convert.ToDecimal(rowView["costo_produccion"]);

                    venta.RegistrarVentaCompleta(productoId, cantidad, precio, costo);

                    MessageBox.Show("¡Producto agregado a la venta!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDetalleVentaTemporal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
        }

        private void Eliminaraventa_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (data_ventas.SelectedRows.Count > 0)
                    {
                        int detalleId = Convert.ToInt32(data_ventas.SelectedRows[0].Cells["id"].Value);

                        using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                        {
                            conexion.Open();
                            string query = "DELETE FROM detalle_ventas WHERE id = @id";
                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", detalleId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Producto eliminado de la venta.");
                        CargarDetalleVentaTemporal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        private void Finalizar_venta_Click(object sender, EventArgs e)
        {
            try
            {
              
                decimal totalVenta = 0;
                foreach (DataGridViewRow row in data_ventas.Rows)
                {
                    if (row.Cells["subtotal"].Value != null)
                    {
                        totalVenta += Convert.ToDecimal(row.Cells["subtotal"].Value);
                    }
                }

                if (totalVenta == 0)
                {
                    MessageBox.Show("No hay productos en la venta actual para finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult resultado = MessageBox.Show(
                    $"El total de la venta es: ${totalVenta:N2}\n¿Desea cobrar y finalizar el ticket?",
                    "Cobrar Venta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {


                    MessageBox.Show("¡Venta finalizada y cobrada con éxito! Ticket generado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    CargarDetalleVentaTemporal();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
