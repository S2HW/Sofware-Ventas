using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();

        }

        private int n;
        private Caja caja = new Caja();

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarProducto(Producto prod)
        {
            int i = dtgvProductos.Rows.Add();
            dtgvProductos.Rows[i].Cells[0].Value = prod.NombreProd;
            dtgvProductos.Rows[i].Cells[1].Value = prod.CodigoProducto;
            dtgvProductos.Rows[i].Cells[2].Value = prod.Precio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtPrecio.Text != "" && txtNombre.Text != "")
            {
                int cod = Convert.ToInt32(txtCodigo.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);
                Producto prod = new Producto(cod, precio, txtNombre.Text);
                Repositorio.agregarProd(prod);
                agregarProducto(prod);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            /*
            //Colocamos la informacion
            caja.cargarProducto(prod);
            agregarProducto(prod);

            //
            */
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = (int)dtgvProductos.Rows[n].Cells[1].Value;
                double pre = (double)dtgvProductos.Rows[n].Cells[2].Value;
                string nom = (string)dtgvProductos.Rows[n].Cells[0].Value;
                if (n != -1)
                {
                    string message = "Esta seguro que desea eliminar " + (string)dtgvProductos.Rows[n].Cells[0].Value;
                    DialogResult r = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {

                        Repositorio.eliminarProd(cod, pre, nom);
                        dtgvProductos.Rows.RemoveAt(n);

                        //caja.eliminarProd((int)dtgvProductos.Rows[n].Cells[1].Value);
                    }
                }
            }
            catch
            {
                string message = "No puede eliminar esa  fila ";
                MessageBox.Show(message);
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Producto p in Repositorio.obtenerProd())
            {
                agregarProducto(p);
            }
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BtnMod(object sender, EventArgs e)
        {
            
            
                try
                {

                int newcod = 0;
                double newpre= 0;
                string newnom = "";
                

                int cod = (int)dtgvProductos.Rows[n].Cells[1].Value;
                    double pre = (double)dtgvProductos.Rows[n].Cells[2].Value;
                    string nom = (string)dtgvProductos.Rows[n].Cells[0].Value;
                    if (n != -1)
                    {
                        string message = "Esta seguro que desea modificar " + (string)dtgvProductos.Rows[n].Cells[0].Value;
                        DialogResult r = MessageBox.Show(message, "Advertencia", MessageBoxButtons.OKCancel);
                        if (r == DialogResult.OK)
                        {

                            Repositorio.modificarProd(cod,pre,nom,newcod,newpre,newnom);

                            //caja.eliminarProd((int)dtgvProductos.Rows[n].Cells[1].Value);
                        }
                    }
                }
                catch
                {
                    string message = "No se puede modificar ";
                    MessageBox.Show(message);
                }
            } 
        }
    }


