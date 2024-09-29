using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDADES
{
    public class Clientes : Persona 
    {
        int idCliente;
        int idPersona;
        string tipoCliente;
        decimal descuento;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public decimal Descuento { get => descuento; set => descuento = value; }


        public Clientes(int Id, int edad, int dni, string nombre, string apellido, string direccion, string email, int idCliente, int idPersona, string tipoCliente, decimal descuento ) : base(Id,edad,dni,nombre,apellido,direccion,email)
        {
            IdCliente = idCliente;
            TipoCliente = tipoCliente;
            Descuento = descuento;
            IdPersona = idPersona;

        }

       




       


        public override void InfoPersona()
        {
            throw new NotImplementedException();
        }
       
    }
}
