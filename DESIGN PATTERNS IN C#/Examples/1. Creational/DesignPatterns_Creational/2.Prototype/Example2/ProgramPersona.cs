using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype.Example2
{
    class ProgramPersona
    {
        public static void Execute()
        {
            Persona personaPrototype = new Persona() { Edad = 15, Nombre = "Fabio" };

            Persona persona1 = personaPrototype.Clone();
            Persona persona2 = personaPrototype.Clone();
            persona2.Nombre = "Luis";
            persona2.Edad = 22;
            persona2.caracteristicas.ColorOjos = "Azules";
            persona2.caracteristicas.ColorPiel = "Blanca";
            persona2.caracteristicas.Estatura = 1.87;

            Persona persona3 = personaPrototype.Clone();
            persona3.Nombre = "Maria";
            persona3.Edad = 26;
            persona3.caracteristicas.ColorOjos = "Verdes";
            persona3.caracteristicas.ColorPiel = "Trigueña";
            persona3.caracteristicas.Estatura = 1.67;

            List<Persona> _ListPersons = new List<Persona>();
            int _cont = 1;

            _ListPersons.AddRange(new Persona[] { persona1, persona2, persona3 });

            foreach (Persona persona in _ListPersons)
            {
                Console.WriteLine($"********** Persona #{_cont} **********");
                Console.WriteLine($"Nombre: {persona.Nombre}");
                Console.WriteLine($"Edad: {persona.Edad.ToString()}");
                Console.WriteLine($"Color de Ojos: {persona.caracteristicas.ColorOjos}");
                Console.WriteLine($"Color de Piel: {persona.caracteristicas.ColorPiel}");
                Console.WriteLine($"Estatura: {persona.caracteristicas.Estatura}");
                Console.WriteLine("");
                _cont++;
            }
        }
    }
}
