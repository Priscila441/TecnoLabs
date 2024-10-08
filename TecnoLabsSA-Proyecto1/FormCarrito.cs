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
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnVolverInicio_Click(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrid();
        }
        // Método para llenar el DataGridView con los productos del Singleton
        private void CargarProductosEnGrid()
        {
            // Obtener la lista de productos desde el Singleton CarritoCompra
            List<Productos> productos = CarritoCompra.Instancia.listProductos;

            // Asignar la lista de productos como fuente de datos para el DataGridView
            dgvCarrito.DataSource = null; // Limpiar el grid antes de asignar la nueva lista
            dgvCarrito.DataSource = productos;
            // Mostrar el precio total en un Label o TextBox
            decimal total = CarritoCompra.Instancia.CalcularTotal();
            labelTotal.Text = $"Total: {total:C}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductosEnGrid();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario ha seleccionado una fila en el DataGridView
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = dgvCarrito.SelectedRows[0].Index;

                // Obtener la lista de productos desde el Singleton
                List<Productos> productos = CarritoCompra.Instancia.listProductos;

                // Eliminar el producto de la lista (en función del índice)
                productos.RemoveAt(indiceFila);

                // Refrescar el DataGridView después de la eliminación
                CargarProductosEnGrid();

                MessageBox.Show("Producto eliminado del carrito.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }
    }
}
