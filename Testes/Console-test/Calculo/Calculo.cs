using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    public static class Calculo
    {
        public static double Soma(double x1, double x2)
        {
            var result = x1 + x2;

            return result;
        }

        public static double Subtracao(double x1, double x2)
        {
            var result = x1 - x2;
            return result;
        }

        public static double Divisao (double x1, double x2)
        {
            var result = x1 / x2;
            return result;
        }

        public static double Multiplicacao(double x1, double x2)
        {
            var result = x1 * x2;
            return result;
        }
    }
}
