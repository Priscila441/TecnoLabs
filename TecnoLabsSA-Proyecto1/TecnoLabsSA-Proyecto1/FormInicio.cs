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
    public partial class FormInicio : Form
    {
        private FormAcceso formAcceso; // Campo para almacenar la instancia de FormAcceso
        public FormInicio()
        {
            InitializeComponent();
            panelPrincipal.Visible = false; // Inicialmente ocultamos el panel principal
        }

        private void AbrirFrmEnPanel(Form formhija)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.Clear(); // Limpia el panel

            formhija.TopLevel = false; // Indica que es un formulario secundario
            formhija.Dock = DockStyle.Fill; // Ajusta el formulario al panel
            this.panelPrincipal.Controls.Add(formhija); // Agrega el formulario al panel
            formhija.Show(); // Muestra el formulario
        }
        // Método para mostrar el panel principal al cerrar el formulario de acceso
        public void MostrarPanelPrincipal()
        {
            panelPrincipal.Visible = true; // Muestra el panel principal
            //this.Show(); // Muestra el formulario principal
        }

        //Realizamos Click en el Boton de la Imagen Administrador y nos desgloza el panel de "Accede a tu cuenta"
        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            if (SubPanelAdministrador.Visible == false)
                SubPanelAdministrador.Visible = true;
            else
                SubPanelAdministrador.Visible = false;
        }

        //Realizamos Click en el Boton "Accede a tu cuenta y nos abre en el contenedor el form de Acceso
        private void BntIconoAcceder_Click(object sender, EventArgs e)
        {
            FormAcceso formAcceso = new FormAcceso(AbrirFrmEnPanel);
            formAcceso.TopLevel = false; // Indica que es un formulario secundario
            formAcceso.Dock = DockStyle.Fill; // Ajusta el formulario al panel
            panelPrincipal.Controls.Add(formAcceso); // Agrega el formulario al panel
            formAcceso.Show(); // Muestra el formulario
        }
        //Realizamos Click en el Boton de Carrito y nos desgloza el panel de "Carrito"
        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            if (PanelCarrito.Visible == false)
                PanelCarrito.Visible = true;
            else
                PanelCarrito.Visible = false;
        }
        //Realizamos Click en el Boton de Notebooks y nos desgloza el panel de "Notebooks"
        private void BtnNotebooks_Click(object sender, EventArgs e)
        {
            if (panelNotebooks.Visible == false)
                panelNotebooks.Visible = true;
            else
                panelNotebooks.Visible = false;
        }
        //Realizamos Click en el Boton de Celular y nos desgloza el panel de "Celular"
        private void BtnCircular_Click(object sender, EventArgs e)
        {
            if (panelCelular.Visible == false)
                panelCelular.Visible = true;
            else
                panelCelular.Visible = false;
        }
        //Realizamos Click en el Boton de Tablets y nos desgloza el panel de "Tablets"
        private void BtnTablets_Click(object sender, EventArgs e)
        {
            if (panelTablets.Visible == false)
                panelTablets.Visible = true;
            else
                panelTablets.Visible = false;
        }
        //Realizamos Click en el Boton "Notebooks" y nos abre en el contenedor el form de "Notebooks"
        private void BntIconoNotebooks_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormNotebooks());
        }

        //Realizamos Click en el Boton "Celular" y nos abre en el contenedor el form de "Celular"
        private void BntIconoCelular_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormCelulares());
        }

        //Realizamos Click en el Boton "Tablets" y nos abre en el contenedor el form de "Tablets"
        private void BntIconoTablets_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormTablets());
        }

        //Realizamos Click en el Boton "Carrito" y nos abre en el contenedor el form de "Carrito"
        private void BntIconoCarrito_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormCarrito());
        }

        //Realizamos click para cerrar la App
        private void BtnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
