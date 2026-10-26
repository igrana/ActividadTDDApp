using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        public static int CalcularFactorial(int n)
        {
            throw new NotImplementedException();
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