using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSqlServer
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Creo objeto tipo ConexionBd
            ConexionBd conexionBd = new ConexionBd();

            try
            {
                //Abro conexion
                conexionBd.abrirConexion();
               
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            

        



        }
    }
}
