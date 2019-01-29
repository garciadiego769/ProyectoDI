using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDMySql;

namespace ProyectoComunDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largo de sepalo,ancho de sepalo,largo de petalo,ancho de petalo,especie");
           
            List<string[]> dataseti = new List<string[]>();
            dataseti = Dataset.cargarDatos("127.0.0.1", "3306", "root", "", "dataset");

            foreach (string[] row in dataseti)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }
            Console.ReadKey();
            #region Acceso MySQL

            #endregion
            #region AccesoCSV

            #endregion

            #region Configurador

            // aquí se instancian las clases necesarias para conectarse a cada base de datos.
            #endregion

        }
	}
}
