using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace ProyectoComunDI
{
  
    class Program
    {
        private const string V = "User Id=SYSTEM;Password=12345Abcde;";
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo");

            #region Acceso MySQL

            // cread una region cada uno con un ejemplo de como se accedea vuestra libreria

            #endregion

            #region Acceso Oracle

            //connection.ConnectionString = "User Id=<SYSTEM>;Password=<12345Abcde>;Data Source=<DANIDIEGO>"; //Data Source Format -> //IP_HOST:PORT/SERVICE_NAME e.g. //127.0.0.1:1521/Service_Name

            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-DIEGO)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
             + V;
            OracleConnection conexion = new OracleConnection(oradb);

            conexion.Open();
            Console.WriteLine("Connected to Oracle" + conexion.ServerVersion);

            //SELECT
            string sql = "select * from DANIDIEGO.ATRIBUTOSFLORES";
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = sql;
            cmd.Connection = conexion;
            
            /*SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                Label8.Text = dr1["quest"].ToString();
                Label9.Text = dr1["ans1"].ToString();
            }
            cn.Close();*/


            /////
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                // OracleCommand sqlCmd = new OracleCommand(sql, conexion);
                string tipoFlor = reader.GetString(2);

                Console.WriteLine(tipoFlor);

            }

            

            
           // OracleDataReader dr = sqlCmd.ExecuteReader();
            //dr.Read();
            Console.Read();
            #endregion

           


        }
    }
}
