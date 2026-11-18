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
    public partial class FormInventario : Form
    {
        private string cadenaConexion = "Server=localhost;Database=hotdogs2;Uid=root;Pwd=;";

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarIngredientesEnComboBox();
            RefrescarGridInventario();
        }
        private void CargarIngredientesEnComboBox()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT id, nombre FROM ingredientes";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        ingredientes.DataSource = dt;
                        ingredientes.DisplayMember = "nombre";
                        ingredientes.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ingredientes: " + ex.Message);
            }
        }

        private void RefrescarGridInventario()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM ingredientes";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        stock.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar inventario: " + ex.Message);
            }
        }

        private void ingredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_agregar_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_stock_Click(object sender, EventArgs e)
        {

        }

        private void stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            FormMenu menuPrincipal = new FormMenu();
            menuPrincipal.Show();
            this.Close();
        }
    }
}
