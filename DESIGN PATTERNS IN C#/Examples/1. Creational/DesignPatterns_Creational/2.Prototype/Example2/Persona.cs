using _2.Prototype.Example2.Interfaces;
using _2.Prototype.Example2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype.Example2
{
    public class Persona : IClonable<Persona>
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Caracteristicas caracteristicas { get; set; }

        public Persona()
        {
            this.caracteristicas = new Caracteristicas();
            this.caracteristicas.ColorOjos = "Negro";
            this.caracteristicas.ColorPiel = "Morena";
            this.caracteristicas.Estatura = 1.75;
        }

        public Persona Clone()
        {
            Persona persona = (Persona)this.MemberwiseClone();
            Caracteristicas _caracteristicas = new Caracteristicas();
            _caracteristicas.ColorOjos = this.caracteristicas.ColorOjos;
            _caracteristicas.ColorPiel = this.caracteristicas.ColorPiel;
            _caracteristicas.Estatura = this.caracteristicas.Estatura;
            persona.caracteristicas = _caracteristicas;
            return persona;
        }
    }
}
