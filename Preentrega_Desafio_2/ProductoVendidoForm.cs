using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preentrega_Desafio_2;
using SistemaGestionEntities;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionUI;


namespace SistemaGestionUI
{
    public partial class ProductoVendidoForm : Form
    {
        public ProductoVendidoForm()
        {
            InitializeComponent();
        }

        private void btnVovler_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
             

                var db = new DatabaseContext();

                ProductoVendido productovendido = db.ProductoVendido.Find(int.Parse(Id));
                db.ProductoVendido.Remove(productovendido);
                db.SaveChanges();
                MessageBox.Show("Se borro el Cliente");
                limpiar();
                Program.form1.Id = 0;
                this.Close();
                Program.form1.cargarProductoVendido();
                Program.form1.Show();


            

        }
        private void limpiar()
        {
            txtIdProducto.Text = null;
            txtStock.Text = null;
            txtIdVenta.Text = null;
            txtId.Text = null;
        }
    }
}
