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
        public FormCarrito()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; // Asegúrate de que el formulario llene el contenedor
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverCarrito_Click(object sender, EventArgs e)
        {
            FormInicio main = new FormInicio();
            // panelPrincipal.Visible = false;
            //PanelContenedor.Visible = true;
            main.Show();
            this.Close();
        }
    }
}
