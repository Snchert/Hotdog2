using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;



namespace Proyecto_individual
{
    public class Conexion
    {
        private readonly string cadenaConexion = "Server=localhost;Database=hotdogs2;Uid=root;Pwd=;";

        protected MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }

    public class Producto
    {
       
        private int id;
        private string nombre;
        private decimal precio_venta_hot;
        private decimal costo_hacerlos;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = string.IsNullOrWhiteSpace(value) ? "Producto desconocido" : value; }
        }

        public decimal PrecioVenta
        {
            get { return precio_venta_hot; }
            set { precio_venta_hot = value >= 0 ? value : 0; } 
        }

        public decimal CostoProduccion
        {
            get { return costo_hacerlos; }
            set { costo_hacerlos = value >= 0 ? value : 0; }
        }
    }
}
