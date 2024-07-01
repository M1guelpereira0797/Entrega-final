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
    public partial class VentaForm : Form
    {
        public VentaForm()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            var db = new VentaBussiness.GetVentaById(id);

            Venta ventas = db.Ventas.Find(int.Parse(id));
            db.Ventas.Remove(ventas);
            db.SaveChanges();
            MessageBox.Show("Se borro el comentario");
            limpiar();
            Program.form1.Id = 0;
            this.Close();
            Program.form1.cargarVenta();
            Program.form1.Show();
        }
        private void limpiar()
        {
            txtIdUsuario.Text = null;
            txtComentario.Text = null;
            txtId.Text = null;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string Comentario = txtComentario.Text;
            //string idCliente = txtId.Text;
            string idUsuario = txtIdUsuario.Text;
           
            int IdUsuario = Program.form1.Id;


            var usuario = new Usuario();



            if (IdUsuario > 0)
            {
                Venta vetnaEdit = VentaData.GetVenta(IdUsuario);
              
                vetnaEdit.Comentario= Comentario;
                vetnaEdit.idUsuario = idUsuario;
                

                MessageBox.Show("Se modifico la venta");

            }
            else
            {
                Venta ventanew = VentaData.GetVenta(IdUsuario);
                ventanew.Comentario = Comentario;
                ventanew.idUsuario = idUsuario;

                VentaData.GetVenta(IdUsuario);
                MessageBox.Show("Se creo la nueva venta");
            }
            /*db.SaveChanges();*/
            limpiar();
            this.Close();
            Program.form1.Id = 0;
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }
    }
}
