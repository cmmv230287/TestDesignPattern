using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype.Models
{
    public class CaracteristicasEspeciales
    {
        public bool Gps { get; set; }
        public bool Automatico { get; set; }

        public CaracteristicasEspeciales Clone()
        {
            return (CaracteristicasEspeciales)this.MemberwiseClone();
        }
    }
}
