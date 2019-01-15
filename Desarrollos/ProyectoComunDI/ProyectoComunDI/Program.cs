using AccesoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoComunDI
{
    class Program
    {
        static void Main(string[] args)
        {
			Acceso test = new Acceso();
			test.downloadFile();
            Console.WriteLine("Hola Mundo");

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
