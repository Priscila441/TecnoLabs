using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using C4_ENTIDADES;
using System.Runtime.Remoting.Messaging;


namespace C3_DAL
{
    internal class Conexion
    {
        //creamos obj de sus clases para usar metodos
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();

        public List<Persona> LeerPersonas()
        {
             List<Persona> listPersona = new List<Persona>();
            conexion.ConnectionString = "data source = DESKTOP-UN9UCN3\\GABI_SQL; initial catalog =TecnoLabs; integrated security = sspi";
            comando.CommandType = System.Data.CommandType.Text; 
            comando.Connection = conexion;
            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Persona p = new Persona();


            }





            return listPersona;
        }

       

       
          
          

    }
}
