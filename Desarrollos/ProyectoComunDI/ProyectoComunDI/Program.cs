using AccesoSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDMySql;
using Utilidades;

namespace ProyectoComunDI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            #region Acceso MySQL
            //List<Evidencia> evidencias = Dataset.cargardatos("127.0.0.1", "3306", "root", "", "dataset");
            // cread una region cada uno con un ejemplo de como se accedea vuestra libreria

            #endregion


            #region Aceso SQLServer
            ////Lista de evidencias            
            //List<Evidencia> evidencias = Consulta.ConsultaTodaLaTabla();

            #region Configurador
            ////Se recorre la lista de objetos para extraer los datos
            //foreach (Evidencia evidencia in evidencias)
            //{

                /* Sale por consola todos los datos*/
              //   Console.WriteLine(evidencia.Longitud_petalo+"--"+evidencia.Longitud_sepalo+
              //    "--"+evidencia.Ancho_petalo + "--" + evidencia.Ancho_sepalo+"--"+evidencia.Clase);
            //}
            //Console.ReadKey();

            //// aquí se instancian las clases necesarias para conectarse a cada base de datos.
            #endregion

        }
    }
    #endregion

}

