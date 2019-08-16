using _2.Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype
{
    public abstract class BaseCar
    {
        public string Modelo { get; set; }
        public double precio { get; set; }
        public CaracteristicasEspeciales _Caracteristicas { get; set; }

        public void SetPrice(double _precio)
        {
            this.precio = _precio;
        }

        public void SetCaracteristicas(bool _Gps, bool _Automatico)
        {
            if(this._Caracteristicas == null)
            {
                this._Caracteristicas = new CaracteristicasEspeciales();
            }

            this._Caracteristicas.Automatico = _Automatico;
            this._Caracteristicas.Gps = _Gps;
        }

        public abstract BaseCar Clone();
    }
}
