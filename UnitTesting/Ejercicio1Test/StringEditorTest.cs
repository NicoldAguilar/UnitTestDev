using Ejercicio1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Test
{
    public class StringEditorTest
    {
        //Prueba01: Grande - Pequeño
        [Test]
        public void MasCaracteres01()
        {
            var cntcaracteres = new StringEditor();
            var obj = cntcaracteres.MayorCantidadCaracteres("grande", "pequeño");
            Assert.AreEqual("pequeño", obj);
        }

        //Prueba02: Mariposa - Oruga
        [Test]
        public void MasCaracteres02()
        {
            var cntcaracteres = new StringEditor();
            var obj = cntcaracteres.MayorCantidadCaracteres("mariposa", "oruga");
            Assert.AreEqual("mariposa", obj);
        }
    }
}
