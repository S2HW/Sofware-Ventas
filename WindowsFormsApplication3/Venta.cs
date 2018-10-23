using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Venta
    {
        private int _codigoCompra;
        private Cliente _deudor;
        private Factura _factura;
        private bool _pagado;

        public int CodigoCompra
        {
            get
            {
                return _codigoCompra;
            }

            set
            {
                _codigoCompra = value;
            }
        }

        public bool Pagado
        {
            get
            {
                return _pagado;
            }

            set
            {
                _pagado = value;
            }
        }

        internal Cliente Deudor
        {
            get
            {
                return _deudor;
            }

            set
            {
                _deudor = value;
            }
        }

        internal Factura Factura
        {
            get
            {
                return _factura;
            }

            set
            {
                _factura = value;
            }
        }


    }
}
