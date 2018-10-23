using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Factura
    {
        private int _idFactura;
        private DateTime _fecha;
        private float _importe;
        private List<Linea> productos;

        public int IdFactura
        {
            get
            {
                return _idFactura;
            }

            set
            {
                _idFactura = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }
        }

        internal List<Linea> Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public float Importe
        {
            get
            {
                return _importe;
            }
        }
    
        private void setImporte()
        {
            float imp = 0;
            foreach(Linea p in productos)
            {
                imp += p.PrecioProd;
            }
            _importe = imp;
        }

    }
}
