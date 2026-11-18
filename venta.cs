using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace Proyecto_individual
{
    public class Venta : Conexion
    {
        public void RegistrarVentaCompleta(int productoId, int cantidad, decimal precio, decimal costo)
        {
            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                MySqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    decimal totalVenta = cantidad * precio;
                    decimal totalCosto = cantidad * costo;

                    // 1. Insertar en ventas
                    string queryVenta = "INSERT INTO ventas (total_venta, total_costo) VALUES (@v, @c); SELECT LAST_INSERT_ID();";
                    long ventaId;
                    using (MySqlCommand cmd = new MySqlCommand(queryVenta, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@v", totalVenta);
                        cmd.Parameters.AddWithValue("@c", totalCosto);
                        ventaId = Convert.ToInt64(cmd.ExecuteScalar());
                    }

                    // 2. Insertar en detalle_ventas
                    string queryDetalle = @"INSERT INTO detalle_ventas (venta_id, producto_id, cantidad, precio_unitario, subtotal, costo_unitario) 
                                            VALUES (@vid, @pid, @cant, @pu, @sub, @cu)";
                    using (MySqlCommand cmd = new MySqlCommand(queryDetalle, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@vid", ventaId);
                        cmd.Parameters.AddWithValue("@pid", productoId);
                        cmd.Parameters.AddWithValue("@cant", cantidad);
                        cmd.Parameters.AddWithValue("@pu", precio);
                        cmd.Parameters.AddWithValue("@sub", totalVenta);
                        cmd.Parameters.AddWithValue("@cu", costo);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Descontar ingredientes según la receta
                    string queryReceta = "SELECT ingrediente_id, cantidad_necesaria FROM producto_ingredientes WHERE producto_id = @pid";
                    DataTable dt = new DataTable();
                    using (MySqlCommand cmd = new MySqlCommand(queryReceta, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@pid", productoId);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        int ingId = Convert.ToInt32(row["ingrediente_id"]);
                        decimal cantReq = Convert.ToDecimal(row["cantidad_necesaria"]) * cantidad;

                        string queryStock = "UPDATE ingredientes SET stock_actual = stock_actual - @cant WHERE id = @iid";
                        using (MySqlCommand cmd = new MySqlCommand(queryStock, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@cant", cantReq);
                            cmd.Parameters.AddWithValue("@iid", ingId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error en la transacción de venta: " + ex.Message);
                }
            }
        }
    }
}