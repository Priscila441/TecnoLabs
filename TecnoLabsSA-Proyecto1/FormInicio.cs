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
        private FormAcceso formAcceso;
        public FormInicio()
        {
            InitializeComponent();
            panelPrincipal.Visible = true;
        }

        public void AbrirFrmEnPanel(Form formhija)
        {
            if (this.panelPrincipal.Controls.Count > 0)            //preguntamos si existe algún contron en el interior del panel
                this.panelPrincipal.Controls.RemoveAt(0);          // si es así se elimina

            formhija.TopLevel = false;                            //declaramos que es un formulario secundario
            formhija.Dock = DockStyle.Fill;                      //que se acople al panel contenedor
            formhija.Anchor = AnchorStyles.Top;
            formhija.Anchor = AnchorStyles.Left;
            formhija.Anchor = AnchorStyles.Right;
            formhija.Anchor = AnchorStyles.Bottom;
            this.panelPrincipal.Controls.Add(formhija);        //lo agregamos al panel
            this.panelPrincipal.Tag = formhija;                //establecemos la instancia como contenedor de datos de nuestro panel
            formhija.Show();                     //lo mostramos
        }

        // Método para mostrar el panel principal al cerrar el formulario de acceso
        public void MostrarPanelPrincipal()
        {
            panelPrincipal.Visible = true;
            this.Show();
        }

        //Realizamos Click en el Boton de la Imagen Administrador y nos desgloza el panel de "Accede a tu cuenta"
        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            if (SubPanelAdministrador.Visible == false)
                SubPanelAdministrador.Visible = true;
            else
                SubPanelAdministrador.Visible = false;
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

        //Realizamos Click en el Boton "Tablets" y nos abre en el contenedor el form de "Tablets"
        private void BntIconoTablets_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormTablets());
        }

        //Realizamos click para cerrar la App
        private void BtnCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Realizamos Click en el Boton "Carrito" y nos abre en el contenedor el form de "Carrito"
        private void BtnCarritoo_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormCarrito());
        }
        //Realizamos Click en el Boton "Accede a tu cuenta y nos abre en el contenedor el form de Acceso
        private void BntIconoAcceder_Click_1(object sender, EventArgs e)
        {
            // Limpiar solo si hay controles de FormAcceso
            if (panelPrincipal.Controls.Count > 0)
                panelPrincipal.Controls.Clear();

            FormAcceso formAcceso = new FormAcceso();
            formAcceso.TopLevel = false;
            formAcceso.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formAcceso);
            formAcceso.Show();

        }
        //Realizamos Click en el Boton "Celular" y nos abre en el contenedor el form de "Celular"
        private void BntIconoCelular_Click(object sender, EventArgs e)
        {
            AbrirFrmEnPanel(new FormCelulares());
        }
    }
}
