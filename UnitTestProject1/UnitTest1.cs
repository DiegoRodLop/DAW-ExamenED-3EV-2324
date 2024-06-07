using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    using Examen3EV;
    using System.Windows.Forms;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void IncluirFrases(int valor)
        {
            string Frase1, Frase2;
            int devuelto;

            Frase1 = "Pelayo se ha caido";
            Frase2 = "y se ha roto la nariz";
          
            Diccionario miApp = new Diccionario();

            devuelto = miApp.analizar(Frase1, Frase2);

            Assert.AreEqual(devuelto, valor);
        }
    }
}
