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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int IdUsuario = Program.form1.Id;
            if (IdUsuario > 0)
            {
                var usuario = new Usuario();
                Usuario _txtUsuario = UsuarioData.GetUsuario(IdUsuario);
                txtNombre.Text = _txtUsuario.Nombre;
                txtApellido.Text = _txtUsuario.Apellido;
                txtContrasena.Text = _txtUsuario.Domicilio;
                txtMail.Text = _txtUsuario.Telefono;
                txtId.Text = _txtUsuario.Id.ToString();

            }
            else
            {
                limpiar();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            //string idCliente = txtId.Text;
            string contrasena = txtContrasena.Text;
            string mail= txtMail.Text;
            int IdUsuario = Program.form1.Id;


            var usuario = new Usuario();



            if (IdUsuario > 0)
            {
                Usuario usuarioEdit = UsuarioData.GetUsuario(IdUsuario);
                usuarioEdit.Nombre = nombre;
                usuarioEdit.Apellido = apellido;
                usuarioEdit.Contrasena = contrasena;
                usuarioEdit.Mail= mail;

                MessageBox.Show("Se modifico el Cliente");

            }
            else
            {
                Usuario usuarioNew = new Usuario();
                usuarioNew.Nombre = nombre;
                usuarioNew.Apellido = apellido;
                usuarioNew.Contrasena = contrasena;
                usuarioNew.Mail = mail;

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

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
            Program.form1.cargarUsuarios();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            var db = new UsuarioBussiness.EliminarUsuario();

            Usuario usuario = db.Usuario.Find(int.Parse(id));
            db.Usuario.Remove(usuario);
            db.SaveChanges();
            MessageBox.Show("Se borro el Cliente");
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

    
