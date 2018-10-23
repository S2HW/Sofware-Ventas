using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Linea
    {
        private string _nombreProd;
        private float _precioProd;

        public Linea(string nombre, float precio)
        {
            _nombreProd = nombre;
            _precioProd = precio;
        }

        public string NombreProd
        {
            get
            {
                return _nombreProd;
            }
            set
            {
                _nombreProd = value;
            }
        }

        public float PrecioProd
        {
            get
            {
                return _precioProd;
            }

            set
            {
                _precioProd = value;
            }
        }
    }
}
