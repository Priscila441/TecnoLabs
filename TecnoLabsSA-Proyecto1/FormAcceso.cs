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
    public partial class FormAcceso : Form
    {
        CN_Productos CnProductos = new CN_Productos();
        public FormAcceso()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; 
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverAdmin_Click(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }
        // Método para volver a la vista principal
        private void volverAVistaPrincipal()
        {
            ContenedorAdministrador.Visible = false;
            panelRegistroCliente.Visible = false;
        }

        //Realizamos click en el Boton "Administrador"
        private void BntIconoAdministrador_Click(object sender, EventArgs e)
        {
            /*if (ContenedorAdministrador.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                panelRegistroCliente.Visible = false;
                ContenedorAdministrador.Visible = true;
            }*/
            ContenedorAdministrador.Visible = !ContenedorAdministrador.Visible;
            panelRegistroCliente.Visible = false;
            panelSesionCliente.Visible = false;

        }

        //Realizamos click en el Boton "Cliente"
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            /*if (panelRegistroCliente.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                ContenedorAdministrador.Visible = false;
                panelRegistroCliente.Visible = true;
            }*/
            panelSesionCliente.Visible = !panelSesionCliente.Visible;
            panelRegistroCliente.Visible = false;
            ContenedorAdministrador.Visible = false;
            
        }

        //Realizamos click en el Inicio de sesion admin para ir al formulario de Administrador
        private void BtnIniciarSesionAdmin_Click(object sender, EventArgs e)
        {
            //AbrirFrmEnPanel(new (FormAdministrador));
            if (TextBoxEmailAdmin.Text == "admin@gmail.com" && TextBoxContraseñaAdmin.Text == "123")
            {
                FormAdministrador admin = new FormAdministrador();
                admin.Show();
            }
            else
            {
                TextBoxEmailAdmin.Text = "";
                TextBoxContraseñaAdmin.Text = "";
                MessageBox.Show("Usuario o contraseña incorrecta", "Error de acceso");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelRegistroCliente.Visible = !panelRegistroCliente.Visible;
            panelSesionCliente.Visible = false;
            ContenedorAdministrador.Visible = false;
        }

        private void IngresaCliente_Click(object sender, EventArgs e)
        {
            panelSesionCliente.Visible = !panelSesionCliente.Visible;
            panelRegistroCliente.Visible = false;
            ContenedorAdministrador.Visible = false;
        }

        private void btnInicioSesionCliente_Click(object sender, EventArgs e)
        {
            bool esValido = CnProductos.VerificarUsuario(txtEmailClienteInicio.Text);
            if (esValido == true)
            {
                MessageBox.Show("Sesión iniciada correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos", "Error de acceso");
            }
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
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo completar el registro. Por favor, verifica los datos e inténtalo de nuevo.", "Registro fallido");
            }
        }
    }
}
