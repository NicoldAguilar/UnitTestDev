using Ejercicio1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Test
{
    public class Pruebas
    {
        //Caso 01: 4! -> 24
        [Test]
        public void Caso01Factorial()
        {
            var factorial = new Factorial();
            var ob = factorial.ObtenerFactorial(4);
            Assert.AreEqual(24, ob);
        }

        //Caso 02: 6! -> 720
        [Test]
        public void Caso02Factorial()
        {
            var factorial = new Factorial();
            var ob = factorial.ObtenerFactorial(6);
            Assert.AreEqual(720, ob);
        }
    }
}
