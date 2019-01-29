using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSqlServer
{
    /// <summary>
    /// Clase ConexionBd que genera la conexion a la BD
    /// </summary>
    class ConexionBd
    {

        #region atributos

        //Atributo SqlConnection, conexion al servidor local
        private SqlConnection con = new SqlConnection("server=JOSE\\SERVIDOR" +
                " ; database=Prueba ; integrated security = true");

       #endregion 

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
