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
        private Action<Form> abrirForm;

        public FormAcceso(Action<Form> abrirForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; // Asegúrate de que el formulario llene el contenedor
            this.abrirForm = abrirForm; // Asigna el delegado
        }

        private void BtnVolverAdmin_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Método para volver a la vista principal
        private void volverAVistaPrincipal()
        {
            ContenedorAdministrador.Visible = false;
            ContenedorCliente.Visible = false;
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
                ContenedorCliente.Visible = false;
                ContenedorAdministrador.Visible = true;
            }
        }

        //Realizamos click en el Boton "Cliente"
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            if (ContenedorCliente.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                ContenedorAdministrador.Visible = false;
                ContenedorCliente.Visible = true;
            }
        }
        
        //Realizamos click en el Inicio de sesion admin para ir al formulario de Administrador
        private void BtnIniciarSesionAdmin_Click(object sender, EventArgs e)
        {

            abrirForm(new FormAdministrador()); // Abre el formulario de Administrador
            (this.Owner as FormInicio)?.MostrarPanelPrincipal(); // Muestra el panel principal
            this.Close(); // Cierra el formulario de acceso
        }
    }
}