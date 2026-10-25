using ActividadTDDApp;
using System.Security.Cryptography.X509Certificates;

namespace FuncionesTest.cs
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        //El primer valor es n y el segundo es n!
        [DataRow (-5, -1)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        public void CalcularFactorial_Test(int n, int resultadoEsperado)
        {
            int result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(result, resultadoEsperado);
        }
    }
}
