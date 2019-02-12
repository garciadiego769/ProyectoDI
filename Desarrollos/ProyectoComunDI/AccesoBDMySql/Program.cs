using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDMySql;
using Utilidades;

namespace AccesoBDMySql
{
    class Program
    {
        static void Main(string[] args)
        {

            Evidencia evidencia = new Evidencia();
            //Lista donde cargaremos los datos
            List<Evidencia> dataseti = new List<Evidencia>();
            //funcion para cargar los datos, hay que pasarle la cadena de conexion a la base de datos.
            dataseti = Dataset.cargarDatos("127.0.0.1", "3306", "root", "", "dataset");
            //repetitiva para mostrar - guardar - ejecutar datos
            foreach (Evidencia row in dataseti)
            {
                Console.WriteLine(row.Longitud_sepalo + " " + row.Ancho_sepalo + " " + row.Longitud_sepalo + " " + row.Longitud_petalo + " " + row.Clase);
            }

            Console.ReadKey();


        }
    }
}
