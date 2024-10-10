using C2_BLL;
using C4_ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoLabsSA_Proyecto1
{
    public partial class FormCarrito : Form
    {
        CN_Productos CnProductos = new CN_Productos();
        public FormCarrito()
        {
            InitializeComponent();
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverInicio_Click(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrid();
            if (dgvCarrito.DataSource != null && dgvCarrito.Rows.Count > 0)
            {
                btnActualizar.Enabled = true;
                BtnComprarPagar.Enabled = true;
                btnQuitarProducto.Enabled = true;
            }
            else
            {
                btnActualizar.Enabled = false;
                BtnComprarPagar.Enabled = false;
                btnQuitarProducto.Enabled = false;
            }
        }
        // Método para llenar el DataGridView con los productos del Singleton
        private void CargarProductosEnGrid()
        {
            // Obtener la lista de productos desde el Singleton CarritoCompra
            List<Productos> productos = CarritoCompra.Instancia.listProductos;

            
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = productos;
            
            decimal total = CarritoCompra.Instancia.CalcularTotal();
            labelTotal.Text = $"Total: ${total}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductosEnGrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                int indiceFila = dgvCarrito.SelectedRows[0].Index;

                List<Productos> productos = CarritoCompra.Instancia.listProductos;

                productos.RemoveAt(indiceFila);

                CargarProductosEnGrid();

                MessageBox.Show("Producto eliminado del carrito.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private void labelRegistrarse_Click(object sender, EventArgs e)
        {
            panelSesionCliente.Visible = false;
            panelRegistroCliente.Visible = !panelRegistroCliente.Visible;
        }

        private void btnInicioSesionCliente_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = CnProductos.VerificarUsuario(txtEmailClienteInicio.Text);
                if (esValido == true)
                {
                    MessageBox.Show("Sesión iniciada correctamente");
                    panelRegistroRapido.Visible = false;
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos", "Error de acceso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que los campos contengan el tipo de dato esperado", "Error de tipeo");
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void IngresaCliente_Click(object sender, EventArgs e)
        {
            panelRegistroCliente.Visible = false;
            panelSesionCliente.Visible = !panelSesionCliente.Visible;
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Clientes persona = new Clientes();
            try
            {
                persona.Nombre = txtNombreCliente.Text;
                persona.Apellido = txtApellido.Text;
                persona.Edad = int.Parse(txtEdad.Text);
                persona.Email = txtEmailRegistro.Text;
                persona.Direccion = txtDireccion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que los campos contengan el tipo de dato esperado", "Error de tipeo");
                MessageBox.Show(ex.Message, "Error");
            }

            bool esRegistrado = CnProductos.NuevoRegistro(persona);
            if (esRegistrado == true)
            {

                MessageBox.Show($"Felicitaciones {GestorCompra.Instancia.PersonaActual.Nombre}, se registró exitosamente!", "Registro exitoso");
                panelRegistroRapido.Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudo completar el registro. Por favor, verifica los datos e inténtalo de nuevo.", "Registro fallido");
            }
        }
        private bool EstaLogueado()
        {
            return GestorCompra.Instancia.ClienteActual != null;
        }
        private void BtnComprarPagar_Click(object sender, EventArgs e)
        {
            if (EstaLogueado())
            {
                panelConfirmarPago.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, inicie sesión para completar la compra");
                panelRegistroRapido.Visible = true;
            }
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            panelRegistroRapido.Visible = false;
        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            panelConfirmarPago.Visible = false;
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            try
            {
                int idCompra = CnProductos.RealizarCompra(txtMetodoPago.Text);
                if (idCompra != 0)
                {
                    MessageBox.Show($"Compra realizada con éxito. ID de Compra: {idCompra}");
                    dgvCarrito.DataSource = null;
                    CarritoCompra.Instancia.listProductos.Clear();
                    Close();
                }
                else
                {
                    MessageBox.Show("Se produjo un error", "Compra Rechazada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que los campos contengan el tipo de dato esperado", "Error de tipeo");
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                btnConfirmarPago.Enabled = true;
            }
            else
            {
                btnConfirmarPago.Enabled = false;
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
