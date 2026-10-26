using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static int CalcularFactorial(int n)
        {
            if (n < 0)
                return -1;

            int factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }


















        public static bool EsContrasenyaValida(string contrasenya)
        {
            return contrasenya != "" &&
                contrasenya != null &&
                contrasenya.Length >= 8 &&
                contrasenya.Contains("#");
        }

    }
}
//isgrpa2526