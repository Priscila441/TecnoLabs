using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using C4_ENTIDADES;

namespace C3_DAL
{
    public class Conexion
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        private string connectionString = "Data Source =PHOENIX\\MSSQLSERVER01; Initial Catalog =PracticoGrupal; Integrated Security =sspi";

        public Conexion()
        {
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public List<ProductoDTO> LeerProductos()
        {
            List<ProductoDTO> listProductos = new List<ProductoDTO>();

            conexion.Open();
            comando.CommandText = "SELECT * FROM VistaProductos";

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                ProductoDTO producto = new ProductoDTO();
                producto.Categoria = lector.GetString(0);
                producto.Marca = lector.GetString(1);
                producto.Modelo = lector.GetString(2);
                producto.Precio = lector.GetDecimal(3);

                listProductos.Add(producto);
            }

            conexion.Close();
            return listProductos;
        }
        // METODOS PARA MOSTRAR PRODUCTOS
        public List<ProductoDTO> FiltrarPorMarca(string marca, string orden)
        {
            List<ProductoDTO> listProductos = new List<ProductoDTO>();

            conexion.Open();

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Marca", marca);
            if (orden == "Menor")
            {
                comando.CommandText = "SELECT * FROM VistaProductos WHERE Marca = @Marca ORDER BY Precio ASC";
            }
            else if (orden == "Mayor")
            {
                comando.CommandText = "SELECT * FROM VistaProductos WHERE Marca = @Marca ORDER BY Precio DESC";
            }
            else
            {
                comando.CommandText = "SELECT * FROM VistaProductos WHERE Marca = @Marca";
            }
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                ProductoDTO producto = new ProductoDTO();
                producto.Categoria = lector.GetString(0);
                producto.Marca = lector.GetString(1);
                producto.Modelo = lector.GetString(2);
                producto.Precio = lector.GetDecimal(3);

                listProductos.Add(producto);
            }
            conexion.Close();
            return listProductos;
        }

        // METODO PARA AGREGAR PRODUCTOS
        public void AgregarProducto(Productos producto)
        {
            conexion.Open();
            comando.CommandText = "INSERT INTO Productos VALUES (@Marca,@Modelo,@Precio,@Stock,@IdCategoria)";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Marca", producto.Marca);
            comando.Parameters.AddWithValue("@Modelo", producto.Modelo);
            comando.Parameters.AddWithValue("@Precio", producto.Precio.ToString());
            comando.Parameters.AddWithValue("@Stock", producto.Stock.ToString());
            comando.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria.ToString());

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // METODO PARA ACTUALIZAR PRECIO Y STOCK DE UN PRODUCTO
        public void ActualizarPrecioStock(ActualizarProductoDTO producto)
        {
            conexion.Open();
            comando.CommandText = "UPDATE Productos SET Precio = @Precio, Stock = @Stock WHERE IdProducto = @IdProducto";

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto.ToString());
            comando.Parameters.AddWithValue("@Precio", producto.Precio.ToString());
            comando.Parameters.AddWithValue("@Stock", producto.Stock.ToString());

            comando.ExecuteNonQuery();
            conexion.Close();
        }

        // METODO PARA ELIMINAR UN PRODUCTO
        public void EliminarProducto(Productos producto)
        {
            conexion.Open();
            comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto.ToString());
            comando.CommandText = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

            comando.ExecuteNonQuery();
            comando.Clone();
        }
    }
}