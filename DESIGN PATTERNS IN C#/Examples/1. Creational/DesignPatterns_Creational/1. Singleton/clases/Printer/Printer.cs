using _1.Singleton.clases.Printer.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton.clases.Printer
{
    public class Printer
    {
        public static IPrinter GetInstancePrinter(string _typePrinter)
        {
            IPrinter _printer = null;
            switch (_typePrinter)
            {
                case "plotter":
                    _printer = new Plotter();
                    break;
                case "laser":
                    _printer = new Laser();
                    break;
                case "puntos":
                    _printer = new Punto();
                    break;
                default:
                    _printer = null;
                    throw new NotImplementedException($"El tipo de impresora {_typePrinter} no existe");
            }

            return _printer;
        }
    }
}
