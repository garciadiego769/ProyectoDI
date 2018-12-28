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

        //Atributo de tipo SqlConecction 
        //Conexion al servidor local
        private SqlConnection con = new SqlConnection("server=JOSE\\SERVIDOR" +
                " ; database=Prueba ; integrated security = true");

        /*
        //Conexion remota a la base de datos de Azure
        private SqlConnection con = new SqlConnection("Server=tcp:servidorazureprueba.database.windows.net,1433;" +
            "Initial Catalog=PruebaAzure;Persist Security Info=False;" +
            "User ID=Jose;Password=Ab1-12345;" +
            "MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout=30");*/

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
