using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Data.Common;
namespace AccesoOracle

{

    public static class ConsultaDatos
    {
        static void Main(string[] args)
        {
        }

        public static List<Evidencia> AccesoBDOracle()
        {
            List<Evidencia> evidencias = new List<Evidencia>();
            const string V = "User Id=SYSTEM;Password=12345Abcde;";
            string oradb = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-DIEGO)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
             + V;
            OracleConnection conexion = new OracleConnection(oradb);

            conexion.Open();
            //Console.WriteLine("Connected to Oracle" + conexion.ServerVersion);

            //SELECT
            string sql = "select * from DANIDIEGO.ATRIBUTOSFLORES";
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = sql;
            cmd.Connection = conexion;


            using (DbDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    double longitudPetalo = reader.GetDouble(2);
                    // Console.WriteLine("Longitud Pétalo: " + longitudPetalo.ToString("0.00"));

                    double longitudSepalo = reader.GetDouble(3);
                    // Console.WriteLine("Longitud Sépalo: " + longitudSepalo.ToString("0.00"));

                    double anchoPetalo = reader.GetDouble(4);
                    // Console.WriteLine("Ancho Pétalo: " + anchoPetalo.ToString("0.00"));

                    double anchoSepalo = reader.GetDouble(5);
                    //Console.WriteLine("Ancho Sépalo: " + anchoSepalo.ToString("0.00"));

                    string tipoFlor = reader.GetString(6);
                    // Console.WriteLine("Tipo Flor: " + tipoFlor);

                    //Creamos los datos como objeto del tipo Evidencia
                    Evidencia evidencia = new Evidencia(longitudPetalo, longitudSepalo, anchoPetalo, anchoSepalo, tipoFlor);

                    evidencias.Add(evidencia);

                }
                return evidencias;
            }


        }
    }
}
