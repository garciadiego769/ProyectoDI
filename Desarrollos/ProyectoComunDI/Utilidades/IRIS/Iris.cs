using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS
{
    class Iris
    {
        private double sepal_lenght;
        private double sepal_width;
        private double petal_lenght;
        private double petal_width;
        private string irisclass;

        public Iris(double sepal_lenght, double sepal_width, double petal_lenght, double petal_width, string irisclass)
        {
            this.sepal_lenght = sepal_lenght;
            this.sepal_width = sepal_width;
            this.petal_lenght = petal_lenght;
            this.petal_width = petal_width;
            this.irisclass = irisclass;
        }
    }
}
