using _2.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype
{
    public class Ferrari : BaseCar
    {
        public Ferrari(string _modelo)
        {
            this.Modelo = _modelo;

            if (this._Caracteristicas == null)
            {
                this._Caracteristicas = new CaracteristicasEspeciales();
            }
        }

        public override BaseCar Clone()
        {
            Ferrari _Ferrari = (Ferrari)this.MemberwiseClone();
            _Ferrari._Caracteristicas = this._Caracteristicas.Clone();
            _Ferrari.SetCaracteristicas(this._Caracteristicas.Gps, this._Caracteristicas.Automatico);

            return _Ferrari;
        }
    }
}
