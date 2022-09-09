using Ejercicio1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Pruebas
{
    public class UnitTest1
    {
        //Caso 01: 4! -> 24
        [TestMethod]
        public void Caso01Factorial()
        {
            var factorial = new Factorial();
            var ob = factorial.ObtenerFacotrial(4);
            Assert.AreEqual(24, ob);

        }
    }
}
