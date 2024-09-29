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

        private string connectionString = "Data Source =PHOENIX\\MSSQLSERVER01; Intitial Catalog =PracticoGrupal; Integrated Security =sspi";

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
        public List<ProductoDTO> FiltrarPorMarca(string marca, string orden)
        {
            List<ProductoDTO> listProductos = new List<ProductoDTO>();

            conexion.Open();

            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Marca", marca);
            if (orden == "Menor")
            {
                comando.CommandText = "SELECT * FROM ViewProductos WHERE Marca = @Marca ORDER BY Precio ASC";
            }
            else if (orden == "Mayor")
            {
                comando.CommandText = "SELECT * FROM ViewProductos WHERE Marca = @Marca ORDER BY Precio DESC";
            }
            else
            {
                comando.CommandText = "SELECT * FROM ViewProductos WHERE Marca = @Marca";
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
    }
}