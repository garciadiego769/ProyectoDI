using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSqlServer
{
    class ConexionBd
    {

        //Atributo de tipo SqlConecction para conectar al sevidor y a la BD
        private SqlConnection con = new SqlConnection("server=JOSE\\SERVIDOR" +
                " ; database=Prueba ; integrated security = true");

        //Metodo para abrir la conexion
        public void abrirConexion()
        {

            try
            {
                con.Open();
                Console.WriteLine("Conexión realizada con éxito");
            }
            catch (SqlException e)
            {
                //Lanzo mensaje de excepcion
                throw e;
            }

        }

        //Metodo para cerrar la conexion
        public void cerrarConexion()
        {
            try
            {
                con.Close();
                Console.WriteLine("Conexión cerrada con éxito");
            }
            catch (SqlException e)
            {
                //Lanzo mensaje de excepcion
                throw e;
            }

        }
    }
}
