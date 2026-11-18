using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_individual
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            FormVentas ventana_Ventas = new FormVentas();
            ventana_Ventas.Show(); 
        }

        private void botonInventario_Click(object sender, EventArgs e)
        {
            FormInventario ventanaInventario = new FormInventario();
            ventanaInventario.Show();
        }

        private void botonCorte_Click(object sender, EventArgs e)
        {
            FormCorte ventanaCorte = new FormCorte();
            ventanaCorte.Show();
        }
    }
}
