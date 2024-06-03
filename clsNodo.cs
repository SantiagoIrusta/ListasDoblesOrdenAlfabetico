using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesOrdenAlfabetico
{
    public class clsNodo
    {
        public clsProducto producto;
        public clsNodo anterior;
        public clsNodo siguiente;

        public clsNodo(clsProducto producto)
        {
            this.producto = producto;
            this.anterior = null;
            this.siguiente = null;
        }
    }
}
