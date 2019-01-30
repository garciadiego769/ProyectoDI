using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.VisualBasic;
using Utilidades;

namespace AccesoCSV
{
    public class Acceso
    {
		private const string FILE_NAME = "C:\\iris.data";

		//variables para almacenar datos flor
		private static double sepal_lenght;
		private static double sepal_width;
		private static double petal_lenght;
		private static double petal_width;
		private static string irisclass;

		private static string[] filas;

		public static void downloadFile()
		{
			var url = "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data";
			WebClient cln = new WebClient();
			cln.DownloadFile(url, FILE_NAME); 
		}

		public static void cargarArchivoData() //lee y almacena los datos del archivo .data
		{
			if (File.Exists(FILE_NAME)) //Comprobaciones ayuda depuración
			{
				Console.WriteLine("{0} already exists!", FILE_NAME);

				using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
				{				
					using (BinaryReader r = new BinaryReader(fs))
					{
						var rows = File.ReadAllLines(FILE_NAME);
						filas = new string[rows.Length];

						for (int i = 0; i < rows.Length; i++)
						{
							filas[i] = rows[i];
						}
					}
				}
			}
			else
			{
				Console.WriteLine("{0} NO exists!", FILE_NAME);
			}

			
		}

		//crea el archivo .csv y lo carga con los datos extraidos del dataset
		public static void crearArchivoCSV()
		{
			string filePath = "C:\\IRIS.csv";

			StringBuilder sb = new StringBuilder();

			for (int index = 0; index < filas.Length; index++)
			{
				sb.AppendLine(filas[index]);
			}
			File.WriteAllText(filePath, sb.ToString());

		}

		//carga los datos del dataset en una lista de evidencias
		public static List<Evidencia> cargarEvidencias()
		{
			var reader = new StreamReader(File.OpenRead(FILE_NAME));
			List<Evidencia> evidencias = new List<Evidencia>();

			while (!reader.EndOfStream)
			{
				var line = reader.ReadLine();
				var values = line.Split(',');

				sepal_lenght = Double.Parse(values[0]);
				sepal_width = Double.Parse(values[1]);
				petal_lenght = Double.Parse(values[2]);
				petal_width = Double.Parse(values[3]);
				irisclass = values[4].ToString();

				//instancia de evidencia
				Evidencia evidencia = new Evidencia(petal_lenght, sepal_lenght, petal_width, sepal_width, irisclass);
				evidencias.Add(evidencia);
			}

			return evidencias;
		}
	}
}
