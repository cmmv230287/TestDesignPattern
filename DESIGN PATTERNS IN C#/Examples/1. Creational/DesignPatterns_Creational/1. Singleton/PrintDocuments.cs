using _1.Singleton.clases.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton
{
    public sealed class PrintDocuments
    {
        private static IPrinter _PrinterLaser{ get; set; }

        private static IPrinter _PrinterPlotter { get; set; }

        private static IPrinter _PrinterPunto { get; set; }

        public static IPrinter PrinterPuntoInstance
        {
            get
            {
                if (_PrinterPunto == null)
                {
                    _PrinterPunto = Printer.GetInstancePrinter("puntos");
                }
                return _PrinterPunto;
            }
        }

        public static IPrinter PrinterLaserInstance
        {
            get
            {
                if (_PrinterLaser == null)
                {
                    _PrinterLaser = Printer.GetInstancePrinter("laser");
                }
                return _PrinterLaser;
            }
        }

        public static IPrinter PrinterplotterInstance
        {
            get
            {
                if (_PrinterPlotter == null)
                {
                    _PrinterPlotter = Printer.GetInstancePrinter("plotter");
                }
                return _PrinterPlotter;
            }
        }

        private PrintDocuments()
        {

        }
    }
}
