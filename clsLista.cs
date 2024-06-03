using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesOrdenAlfabetico
{
    public class clsLista
    {
        clsNodo inicio;
        clsNodo fin;

        public clsLista()
        {
            inicio = null;
            fin = null;
        }

        public void insertar(clsProducto producto)
        {
            clsNodo nuevo = new clsNodo(producto);

            if(inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                if(nuevo.producto.descripcion.CompareTo(inicio.producto.descripcion) < 0)
                {
                    nuevo.siguiente = inicio;
                    inicio.anterior = nuevo;
                    inicio = nuevo;
                }
                else
                {
                    if(nuevo.producto.descripcion.CompareTo(fin.producto.descripcion) > 0)
                    {
                        fin.siguiente = nuevo;
                        nuevo.anterior = fin;
                        fin = nuevo;
                    }
                    else
                    {
                        clsNodo aux = inicio;

                        while(nuevo.producto.descripcion.CompareTo(aux.producto.descripcion)> 0)
                        {
                            aux = aux.siguiente;
                        }

                        nuevo.siguiente = aux;
                        nuevo.anterior = aux.anterior;
                        aux.anterior.siguiente = nuevo;
                        aux.anterior = nuevo;
                    }
                }
            }
        }

        public void listar(DataGridView grilla)
        {
            grilla.Rows.Clear();

            if(inicio != null)
            {
                clsNodo actual = inicio;

                while(actual != null)
                {
                    grilla.Rows.Add(actual.producto.id, actual.producto.descripcion,
                        actual.producto.categoria, actual.producto.precio);

                    actual = actual.siguiente;
                }
            }
        }
    }
}
