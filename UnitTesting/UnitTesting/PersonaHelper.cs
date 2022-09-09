using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class PersonaHelper
    {
        private List<Persona> Personas;

        public PersonaHelper(List<Persona> personas)
        {
            this.Personas = personas;
        }
        public Persona ObtenerAlMayor()
        {
            return Personas.First(o => o.Edad == Personas.Max(x => x.Edad));
        }
    }
}
