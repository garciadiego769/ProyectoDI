using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.VisualBasic;

namespace AccesoCSV
{
    public class Acceso
    {
		private const string FILE_NAME = "C:\\Users\\Anselmo\\Desktop\\iris.data"; //esta ruta debería servir para cualquier ordenador -> modificar!

		//variables para almacenar datos flor
		private double sepal_lenght;
		private double sepal_width;
		private double petal_lenght;
		private double petal_width;
		private string irisclass;

		//cantidad de campos por cada fila de datos en el dataset
		private int numCamposEntradaDataSet = 5; //-> número campos de cada fila en el dataset de IRIS

		private string[] filas;

		public void downloadFile()
		{
			var url = "https://archive.ics.uci.edu/ml/machine-learning-databases/iris/iris.data";
			WebClient cln = new WebClient();
			cln.DownloadFile(url, FILE_NAME); 
		}

		public void cargarArchivoData() //lee y almacena los datos del archivo .data
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
		public void crearArchivoCSV()
		{

			string filePath = "C:\\Users\\Anselmo\\Desktop\\IRIS.csv";

			StringBuilder sb = new StringBuilder();

			for (int index = 0; index < filas.Length; index++)
			{
				sb.AppendLine(filas[index]);
			}
			File.WriteAllText(filePath, sb.ToString());

		}

		public void crearEvidencias()
		{
			var reader = new StreamReader(File.OpenRead(FILE_NAME));

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
			}
		}
	}
}
