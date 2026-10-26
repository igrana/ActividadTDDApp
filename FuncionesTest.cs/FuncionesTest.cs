using ActividadTDDApp;

namespace FuncionesTest.cs
{
    [TestClass]
    public sealed class FuncionesTest
    {
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
