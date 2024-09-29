using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDADES
{
    public class Productos
    {
        int idProducto;
        private string marca;
        private string modelo;
        private float precio;
        private int stock;
        private int idCategoria;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }


        public Productos (int idProducto, string marca,  string modelo,float precio ,int stock ,int idCategoria)
        {
            IdProducto = idProducto;
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Stock = stock;
            IdCategoria = idCategoria;
        }

        public void CrearProducto()
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = stock;
            this.IdCategoria = idCategoria;
        }

        public void ModificarProducto()
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = stock;
            this.IdCategoria = idCategoria;

        }

        public void ActualizarPrecio(float nuevoPrecio)
        {
            precio = nuevoPrecio;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"id {idProducto} , marca {marca}, modelo: {modelo}, precio:{precio}, stock:{stock},id categoria{idCategoria}");

        }
        public void DisminuirStock(int cantidad)
        {
            if(cantidad < 0 && cantidad <= stock)
            {
                stock -= cantidad;
            }
            else
            {
                throw new ArgumentException("la cantidad para disminuir en stok es invalida");
            }

        }

        public  List<Productos> ListarProductos (List<Productos> miproducto) 
        {
            if(miproducto == null || miproducto.Count == 0)
            {
                Console.WriteLine("no hay productos cargados");
                return new List<Productos> ();

            }
            
            Console.WriteLine("lista de productos cargados");
            foreach(Productos productos in miproducto) 
            {  Console.WriteLine(productos.ToString()); }

            return miproducto;
        }





    }
}
