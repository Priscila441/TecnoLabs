using C2_BLL;
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
    public partial class FormAdministrador : Form
    {
        CN_Productos CnProductos = new CN_Productos();
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


        //Se realiza click en el boton para volver a la pantalla principal
        private void BtnSalirAdmin_Click(object sender, EventArgs e)
        {
            //FormInicio formInicio = new FormInicio();
            //formInicio.Show();
            Close();
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
        public void Cargar()
        {
            try
            {
                dgvProductos.DataSource = CnProductos.CargarProductos();

                dgvProductos.Columns["IdProducto"].DisplayIndex = 0;
                dgvProductos.Columns["Marca"].DisplayIndex = 1;
                dgvProductos.Columns["Modelo"].DisplayIndex = 2;
                dgvProductos.Columns["Precio"].DisplayIndex = 3;
                dgvProductos.Columns["Stock"].DisplayIndex = 4;
                dgvProductos.Columns["IdCategoria"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión con la base de datos", "ERROR");
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            Cargar();
        }
        public int ObtenerIdCategoria(string cmbText)
        {
            int idCategoria = 0;

            if (cmbText == "Celulares") idCategoria = 1;

            if (cmbText == "Tablets") idCategoria = 2;

            if (cmbText == "Notebooks") idCategoria = 3;

            return idCategoria;
        }
        public void LimpiarCampos()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cmbCategoria.Text = "";
        }
        public void LimpiarCamposEditar()
        {
            texMarca.Text = "";
            texModelo.Text = "";
            texPrecio.Text = "";
            texStock.Text = "";
            cmbIdCategoria.Text = "";
        }
        public void ActivarCampos()
        {
            texMarca.Enabled = true;
            texModelo.Enabled = true;
            texPrecio.Enabled = true;
            texStock.Enabled = true;
            cmbIdCategoria.Enabled = true;

            BtnGuardarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
        }
        public bool ComprobarCampos()
        {
            if (txtMarca.Text != null && txtModelo.Text != null && txtPrecio.Text != null && txtStock.Text != null && cmbCategoria.Text != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Productos producto = new Productos();
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            try
            {
                int idCategoria = ObtenerIdCategoria(cmbCategoria.Text);

                producto.Marca = txtMarca.Text;
                producto.Modelo = txtModelo.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.IdCategoria = idCategoria;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que los campos contengan el tipo de dato esperado", "Error de tipeo");
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos() == true)
            {
                try
                {
                    CnProductos.AgregarNuevoProducto(producto);

                    MessageBox.Show("Registro exitoso", "EXITO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión con la base de datos", "ERROR");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texMarca.Text = dgvProductos.CurrentRow.Cells["Marca"].Value.ToString();
            texModelo.Text = dgvProductos.CurrentRow.Cells["Modelo"].Value.ToString();
            texPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();
            texStock.Text = dgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
            cmbIdCategoria.Text = dgvProductos.CurrentRow.Cells["IdCategoria"].Value.ToString();
        }
        public Productos ObtenerProducto()
        {
            Productos producto = new Productos();

            producto.IdProducto = int.Parse(dgvProductos.CurrentRow.Cells["IdProducto"].Value.ToString());
            producto.Marca = texMarca.Text;
            producto.Modelo = texModelo.Text;
            producto.Precio = decimal.Parse(texPrecio.Text);
            producto.Stock = int.Parse(texStock.Text);
            producto.IdCategoria = int.Parse(cmbIdCategoria.Text);

            return producto;
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Productos producto = new Productos();
                producto = ObtenerProducto();
                CnProductos.Editar(producto);
                LimpiarCamposEditar();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión con la base de datos", "ERROR");
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCamposEditar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ActivarCampos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres eliminar este Producto?", "Confirmar de Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Productos producto = new Productos();
                producto = ObtenerProducto();

                CnProductos.Eliminar(producto);

                MessageBox.Show("Registro eliminado correctamente");
                Cargar();

            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.DataSource = CnProductos.Buscar(txtBuscarProducto.Text);

                dgvProductos.Columns["IdProducto"].DisplayIndex = 0;
                dgvProductos.Columns["Marca"].DisplayIndex = 1;
                dgvProductos.Columns["Modelo"].DisplayIndex = 2;
                dgvProductos.Columns["Precio"].DisplayIndex = 3;
                dgvProductos.Columns["Stock"].DisplayIndex = 4;
                dgvProductos.Columns["IdCategoria"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión con la base de datos", "ERROR");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            gbxFiltros.Visible = !gbxFiltros.Visible;
        }

        private void btnAplicarFiltros_Click(object sender, EventArgs e)
        {
            int idCategoria = ObtenerIdCategoria(txtFiltroCategoria.Text);
            string orden = txtFiltroOrden.Text;

            try
            {
                dgvProductos.DataSource = CnProductos.AplicarFiltros(idCategoria, orden);

                dgvProductos.Columns["IdProducto"].DisplayIndex = 0;
                dgvProductos.Columns["Marca"].DisplayIndex = 1;
                dgvProductos.Columns["Modelo"].DisplayIndex = 2;
                dgvProductos.Columns["Precio"].DisplayIndex = 3;
                dgvProductos.Columns["Stock"].DisplayIndex = 4;
                dgvProductos.Columns["IdCategoria"].DisplayIndex = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión con la base de datos", "ERROR");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
