using ActividadTDDApp;
using System.Security.Cryptography.X509Certificates;

//Ejercicio de isgrpa2526

namespace FuncionesTest.cs
{
    [TestClass]
    public sealed class FuncionesTest
    {
        //El primer valor es n y el segundo es n!
        [TestMethod]
        [DataRow(-5, -1)]
        [DataRow(0, 1)]
        [DataRow(5, 120)]
        public void CalcularFactorial_Test(int n, int resultadoEsperado)
        {
            int result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(result, resultadoEsperado);
        }

        [TestMethod]
        [DataRow("", false)]
        [DataRow("null", false)]
        [DataRow("1234567", false)]
        [DataRow("12345678", false)]
        [DataRow("1234567#", true)]
        [DataRow("pruebaprueba#", true)]
        public void EsContrasenyaValida_Test(string contrasenya, bool resultadoEsperado)
        {
            bool result = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(result, resultadoEsperado);
        }
    }
}
