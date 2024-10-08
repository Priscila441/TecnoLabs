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
    public partial class FormCelulares : Form
    {
        public FormCelulares()
        {
            InitializeComponent();
        }
        
        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverCelu_Click_1(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }

        private void BtnAgregaralCarritoCelu1_Click(object sender, EventArgs e)
        {
            Productos celu = new Productos();
            celu.IdProducto = 2;
            celu.Marca = "Apple";
            celu.Modelo = "iPhone 11";
            celu.Precio = 1100;
            celu.Stock = 12;
            celu.IdCategoria = 1;

            CarritoCompra.Instancia.AgregarProducto(celu);
            MessageBox.Show($"Producto {celu.Marca} {celu.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoCelu2_Click(object sender, EventArgs e)
        {
            Productos celu = new Productos();
            celu.IdProducto = 3;
            celu.Marca = "Samsung";
            celu.Modelo = "Galaxy A53";
            celu.Precio = 600;
            celu.Stock = 31;
            celu.IdCategoria = 1;

            CarritoCompra.Instancia.AgregarProducto(celu);
            MessageBox.Show($"Producto {celu.Marca} {celu.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoCelu3_Click(object sender, EventArgs e)
        {
            Productos celu = new Productos();
            celu.IdProducto = 4;
            celu.Marca = "Redmi";
            celu.Modelo = "Note 13 Pro";
            celu.Precio = 940;
            celu.Stock = 43;
            celu.IdCategoria = 1;

            CarritoCompra.Instancia.AgregarProducto(celu);
            MessageBox.Show($"Producto {celu.Marca} {celu.Modelo} agregado al carrito.");
        }
    }
}
