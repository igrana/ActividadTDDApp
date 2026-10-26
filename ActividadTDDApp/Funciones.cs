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

            if (contrasenya == "")
                return false;

            if (contrasenya == null)
                return false;

            if (contrasenya.Length < 8)
                return false;

            if (!contrasenya.Contains("#"))
                return false;

            return true;
        }
    }
}
//isgrpa2526