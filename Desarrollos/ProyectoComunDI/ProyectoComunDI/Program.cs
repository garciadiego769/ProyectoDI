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
           
            #region Acceso MySQL
            List<string[]> dataseti = new List<string[]>();
            dataseti = Dataset.cargarDatos("127.0.0.1", "3306", "root", "", "dataset");
            #endregion
            #region AccesoCSV

            #endregion

            #region Configurador

            // aquí se instancian las clases necesarias para conectarse a cada base de datos.
            #endregion
            
        }
    }
}
