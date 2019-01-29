using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace AccesoSqlServer
{
    /// <summary>
    /// Clase Consulta que se encarga de hacer una SELECT en la BD
    /// </summary>
    public static class Consulta
    {
        /// <summary>
        /// Metodo que devuelve una lista de objetos Evidencia
        /// </summary>
        /// <returns></returns>
        public static List<Evidencia> ConsultaTodaLaTabla()
        {

            //Creo una lista de tipo Evidencia
            List<Evidencia> evidencias = new List<Evidencia>();

            //Genero objeto ConexionBd
            ConexionBd bd = new ConexionBd();

            //Preparo la consulta
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.AtributosFlores", bd.ConectiocSql);

            //Abro conexion
            bd.abrirConexion();

            //Preparo el reader
            SqlDataReader rdr = command.ExecuteReader();

            //Procedo a leer
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    double longitud_petalo = Convert.ToDouble(rdr["longitud_petalo"]);
                    double longitud_sepalo = Convert.ToDouble(rdr["longitud_sepalo"].ToString());
                    double ancho_petalo = Convert.ToDouble(rdr["ancho_petalo"].ToString());
                    double ancho_sepalo = Convert.ToDouble(rdr["ancho_sepalo"].ToString());
                    string clase = rdr["clase"].ToString();

                    Evidencia evidencia = new Evidencia(longitud_petalo, longitud_sepalo, ancho_petalo,
                        ancho_sepalo, clase);

                    evidencias.Add(evidencia);

                    
                }
            }

            else
            {
                Console.WriteLine("No rows found.");
            }
            rdr.Close();
            bd.cerrarConexion();
            return evidencias;


        }

    }
}













