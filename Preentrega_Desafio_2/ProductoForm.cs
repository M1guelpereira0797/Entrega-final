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
            Program.form1.cargarProducto();
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
                
                productoEdit.Descripcion = Descripcion;
                productoEdit.Costo = Convert.ToDouble(Costo);
                productoEdit.Stock = Convert.ToInt32(Stock);
                productoEdit.PrecioVenta = Convert.ToDouble(PrecioVenta);

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Producto productoNew = ProductoData.GetProducto(IdUsuario);
                productoNew.Descripcion = Descripcion;
                productoNew.Costo = Convert.ToDouble(Costo);
                productoNew.Stock= Convert.ToInt32(Stock);
                productoNew.PrecioVenta = Convert.ToDouble(PrecioVenta);
               

                ProductoData.GetProducto(IdUsuario);
                MessageBox.Show("Se creo el nuevo Cliente");
            }
           
            limpiar();
            this.Close();
            Program.form1.Id = 0;
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }

        private void btnElminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;

           
            Producto productos= new Producto();
            
            MessageBox.Show("Se borro el producto");
            limpiar();
            Program.form1.Id = 0;
            this.Close();
            Program.form1.cargarUsuarios();
            Program.form1.Show();


        }
        private void limpiar()
        {
            txtDescripcion.Text = null;
            txtStock.Text = null;
            txtPrecioVenta.Text = null;
            txtCosto.Text = null;
            txtIdUsuario.Text = null;
        }
    }
}
