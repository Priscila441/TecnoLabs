using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ENTIDADES
{
    public class Administradores : Persona
    {
        private int idPersona;
        private string rol;
        private int idAdmin;
        private string clave;

        public int IdAdmin { get => idAdmin; set => idAdmin = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Rol { get => rol; set => rol = value; }

        public Administradores(int Id, int edad, int dni, string nombre, string apellido, string direccion, string email ,int idAdmin,string rol,string clave,int idPersona ) : base(Id, edad, dni, nombre, apellido, direccion, email)
        {
            IdAdmin = idAdmin;
            Rol = rol;
            Clave = clave;
            IdPersona = idPersona;
           
        }
        public override void InfoPersona()
        {
            Console.WriteLine($"datos del admi : idadmi{idAdmin} rol:{rol} ");
        }
        public override void ListarProducto()
        {
            base.ListarProducto();
        }

    }
}
