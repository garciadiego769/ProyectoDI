using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoBDMySql;

namespace AccesoBDMySql
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string[]> dataseti = new List<string[]>();
            dataseti = Dataset.cargarDatos("127.0.0.1", "3306", "root","", "dataset");

            foreach(string[] row in dataseti)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }
            Console.ReadKey();


        }
    }
}
