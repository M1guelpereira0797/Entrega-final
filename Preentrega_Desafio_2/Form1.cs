using SistemaGestionEntities;
using SistemaGestionData;
using SistemaGestionBussiness;
using SistemaGestionUI;

namespace Preentrega_Desafio_2
{
    public partial class Form1 : Form
    {
        public int Id;
        
        public string datosCargados;
        public Form1()
        {
            InitializeComponent();
        }
        public void cargarUsuarios()
        {

            List<Usuario> usuarios = UsuarioBussiness.GetUsuarios();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = usuarios;
             datosCargados= "Usuario";
        }
        public void cargarProducto()
        {



            List<Producto> productos = ProductoBussiness.GetProductos();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = productos;
            datosCargados = "Producto";
        }
        
        public void cargarVenta()
        {




            List<Venta> ventas = VentaBussiness.GetVentas();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = ventas;
            datosCargados = "Venta";
        }
        public void cargarProductoVendido()
        {

            

            List<ProductoVendido> productosVendido = ProductoVendidoBussiness.GetProductoVendidos();
            dgvCliente.AutoGenerateColumns = true;
            dgvCliente.DataSource = productosVendido;
            datosCargados = "Producto Vendido";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectValue = comboBox1.SelectedItem.ToString();
            if (selectValue == "Usuario")
            {
                cargarUsuarios();
            }
            else if (selectValue == "Producto")
            {
                cargarProducto();
            }
            else if (selectValue == "Producto Vendido")
            {
                cargarProductoVendido();
            }
            else if (selectValue == "Venta")
            {
                cargarVenta();
            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (datosCargados == "Usuario")
            {
                Form2 form2 = new Form2();
                Program.form1.Hide();
                form2.Show();

            }
            else if (datosCargados == "Venta")
            {
                VentaForm ventaform = new VentaForm();
                Program.form1.Hide();
                ventaform.Show();

            }
            else if(datosCargados == "Producto")
            {
                ProductoForm productoform = new ProductoForm();
                Program.form1.Hide();
                productoform.Show();

            }
            else if (datosCargados == "Producto Vendido")
            {
                ProductoVendidoForm productoVendidoform = new ProductoVendidoForm();
                Program.form1.Hide();
                productoVendidoform.Show();

            }
         

        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int filaSeleccionada = (int)e.RowIndex;
                Id = int.Parse(dgvCliente[0, filaSeleccionada].Value.ToString());
            }


            if (datosCargados == "Producto")
            {
                ProductoForm productoForm = new ProductoForm();
                Program.form1.Hide();
                productoForm.Show();
            }
            else
            {
                Form2 clienteForm = new Form2();
                Program.form1.Hide();
                clienteForm.Show();
            }

        }
    }
 
}