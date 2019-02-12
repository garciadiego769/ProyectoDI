using AccesoSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;



namespace ProyectoComunDI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Acceso MySQL

            // cread una region cada uno con un ejemplo de como se accedea vuestra libreria

            #endregion

            #region Aceso SQLServer
            //Lista de evidencias            
            List<Evidencia> evidencias = Consulta.ConsultaTodaLaTabla();

            //Se recorre la lista de objetos para extraer los datos
            foreach (Evidencia evidencia in evidencias)
            {
                
                /* Sale por consola todos los datos
                 * Console.WriteLine(evidencia.Longitud_petalo+"--"+evidencia.Longitud_sepalo+
                    "--"+evidencia.Ancho_petalo + "--" + evidencia.Ancho_sepalo+"--"+evidencia.Clase);*/
            }
            Console.ReadKey();

            #endregion

            #region Acceso Firebird

           /* Console.WriteLine("Escribe la ruta de la base de datos: ");
            string nombreBD = Console.ReadLine();

            Console.WriteLine("Escribe el usuario: ");
            string user = Console.ReadLine();

            Console.WriteLine("Escribe la contraseña: ");
            string password = Console.ReadLine();

            ConexionBDFirebird conexion = new ConexionBDFirebird();
            conexion.AbrirConexionBDFirebird(nombreBD, user, password);*/


            #endregion


        }
    }
}
