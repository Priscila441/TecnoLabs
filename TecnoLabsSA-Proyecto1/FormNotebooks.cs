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
    public partial class FormNotebooks : Form
    {
        public FormNotebooks()
        {
            InitializeComponent();
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverNotebooks_Click_1(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }

        private void BtnAgregaralCarritoNote1_Click(object sender, EventArgs e)
        {
            Productos compu = new Productos();
            compu.IdProducto = 8;
            compu.Marca = "Apple";
            compu.Modelo = "Air";
            compu.Precio = 1800;
            compu.Stock = 8;
            compu.IdCategoria = 3;

            CarritoCompra.Instancia.AgregarProducto(compu);
            MessageBox.Show($"Producto {compu.Marca} {compu.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoNote2_Click(object sender, EventArgs e)
        {
            Productos compu = new Productos();
            compu.IdProducto = 9;
            compu.Marca = "Asus";
            compu.Modelo = "Vivobook 16";
            compu.Precio = 1400;
            compu.Stock = 13;
            compu.IdCategoria = 3;

            CarritoCompra.Instancia.AgregarProducto(compu);
            MessageBox.Show($"Producto {compu.Marca} {compu.Modelo} agregado al carrito.");
        }

        private void BtnAgregaralCarritoNote3_Click(object sender, EventArgs e)
        {
            Productos compu = new Productos();
            compu.IdProducto = 10;
            compu.Marca = "Asus";
            compu.Modelo = "Vivobook 16";
            compu.Precio = 1400;
            compu.Stock = 13;
            compu.IdCategoria = 3;

            CarritoCompra.Instancia.AgregarProducto(compu);
            MessageBox.Show($"Producto {compu.Marca} {compu.Modelo} agregado al carrito.");
        }
    }
}
