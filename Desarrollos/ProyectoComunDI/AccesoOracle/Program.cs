using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Oracle.DataAccess.Client;

namespace AccesoOracle
{
    class Program
    {
        private const string V = "User Id=SYSTEM;Password=12345Abcde;";

        static void Main(string[] args)
        {
            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=a224p07.arriagainfo.local)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
             + V;

            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            Console.WriteLine("Conexión realziada con Oracle" + con.ServerVersion);

            Console.Read();
        }

        /* public void conectar()
        {
            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=a224p07.arriagainfo.local)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
             + V;

            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            Console.WriteLine("Conexión realziada con Oracle" + con.ServerVersion);

            Console.Read();
        } */

    }
}
