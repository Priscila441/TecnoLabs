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
            if (ContenedorAdministrador.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                panelRegistroCliente.Visible = false;
                ContenedorAdministrador.Visible = true;
            }

        }

        //Realizamos click en el Boton "Cliente"
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            if (panelRegistroCliente.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                ContenedorAdministrador.Visible = false;
                panelRegistroCliente.Visible = true;
            }
            
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
        }

        private void IngresaCliente_Click(object sender, EventArgs e)
        {
            panelSesionCliente.Visible = !panelSesionCliente.Visible;
        }
    }
}
