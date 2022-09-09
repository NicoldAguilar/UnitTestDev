using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1;
using NUnit.Framework;

namespace Ejercicio1Test
{
    public class PersonaTest
    {
        [Test]
        public void QuienEsElMayorCaso01()
        {
            //Crear personas
            var personas = new List<Persona>
            {
                new Persona{Nombre = "Luis", Edad = 20},
                new Persona{Nombre = "Maria", Edad = 21},
                new Persona{Nombre = "Juan", Edad = 15},
            };

            var helper = new PersonaHelper();
            var result = helper.ObtenerAlMayor(personas);
            Assert.AreEqual("Maria", result.Nombre);
        }
    }
}
