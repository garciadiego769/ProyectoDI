using System;

public class Oracle
{
	public void Conexion()
	{
        OracleConnection con;
                
            con = new OracleConnection();
            //La cadena de conexión con el nombre de usuario, contraseña y BD
            con.ConnectionString = "User Id=<SYSTEM>;Password=<12345Abcde>;Data Source=<DANIDIEGO>";
            con.Open(); 
            Console.WriteLine("Conexión realziada con Oracle" + con.ServerVersion); //muestra la versión
        }

        void Close()
        {
            con.Close();
            con.Dispose();
        }

        void Main()
        {
            OraTest ot = new OraTest();
            ot.Connect();
            ot.Close();
        }
    }

