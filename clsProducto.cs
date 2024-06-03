using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesOrdenAlfabetico
{
    public class clsProducto
    {
        public int id;
        public string descripcion;
        public string categoria;
        public double precio;

        public clsProducto(int id, string descripcion, string categoria, double precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precio = precio;
        }
    }
}
