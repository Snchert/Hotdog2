using Proyecto_individual;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_individual
{
    internal class Productos : Producto
    {
        private bool incluye_chilechilacon;
        private bool es_res;

        public bool IncluyeChilaca
        {
            get { return incluye_chilechilacon; }
            set { incluye_chilechilacon = value; }
        }

        public bool EsCarneRes
        {
            get { return es_res; }
            set { es_res = value; }
        }

        
        public Productos(int id, string nombre, decimal precio, decimal costo, bool chilaca, bool res)
        {
            Id = id;
            Nombre = nombre;
            PrecioVenta = precio;
            CostoProduccion = costo;
            IncluyeChilaca = chilaca;
            EsCarneRes = res;
        }
    }
    
}
public class Banderilla : Producto
{
    public bool EsEmpanizadaCrujiente { get; set; } = true;

    public Banderilla(int id, string nombre, decimal precio, decimal costo)
    {
        Id = id;
        Nombre = nombre;
        PrecioVenta = precio;
        CostoProduccion = costo;
    }
}