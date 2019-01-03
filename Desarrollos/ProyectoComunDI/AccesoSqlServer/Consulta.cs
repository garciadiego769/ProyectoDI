using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSqlServer
{
    class Consulta
    {

        public static List<Evidencia> consultaTodaLaTabla() {

            List<Evidencia> evidencias = new List<Evidencia>(); 

            ConexionBd bd = new ConexionBd();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.AtributosFlores", bd.ConectiocSql);

            bd.abrirConexion();
            SqlDataReader rdr = command.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    int numeroEvidencia = Convert.ToInt32(rdr["numero_evidencia"].ToString());
                    double longitud_petalo = Convert.ToDouble(rdr["longitud_petalo"]);
                    double longitud_sepalo = Convert.ToDouble(rdr["longitud_sepalo"].ToString());
                    double ancho_petalo = Convert.ToDouble(rdr["ancho_petalo"].ToString());
                    double ancho_sepalo = Convert.ToDouble(rdr["ancho_sepalo"].ToString());
                    string clase = rdr["clase"].ToString();

                    Evidencia evidencia = new Evidencia(numeroEvidencia, longitud_petalo, longitud_sepalo, ancho_petalo,
                        ancho_sepalo, clase);

                    evidencias.Add(evidencia);



                    Console.WriteLine(numeroEvidencia + "--" + longitud_petalo + "--" + longitud_sepalo + "--"
                                    + ancho_petalo + "--" + ancho_sepalo + "--" + clase);
                }
            }

            else
            {
             Console.WriteLine("No rows found.");
            }
            rdr.Close();
            Console.ReadKey();
            bd.cerrarConexion();

            return evidencias;

        }

        public static void consultaPorIdTabla(int id)
        {
            ConexionBd bd = new ConexionBd();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.AtributosFlores where numero_evidencia;", bd.ConectiocSql);

            bd.abrirConexion();
            SqlDataReader rdr = command.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    int numeroEvidencia = Convert.ToInt32(rdr["numero_evidencia"].ToString());
                    double longitud_petalo = Convert.ToDouble(rdr["longitud_petalo"]);
                    double longitud_sepalo = Convert.ToDouble(rdr["longitud_sepalo"].ToString());
                    double ancho_petalo = Convert.ToDouble(rdr["ancho_petalo"].ToString());
                    double ancho_sepalo = Convert.ToDouble(rdr["ancho_sepalo"].ToString());
                    string clase = rdr["clase"].ToString();

                    Evidencia evidencia = new Evidencia(numeroEvidencia, longitud_petalo, longitud_sepalo, ancho_petalo,
                        ancho_sepalo, clase);



                    Console.WriteLine(numeroEvidencia + "--" + longitud_petalo + "--" + longitud_sepalo + "--"
                                    + ancho_petalo + "--" + ancho_sepalo + "--" + clase);
                }
            }

            else
            {
                Console.WriteLine("No rows found.");
            }

            rdr.Close();

            Console.ReadKey();
            bd.cerrarConexion();
        }

        public static void porId(int id)
        {
            ConexionBd bd = new ConexionBd();

            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM dbo.AtributosFlores WHERE " +
                "numero_evidencia ="+id+""),bd.ConectiocSql);

            bd.abrirConexion();
            

            SqlDataReader rdr = command.ExecuteReader();

            
            
                while (rdr.Read())
                {

                    ReadSingleRow((IDataRecord)rdr);

                }

                rdr.Close();
                Console.ReadKey();
                bd.cerrarConexion();

        }

        private static void ReadSingleRow(IDataRecord record)
        {
            Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", record[0], record[1], record[2], record[3], record[4], record[5
]));
        }


    }
}

      









          

