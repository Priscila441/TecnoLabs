using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C3_DAL;
using C4_ENTIDADES;

namespace C2_BLL
{
    public class CN_Productos
    {
        public readonly StringBuilder stringBuilder = new StringBuilder();
        Conexion conexion = new Conexion();

        public void AgregarNuevoProducto(Productos producto)
        {
            if (producto == null) stringBuilder.Append("Proporcione valores válidos");

            if (stringBuilder.Length == 0)
            {
                conexion.AgregarProducto(producto);
            }
        }
    }
}
