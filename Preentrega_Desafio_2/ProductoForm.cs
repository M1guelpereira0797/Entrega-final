using Preentrega_Desafio_2;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string Descripcion = txtDescripcion.Text;
            //string idCliente = txtId.Text;
            string Costo  = Convert.ToString(txtCosto.Text);
            string PrecioVenta = txtPrecioVenta.Text;
            string Stock = txtStock.Text;
            int IdUsuario = Program.form1.Id;


            var productos= new Producto();



            if (IdUsuario > 0)
            {
                Producto productoEdit = ProductoData.GetProducto(IdUsuario);
                productoEdit.Id = Id;
                productoEdit.Descripcion = Descripcion;
                productoEdit.Costo = Costo;
                productoEdit.Stock = Stock;
                productoEdit.PrecioVenta = PrecioVenta;

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Producto productoNew = ProductoData.GetProducto(IdUsuario);
                productoNew.Descripcion = Descripcion;
                productoNew.Costo = Costo;
                productoNew.Stock= Stock;
                productoNew.PrecioVenta = PrecioVenta;
                productoNew.Id = Id;

                UsuarioData.GetUsuario(IdUsuario);
                MessageBox.Show("Se creo el nuevo Cliente");
            }
            /*db.SaveChanges();*/
            limpiar();
            this.Close();
            Program.form1.Id = 0;
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;

            var db = ProductoBussiness.BorrarProducto(Id);
            Producto productos= db.Producto.Find(int.Parse(Id));
            db.ProductoBussiness.Remove(productos);
            db.SaveChanges();
            MessageBox.Show("Se borro el producto");
            limpiar();
            Program.form1.Id = 0;
            this.Close();
            Program.form1.cargarUsuarios();
            Program.form1.Show();


        }
        private void limpiar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtContrasena.Text = null;
            txtMail.Text = null;
            txtId.Text = null;
        }
    }
}
