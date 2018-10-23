using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Cliente
    {
        private string _nombre;
        private string _telefono;
        private string _dni;

        public Cliente (string nombre, string telefono, string dni)
        {
            _nombre = Nombre;
            _telefono = telefono;
            _dni = Dni;
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public string Dni
        {
            get
            {
                return _dni;
            }

            set
            {
                _dni = value;
            }
        }
    }
}
