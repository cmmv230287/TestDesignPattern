using _2.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype
{
    public class Mazda : BaseCar
    {
        public Mazda(string _modelo)
        {
            this.Modelo = _modelo;

            if (this._Caracteristicas == null)
            {
                this._Caracteristicas = new CaracteristicasEspeciales();
            }
        }

        public override BaseCar Clone()
        {
            Mazda _Mazda = (Mazda)this.MemberwiseClone();
            _Mazda._Caracteristicas = this._Caracteristicas.Clone();
            _Mazda.SetCaracteristicas(this._Caracteristicas.Gps, this._Caracteristicas.Automatico);

            return _Mazda;
        }
    }
}
