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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TecnoLabsSA_Proyecto1
{
    public partial class FormTablets : Form
    {
        public FormTablets()
        {
            InitializeComponent();
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverTablets_Click_1(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }

        private void BtnAgregaralCarritoTablet1_Click(object sender, EventArgs e)
        {
            Productos tablet = new Productos();
            tablet.IdProducto = 5;
            tablet.Marca = "Apple";
            tablet.Modelo = "iPad 9°";
            tablet.Precio = 700;
            tablet.Stock = 11;
            tablet.IdCategoria = 2;

            CarritoCompra.Instancia.AgregarProducto(tablet);
            MessageBox.Show($"Producto {tablet.Marca} {tablet.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoTablet2_Click(object sender, EventArgs e)
        {
            Productos tablet = new Productos();
            tablet.IdProducto = 6;
            tablet.Marca = "Lenovo";
            tablet.Modelo = "Tab M10 Plus";
            tablet.Precio = 580;
            tablet.Stock = 14;
            tablet.IdCategoria = 2;

            CarritoCompra.Instancia.AgregarProducto(tablet);
            MessageBox.Show($"Producto {tablet.Marca} {tablet.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoTablet3_Click(object sender, EventArgs e)
        {
            Productos tablet = new Productos();
            tablet.IdProducto = 7;
            tablet.Marca = "Samsung";
            tablet.Modelo = "Galaxy Tab S Lite";
            tablet.Precio = 640;
            tablet.Stock = 3;
            tablet.IdCategoria = 2;

            CarritoCompra.Instancia.AgregarProducto(tablet);
            MessageBox.Show($"Producto {tablet.Marca} {tablet.Modelo} agregado al carrito.");
        }
    }
}
