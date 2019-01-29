using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class Evidencia
    {

        #region atributos
        /// <summary>
        /// Atributos
        /// </summary>
        private double longitud_petalo;
        private double longitud_sepalo;
        private double ancho_petalo;
        private double ancho_sepalo;
        private string clase;
        #endregion atributos

        #region constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="longitud_petalo"></param>
        /// <param name="longitud_sepalo"></param>
        /// <param name="ancho_petalo"></param>
        /// <param name="ancho_sepalo"></param>
        /// <param name="clase"></param>
        public Evidencia(double longitud_petalo, double longitud_sepalo,
            double ancho_petalo, double ancho_sepalo, string clase)
        {
            this.longitud_petalo = longitud_petalo;
            this.longitud_sepalo = longitud_sepalo;
            this.ancho_petalo = ancho_petalo;
            this.ancho_sepalo = ancho_sepalo;
            this.clase = clase;
        }

        /// <summary>
        /// Constructor vacío.
        /// </summary>
        public Evidencia()
        {

        }

        #endregion constructor

        #region descriptores de acceso get y set
        public double Longitud_petalo { get => longitud_petalo; set => longitud_petalo = value; }
        public double Longitud_sepalo { get => longitud_sepalo; set => longitud_sepalo = value; }
        public double Ancho_petalo { get => ancho_petalo; set => ancho_petalo = value; }
        public double Ancho_sepalo { get => ancho_sepalo; set => ancho_sepalo = value; }
        public string Clase { get => clase; set => clase = value; }
        #endregion descriptores de acceso get y set

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
