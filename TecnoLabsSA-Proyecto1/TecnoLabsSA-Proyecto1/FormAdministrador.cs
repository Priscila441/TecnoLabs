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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }
        //Realizamos un metodo para Agregar
        private void MostrarPanelAgregar()
        {
            GroupBoxBuscarProducto.Visible = false; 
            GroupBoxEditarEliminar.Visible = false; 
            GroupBoxDatosDelProducto.Visible = true;   
        }
        //Realizamos un metodo para Buscar
        private void MostrarPanelBuscar()
        {
            GroupBoxDatosDelProducto.Visible = false; 
            GroupBoxEditarEliminar.Visible = false;    
            GroupBoxBuscarProducto.Visible = true;     
        }
        //Realizamos un metodo para Editar
        private void MostrarPanelEditar()
        {
            GroupBoxDatosDelProducto.Visible = false;
            GroupBoxBuscarProducto.Visible = false;
            GroupBoxEditarEliminar.Visible = true;     
        }
        // Método para volver a la vista principal
        private void volverAVistaPrincipal()
        {
            GroupBoxDatosDelProducto.Visible = false;    
            GroupBoxBuscarProducto.Visible = false;      
            GroupBoxEditarEliminar.Visible = false;      
        }

        //Realizo click en el boton agregar para que me habra el contenedor de "Agregar"
        private void BtnAgregarProduct_Click(object sender, EventArgs e)
        {
            if (GroupBoxDatosDelProducto.Visible)
            {
                volverAVistaPrincipal(); // Si el panel ya está visible, vuelve a la vista principal
            }
            else
            {
                MostrarPanelAgregar(); // Muestra solo el panel de agregar
            }
        }
        //Realizo click en el boton Editar para que me habra el contenedor de "Editar"
        private void BtnEditarProduct_Click(object sender, EventArgs e)
        {
            if (GroupBoxEditarEliminar.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                MostrarPanelEditar(); 
            }
        }

        //Realizo click en el boton Buscar para que me habra el contenedor de "Buscar"
        private void BtnBuscarProduct_Click(object sender, EventArgs e)
        {
            if (GroupBoxBuscarProducto.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                MostrarPanelBuscar();
            }
        }

        //Realizo click en el boton Eliminar para que me habra el contenedor de "Eliminar"
        private void BtnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            if (GroupBoxEditarEliminar.Visible)
            {
                volverAVistaPrincipal();
            }
            else
            {
                MostrarPanelEditar();
            }
        }
    }
}
