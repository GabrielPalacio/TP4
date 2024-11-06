using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public static class GeneradorDistribuciones
    {
        private static readonly Random rnd = new Random();

        // Distribución uniforme entre a y b
        public static double GenerarUniforme(double a, double b, double random)
        {
            return a + (b - a) * random;
        }

        // Distribución exponencial negativa con media especificada
        public static double GenerarExponencial(double media, double random)
        {
            double lambda = 1.0 / media;
            return -Math.Log(1 - random) / lambda;
        }

        public static double GenerarRandom()
        {
            return rnd.NextDouble();
        }


    }
}
