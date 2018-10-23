using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication3
{
    class Caja
    {
        private List<Producto> listaDeProductos;

        public Caja()
        {
            listaDeProductos = new List<Producto>();
        }

        public void cargarProducto(Producto p)
        {
            listaDeProductos.Add(p);
        }

        public List<Producto> getListaProducto()
        {
            return listaDeProductos;
        }

        public Producto buscarProducto(int codProd)
        {
            Producto pro = null;
            foreach (Producto p in listaDeProductos)
            {
                if (p.CodigoProducto == codProd)
                {
                    pro = p;
                    break;
                }
            }
            return pro;
        }

        public bool eliminarProd(int codProd)
        {
            bool ok = false;
            foreach (Producto p in listaDeProductos)
            {
                if (p.CodigoProducto == codProd)
                {
                    listaDeProductos.Remove(p);
                    ok = true;
                }
            }
            return ok;
        }

        
    }
}
