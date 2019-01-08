using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoSqlServer
{
    class Program
    {
        
        static void Main(string[] args)
        {


            Evidencia evidencia = Consulta.porIdDeTabla(149);

            Console.WriteLine("--------\n\n\n------");
            Console.WriteLine(evidencia.Clase);

            Console.ReadKey();

            //Consulta.consultaTodaLaTabla();


            






            



            










        }
    }
}
