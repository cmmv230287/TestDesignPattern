using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Singleton.clases.Printer.Implements
{
    internal class Laser : IPrinter
    {
        public string Print(string _content)
        {
            return $"Contenido impreso con una impresora Laser : {_content}";
        }
    }
}
