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
    public partial class FormCorte : Form
    {
        private string cadenaConexion = "Server=localhost;Database=hotdogs2;Uid=root;Pwd=;";

        public FormCorte()
        {
            InitializeComponent();
        }

        private void FormCorte_Load(object sender, EventArgs e)
        {
            CargarHistorialCortes();
        }
        private void CargarHistorialCortes()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM cierre_diario";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ventas_dia.DataSource = dt; // Grid propio para ver los cortes
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial de cortes: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ventas_dia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void corte_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de querer realizar el corte de caja ahora mismo?",
                "Confirmación de Corte",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        
                        string queryCorte = "INSERT INTO cierre_diario (fecha, total_ventas) SELECT CURDATE(), SUM(subtotal) FROM detalle_ventas";
                        using (MySqlCommand cmd = new MySqlCommand(queryCorte, conexion))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Corte realizado con éxito.", "Cierre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHistorialCortes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el corte: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operación de corte cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            FormMenu menuPrincipal = new FormMenu();
            menuPrincipal.Show();

        
            this.Close();
        }
    }
}
