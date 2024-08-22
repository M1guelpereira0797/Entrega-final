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
            int Id = Program.form1.Id;
            if (Id > 0)
            {
                var usuario = new Usuario();
                Usuario _txtUsuario = UsuarioData.GetUsuario(Id);
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
        private readonly UsuarioBussiness _service;

        public SistemaGestionUI(UsuarioBussiness service)
        {
            _service = service;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        
        Usuario usuario = new Usuario
            {


                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Contrasena = txtContrasena.Text,
                Mail = txtMail.Text
            };

            _service.AltaUsuario(usuario);
            MessageBox.Show("Usuario ingresado correctamente");


               



            /* if (Id > 0)

             {
                 Usuario usuarioEdit = new Usuario();

                 usuarioEdit.Nombre = Nombre;
                 usuarioEdit.Apellido = apellido;
                 usuarioEdit.Contrasena = contrasena;
                 usuarioEdit.Mail = mail;

                 MessageBox.Show("Se modifico el Cliente");

             }
             else
             {
                 Usuario usuarioNew = new Usuario();
                 usuarioNew.Nombre = nombre;
                 usuarioNew.Apellido = apellido;
                 usuarioNew.Contrasena = contrasena;
                 usuarioNew.Mail = mail;

                 UsuarioData.GetUsuario(Id);
                 MessageBox.Show("Se creo el nuevo Cliente");
             }*/
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

            Usuario usuaruario = new Usuario(); 
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

    
