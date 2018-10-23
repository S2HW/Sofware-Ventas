using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication3
{
   public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProd { get; set; }


        private int _codigoProducto = 0;
        private double _precio = 0;
        private string _nombreProd;
        private int _codigoProveedor;

        public Producto() { }

        public Producto(int codigo, double precio, string nombre)
        {
            _codigoProducto = codigo;
            _precio = precio;
            _nombreProd = nombre;
        }

        public int CodigoProducto
        {
            get
            {
                return _codigoProducto;
            }

            set
            {
                _codigoProducto = value;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                _precio = value;
            }
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

        public int CodigoProveedor
        {
            get
            {
                return _codigoProveedor;
            }

            set
            {
                _codigoProveedor = value;
            }
        }

        public int Guardar()
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialogo = new System.Windows.Forms.SaveFileDialog())
                {
                    if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.Create))
                        {
                            var binfor = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            binfor.Serialize(st, this);
                        }
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                return 2;
            }
        }
    }
}
