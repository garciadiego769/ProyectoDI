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


        /*Conexion remota a la base de datos de Azure
        private SqlConnection conectiocSql = new SqlConnection("Server=tcp:servidorazureprueba.database.windows.net,1433;" +
            "Initial Catalog=ProyectoDI;Persist Security Info=False;" +
            "User ID=Jose;Password=Ab112345;" +
            "MultipleActiveResultSets=False;Encrypt=True;" +
            "TrustServerCertificate=False;Connection Timeout=30");*/

        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="con"></param>
        public ConexionBd()
        {

        }

        #endregion constructor

        #region metodos
        /// <summary>
        /// Funcion que habre la conexion con la BD
        /// </summary>
        public void abrirConexion()
        {

            try
            {

                con.Open();
                Console.WriteLine("Conexion abierta");


            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }


        }

        /// <summary>
        /// Funcion que cierra la conexion con la BD
        /// </summary>
        public void cerrarConexion()
        {

            try
            {

                con.Close();
                Console.WriteLine("Conexion cerrada");


            }
            catch (SqlException e)
            {
                Console.Write(e.Message);
            }


        }
        #endregion metodos

        public SqlConnection ConectiocSql { get => con; set => con = value; }


    }
}
