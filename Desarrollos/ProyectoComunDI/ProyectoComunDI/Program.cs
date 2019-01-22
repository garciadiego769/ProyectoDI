using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace ProyectoComunDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            #region Acceso MySQL

            // cread una region cada uno con un ejemplo de como se accedea vuestra libreria

            #endregion

            #region Acceso Oracle
            OracleConnection con;
            con = new OracleConnection();
            //La cadena de conexión con el nombre de usuario, contraseña y BD
            con.ConnectionString = "User Id=<SYSTEM>;Password=<12345Abcde>;Data Source=<DANIDIEGO>";
            con.Open();
            Console.WriteLine("Conexión realzada con Oracle" + con.ServerVersion); //muestra la versión
            #endregion



        }
    }
}
