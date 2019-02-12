using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Utilidades;

namespace AccesoBDMySql
{
    public static class Dataset
    {

        private static MySqlConnection conectar(string host, string port, string user, string pass, string database)
        {
            string connectionString = "datasource=" + host + ";port=" + port + ";username=" + user + ";password=" + pass + ";database=" + database + ";";

            MySqlConnection conexion = new MySqlConnection(connectionString);

            return conexion;
        }

        public static List<Evidencia> cargardatos(string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }

        public static List<Evidencia> cargarDatos(string host, string port, string user, string pass, string database)
        {

            try
            {
                MySqlConnection conn = conectar(host, port, user, pass, database);

                string query = "SELECT * FROM datasetiris";
                MySqlCommand sentencia = new MySqlCommand(query, conn);
                sentencia.CommandTimeout = 60;
                MySqlDataReader reader;

                //Abrir la base de datos
                conn.Open();

                //Ejecutar la consulta
                reader = sentencia.ExecuteReader();

                //Si la consulta devuelve datos ejecutar el codigo, si no alertar de que no devuelve
                List<Evidencia> dataset = new List<Evidencia>();

                if (reader.HasRows)
                {
                    //ArrayList dataset;
                    while (reader.Read())
                    {
                        // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Hacer algo con cada fila obtenida
                        Evidencia evi= new Evidencia(double.Parse(reader.GetString(2)), double.Parse(reader.GetString(0)), double.Parse(reader.GetString(3)), double.Parse(reader.GetString(1)), reader.GetString(4));
                       
                        dataset.Add(evi);


                    }
                }

                //Console.ReadKey();

                // Cerrar la conexión
                conn.Close();

                return dataset;



            }
            catch (Exception ex)
            {
                // Mostrar cualquier excepción
                Console.WriteLine(ex.Message);
            }

            throw new Exception("No ha entrado al trycatch");

        }

    }
}
